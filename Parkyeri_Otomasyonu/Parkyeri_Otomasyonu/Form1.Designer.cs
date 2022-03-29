
namespace Parkyeri_Otomasyonu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtGirisSaati = new System.Windows.Forms.TextBox();
            this.txtBxParkyeri = new System.Windows.Forms.TextBox();
            this.txtBxUcret = new System.Windows.Forms.TextBox();
            this.btnAracGiris = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.btnAracCikis = new System.Windows.Forms.Button();
            this.btnDolulukDurum = new System.Windows.Forms.Button();
            this.listBoxEkran = new System.Windows.Forms.ListBox();
            this.lblCikisSaati = new System.Windows.Forms.Label();
            this.cmbxParkyerisecim = new System.Windows.Forms.ComboBox();
            this.lblAracGirisi = new System.Windows.Forms.Label();
            this.lblParkyeriSecim = new System.Windows.Forms.Label();
            this.lblAracCikis = new System.Windows.Forms.Label();
            this.lblParkYeri = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.btnAracGoruntule = new System.Windows.Forms.Button();
            this.btnIceridekiAraclar = new System.Windows.Forms.Button();
            this.dataGridViewEkran = new System.Windows.Forms.DataGridView();
            this.btnSimgeDurumunaGetir = new System.Windows.Forms.Button();
            this.btnTamEkranYap = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKazancGoruntule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEkran)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(402, 96);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlaka.Location = new System.Drawing.Point(123, 114);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(150, 22);
            this.txtPlaka.TabIndex = 0;
            // 
            // txtGirisSaati
            // 
            this.txtGirisSaati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGirisSaati.Location = new System.Drawing.Point(401, 126);
            this.txtGirisSaati.Name = "txtGirisSaati";
            this.txtGirisSaati.Size = new System.Drawing.Size(150, 22);
            this.txtGirisSaati.TabIndex = 0;
            // 
            // txtBxParkyeri
            // 
            this.txtBxParkyeri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBxParkyeri.Location = new System.Drawing.Point(401, 155);
            this.txtBxParkyeri.Name = "txtBxParkyeri";
            this.txtBxParkyeri.Size = new System.Drawing.Size(150, 22);
            this.txtBxParkyeri.TabIndex = 0;
            // 
            // txtBxUcret
            // 
            this.txtBxUcret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBxUcret.Location = new System.Drawing.Point(401, 183);
            this.txtBxUcret.Name = "txtBxUcret";
            this.txtBxUcret.Size = new System.Drawing.Size(150, 22);
            this.txtBxUcret.TabIndex = 0;
            // 
            // btnAracGiris
            // 
            this.btnAracGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAracGiris.Location = new System.Drawing.Point(123, 190);
            this.btnAracGiris.Name = "btnAracGiris";
            this.btnAracGiris.Size = new System.Drawing.Size(121, 61);
            this.btnAracGiris.TabIndex = 1;
            this.btnAracGiris.Text = "Araç Girişi";
            this.btnAracGiris.UseVisualStyleBackColor = true;
            this.btnAracGiris.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(346, 101);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(48, 16);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "AracID";
            // 
            // lblPlaka
            // 
            this.lblPlaka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(31, 119);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(83, 16);
            this.lblPlaka.TabIndex = 3;
            this.lblPlaka.Text = "Arac Plakası";
            // 
            // btnAracCikis
            // 
            this.btnAracCikis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAracCikis.Location = new System.Drawing.Point(402, 221);
            this.btnAracCikis.Name = "btnAracCikis";
            this.btnAracCikis.Size = new System.Drawing.Size(128, 49);
            this.btnAracCikis.TabIndex = 4;
            this.btnAracCikis.Text = "Araç Çıkışı";
            this.btnAracCikis.UseVisualStyleBackColor = true;
            this.btnAracCikis.Click += new System.EventHandler(this.btnAracCikis_Click);
            // 
            // btnDolulukDurum
            // 
            this.btnDolulukDurum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDolulukDurum.Location = new System.Drawing.Point(638, 94);
            this.btnDolulukDurum.Name = "btnDolulukDurum";
            this.btnDolulukDurum.Size = new System.Drawing.Size(180, 33);
            this.btnDolulukDurum.TabIndex = 5;
            this.btnDolulukDurum.Text = "Doluluk Durumu";
            this.btnDolulukDurum.UseVisualStyleBackColor = true;
            this.btnDolulukDurum.Click += new System.EventHandler(this.btnDolulukDurum_Click);
            // 
            // listBoxEkran
            // 
            this.listBoxEkran.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxEkran.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listBoxEkran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxEkran.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEkran.FormattingEnabled = true;
            this.listBoxEkran.ItemHeight = 24;
            this.listBoxEkran.Location = new System.Drawing.Point(51, 285);
            this.listBoxEkran.Name = "listBoxEkran";
            this.listBoxEkran.Size = new System.Drawing.Size(814, 264);
            this.listBoxEkran.TabIndex = 7;
            this.listBoxEkran.Visible = false;
            // 
            // lblCikisSaati
            // 
            this.lblCikisSaati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCikisSaati.AutoSize = true;
            this.lblCikisSaati.Location = new System.Drawing.Point(324, 129);
            this.lblCikisSaati.Name = "lblCikisSaati";
            this.lblCikisSaati.Size = new System.Drawing.Size(70, 16);
            this.lblCikisSaati.TabIndex = 8;
            this.lblCikisSaati.Text = "Çıkış Saati";
            // 
            // cmbxParkyerisecim
            // 
            this.cmbxParkyerisecim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbxParkyerisecim.FormattingEnabled = true;
            this.cmbxParkyerisecim.Location = new System.Drawing.Point(123, 153);
            this.cmbxParkyerisecim.Name = "cmbxParkyerisecim";
            this.cmbxParkyerisecim.Size = new System.Drawing.Size(150, 24);
            this.cmbxParkyerisecim.TabIndex = 9;
            // 
            // lblAracGirisi
            // 
            this.lblAracGirisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAracGirisi.AutoSize = true;
            this.lblAracGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAracGirisi.Location = new System.Drawing.Point(45, 69);
            this.lblAracGirisi.Name = "lblAracGirisi";
            this.lblAracGirisi.Size = new System.Drawing.Size(145, 32);
            this.lblAracGirisi.TabIndex = 11;
            this.lblAracGirisi.Text = "Araç Girişi";
            // 
            // lblParkyeriSecim
            // 
            this.lblParkyeriSecim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblParkyeriSecim.AutoSize = true;
            this.lblParkyeriSecim.Location = new System.Drawing.Point(11, 159);
            this.lblParkyeriSecim.Name = "lblParkyeriSecim";
            this.lblParkyeriSecim.Size = new System.Drawing.Size(103, 16);
            this.lblParkyeriSecim.TabIndex = 12;
            this.lblParkyeriSecim.Text = "Parkyeri Seçiniz";
            // 
            // lblAracCikis
            // 
            this.lblAracCikis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAracCikis.AutoSize = true;
            this.lblAracCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAracCikis.Location = new System.Drawing.Point(381, 51);
            this.lblAracCikis.Name = "lblAracCikis";
            this.lblAracCikis.Size = new System.Drawing.Size(148, 32);
            this.lblAracCikis.TabIndex = 11;
            this.lblAracCikis.Text = "Araç Çıkışı";
            // 
            // lblParkYeri
            // 
            this.lblParkYeri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblParkYeri.AutoSize = true;
            this.lblParkYeri.Location = new System.Drawing.Point(332, 159);
            this.lblParkYeri.Name = "lblParkYeri";
            this.lblParkYeri.Size = new System.Drawing.Size(62, 16);
            this.lblParkYeri.TabIndex = 13;
            this.lblParkYeri.Text = "Park Yeri";
            // 
            // lblUcret
            // 
            this.lblUcret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(356, 185);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(39, 16);
            this.lblUcret.TabIndex = 14;
            this.lblUcret.Text = "Ucret";
            // 
            // btnAracGoruntule
            // 
            this.btnAracGoruntule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAracGoruntule.Location = new System.Drawing.Point(638, 176);
            this.btnAracGoruntule.Name = "btnAracGoruntule";
            this.btnAracGoruntule.Size = new System.Drawing.Size(180, 33);
            this.btnAracGoruntule.TabIndex = 15;
            this.btnAracGoruntule.Text = "Araçları Görüntüle";
            this.btnAracGoruntule.UseVisualStyleBackColor = true;
            this.btnAracGoruntule.Click += new System.EventHandler(this.btnAracGoruntule_Click);
            // 
            // btnIceridekiAraclar
            // 
            this.btnIceridekiAraclar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIceridekiAraclar.Location = new System.Drawing.Point(638, 214);
            this.btnIceridekiAraclar.Name = "btnIceridekiAraclar";
            this.btnIceridekiAraclar.Size = new System.Drawing.Size(180, 33);
            this.btnIceridekiAraclar.TabIndex = 16;
            this.btnIceridekiAraclar.Text = "Otoparktaki Araçlar";
            this.btnIceridekiAraclar.UseVisualStyleBackColor = true;
            this.btnIceridekiAraclar.Click += new System.EventHandler(this.btnIceridekiAraclar_Click_1);
            // 
            // dataGridViewEkran
            // 
            this.dataGridViewEkran.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewEkran.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridViewEkran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEkran.Location = new System.Drawing.Point(0, 276);
            this.dataGridViewEkran.Name = "dataGridViewEkran";
            this.dataGridViewEkran.RowHeadersWidth = 51;
            this.dataGridViewEkran.RowTemplate.Height = 24;
            this.dataGridViewEkran.Size = new System.Drawing.Size(865, 283);
            this.dataGridViewEkran.TabIndex = 17;
            this.dataGridViewEkran.Visible = false;
            // 
            // btnSimgeDurumunaGetir
            // 
            this.btnSimgeDurumunaGetir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimgeDurumunaGetir.BackgroundImage = global::Parkyeri_Otomasyonu.Properties.Resources.alt;
            this.btnSimgeDurumunaGetir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSimgeDurumunaGetir.Location = new System.Drawing.Point(736, 3);
            this.btnSimgeDurumunaGetir.Name = "btnSimgeDurumunaGetir";
            this.btnSimgeDurumunaGetir.Size = new System.Drawing.Size(38, 32);
            this.btnSimgeDurumunaGetir.TabIndex = 23;
            this.btnSimgeDurumunaGetir.UseVisualStyleBackColor = true;
            this.btnSimgeDurumunaGetir.Click += new System.EventHandler(this.btnSimgeDurumunaGetir_Click);
            // 
            // btnTamEkranYap
            // 
            this.btnTamEkranYap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamEkranYap.BackgroundImage = global::Parkyeri_Otomasyonu.Properties.Resources.tek;
            this.btnTamEkranYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTamEkranYap.Location = new System.Drawing.Point(780, 3);
            this.btnTamEkranYap.Name = "btnTamEkranYap";
            this.btnTamEkranYap.Size = new System.Drawing.Size(38, 32);
            this.btnTamEkranYap.TabIndex = 22;
            this.btnTamEkranYap.UseVisualStyleBackColor = true;
            this.btnTamEkranYap.Click += new System.EventHandler(this.btnTamEkranYap_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackgroundImage = global::Parkyeri_Otomasyonu.Properties.Resources.cıkıs_butonu;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Location = new System.Drawing.Point(821, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(38, 32);
            this.btnKapat.TabIndex = 21;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnSimgeDurumunaGetir);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.btnTamEkranYap);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 35);
            this.panel1.TabIndex = 24;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnKazancGoruntule
            // 
            this.btnKazancGoruntule.Location = new System.Drawing.Point(638, 134);
            this.btnKazancGoruntule.Name = "btnKazancGoruntule";
            this.btnKazancGoruntule.Size = new System.Drawing.Size(180, 33);
            this.btnKazancGoruntule.TabIndex = 25;
            this.btnKazancGoruntule.Text = "Kazanç Görüntüle";
            this.btnKazancGoruntule.UseVisualStyleBackColor = true;
            this.btnKazancGoruntule.Click += new System.EventHandler(this.btnKazancGoruntule_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(862, 553);
            this.Controls.Add(this.btnKazancGoruntule);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewEkran);
            this.Controls.Add(this.btnIceridekiAraclar);
            this.Controls.Add(this.btnAracGoruntule);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.lblParkYeri);
            this.Controls.Add(this.lblParkyeriSecim);
            this.Controls.Add(this.lblAracCikis);
            this.Controls.Add(this.lblAracGirisi);
            this.Controls.Add(this.cmbxParkyerisecim);
            this.Controls.Add(this.lblCikisSaati);
            this.Controls.Add(this.listBoxEkran);
            this.Controls.Add(this.btnDolulukDurum);
            this.Controls.Add(this.btnAracCikis);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAracGiris);
            this.Controls.Add(this.txtBxUcret);
            this.Controls.Add(this.txtBxParkyeri);
            this.Controls.Add(this.txtGirisSaati);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEkran)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtGirisSaati;
        private System.Windows.Forms.TextBox txtBxParkyeri;
        private System.Windows.Forms.TextBox txtBxUcret;
        private System.Windows.Forms.Button btnAracGiris;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Button btnAracCikis;
        private System.Windows.Forms.Button btnDolulukDurum;
        private System.Windows.Forms.ListBox listBoxEkran;
        private System.Windows.Forms.Label lblCikisSaati;
        private System.Windows.Forms.ComboBox cmbxParkyerisecim;
        private System.Windows.Forms.Label lblAracGirisi;
        private System.Windows.Forms.Label lblParkyeriSecim;
        private System.Windows.Forms.Label lblAracCikis;
        private System.Windows.Forms.Label lblParkYeri;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Button btnAracGoruntule;
        private System.Windows.Forms.Button btnIceridekiAraclar;
        private System.Windows.Forms.DataGridView dataGridViewEkran;
        private System.Windows.Forms.Button btnSimgeDurumunaGetir;
        private System.Windows.Forms.Button btnTamEkranYap;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKazancGoruntule;
    }
}

