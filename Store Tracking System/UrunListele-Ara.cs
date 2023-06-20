using Npgsql;
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
    public partial class UrunListele_Ara : Form
    {
        public UrunListele_Ara()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=magaza;");

        private void button1_Click(object sender, EventArgs e)
        {

            UrunAnasayfa urun = new UrunAnasayfa();
            urun.Show();
            this.Hide();
        }

        private void UrunListele_Ara_Load(object sender, EventArgs e)
        {
            dgvurunler.DataSource = yenileUrunler();
        }

        DataTable yenileUrunler()
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT urunkod, urunad, toptanciad, alisfiyat, satisfiyat, stok, tarih FROM urunler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            dgvurunler.DataSource = yenileUrunler();
            txtAra.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sorgu = "SELECT urunkod, urunad, toptanciad, alisfiyat, satisfiyat, stok, tarih FROM urunler WHERE urunad like '" + txtAra.Text.ToUpper() + "%'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "urunbilgi");
                dgvurunler.DataSource = ds.Tables["urunbilgi"];
                baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama Hatası" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }
    }
}
