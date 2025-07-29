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
    public partial class yag_bilgileri : Form
    {
        public yag_bilgileri()
        {
            InitializeComponent();
        }
        //Veri tabanı yolu
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=Arac_Bakim_Takip;Integrated Security=True");

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoslukVar.Kontrol(
                    txt_marka.Text,
                    txt_Viskozite1.Text,
                    txt_Viskozite2.Text))
                {
                    MessageBox.Show("Text'ler boş bırakılamaz !!!");
                    return;// veritabanına kayıt işlemini engellemiş oldu neden textler boş bırakılamaz
                }
                string vt_Kayit = "INSERT INTO motor_yaglari (marka, viskozite1, viskozite2) VALUES (@marka, @viskozite1, @viskozite2); SELECT SCOPE_IDENTITY();";
                SqlCommand yag_kayit = new SqlCommand(vt_Kayit, baglanti);
                yag_kayit.Parameters.AddWithValue("@marka", txt_marka.Text);
                yag_kayit.Parameters.AddWithValue("@viskozite1", txt_Viskozite1.Text);
                yag_kayit.Parameters.AddWithValue("@viskozite2", txt_Viskozite2.Text);

                baglanti.Open();
                object sonuc = yag_kayit.ExecuteScalar();

                lbl_Bilgi.Text = "Kayıt Başarılı";
                txt_marka.Text = "";
                txt_Viskozite1.Text = "";
                txt_Viskozite2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA \n" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoslukVar.Kontrol(
                    txt_marka.Text,
                    txt_Viskozite1.Text,
                    txt_Viskozite2.Text))
                {
                    MessageBox.Show("Marka ve Viskozite bilgileri boş bırakılamaz!");
                    return;
                }

                SqlCommand silKomut = new SqlCommand("DELETE FROM motor_yaglari WHERE marka = @marka AND viskozite1 = @v1 AND viskozite2 = @v2",baglanti);

                silKomut.Parameters.AddWithValue("@marka", txt_marka.Text.Trim());
                silKomut.Parameters.AddWithValue("@v1", txt_Viskozite1.Text.Trim());
                silKomut.Parameters.AddWithValue("@v2", txt_Viskozite2.Text.Trim());

                baglanti.Open();
                int sonuc = silKomut.ExecuteNonQuery();
                baglanti.Close();

                if (sonuc > 0)
                    lbl_Bilgi.Text = "Silme işlemi başarılı.";
                else
                    lbl_Bilgi.Text = "Kayıt bulunamadı.";

                txt_marka.Text = "";
                txt_Viskozite1.Text = "";
                txt_Viskozite2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }
    }
}
