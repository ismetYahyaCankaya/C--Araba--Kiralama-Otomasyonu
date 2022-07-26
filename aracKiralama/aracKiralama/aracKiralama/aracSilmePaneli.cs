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
    public partial class aracSilmePaneli : Form
    {
        DataSet ds = new DataSet();
        SqlDataReader oku;
        SqlConnection baglanti = new SqlConnection("Data Source=CANKAYAHOME\\SQLEXPRESS;Initial Catalog=aracKiralama;Integrated Security=True");
        public int silGelenAdminId;
        private string id;
        public aracSilmePaneli()
        {
            InitializeComponent();
        }

        void gridDoldur() 
        {
            SqlDataAdapter yerlestir = new SqlDataAdapter("select aracId,aracPlaka,aracMarka,aracModel,aracRenk,aracDurum,aracYil from araclar", baglanti);
            baglanti.Open();
            yerlestir.Fill(ds, "araclar");
            araclarDGV.DataSource = ds.Tables["araclar"];
            baglanti.Close();
        }


        private void aracSilmePaneli_Load(object sender, EventArgs e)
        {
            gridDoldur();
        }


        private void aracSilButon_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                baglanti.Open();
                string sil = "delete from araclar where aracId=@id";
                SqlCommand komut = new SqlCommand(sil, baglanti);
                komut.Parameters.AddWithValue("@id", id);
                oku = komut.ExecuteReader();
                baglanti.Close();
                MessageBox.Show("Seçilen Araç Silinmiştir.");
                ds.Clear();
                gridDoldur();
            }
        }

        private void menuButon_Click(object sender, EventArgs e)
        {
            adminPanel yonlendir = new adminPanel();
            yonlendir.gelenAdminId = silGelenAdminId;
            yonlendir.Show();
            this.Hide();
        }

        private void araclarDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt16(ds.Tables["araclar"].Rows[e.RowIndex]["aracId"]).ToString();
        }
    }
}
