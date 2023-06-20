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
    public partial class UrunGuncelle : Form
    {
        public UrunGuncelle()
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

        private void UrunGuncelle_Load(object sender, EventArgs e)
        {
            dgwUrunler.DataSource = yenileUrunler();
        }

        DataTable yenileUrunler()
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT urunad, urunkod, stok, alisfiyat, satisfiyat, toptanciad, tarih FROM urunler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        private void dgwUrunler_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dgwUrunler.Rows.Count)
            {
                txtUrunAd.Text = dgwUrunler.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUrunKod.Text = dgwUrunler.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUrunAdet.Text = dgwUrunler.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAlisFiyat.Text = dgwUrunler.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSatisFiyat.Text = dgwUrunler.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtToptanciAd.Text = dgwUrunler.Rows[e.RowIndex].Cells[5].Value.ToString();
            }

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

                    /*
                     CREATE OR REPLACE FUNCTION urun_guncelle(
                        urunkod_param char varying(100),
                        urunad_param char varying(100),
                        toptanciad_param char varying(100),
                        alisfiyat_param double precision,
                        satisfiyat_param double precision,
                        stok_param INTEGER
                    )
                    RETURNS VOID AS $$
                    BEGIN
                        UPDATE urunler
                        SET urunad = urunad_param,
                            toptanciad = toptanciad_param,
                            alisfiyat = alisfiyat_param,
                            satisfiyat = satisfiyat_param,
                            stok = stok_param
                        WHERE urunkod = urunkod_param;
                    END;
                    $$ LANGUAGE plpgsql;


                     */

                    double satisdeger = double.Parse(txtSatisFiyat.Text);
                    double alisdeger = double.Parse(txtAlisFiyat.Text);
                    int stokdeger = Int32.Parse(txtUrunAdet.Text);

                    baglanti.Open();
                    NpgsqlCommand kaydet = new NpgsqlCommand(" SELECT urun_guncelle(@urunad_param, @toptanciad_param, @alisfiyat_param, @satisfiyat_param, @stok_param,  @urunkod_param )", baglanti);
                    kaydet.Parameters.AddWithValue("@urunad_param", txtUrunAd.Text.ToString().ToUpper());
                    kaydet.Parameters.AddWithValue("@toptanciad_param", txtToptanciAd.Text.ToString().ToUpper());
                    kaydet.Parameters.AddWithValue("@alisfiyat_param", alisdeger);
                    kaydet.Parameters.AddWithValue("@satisfiyat_param", satisdeger);
                    kaydet.Parameters.AddWithValue("@stok_param", stokdeger);
                    kaydet.Parameters.AddWithValue("@urunkod_param", txtUrunKod.Text.ToString().ToUpper());

                    kaydet.ExecuteNonQuery();
                    baglanti.Close();


                    txtUrunAd.Text = "";
                    txtUrunKod.Text = "";
                    txtUrunAdet.Text = "";
                    txtAlisFiyat.Text = "";
                    txtSatisFiyat.Text = "";
                    txtToptanciAd.Text = "";

                    MessageBox.Show("Ürün Güncellendi");



                }
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Kayıt Hatası ! " + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("DELETE FROM urunler WHERE urunkod = '" + txtUrunKod.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ürün Silindi" + MessageBoxButtons.OK + MessageBoxIcon.Information);
                dgwUrunler.DataSource = yenileUrunler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün Silinemedi !" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }
    }
}
