using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkyeri_Otomasyonu.Model
{
    class Arac
    {
        public int AracID { get; set; }
        public string Plaka { get; set; }
        public DateTime AracGirisSaati { get; set; }
        public int ParkyeriID { get; set; }
        public bool Durum { get; set; }


    }
}
