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
    public partial class kayitOl : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=aracKiralama;Integrated Security=True");
        public kayitOl()
        {
            InitializeComponent();
        }

        private void musteriKayitButon_Click(object sender, EventArgs e)
        {
            string ad, soyad, tc, sifre;
            ad = adText.Text;
            soyad = soyadText.Text;
            tc = tcText.Text;
            sifre = sifreText.Text;
            if (tc.Length != 11) 
            {
                MessageBox.Show("TC'niz 11 haneli olmalı!!!");
            }
            else if (sifre.Length < 8) 
            {
                MessageBox.Show("Sifreniz En Az 8 Haneli Olmalı!!!");
            }
            else 
            {
                baglanti.Open();
                string cek = "insert into musteriler(musteriAd,musteriSoyad,musteriTc,musteriSifre) values (@ad,@soyad,@tc,@sifre)";
                SqlCommand komut = new SqlCommand(cek, baglanti);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@soyad", soyad);
                komut.Parameters.AddWithValue("@tc", tc);
                komut.Parameters.AddWithValue("@sifre", sifre);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarılı.. Giriş sayfasına yönlendiriliyorsunuz.");   
                musteriGirisi yonlendir = new musteriGirisi();
                yonlendir.Show();
                this.Hide();
            }
        }
    }
}
