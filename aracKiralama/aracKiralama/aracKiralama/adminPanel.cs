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
        
    public partial class adminPanel : Form
    {
        SqlDataReader oku;
        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=aracKiralama;Integrated Security=True");
        public int gelenAdminId;

        public adminPanel()
        {
            InitializeComponent();
        }
        
        private void adminPanel_Load(object sender, EventArgs e)
        {
            string ad, soyad;
            baglanti.Open();
            string cek = "select adminAd,adminSoyad from adminler where adminId=@id";
            SqlCommand komut = new SqlCommand(cek, baglanti);
            komut.Parameters.AddWithValue("@id", gelenAdminId);
            oku = komut.ExecuteReader();
            oku.Read();
            ad = (string)oku["adminAd"];
            soyad = (string)oku["adminSoyad"];
            baglanti.Close();
            adSoyadLabel.Text = "Hoşgeldiniz, " + ad + " " + soyad;


        }

        private void aracEkleButon_Click(object sender, EventArgs e)
        {
            aracEklemePaneli yonlendir = new aracEklemePaneli();
            yonlendir.eklemeGelenAdminId = gelenAdminId;
            yonlendir.Show();
            this.Hide();
        }

        private void musteriEngelleButon_Click(object sender, EventArgs e)
        {
            musteriEngellemePaneli yonlendir = new musteriEngellemePaneli();
            yonlendir.engelleGelenAdminId = gelenAdminId;
            yonlendir.Show();
            this.Hide();
        }

        private void aracSilButon_Click(object sender, EventArgs e)
        {
            aracSilmePaneli yonlendir = new aracSilmePaneli();
            yonlendir.silGelenAdminId = gelenAdminId;
            yonlendir.Show();
            this.Hide();
        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            adminGirisi yonlendir = new adminGirisi();
            yonlendir.Show();
            this.Hide();
        }
    }
}
