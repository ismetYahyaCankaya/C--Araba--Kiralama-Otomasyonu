using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracKiralama
{
    public partial class anaEkran : Form
    {
        public anaEkran()
        {
            InitializeComponent();
        }

        private void adminGirisButon_Click(object sender, EventArgs e)
        {
            adminGirisi yonlendir = new adminGirisi();
            yonlendir.Show();
            this.Hide();
        }

        private void musteriGirisButon_Click(object sender, EventArgs e)
        {
            musteriGirisi yonlendir = new musteriGirisi();
            yonlendir.Show();
            this.Hide();
        }
    }
}
