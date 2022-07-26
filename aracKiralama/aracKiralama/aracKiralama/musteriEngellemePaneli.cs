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
    public partial class musteriEngellemePaneli : Form
    {
        DataSet ds = new DataSet();
        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=aracKiralama;Integrated Security=True");
        public int engelleGelenAdminId;
        private string id;
        public musteriEngellemePaneli()
        {
            InitializeComponent();
        }

        void gridDoldur()
        {
            SqlDataAdapter yerlestir = new SqlDataAdapter("select musteriId,musteriAd,musteriSoyad,musteriTc,musteriSifre from musteriler", baglanti);
            baglanti.Open();
            yerlestir.Fill(ds, "musteriler");
            musterilerDGV.DataSource = ds.Tables["musteriler"];
            baglanti.Close();
        }


        private void musteriEngellemePaneli_Load(object sender, EventArgs e)
        {
            gridDoldur();
        }

        private void engelleButon_Click(object sender, EventArgs e)
        {
            if(id!= null)
            { 
            baglanti.Open();
            string engelle = "update musteriler set musteriEngel=1 where musteriId=@id";
            SqlCommand komut = new SqlCommand(engelle, baglanti);
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Seçilen Müşteri Engellenmiştir!");
            ds.Clear();
            gridDoldur();
            }
        }

        private void menuButon_Click(object sender, EventArgs e)
        {
            adminPanel yonlendir = new adminPanel();
            yonlendir.gelenAdminId = engelleGelenAdminId;
            yonlendir.Show();
            this.Hide();
        }

        private void musterilerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt16(ds.Tables["musteriler"].Rows[e.RowIndex]["musteriId"]).ToString();
        }
    }
}
