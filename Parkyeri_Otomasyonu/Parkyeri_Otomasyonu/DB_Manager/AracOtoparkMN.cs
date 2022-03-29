using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parkyeri_Otomasyonu.Model;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Parkyeri_Otomasyonu.DB_Manager
{
    class AracOtoparkMN
    {
        SQLConnect conn=new SQLConnect();
        private int SaatUcreti = 10;
        //Otoparktan çıkış yapan araçların veri tabanında AracOtopark tablosuna ekler.
        public void AracCikis(OtoparkArac cikanArac,Arac arac)
        {
            conn.ConnectionOpen();
            SqlCommand cmd = new SqlCommand("insert into AracOtopark values(@aracid,@parkyeriid,getDate(),@tutar)", conn.Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@aracid", arac.AracID);
            cmd.Parameters.AddWithValue("@parkyeriid",arac.ParkyeriID);
            cmd.Parameters.AddWithValue("@tutar", UcretHesaplama(arac,cikanArac));
            cmd.ExecuteNonQuery();
            conn.ConnectionClose();
        }
        //Aracın ziyaret süresine göre ödenecek ücret hesaplanır.
        public double UcretHesaplama(Arac arac,OtoparkArac otoarac)
        {
            TimeSpan span = DateTime.Now.Subtract(arac.AracGirisSaati);
            otoarac.Ucret = span.Hours * SaatUcreti;
            return otoarac.Ucret;
        }
        //Giren Aracın parkyerinin durumunu boş olarak günceller.
        public void ParkyeriDurumGuncellemeCikis(Otopark parkyeri)
        {
            conn.ConnectionOpen();
            SqlCommand cmd = new SqlCommand("update Otopark set DoluBos=@bosalt where ParkyeriID=@id", conn.Conn);
            cmd.Parameters.AddWithValue("@id", parkyeri.ParkyeriID);
            cmd.Parameters.AddWithValue("@bosalt", 0);
            cmd.ExecuteNonQuery();
            conn.ConnectionClose();
        }
        public List<OtoparkArac> Listeleme()
        {
            List<OtoparkArac> listelenenAraclar = new List<OtoparkArac>();
            conn.ConnectionOpen();
            string sqlStr = "select * from AracOtopark";
            SqlCommand cmd = new SqlCommand(sqlStr, conn.Conn);
            SqlDataReader dr = cmd.ExecuteReader();           
            while (dr.Read())
            {
                OtoparkArac araclar = new OtoparkArac();
                araclar.AracID = Convert.ToInt32(dr[1]);
                araclar.ParkyeriID = Convert.ToInt32(dr[2]);
                araclar.AracCikisSaati = (DateTime)dr[3];
                araclar.Ucret = Convert.ToDouble(dr[4]);
                listelenenAraclar.Add(araclar);
            }
            return listelenenAraclar;
        }
        public DataTable KazancGoruntuleme()
        {
            conn.ConnectionOpen();
            SqlDataAdapter da = new SqlDataAdapter("select AracPlakasi,Ucret from Araclar inner join AracOtopark on Araclar.AracID=AracOtopark.AracID", conn.Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow satir = dt.NewRow();
            return dt;
        }
        
    }
}
