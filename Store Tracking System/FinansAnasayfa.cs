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
    public partial class FinansAnasayfa : Form
    {
        public FinansAnasayfa()
        {
            InitializeComponent();
        }

        private void FinansAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CariHesap cari = new CariHesap();
            cari.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kar_Zarar kar = new Kar_Zarar();
            kar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UrunMaliyet maliyet = new UrunMaliyet();
            maliyet.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
