using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Tracking_System
{
    public partial class CariHesap : Form
    {
        public CariHesap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinansAnasayfa finans = new FinansAnasayfa();
            finans.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdenecekGiderEkle giderEkle = new OdenecekGiderEkle();
            giderEkle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OdenecekGiderGuncelle giderGuncelle = new OdenecekGiderGuncelle();
            giderGuncelle.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CariHesapBilgi hesapBilgi = new CariHesapBilgi();
            hesapBilgi.Show();
            this.Hide();
        }
    }
}
