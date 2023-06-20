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
    public partial class CariHesapBilgi : Form
    {
        public CariHesapBilgi()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=magaza;");

        private void button1_Click(object sender, EventArgs e)
        {
            CariHesap cari = new CariHesap();
            cari.Show();
            this.Hide();
        }

        private void CariHesapBilgi_Load(object sender, EventArgs e)
        {
            dgvFaturalar.DataSource = yenileFaturalar();
        }

        DataTable yenileFaturalar()
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT islemad, odenecekyer, fiyat, tarih, faturano FROM faturalar", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        private void dgvFaturalar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtSecilenFaturaNo.Text = dgvFaturalar.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
                if (MessageBox.Show(txtSecilenFaturaNo.Text + "\nAdlı Faturayı Ödediğinizi Onaylıyor Musunuz ?", "Fatura Ödeme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM faturalar WHERE faturano = @faturano";
                    NpgsqlCommand delete = new NpgsqlCommand(deleteQuery, baglanti);
                    delete.Parameters.AddWithValue("@faturano", txtSecilenFaturaNo.Text);

                    try
                    {
                        baglanti.Open();
                        delete.ExecuteNonQuery();
                        baglanti.Close() ;
                        MessageBox.Show("Fatura Ödendi Olarak Sisteme Girildi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvFaturalar.DataSource = yenileFaturalar();

                    }
                    catch (Exception ex)
                    {
                    baglanti.Close();
                        MessageBox.Show("İşlem Gerçekleştirilemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            

        }
    }
}
