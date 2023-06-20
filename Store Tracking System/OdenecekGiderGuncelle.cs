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
    public partial class OdenecekGiderGuncelle : Form
    {
        public OdenecekGiderGuncelle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost; Port=5432; User Id =postgres; Password=12345; Database=magaza;");
        private double fiyat;
        private void button1_Click(object sender, EventArgs e)
        {
            CariHesap cari = new CariHesap();
            cari.Show();
            this.Hide();
        }

        private void OdenecekGiderGuncelle_Load(object sender, EventArgs e)
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
            
            txtIslemAd.Text = dgvFaturalar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtOdenecekYer.Text = dgvFaturalar.Rows[e.RowIndex].Cells[1].Value.ToString();
            fiyat = Convert.ToDouble(dgvFaturalar.Rows[e.RowIndex].Cells[2].Value);
            txtFiyat.Text = fiyat.ToString();
            txtFaturaNo.Text = dgvFaturalar.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtIslemAd.TextLength == 0 || txtOdenecekYer.TextLength == 0 || txtFiyat.TextLength == 0 || txtFaturaNo.TextLength == 0)
                {
                    MessageBox.Show("Boş Alan Bırakmayınız !");
                }
                else
                {

                    /*
                    CREATE OR REPLACE FUNCTION fatura_guncelle(
                       islemad_param VARCHAR(100),
                       odenecekyer_param VARCHAR(100),
                       fiyat_param VARCHAR(100),
                       sontarih_param DATE,
                       faturano_param VARCHAR(100)
                    )
                    RETURNS VOID AS $$
                    BEGIN
                        UPDATE faturalar
                        SET islemad = islemad_param,
                            odenecekyer = odenecekyer_param,
                            fiyat = fiyat_param,
                            sontarih = sontarih_param
                        WHERE faturano = faturano_param;
                    END;
                    $$ LANGUAGE plpgsql;



                     */

                    string sql = "UPDATE faturalar SET islemad = @islemad, odenecekyer = @odenecekyer, fiyat = @fiyat WHERE faturano = @faturano";
                    baglanti.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, baglanti);
                    cmd.Parameters.AddWithValue("@islemad", txtIslemAd.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@odenecekyer", txtOdenecekYer.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                    cmd.Parameters.AddWithValue("@faturano", txtFaturaNo.Text.ToUpper());

                    cmd.ExecuteNonQuery();
                    baglanti.Close();


                    dgvFaturalar.DataSource = yenileFaturalar();



                    /*     baglanti.Open();
                         NpgsqlCommand kaydet = new NpgsqlCommand("SELECT * from fatura_guncelle(:islemad_param, :odenecekyer_param, :fiyat_param, :sontarih_param, :faturano_param)", baglanti);
                         kaydet.Parameters.AddWithValue("islemad_param", txtIslemAd.Text.ToString().ToUpper());
                         kaydet.Parameters.AddWithValue("odenecekyer_param", txtOdenecekYer.Text.ToString().ToUpper());
                         kaydet.Parameters.AddWithValue("fiyat_param", txtFiyat.Text.ToString().ToUpper());
                         kaydet.Parameters.AddWithValue("sontarih_param", txtSonTarih.Text.ToString());
                         kaydet.Parameters.AddWithValue("faturano_param", txtFaturaNo.Text.ToString());
                         kaydet.ExecuteNonQuery();
                         baglanti.Close();   */


                    txtIslemAd.Text = "";
                    txtOdenecekYer.Text = "";
                    txtFiyat.Text = "";

                    txtFaturaNo.Text = "";

                    MessageBox.Show("Fatura Güncellendi");



                }
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Kayıt Hatası ! " + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }
    }
}
