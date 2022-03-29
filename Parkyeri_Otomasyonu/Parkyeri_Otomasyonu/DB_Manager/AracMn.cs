using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parkyeri_Otomasyonu.Model;
namespace Parkyeri_Otomasyonu.DB_Menager
{
    class AracMn
    {
        SQLConnect conn = new SQLConnect();  
        //Otoparka giriş yapacak aracın bilgilerinin ve giriş saatinin veri tabanına kayıt edilmesi
        public void AracEkle(Arac arac)
        {
            arac.AracGirisSaati = DateTime.Now;
            conn.ConnectionOpen();
            string strSql = "insert into Araclar values(@plaka,getDate(),@parkyeriid,@durum)";
            SqlCommand cmd = new SqlCommand(strSql,conn.Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@plaka", arac.Plaka);
            cmd.Parameters.AddWithValue("@parkyeriid", arac.ParkyeriID);
            cmd.Parameters.AddWithValue("@durum", arac.Durum = true);
            cmd.ExecuteNonQuery();
            conn.ConnectionClose();
        }
        //Araç çıkışı için arac bulunur.
        public void AracBul(Arac arac)
        {
            conn.ConnectionOpen();
            string strSql = "select * from Araclar where AracID=@id";
            SqlCommand cmd = new SqlCommand(strSql,conn.Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", arac.AracID);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {       
                
                arac.AracID = (int)dr[0];
                arac.Plaka = dr[1].ToString();
                arac.AracGirisSaati = (DateTime)dr[2];
                arac.ParkyeriID = (int)dr[3];
            }
            else
            {               
                arac.AracID = -1;
            }
            conn.ConnectionClose();
        }
        //Otoparktaki Araçlar listelenir
        public DataTable AraclariListele(Arac arac)
        {
            conn.ConnectionOpen();
            SqlDataAdapter da = new SqlDataAdapter("select AracOtoparkID,AracID,ParkyeriID,CıkısSaati from AracOtopark  ", conn.Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow satir = dt.NewRow();
            conn.ConnectionClose();
            return dt;
        }
        //Giren Aracın parkyerinin durumunu dolu olarak günceller.
        public void DurumTersle(Arac arac)
        {
            conn.ConnectionOpen();
            string strSql = "update  Araclar set Durum=@false where AracID=@aracid";
            SqlCommand cmd = new SqlCommand(strSql, conn.Conn);
            cmd.Parameters.AddWithValue("@aracid", arac.AracID);
            cmd.Parameters.AddWithValue("@false",arac.Durum=false);
            cmd.ExecuteNonQuery();
            conn.ConnectionClose();
        }
        //Otopark içerisindeki ve otoparktan çıkış yapmış tüm araçları listeler, raporlama amacıyla yapılmıştır. Saklı prosedür olarak db den çekilir.
        public DataTable OtoparkIcindekiAraclar(Arac arac)
        {
            conn.ConnectionOpen();
            SqlDataAdapter da = new SqlDataAdapter("exec gp_Araclar", conn.Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow satir = dt.NewRow();
            conn.ConnectionClose();
            return dt;
        }
    }
}
