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

namespace aracKiralama
{
    public partial class musteriGirisi : Form
    {
        SqlDataReader oku;
        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=aracKiralama;Integrated Security=True");
        public int gidenMusteriId;
        public musteriGirisi()
        {
            InitializeComponent();
        }

        private void musteriKayitButon_Click(object sender, EventArgs e)
        {
            kayitOl yonlendir = new kayitOl();
            yonlendir.Show();
            this.Hide();
        }

        private void musteriGirisButon_Click(object sender, EventArgs e)
        {
            string tc,sifre;
            tc = tcText.Text;
            sifre = sifreText.Text;
            baglanti.Open();
            string giris = "select musteriId from musteriler where musteriTc=@tc and musteriSifre=@sifre";
            SqlCommand komut = new SqlCommand(giris, baglanti);
            komut.Parameters.AddWithValue("@tc", tc);
            komut.Parameters.AddWithValue("@sifre", sifre);
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                gidenMusteriId = (int)oku["musteriId"];
                musteriPaneli yonlendir = new musteriPaneli();
                yonlendir.gelenMusteriId = gidenMusteriId;
                yonlendir.Show();
                this.Hide();
            }

            else if (sifre.Length < 8)
            {
                MessageBox.Show("Şifreniz En Az 8 Karakter Uzunluğunda Olmalı.");
            }

            else if (tc.Length != 11) 
            {
                MessageBox.Show("TC'niz 11 Haneli Olmalıdır!");
            }

            else
            {
                MessageBox.Show("Tc'niz veya Şifreniz Yanlış.");
                this.Size = new Size(340, 475);
                sifreKurtarma.Visible = true;
                tcText.Clear();
                sifreText.Clear();
            }
            baglanti.Close();
        }

        private void cikisYapButon_Click(object sender, EventArgs e)
        {
            anaEkran yonlendir = new anaEkran();
            yonlendir.Show();
            this.Hide();
        }

        private void musteriGirisi_Load(object sender, EventArgs e)
        {
            sifreKurtarma.Visible = false;
            this.Size = new Size(340, 285);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sifreDegistir_Click(object sender, EventArgs e)
        {
            
            string yeniSifre, tekrarSifre, girilenTc;
            girilenTc = tcKurtarmaText.Text;
            yeniSifre = yeniSifreText.Text;
            tekrarSifre = yeniSifreTekrarText.Text;
            baglanti.Open();
            string cek = "select musteriId from musteriler where musteriTc=@tc";
            SqlCommand komut = new SqlCommand(cek, baglanti);
            komut.Parameters.AddWithValue("@tc", girilenTc);
            oku = komut.ExecuteReader();
            if (oku.Read()) 
            {
                if (yeniSifre != tekrarSifre)
                {
                    MessageBox.Show("Şifreler Eşleşmiyor.");
                    
                }

                else if (yeniSifre.Length < 8)
                {
                    MessageBox.Show("Şifreniz En Az 8 Karakter Uzunluğunda Olmalı.");
                }

                else
                {
                    int id = (int)oku["musteriId"];
                    baglanti.Close();

                    baglanti.Open();
                    string guncelle = "update musteriler set musteriSifre=@sifre where musteriId=@id";
                    SqlCommand komut2 = new SqlCommand(guncelle, baglanti);
                    komut2.Parameters.AddWithValue("@sifre", yeniSifre);
                    komut2.Parameters.AddWithValue("@id", id);
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Şifreniz Başarıyla Güncellenmiştir.");
                    tcKurtarmaText.Clear();
                    yeniSifreText.Clear();
                    yeniSifreTekrarText.Clear();
                    sifreKurtarma.Visible = false;
                    this.Size = new Size(340, 285);
                }

            }
            baglanti.Close();
            
        }
    }
}
