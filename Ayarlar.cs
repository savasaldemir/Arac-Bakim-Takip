using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Bakım_Takip
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void btn_LoglariGoster_Click(object sender, EventArgs e)
        {
            string klasorYolu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Loglar");
            string dosyaAdi = $"{DateTime.Now:yyyy-MM-dd}_log.txt";
            string logDosyasi = Path.Combine(klasorYolu, dosyaAdi);

            // Dosya varsa aç, yoksa uyarı ver
            if (File.Exists(logDosyasi))
            {
                Process.Start("notepad.exe", logDosyasi);
            }
            else
            {
                MessageBox.Show("Bugün için log dosyası bulunamadı.");
            }
        
        }

        private void btn_YagBilgileri_Click(object sender, EventArgs e)
        {
            yag_bilgileri yag_Bilgileri = new yag_bilgileri();
            yag_Bilgileri.ShowDialog();
        }
    }
}
