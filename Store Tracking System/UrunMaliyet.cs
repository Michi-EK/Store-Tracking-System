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
    public partial class UrunMaliyet : Form
    {
        public UrunMaliyet()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=magaza;");
        private double alis;
        private double satis;

        private void button1_Click(object sender, EventArgs e)
        {
            FinansAnasayfa finans = new FinansAnasayfa();
            finans.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        DataTable yenileUrunler()
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT urunad, urunkod, stok, alisfiyat, satisfiyat FROM urunler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        private void UrunMaliyet_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = yenileUrunler();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUrunKod.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            satis = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            alis = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

            txtAlisFiyat.Text = alis.ToString();
            txtSatisFiyat.Text = satis.ToString();
            float netkar = (float)(satis - alis);
            float karZararYuzdesi = (float)((netkar / alis) * 100.0f);
            string formattedKarZararYuzdesi = karZararYuzdesi.ToString("0.00");
            txtNetKar.Text = netkar.ToString();

            if (karZararYuzdesi > 0)
            {
                yuzde.Text = "Kar Yüzdesi: %" + formattedKarZararYuzdesi.ToString();
            }
            else if (karZararYuzdesi < 0)
            {
                yuzde.Text = "Zarar Yüzdesi: %" + formattedKarZararYuzdesi.ToString();
            }
            else
            {
                yuzde.Text = "Kar/ZararYüzdesi: %" + formattedKarZararYuzdesi.ToString();
            }
        }
    }
}
