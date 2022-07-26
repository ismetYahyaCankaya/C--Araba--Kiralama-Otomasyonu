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
    public partial class aracEklemePaneli : Form
    {
        public aracEklemePaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=aracKiralama;Integrated Security=True");
        private string dosyaYolu;
        public int eklemeGelenAdminId;
        private void aracEklemePaneli_Load(object sender, EventArgs e)
        {
            markaCombo.Items.Add("Mercedes");
            markaCombo.Items.Add("BMW");
            markaCombo.Items.Add("DACIA");


            renkCombo.Items.Add("Turuncu");
            renkCombo.Items.Add("Kırmızı");
            renkCombo.Items.Add("Pembe");
            renkCombo.Items.Add("Mor");
            renkCombo.Items.Add("Yeşil");


            durumCombo.Items.Add("Kiralık");
            durumCombo.Items.Add("Satılık");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string plaka, marka, model, renk, durum;
            int yil;
            plaka = plakaText.Text;
            marka = markaCombo.Text;
            model = modelCombo.Text;
            renk = renkCombo.Text;
            durum = durumCombo.Text;
            yil = Convert.ToInt16(yilText.Text);

            if(plaka=="" || marka=="" || model=="" || renk=="" || durum=="" || yil.ToString()=="") 
            {
                MessageBox.Show("Hiçbir Alan Boş Bırakılamaz");
            }

            else if (yil < 1950) 
            {
                MessageBox.Show("Aracın Yılı 1950'den Küçük Olamaz!");
            }

            else if (dosyaYolu == "") 
            {
                MessageBox.Show("Resim Eklemek Zorunlu!");
            
            }

            else 
            {
                MemoryStream ms = new MemoryStream();
                arabaResimPB.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] resim = ms.GetBuffer();
                baglanti.Open();
                string cek = "insert into araclar(aracPlaka,aracMarka,aracModel,aracRenk, aracDurum,aracYil,aracResim) values (@plaka,@marka,@model,@renk,@durum,@yil,@resim)";
                SqlCommand komut = new SqlCommand(cek, baglanti);
                
                komut.Parameters.AddWithValue("@plaka", plaka);
                komut.Parameters.AddWithValue("@marka", marka);
                komut.Parameters.AddWithValue("@model", model);
                komut.Parameters.AddWithValue("@renk", renk);
                komut.Parameters.AddWithValue("@durum", durum);
                komut.Parameters.AddWithValue("@yil", yil);
                komut.Parameters.Add("@resim", SqlDbType.Image, resim.Length).Value = resim;
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Araç Eklenmiştir.");
                plakaText.Clear();
                yilText.Clear();
                arabaResimPB.Image = null;
                modelCombo.SelectedIndex = -1;
                markaCombo.SelectedIndex = -1;
                durumCombo.SelectedIndex = -1;
                renkCombo.SelectedIndex = -1;

            }
        }

        private void markaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelCombo.Items.Clear();

            if (markaCombo.SelectedIndex == 0) 
            {
                modelCombo.Items.Add("Mercedes M1");
                modelCombo.Items.Add("Mercedes M2");
                modelCombo.Items.Add("Mercedes M3");
                
            }
            if (markaCombo.SelectedIndex == 1)
            {
                modelCombo.Items.Add("BMW M1");
                modelCombo.Items.Add("BMW M2");
                modelCombo.Items.Add("BMW M3");
                
            }
            if (markaCombo.SelectedIndex == 2) 
            {
                modelCombo.Items.Add("DACIA M1");
                modelCombo.Items.Add("DACIA M2");
                modelCombo.Items.Add("DACIA M3");

            }
        }

        private void resimEkleButon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            dosyaYolu = dosya.FileName;
            arabaResimPB.SizeMode = PictureBoxSizeMode.StretchImage;
            arabaResimPB.ImageLocation = dosyaYolu;

             
             
        }

        private void menuButon_Click(object sender, EventArgs e)
        {
            adminPanel yonlendir = new adminPanel();
            yonlendir.gelenAdminId = eklemeGelenAdminId;
            yonlendir.Show();
            this.Hide();
        }
    }
}
