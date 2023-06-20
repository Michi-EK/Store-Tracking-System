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
    public partial class UrunStokGuncelle : Form
    {
        public UrunStokGuncelle()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=magaza;");
        private string urunkodu = "";
        private void button1_Click(object sender, EventArgs e)
        {

            UrunAnasayfa urun = new UrunAnasayfa();
            urun.Show();
            this.Hide();
        }

        private void UrunStokGuncelle_Load(object sender, EventArgs e)
        {
            dgvurunler.DataSource = yenileUrunler();
        }

        DataTable yenileUrunler()
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT urunkod, urunad, stok, tarih FROM urunler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("UPDATE urunler SET stok = '" + txtYeniStok.Text + "' WHERE urunkod = '" + urunkodu + "'", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Stok Bilgisi Güncellendi !");

                txtMevcutStok.Text = "";
                txtYeniStok.Text = "";

                dgvurunler.DataSource = yenileUrunler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem Gerçekleştirilemedi ! " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void dgvurunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvurunler_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMevcutStok.Text = dgvurunler.Rows[e.RowIndex].Cells[2].Value.ToString();
            urunkodu = dgvurunler.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
