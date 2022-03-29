using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkyeri_Otomasyonu.Model
{
    class OtoparkArac
    {
        public int AracOtoparkID { get; set; }
        public int AracID { get; set; }
        public int ParkyeriID { get; set; }
        public DateTime AracCikisSaati { get; set; }
        public double Ucret { get; set; }
    }
}
