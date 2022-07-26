using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace aracKiralama
{
    public partial class musteriPaneli : Form
    {
        public int gelenMusteriId;
        SqlDataReader oku;
        DataSet ds = new DataSet();
        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=aracKiralama;Integrated Security=True");
        private string id;
        public musteriPaneli()
        {
            InitializeComponent();
        }
        void filtrele()
        {
            string format = "";
            int sayac = 0;
            string renk, durum, marka, model; ;
            renk = renkFiltreCombo.Text;
            durum = durumFiltreCombo.Text;
            marka = markaFiltreCombo.Text; 
            model = modelFiltreCombo.Text;
            if (!string.IsNullOrEmpty(renk)) 
            {
            
                if (sayac != 0 && sayac != 4) { format += " AND "; sayac++; }
                format += "aracRenk='" + renk + "'";
                sayac++;
            }
            if (!string.IsNullOrEmpty(durum))
            {
                if (sayac != 0 && sayac != 4) { format += " AND "; }
                format += "aracDurum='" + durum + "'";
                sayac++;
            }
            if (!string.IsNullOrEmpty(marka))
            {
                if (sayac != 0 && sayac != 4) { format += " AND "; }
                format += "aracMarka='" + marka + "'";
                sayac++;
            }
            if (!string.IsNullOrEmpty(model))
            {
                if (sayac != 0 && sayac != 4) { format += " AND "; }
                format += "aracModel='" + model + "'";
                sayac++;
            }

            DataView dv = ds.Tables[0].DefaultView;
            dv.RowFilter = format;
            araclarDGV.DataSource = dv;

        }

        void gridDoldur() 
        {
            SqlDataAdapter yerlestir = new SqlDataAdapter("select aracId,aracPlaka,aracMarka,aracModel,aracRenk,aracDurum,aracYil from araclar", baglanti);
            baglanti.Open();
            yerlestir.Fill(ds, "araclar");
            araclarDGV.DataSource = ds.Tables["araclar"];
            baglanti.Close();
        }

        private void musteriPaneli_Load(object sender, EventArgs e)
        {
            string ad, soyad;
            bool engel;
            baglanti.Open();
            string cek = "select musteriAd,musteriSoyad,musteriEngel from musteriler where musteriId=@id";
            SqlCommand komut = new SqlCommand(cek, baglanti);
            komut.Parameters.AddWithValue("@id", gelenMusteriId);
            oku = komut.ExecuteReader();
            oku.Read();
            ad = (string)oku["musteriAd"];
            soyad = (string)oku["musteriSoyad"];
            engel = (bool)oku["musteriEngel"];
            baglanti.Close();
            if (engel)
            {
                MessageBox.Show("Adminler Tarafından Engellendiniz, Bu Hesap Kullanılamaz.");
                musteriGirisi yonlendir = new musteriGirisi();
                yonlendir.Show();
                this.Close();
            }

            else 
            {
                adSoyadLabel.Text = "Hoşgeldiniz " + ad + " " + soyad;

                gridDoldur();

                markaFiltreCombo.Items.Add("Mercedes");
                markaFiltreCombo.Items.Add("BMW");
                markaFiltreCombo.Items.Add("DACIA");

                renkFiltreCombo.Items.Add("Turuncu");
                renkFiltreCombo.Items.Add("Kırmızı");
                renkFiltreCombo.Items.Add("Pembe");
                renkFiltreCombo.Items.Add("Mor");
                renkFiltreCombo.Items.Add("Yeşil");

                durumFiltreCombo.Items.Add("Kiralık");
                durumFiltreCombo.Items.Add("Satılık");
            }

        }

        private void renkFiltreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            filtrele();

        }

        private void durumFiltreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrele();

        }

        private void modelFiltreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            filtrele();
        }

        private void markaFiltreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelFiltreCombo.Items.Clear();

            if (markaFiltreCombo.SelectedIndex == 0)
            {
                modelFiltreCombo.Items.Add("Mercedes M1");
                modelFiltreCombo.Items.Add("Mercedes M2");
                modelFiltreCombo.Items.Add("Mercedes M3");

            }
            if (markaFiltreCombo.SelectedIndex == 1)
            {
                modelFiltreCombo.Items.Add("BMW M1");
                modelFiltreCombo.Items.Add("BMW M2");
                modelFiltreCombo.Items.Add("BMW M3");

            }
            if (markaFiltreCombo.SelectedIndex == 2)
            {
                modelFiltreCombo.Items.Add("DACIA M1");
                modelFiltreCombo.Items.Add("DACIA M2");
                modelFiltreCombo.Items.Add("DACIA M3");
            }

            filtrele();

        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            anaEkran yonlendir = new anaEkran();
            yonlendir.Show();
            this.Hide();
        }


        private void araclarDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt16(ds.Tables["araclar"].Rows[e.RowIndex]["aracId"]).ToString();
            if (id!=null)
            {        
                baglanti.Open();
                string resimYansit = "select aracResim from araclar where aracId=@id";
                SqlCommand komut = new SqlCommand(resimYansit, baglanti);
                komut.Parameters.AddWithValue("@id", id);
                oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    byte[] resim = new byte[0];
                    resim = (byte[])oku["aracResim"];
                    MemoryStream ms = new MemoryStream(resim);
                    aracResimPB.Image = Image.FromStream(ms);
                }
                baglanti.Close();
            }

        }

        private void alButon_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                baglanti.Open();
                string ilanKaldir = "delete from araclar where aracId=@id";
                SqlCommand komut = new SqlCommand(ilanKaldir, baglanti);
                komut.Parameters.AddWithValue("@id", id);
                oku = komut.ExecuteReader();
                baglanti.Close();
                MessageBox.Show("Seçtiğiniz Aracı Satın Almış Bulunmaktasınız, İlgili Araç İlanlarda Gözükmeyecek.");
                ds.Clear();
                gridDoldur();
            }
        }
    }
}
