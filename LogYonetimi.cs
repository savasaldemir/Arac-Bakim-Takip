using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public static class LogYonetimi
{
    public static void Yaz(string mesaj)
    {
        // Loglar klasörü dinamik olarak ayarlanır
        string klasorYolu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Loglar");

        // Eğer klasör yoksa oluştur
        if (!Directory.Exists(klasorYolu))
            Directory.CreateDirectory(klasorYolu);

        // Günlük log dosyası (örn: 2025-07-18_log.txt)
        string dosyaAdi = $"{DateTime.Now:yyyy-MM-dd}_log.txt";
        string dosyaYolu = Path.Combine(klasorYolu, dosyaAdi);

        // Mesaj zaman damgası ile yazılır
        string zamanliMesaj = $"{DateTime.Now:HH:mm:ss} | {mesaj}";

        // Dosyaya eklenir
        File.AppendAllText(dosyaYolu, zamanliMesaj + Environment.NewLine);
    }
}
