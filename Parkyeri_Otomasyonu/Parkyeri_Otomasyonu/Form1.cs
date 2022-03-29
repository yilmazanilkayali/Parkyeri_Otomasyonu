using Parkyeri_Otomasyonu.DB_Menager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parkyeri_Otomasyonu.Model;
using Parkyeri_Otomasyonu.Properties;
using System.Data.SqlClient;
using Parkyeri_Otomasyonu.DB_Manager;
using System.Collections;

namespace Parkyeri_Otomasyonu
{
    public partial class Form1 : Form
    {
       
        Arac arac = new Arac();
        AracMn aracMn = new AracMn();
        Otopark otopark = new Otopark();
        OtoparkMn otoparkMn = new OtoparkMn();
        AracOtoparkMN aracoto=new AracOtoparkMN();
        OtoparkArac otoarac=new OtoparkArac();       
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbxParkyerisecim.DataSource = otoparkMn.Parkyerleri(otopark);
            cmbxParkyerisecim.DisplayMember = "ParkyeriKodu";
            cmbxParkyerisecim.ValueMember = "ParkyeriID";
            //txtPlaka.Focus();
        }
        private void Ekle_Click(object sender, EventArgs e)
        {         
            arac.Plaka = txtPlaka.Text;
            if (txtPlaka.Text != "")
            {
                arac.ParkyeriID = Convert.ToInt32(cmbxParkyerisecim.SelectedValue);
                try
                {
                    aracMn.AracEkle(arac);
                    otopark.ParkyeriID = arac.ParkyeriID;
                    otoparkMn.ParkyeriDurumGuncelleme(otopark);
                    MessageBox.Show("Araç Girişi Yapıldı");
                    cmbxParkyerisecim.DataSource = otoparkMn.Parkyerleri(otopark);
                    cmbxParkyerisecim.DisplayMember = "ParkyeriKodu";
                    cmbxParkyerisecim.ValueMember = "ParkyeriID";
                    txtPlaka.Text = "";
                }
                catch (SqlException )
                {

                    MessageBox.Show("Girilmiş Plaka yada Geçerli Bir Plaka Giriniz");       
                }
                
            }
            else
                MessageBox.Show("Geçerli Bir Plaka Giriniz");
        }
        private void btnDolulukDurum_Click(object sender, EventArgs e)
        {
            dataGridViewEkran.Visible = false;
            listBoxEkran.Visible = true;
            listBoxEkran.Items.Clear();
            //int sayi = otoparkMn.ParkDurumuListele(otopark).Count;
            foreach (string item in otoparkMn.ParkDurumuListele(otopark))
            {
                listBoxEkran.Items.Add(item.ToString());
            }
        }

        private void btnKazancGoruntule_Click(object sender, EventArgs e)
        {
            listBoxEkran.Items.Clear();
            dataGridViewEkran.Visible = true;
            dataGridViewEkran.DataSource = aracoto.KazancGoruntuleme();
            //foreach (string item in aracoto.KazancGoruntuleme())
            //{
            //    listBox1.Items.Add(item);
            //}

        }        
        private void btnAracCikis_Click(object sender, EventArgs e)
        {
            arac.AracID = int.Parse(txtID.Text);
            //if (arac.AracID == -1 || txtID.Text =="" || txtBxParkyeri.Text==""|| txtBxUcret.Text==""||txtGirisSaati.Text==""||txtPlaka.Text=="")
            //{
            //    MessageBox.Show("Aradığınız Araç Bulunamadı");
            //}
            //else
            //{
                aracMn.AracBul(arac);
                arac.Plaka = txtPlaka.Text;
                txtGirisSaati.Text = arac.AracGirisSaati.ToString();
                txtBxParkyeri.Text = arac.ParkyeriID.ToString();
                otoarac.AracID = arac.AracID;
                otoarac.ParkyeriID = arac.ParkyeriID;
                otoarac.AracCikisSaati = DateTime.Now;
                aracoto.AracCikis(otoarac, arac);
                otopark.ParkyeriID = arac.ParkyeriID;
                txtBxUcret.Text = otoarac.Ucret.ToString();
                aracoto.ParkyeriDurumGuncellemeCikis(otopark);
                aracMn.DurumTersle(arac);
                cmbxParkyerisecim.DataSource = otoparkMn.Parkyerleri(otopark);
                cmbxParkyerisecim.DisplayMember = "ParkyeriKodu";
                cmbxParkyerisecim.ValueMember = "ParkyeriID";/////hepsi bir metodda topla.
                MessageBox.Show("Araç Çıkışı Gerçekleşti");
                txtID.Text = "";
                txtPlaka.Text = "";
                txtGirisSaati.Text = "";
                txtBxUcret.Text = "";
                txtBxParkyeri.Text = "";
            //}
        }
        private void btnAracGoruntule_Click(object sender, EventArgs e)
        {
            
            listBoxEkran.Items.Clear();
            dataGridViewEkran.Visible = true;
            dataGridViewEkran.DataSource = aracMn.AraclariListele(arac);
        }
                    
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTamEkranYap_Click(object sender, EventArgs e)
        {  
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnSimgeDurumunaGetir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIceridekiAraclar_Click_1(object sender, EventArgs e)
        {
            dataGridViewEkran.Visible = true;
            dataGridViewEkran.DataSource = aracMn.OtoparkIcindekiAraclar(arac);
        }
        int Move=-1;
        int Mouse_X;
        int Mouse_Y;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void btnKazancGoruntule_Click_1(object sender, EventArgs e)
        {
            dataGridViewEkran.Visible = true;
            dataGridViewEkran.DataSource = aracoto.KazancGoruntuleme();

        }
    }
}
