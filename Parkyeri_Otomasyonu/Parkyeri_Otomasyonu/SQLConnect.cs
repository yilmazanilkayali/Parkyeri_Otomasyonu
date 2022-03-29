using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Parkyeri_Otomasyonu
{
    public class SQLConnect
    {
        public string ConnStr { get; set; }
        public SqlConnection Conn { get; set; }
        public SQLConnect()
        {
            ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString.ToString();
        }
        public void ConnectionOpen()
        {
            Conn = new SqlConnection(ConnStr);
            Conn.Open();
        }
        public void ConnectionClose()
        {
            Conn.Close();
        }
    }
}
