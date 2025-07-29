using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Bakım_Takip
{
    public partial class araclar_sayfasi : Form
    {
        public araclar_sayfasi()
        {
            InitializeComponent();
        }
        //Veritabanı kayıt baglantisi dinamik
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=Arac_Bakim_Takip;Integrated Security=True");

        //dataGridView1 veritabanındaki bilgileri gösterme
        DataTable dt = new DataTable();

        private void MusteriListele()
        {
            //dataGridView1 için sql sorgusu
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM musteri_bilgileri INNER JOIN arac_bilgileri ON musteri_bilgileri.id = arac_bilgileri.musteri_id", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void araclar_sayfasi_Load(object sender, EventArgs e)
        {
            timer1.Start();
            MusteriListele(); // veya bir “Listele” 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Tarih_Saat.Text = DateTime.Now.ToString("g");
        }

        private void btn_AracEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoslukVar.Kontrol(
                    txt_AdiSoyadi.Text,
                    txt_Telefon.Text,
                    txt_Plaka.Text,
                    txt_Marka.Text,
                    txt_Model.Text,
                    txt_Yil.Text))
                {
                    MessageBox.Show("Text'ler boş bırakılamaz !!!");
                    return;// veritabanına kayıt işlemini engellemiş oldu neden textler boş bırakılamaz
                }
                //VeriTabanı açma                
                baglanti.Open();
                //Plaka için veritabanı sorgusu
                string plakaKontrol = "SELECT COUNT(*) FROM arac_bilgileri WHERE plaka = @plaka";
                SqlCommand plakaCmd = new SqlCommand(plakaKontrol, baglanti);
                plakaCmd.Parameters.AddWithValue("@plaka", txt_Plaka.Text);
                int ayniPlakaSayisi = Convert.ToInt32(plakaCmd.ExecuteScalar());

                if (ayniPlakaSayisi > 0)
                {
                    MessageBox.Show("Bu plaka zaten sistemde kayıtlı!");
                    LogYonetimi.Yaz("Plaka zaten vardı: " + txt_Plaka.Text);
                    return; // kayıt işlemini durdur
                }

                //müşteri bilgileri
                //SELECT SCOPE_IDENTITY(); son eklenen kaydın otomatik olarak oluşan ID’sini almak için kullanılır.                
                string arac_ekle = "INSERT INTO musteri_bilgileri (adi_soyadi, telefon) VALUES (@adi_soyadi, @telefon); SELECT SCOPE_IDENTITY();";
                SqlCommand parametreler = new SqlCommand(arac_ekle,baglanti);
                parametreler.Parameters.AddWithValue("@adi_soyadi",txt_AdiSoyadi.Text);
                parametreler.Parameters.AddWithValue("@telefon",txt_Telefon.Text);
                //Müşteri ID ilişkilendirme
                //int musteriID = Convert.ToInt32(parametreler.ExecuteScalar()); ExecuteScalar() için önce bağlanti açılmalı
                //Müşteri bilgilerinde oluşan MusteriID'sini aldık
                int musteriID = Convert.ToInt32(parametreler.ExecuteScalar());
                // NOT :
                //parametreler.ExecuteNonQuery(); //Arac ekle bilgilerini veritabanına kayıt
                //Müşteri Id 'sini ExecuteSclar() ile aldığımız için  parametreler.ExecuteNonQuery(); eklenmedi

                //araç bilgileri
                string arac_bilgileri = "INSERT INTO arac_bilgileri (plaka,marka,model,yil,musteri_id) VALUES(@plaka,@marka,@model,@yil,@musteri_id)";
                SqlCommand aracParametre = new SqlCommand(arac_bilgileri,baglanti);
                aracParametre.Parameters.AddWithValue("@plaka",txt_Plaka.Text);
                aracParametre.Parameters.AddWithValue("@marka",txt_Marka.Text);
                aracParametre.Parameters.AddWithValue("@model",txt_Model.Text);
                aracParametre.Parameters.AddWithValue("@yil",txt_Yil.Text);
                aracParametre.Parameters.AddWithValue("@musteri_id",musteriID);
                                
                aracParametre.ExecuteNonQuery();//Araç bilgilerini veritabanına kayıt

                LogYonetimi.Yaz("Araç eklendi: " + txt_Plaka.Text);//Log tutma

                MessageBox.Show("Müşteri ve Araç Bilgileri Kayıt edildi ...");

            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA oluştu:\n" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void btn_Ayarlar_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.ShowDialog();
        }

        private void btn_AracGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoslukVar.Kontrol(
                    txt_AdiSoyadi.Text,
                    txt_Telefon.Text,
                    txt_Plaka.Text,
                    txt_Marka.Text,
                    txt_Model.Text,
                    txt_Yil.Text))
                {
                    MessageBox.Show("Text'ler boş bırakılamaz !!!");
                    return;// veritabanına kayıt işlemini engellemiş oldu neden textler boş bırakılamaz
                }

                baglanti.Open();
                //Müşteri bilgileri Güncelleme
                string guncelle_musteri = "UPDATE musteri_bilgileri SET adi_soyadi=@adi_soyadi,telefon=@telefon WHERE id=@id";
                SqlCommand cmd = new SqlCommand(guncelle_musteri,baglanti);
                //dataGridView1 den müşteri id sini alıcaz
                int musteriID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

                cmd.Parameters.AddWithValue("@adi_soyadi",txt_AdiSoyadi.Text);
                cmd.Parameters.AddWithValue("@telefon",txt_Telefon.Text);
                cmd.Parameters.AddWithValue("@id",musteriID);

                //Araç bilgilerini güncelle
                string arac_bilgi_guncelle = "UPDATE arac_bilgileri SET plaka=@plaka,marka=@marka,model=@model,yil=@yil,musteri_id=@musteri_id WHERE musteri_id=@musteri_id";
                SqlCommand cmd_arac_bilgi = new SqlCommand(arac_bilgi_guncelle,baglanti);
                cmd_arac_bilgi.Parameters.AddWithValue("@plaka",txt_Plaka.Text);
                cmd_arac_bilgi.Parameters.AddWithValue("@marka",txt_Marka.Text);
                cmd_arac_bilgi.Parameters.AddWithValue("@model",txt_Model.Text);
                cmd_arac_bilgi.Parameters.AddWithValue("@yil",txt_Yil.Text);
                cmd_arac_bilgi.Parameters.AddWithValue("@musteri_id", musteriID);

                cmd.ExecuteNonQuery();
                cmd_arac_bilgi.ExecuteNonQuery();

                MessageBox.Show("Veriler Güncellendi");

            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA oluştu:\n" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGrid Wiew de müşteri bilgisine tıklandığında TEXT'ler otomatik dolacak
            txt_AdiSoyadi.Text = dataGridView1.CurrentRow.Cells["adi_soyadi"].Value.ToString();
            txt_Telefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txt_Plaka.Text = dataGridView1.CurrentRow.Cells["plaka"].Value.ToString();
            txt_Marka.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            txt_Model.Text = dataGridView1.CurrentRow.Cells["model"].Value.ToString();
            txt_Yil.Text = dataGridView1.CurrentRow.Cells["yil"].Value.ToString();

            lbl_id.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            int musteriID = Convert.ToInt32(lbl_id.Text); // artık ID label'dan alınır

        }

        private void txt_Plaka_TextChanged(object sender, EventArgs e)
        {
            // Plakaya göre müşteri bilgileri ve arç bilgileri DataGridWiew de görünecek
            DataView dv = dt.DefaultView; // 'dt' veri kaynağı → formda global tanımlanmalı
            dv.RowFilter = $"plaka LIKE '%{txt_Plaka.Text}%'";
            dataGridView1.DataSource = dv;
        }

        private void btn_AracSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoslukVar.Kontrol(
                    txt_AdiSoyadi.Text,
                    txt_Telefon.Text,
                    txt_Plaka.Text,
                    txt_Marka.Text,
                    txt_Model.Text,
                    txt_Yil.Text))
                {
                    MessageBox.Show("Text'ler boş bırakılamaz !!!");
                    return;// veritabanına kayıt işlemini engellemiş oldu neden textler boş bırakılamaz
                }
                int musteriID = Convert.ToInt32(lbl_id.Text);
                baglanti.Open();

                // 1. Araçları sil
                SqlCommand arac_sil = new SqlCommand("DELETE FROM arac_bilgileri WHERE musteri_id=@id", baglanti);
                arac_sil.Parameters.AddWithValue("@id", musteriID);
                arac_sil.ExecuteNonQuery(); // ❗ Silme komutu çalıştırıldı

                // 2. Müşteriyi sil
                SqlCommand sil_Musteri_Tablosu = new SqlCommand("DELETE FROM musteri_bilgileri WHERE id=@id", baglanti);
                sil_Musteri_Tablosu.Parameters.AddWithValue("@id", musteriID);
                sil_Musteri_Tablosu.ExecuteNonQuery(); // ❗ Silme komutu çalıştırıldı

                MessageBox.Show("Silme işlemi başarılı");
                MusteriListele(); // yenileme
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA oluştu:\n" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}