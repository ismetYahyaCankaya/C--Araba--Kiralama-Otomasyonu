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
    public partial class adminGirisi : Form
    {
        SqlDataReader oku;
        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=aracKiralama;Integrated Security=True");
        public adminGirisi()
        {
            InitializeComponent();
        }
        public int gidenAdminId;
        private void adminGirisButon_Click(object sender, EventArgs e)
        {
            string ad, sifre;
            ad = adText.Text;
            sifre = sifreText.Text;
            baglanti.Open();
            string giris="select adminId from adminler where adminAd=@ad and adminSifre=@sifre";
            SqlCommand komut = new SqlCommand(giris, baglanti);
            komut.Parameters.AddWithValue("@ad",ad);
            komut.Parameters.AddWithValue("@sifre", sifre);
            oku = komut.ExecuteReader();
            if (oku.Read()) 
            {
                gidenAdminId = (int)oku["adminId"];
                adminPanel yonlendir = new adminPanel();
                yonlendir.gelenAdminId = gidenAdminId;
                yonlendir.Show();
                this.Hide();
  
            }

            else 
            {
                MessageBox.Show("Adınız veya Şifreniz Yanlış.");
            }

               baglanti.Close();
        }

        private void cikisYapButon_Click(object sender, EventArgs e)
        {
            anaEkran yonlendir = new anaEkran();
            yonlendir.Show();
            this.Hide();
        }
    }
}
