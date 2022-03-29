using System;
using System.Collections;
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
    class OtoparkMn
    {
        SQLConnect conn = new SQLConnect();
        //Park yerlerinin dolu-boş durumlarını listeler
        public List<string> ParkDurumuListele(Otopark parkyeri)
        {
            conn.ConnectionOpen();
            List<string> otoparkdurum = new List<string>();
            string strSql = "select ParkyeriKodu, case DoluBos when '0' then 'Boş' else 'Dolu' end as Durum from Otopark";
            SqlCommand cmd = new SqlCommand(strSql, conn.Conn);
            SqlDataReader dr = cmd.ExecuteReader();
            string strSatir = "";
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    strSatir += dr.GetValue(i) + " ";
                }
                otoparkdurum.Add(strSatir);
                strSatir = "";
            }
            conn.ConnectionClose();
            return otoparkdurum;
        }
        //Boş park yerlerini listeler
        public List<Otopark> Parkyerleri(Otopark parkyeri)
        {
            List<Otopark> parkyerleri=new List<Otopark>();
            conn.ConnectionOpen();            
            SqlCommand cmd = new SqlCommand("select * from Otopark where DoluBos=0 ", conn.Conn);
            SqlDataReader dr = cmd.ExecuteReader();           
            while (dr.Read())
            {
                Otopark parkalani = new Otopark();
                parkalani.ParkyeriID = Convert.ToInt32(dr[0]);
                parkalani.ParkyeriKodu = dr[2].ToString();
                parkyerleri.Add(parkalani);
            }
            conn.ConnectionClose();
            return parkyerleri;  
        } 
        //Çıkış yapan aracın parkeyerini dolu olarak günceller.
        public void ParkyeriDurumGuncelleme(Otopark parkyeri)
        {
            conn.ConnectionOpen();
            string strsql = "update Otopark set DoluBos=@doldu where ParkyeriID=@id";
            SqlCommand cmd = new SqlCommand(strsql,conn.Conn);
            cmd.Parameters.AddWithValue("@id", parkyeri.ParkyeriID);
            cmd.Parameters.AddWithValue("@doldu", 1);          
            cmd.ExecuteNonQuery();
            conn.ConnectionClose();
        }
    }
}
