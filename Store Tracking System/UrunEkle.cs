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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
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

        private void UrunEkle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



            try
            {

                if (txtUrunAd.TextLength == 0 || txtUrunKod.TextLength == 0 || txtUrunAdet.TextLength == 0 || txtAlisFiyat.TextLength == 0 || txtSatisFiyat.TextLength == 0 || txtToptanciAd.TextLength == 0)
                {
                    MessageBox.Show("Boş Alan Bırakmayınız !");
                }
                else
                {
                    baglanti.Open();
                    NpgsqlCommand komut0 = new NpgsqlCommand("SELECT * FROM urunler WHERE urunkod = '" + txtUrunKod.Text.ToUpper() + "'", baglanti);
                    NpgsqlDataReader dr = komut0.ExecuteReader();


                    if (dr.Read())
                    {
                        MessageBox.Show("Bu Urun Koduna Sahip Ürün Mevcut", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        baglanti.Close();


                    }
                    else
                    {

                        /*
                         CREATE OR REPLACE FUNCTION urun_ekle(
                            urunkod_param VARCHAR(100),
                            urunad_param VARCHAR(100),
	                        toptanciad_param VARCHAR(100),
                            alisfiyat_param NUMERIC(10, 2),
                            satisfiyat_param NUMERIC(10, 2),
                            stok_param INTEGER
                        )
                        RETURNS VOID AS $$
                        BEGIN
                            INSERT INTO urunler (urunkod, urunad, toptanciad, alisfiyat, satisfiyat, stok, tarih)
                            VALUES (urunkod_param, urunad_param, toptanciad_param, alisfiyat_param, satisfiyat_param, stok_param, CURRENT_DATE);
                        END;
                        $$ LANGUAGE plpgsql;

                         */

                        baglanti.Close();
                        baglanti.Open();
                        NpgsqlCommand kaydet = new NpgsqlCommand("SELECT FROM urun_ekle(:urunkod_param, :urunad_param, :toptanciad_param, :alisfiyat_param, :satisfiyat_param, :stok_param)", baglanti);
                        kaydet.Parameters.AddWithValue("urunkod_param", txtUrunKod.Text.ToString().ToUpper());
                        kaydet.Parameters.AddWithValue("urunad_param", txtUrunAd.Text.ToString().ToUpper());
                        kaydet.Parameters.AddWithValue("toptanciad_param", txtToptanciAd.Text.ToString().ToUpper());
                        kaydet.Parameters.AddWithValue("alisfiyat_param", double.Parse(txtAlisFiyat.Text));
                        kaydet.Parameters.AddWithValue("satisfiyat_param", double.Parse(txtSatisFiyat.Text));
                        kaydet.Parameters.AddWithValue("stok_param", Int32.Parse(txtUrunAdet.Text));
                        kaydet.ExecuteNonQuery();
                        baglanti.Close();

                        txtUrunAd.Text = "";
                        txtUrunKod.Text = "";
                        txtUrunAdet.Text = "";
                        txtAlisFiyat.Text = "";
                        txtSatisFiyat.Text = "";
                        txtToptanciAd.Text = "";

                        MessageBox.Show("Ürün Eklendi");

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

 
    }
}
