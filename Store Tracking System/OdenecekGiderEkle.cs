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
    public partial class OdenecekGiderEkle : Form
    {
        public OdenecekGiderEkle()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtIslemAd.TextLength == 0 || txtOdenecekYer.TextLength == 0 || txtFiyat.TextLength == 0)
                {
                    MessageBox.Show("Boş Alan Bırakmayınız !");
                }
                else
                {
                    baglanti.Open();
                    NpgsqlCommand komut0 = new NpgsqlCommand("SELECT * FROM faturalar WHERE faturano = '" + txtFaturaNo.Text.ToUpper() + "'", baglanti);
                    NpgsqlDataReader dr = komut0.ExecuteReader();


                    if (dr.Read())
                    {
                        MessageBox.Show("Bu Urun Koduna Sahip Fatura Mevcut", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        baglanti.Close();


                    }
                    else
                    {

                        /*
                         CREATE OR REPLACE FUNCTION fatura_ekle(
                            p_islemad character varying(100),
                            p_odenecekyer character varying(100),
                            p_fiyat double precision,
                            p_sontarih date,
                            p_faturano character varying(100)
                        )
                        RETURNS VOID AS
                        $$
                        BEGIN
                            INSERT INTO faturalar (islemad, odenecekyer, fiyat, sontarih, tarih, faturano)
                            VALUES (p_islemad, p_odenecekyer, p_fiyat, p_sontarih, current_date, p_faturano);
                        END;
                        $$
                        LANGUAGE plpgsql;

                         */
                        string islemad = txtIslemAd.Text.ToUpper();
                        string odenecekyer = txtOdenecekYer.Text.ToUpper();
                        double fiyat = Convert.ToDouble(txtFiyat.Text);
                        
                        string faturano = txtFaturaNo.Text.ToString();

                        baglanti.Close();
                        baglanti.Open();
                        string sql = "INSERT INTO faturalar (islemad, odenecekyer, fiyat, tarih, faturano) " +
                    "VALUES (@islemad, @odenecekyer, @fiyat, CURRENT_DATE, @faturano)";
                        NpgsqlCommand kaydet = new NpgsqlCommand(sql, baglanti);
                        kaydet.Parameters.AddWithValue("@islemad", islemad);
                        kaydet.Parameters.AddWithValue("@odenecekyer", odenecekyer);
                        kaydet.Parameters.AddWithValue("@fiyat", fiyat);          
                        kaydet.Parameters.AddWithValue("@faturano", faturano);
                        kaydet.ExecuteNonQuery();
                        baglanti.Close();

                        txtIslemAd.Text = "";
                        txtOdenecekYer.Text = "";
                        txtFiyat.Text = "";
                        txtFaturaNo.Text = "";

                        MessageBox.Show("Fatura Eklendi");

                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Kayıt Hatası ! " + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
