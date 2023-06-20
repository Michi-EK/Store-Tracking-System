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
    public partial class UrunAnasayfa : Form
    {
        public UrunAnasayfa()
        {
            InitializeComponent();
        }



        private void UrunAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunEkle ekle = new UrunEkle();
            ekle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunGuncelle guncelle = new UrunGuncelle();
            guncelle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UrunListele_Ara listele_Ara = new UrunListele_Ara();
            listele_Ara.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UrunStokGuncelle stokGuncelle = new UrunStokGuncelle();
            stokGuncelle.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
