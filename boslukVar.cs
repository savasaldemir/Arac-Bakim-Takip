using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Bakım_Takip
{
    public static class BoslukVar
    {
        public static bool Kontrol(params string[] alanlar)
        {
            foreach (string alan in alanlar)
            {
                if (string.IsNullOrWhiteSpace(alan))//Boşluklar kontrol
                    return true;
            }
            return false;
        }
    }
}
