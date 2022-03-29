using Parkyeri_Otomasyonu.DB_Manager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkyeri_Otomasyonu.DB_Menager
{
    class OtoparkDBManager
    {
        public AracMn Arac { get; set; }
        public OtoparkMn Otopark { get; set; }
        public AracOtoparkMN aracOtopark { get; set; }
    }
}
