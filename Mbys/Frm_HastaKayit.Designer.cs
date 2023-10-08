namespace Mbys
{
    partial class Frm_HastaKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_hastaEkle = new System.Windows.Forms.Button();
            this.msk_hasta_Adres = new System.Windows.Forms.TextBox();
            this.msk_hasta_dgmYeri = new System.Windows.Forms.ComboBox();
            this.msk_hasta_medenihal = new System.Windows.Forms.ComboBox();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.msk_hasta_Telno = new System.Windows.Forms.MaskedTextBox();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_Adi = new System.Windows.Forms.Label();
            this.lbl_dgmYeri = new System.Windows.Forms.Label();
            this.msk_hasta_dogumtarihi = new System.Windows.Forms.MaskedTextBox();
            this.lbl_dogum_tarihi = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.msk_hasta_soyad = new System.Windows.Forms.MaskedTextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.msk_hasta_adi = new System.Windows.Forms.MaskedTextBox();
            this.lbl_medenidurum = new System.Windows.Forms.Label();
            this.msk_hasta_tc = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(300, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 37);
            this.label1.TabIndex = 36;
            this.label1.Text = "Hasta Kayıt Bilgisi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_hastaEkle);
            this.groupBox1.Controls.Add(this.msk_hasta_Adres);
            this.groupBox1.Controls.Add(this.msk_hasta_dgmYeri);
            this.groupBox1.Controls.Add(this.msk_hasta_medenihal);
            this.groupBox1.Controls.Add(this.lbl_soyad);
            this.groupBox1.Controls.Add(this.msk_hasta_Telno);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.lbl_Adi);
            this.groupBox1.Controls.Add(this.lbl_dgmYeri);
            this.groupBox1.Controls.Add(this.msk_hasta_dogumtarihi);
            this.groupBox1.Controls.Add(this.lbl_dogum_tarihi);
            this.groupBox1.Controls.Add(this.lbl_telefon);
            this.groupBox1.Controls.Add(this.msk_hasta_soyad);
            this.groupBox1.Controls.Add(this.lblAdres);
            this.groupBox1.Controls.Add(this.msk_hasta_adi);
            this.groupBox1.Controls.Add(this.lbl_medenidurum);
            this.groupBox1.Controls.Add(this.msk_hasta_tc);
            this.groupBox1.Location = new System.Drawing.Point(185, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(430, 356);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Kayıt";
            // 
            // btn_hastaEkle
            // 
            this.btn_hastaEkle.Location = new System.Drawing.Point(162, 312);
            this.btn_hastaEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hastaEkle.Name = "btn_hastaEkle";
            this.btn_hastaEkle.Size = new System.Drawing.Size(82, 22);
            this.btn_hastaEkle.TabIndex = 38;
            this.btn_hastaEkle.Text = "Ekle";
            this.btn_hastaEkle.UseVisualStyleBackColor = true;
            this.btn_hastaEkle.Click += new System.EventHandler(this.btn_hastaEkle_Click);
            // 
            // msk_hasta_Adres
            // 
            this.msk_hasta_Adres.Location = new System.Drawing.Point(162, 250);
            this.msk_hasta_Adres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hasta_Adres.Multiline = true;
            this.msk_hasta_Adres.Name = "msk_hasta_Adres";
            this.msk_hasta_Adres.Size = new System.Drawing.Size(203, 43);
            this.msk_hasta_Adres.TabIndex = 37;
            // 
            // msk_hasta_dgmYeri
            // 
            this.msk_hasta_dgmYeri.FormattingEnabled = true;
            this.msk_hasta_dgmYeri.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak",
            "Belirtilmemiş"});
            this.msk_hasta_dgmYeri.Location = new System.Drawing.Point(162, 216);
            this.msk_hasta_dgmYeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hasta_dgmYeri.Name = "msk_hasta_dgmYeri";
            this.msk_hasta_dgmYeri.Size = new System.Drawing.Size(110, 23);
            this.msk_hasta_dgmYeri.TabIndex = 36;
            // 
            // msk_hasta_medenihal
            // 
            this.msk_hasta_medenihal.FormattingEnabled = true;
            this.msk_hasta_medenihal.Items.AddRange(new object[] {
            "Bekar",
            "Evli ",
            "Dul",
            "Boşanmış",
            "Belirtilmemiş"});
            this.msk_hasta_medenihal.Location = new System.Drawing.Point(162, 181);
            this.msk_hasta_medenihal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hasta_medenihal.Name = "msk_hasta_medenihal";
            this.msk_hasta_medenihal.Size = new System.Drawing.Size(110, 23);
            this.msk_hasta_medenihal.TabIndex = 35;
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_soyad.Location = new System.Drawing.Point(68, 90);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(46, 15);
            this.lbl_soyad.TabIndex = 2;
            this.lbl_soyad.Text = "Soyadı:";
            // 
            // msk_hasta_Telno
            // 
            this.msk_hasta_Telno.Location = new System.Drawing.Point(162, 150);
            this.msk_hasta_Telno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hasta_Telno.Mask = "9990000000";
            this.msk_hasta_Telno.Name = "msk_hasta_Telno";
            this.msk_hasta_Telno.Size = new System.Drawing.Size(110, 23);
            this.msk_hasta_Telno.TabIndex = 17;
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tc.Location = new System.Drawing.Point(68, 31);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(22, 15);
            this.lbl_tc.TabIndex = 0;
            this.lbl_tc.Text = "Tc:";
            // 
            // lbl_Adi
            // 
            this.lbl_Adi.AutoSize = true;
            this.lbl_Adi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Adi.Location = new System.Drawing.Point(68, 61);
            this.lbl_Adi.Name = "lbl_Adi";
            this.lbl_Adi.Size = new System.Drawing.Size(28, 15);
            this.lbl_Adi.TabIndex = 1;
            this.lbl_Adi.Text = "Adı:";
            // 
            // lbl_dgmYeri
            // 
            this.lbl_dgmYeri.AutoSize = true;
            this.lbl_dgmYeri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dgmYeri.Location = new System.Drawing.Point(69, 215);
            this.lbl_dgmYeri.Name = "lbl_dgmYeri";
            this.lbl_dgmYeri.Size = new System.Drawing.Size(75, 15);
            this.lbl_dgmYeri.TabIndex = 3;
            this.lbl_dgmYeri.Text = "Doğum Yeri:";
            // 
            // msk_hasta_dogumtarihi
            // 
            this.msk_hasta_dogumtarihi.Location = new System.Drawing.Point(162, 122);
            this.msk_hasta_dogumtarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hasta_dogumtarihi.Mask = "00/00/0000";
            this.msk_hasta_dogumtarihi.Name = "msk_hasta_dogumtarihi";
            this.msk_hasta_dogumtarihi.Size = new System.Drawing.Size(110, 23);
            this.msk_hasta_dogumtarihi.TabIndex = 14;
            this.msk_hasta_dogumtarihi.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_dogum_tarihi
            // 
            this.lbl_dogum_tarihi.AutoSize = true;
            this.lbl_dogum_tarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dogum_tarihi.Location = new System.Drawing.Point(68, 121);
            this.lbl_dogum_tarihi.Name = "lbl_dogum_tarihi";
            this.lbl_dogum_tarihi.Size = new System.Drawing.Size(84, 15);
            this.lbl_dogum_tarihi.TabIndex = 4;
            this.lbl_dogum_tarihi.Text = "Doğum Tarihi:";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_telefon.Location = new System.Drawing.Point(68, 149);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(71, 15);
            this.lbl_telefon.TabIndex = 7;
            this.lbl_telefon.Text = "Telefon No:";
            // 
            // msk_hasta_soyad
            // 
            this.msk_hasta_soyad.Location = new System.Drawing.Point(162, 91);
            this.msk_hasta_soyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hasta_soyad.Name = "msk_hasta_soyad";
            this.msk_hasta_soyad.Size = new System.Drawing.Size(110, 23);
            this.msk_hasta_soyad.TabIndex = 12;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdres.Location = new System.Drawing.Point(80, 249);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(42, 15);
            this.lblAdres.TabIndex = 8;
            this.lblAdres.Text = "Adres:";
            // 
            // msk_hasta_adi
            // 
            this.msk_hasta_adi.Location = new System.Drawing.Point(162, 62);
            this.msk_hasta_adi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hasta_adi.Name = "msk_hasta_adi";
            this.msk_hasta_adi.Size = new System.Drawing.Size(110, 23);
            this.msk_hasta_adi.TabIndex = 11;
            // 
            // lbl_medenidurum
            // 
            this.lbl_medenidurum.AutoSize = true;
            this.lbl_medenidurum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_medenidurum.Location = new System.Drawing.Point(68, 180);
            this.lbl_medenidurum.Name = "lbl_medenidurum";
            this.lbl_medenidurum.Size = new System.Drawing.Size(76, 15);
            this.lbl_medenidurum.TabIndex = 9;
            this.lbl_medenidurum.Text = "Medeni Hali:";
            // 
            // msk_hasta_tc
            // 
            this.msk_hasta_tc.Location = new System.Drawing.Point(162, 32);
            this.msk_hasta_tc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hasta_tc.Mask = "00000000000";
            this.msk_hasta_tc.Name = "msk_hasta_tc";
            this.msk_hasta_tc.Size = new System.Drawing.Size(110, 23);
            this.msk_hasta_tc.TabIndex = 10;
            this.msk_hasta_tc.ValidatingType = typeof(int);
            // 
            // Frm_HastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_HastaKayit";
            this.Text = "Frm_HastaKayit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btn_hastaEkle;
        private TextBox msk_hasta_Adres;
        private ComboBox msk_hasta_dgmYeri;
        private ComboBox msk_hasta_medenihal;
        private Label lbl_soyad;
        private MaskedTextBox msk_hasta_Telno;
        private Label lbl_tc;
        private Label lbl_Adi;
        private Label lbl_dgmYeri;
        private MaskedTextBox msk_hasta_dogumtarihi;
        private Label lbl_dogum_tarihi;
        private Label lbl_telefon;
        private MaskedTextBox msk_hasta_soyad;
        private Label lblAdres;
        private MaskedTextBox msk_hasta_adi;
        private Label lbl_medenidurum;
        private MaskedTextBox msk_hasta_tc;
    }
}