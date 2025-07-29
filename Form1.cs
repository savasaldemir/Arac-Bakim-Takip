using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Bakım_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SQL sorgu bağlantısı
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=Arac_Bakim_Takip;Integrated Security=True");


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            MarkaGetir(); // fonksiyonu çağırıyoruz
            Viskozite1Getir();
            Viskozite2Getir();

        }

        private void MarkaGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT marka FROM motor_yaglari", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            combo_MarkaSec.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                combo_MarkaSec.Items.Add(row["marka"].ToString());
            }
        }

        private void Viskozite1Getir()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT viskozite1 FROM motor_yaglari", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboViskozite1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                comboViskozite1.Items.Add(row["viskozite1"].ToString());
            }
        }

        private void Viskozite2Getir()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT viskozite2 FROM motor_yaglari", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            combo_Viskozite2.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                combo_Viskozite2.Items.Add(row["viskozite2"].ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Tarih_Saat.Text= DateTime.Now.ToString("g");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            araclar_sayfasi araclar_Sayfasi = new araclar_sayfasi();
            araclar_Sayfasi.ShowDialog();
        }

        private void txt_PlakaSorgu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string plaka = txt_PlakaSorgu.Text.Trim();

                    string sorgu = @"
                    SELECT 
                    ab.id,
                    ab.plaka,
                    ab.marka,
                    ab.model,
                    ab.yil,
                    bi.tarih AS SonBakimTarihi,
                    bi.yag_filtre,
                    bi.yakit_filtre,
                    bi.hava_filtre,
                    bi.polen_filtre,
                    bi.antifriz_degisim,
                    bi.aciklama
                    FROM arac_bilgileri AS ab
                    LEFT JOIN (SELECT * FROM bakim_islemleri AS b1 WHERE tarih = (SELECT MAX(tarih) FROM bakim_islemleri WHERE arac_id = b1.arac_id))
                 AS bi ON ab.id = bi.arac_id
                 WHERE ab.plaka LIKE @plaka + '%'";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@plaka", plaka);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGrid_Arac_Bilgileri.DataSource = dt;

                // Opsiyonel: ilk satırdan ID al
                if (dt.Rows.Count > 0)
                {
                    object idDegeri = dt.Rows[0]["id"];
                    if (idDegeri != null)
                        lbl_aracid.Text = idDegeri.ToString();
                }
                else
                {
                    lbl_aracid.Text = ""; // Hiç veri yoksa temizle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA oluştu:\n" + ex.Message);
            }
        }

        private void combo_MarkaSec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Yapilan_islemler_kayit_Click(object sender, EventArgs e)
        {
            // ✅ CheckBox'lardan filtre durumları alınır
            string yagFiltreDurumu = checkBox_YagFiltre.Checked ? "DEĞİŞTİ" : "DEĞİŞMEDİ";
            string yakitFiltreDurumu = checkBox_YakitFiltre.Checked ? "DEĞİŞTİ" : "DEĞİŞMEDİ";
            string havaFiltreDurumu = checkBox_HavaFiltre.Checked ? "DEĞİŞTİ" : "DEĞİŞMEDİ";
            string polenFiltreDurumu = checkBox_PolenFiltre.Checked ? "DEĞİŞTİ" : "DEĞİŞMEDİ";
            string antifrizDurumu = checkBox_Antifriz.Checked ? "DEĞİŞTİ" : "DEĞİŞMEDİ";

            // ✏️ Açıklama metni alınır
            string aciklama = txt_Aciklama.Text.Trim();

            // 📆 Tarih Label'ından alınır ve SQL uyumlu formatlanır
            DateTime zaman = DateTime.Parse(lbl_Tarih_Saat.Text);
            string tarih = zaman.ToString("yyyy-MM-dd");

            // 🔑 Araç ID'si alınır
            int aracID = Convert.ToInt32(lbl_aracid.Text);

            // 💾 SQL INSERT sorgusu hazırlanır
            string sql = @"INSERT INTO bakim_islemleri
                   (arac_id, tarih, yag_filtre, yakit_filtre, hava_filtre, polen_filtre, antifriz_degisim, aciklama)
                   VALUES
                   (@arac_id, @tarih, @yag, @yakit, @hava, @polen, @antifriz, @aciklama)";

            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@arac_id", aracID);
            cmd.Parameters.AddWithValue("@tarih", tarih);
            cmd.Parameters.AddWithValue("@yag", yagFiltreDurumu);
            cmd.Parameters.AddWithValue("@yakit", yakitFiltreDurumu);
            cmd.Parameters.AddWithValue("@hava", havaFiltreDurumu);
            cmd.Parameters.AddWithValue("@polen", polenFiltreDurumu);
            cmd.Parameters.AddWithValue("@antifriz", antifrizDurumu);
            cmd.Parameters.AddWithValue("@aciklama", aciklama);

            // 🚀 Kayıt işlemi gerçekleştirilir
            try
            {
                baglanti.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("✅ Bakım kaydı başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }


    }
    
}
