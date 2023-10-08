namespace Mbys
{
    partial class frm_mainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mainPage));
            this.btn_IlacKaydet = new System.Windows.Forms.Button();
            this.btn_MuayeneKaydet = new System.Windows.Forms.Button();
            this.btn_HastaKaydet = new System.Windows.Forms.Button();
            this.btn_bilgi_goruntule = new System.Windows.Forms.Button();
            this.btn_ilacverilenhasta = new System.Windows.Forms.Button();
            this.btn_muayene = new System.Windows.Forms.Button();
            this.btn_hastabilgigoster = new System.Windows.Forms.Button();
            this.gb_eczacı = new System.Windows.Forms.GroupBox();
            this.gb_Doctor = new System.Windows.Forms.GroupBox();
            this.pgEczacı = new System.Windows.Forms.PictureBox();
            this.gb_sekreter = new System.Windows.Forms.GroupBox();
            this.btn_hastayaverilenilac = new System.Windows.Forms.Button();
            this.lblyazı = new System.Windows.Forms.Label();
            this.lblsecim = new System.Windows.Forms.Label();
            this.rb_sekreter = new System.Windows.Forms.RadioButton();
            this.rb_eczacı = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rb_doktor = new System.Windows.Forms.RadioButton();
            this.pb_hastaoto = new System.Windows.Forms.PictureBox();
            this.pgDoctor = new System.Windows.Forms.PictureBox();
            this.pgSekreter = new System.Windows.Forms.PictureBox();
            this.gb_eczacı.SuspendLayout();
            this.gb_Doctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgEczacı)).BeginInit();
            this.gb_sekreter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hastaoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgSekreter)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_IlacKaydet
            // 
            this.btn_IlacKaydet.Location = new System.Drawing.Point(6, 50);
            this.btn_IlacKaydet.Name = "btn_IlacKaydet";
            this.btn_IlacKaydet.Size = new System.Drawing.Size(146, 32);
            this.btn_IlacKaydet.TabIndex = 6;
            this.btn_IlacKaydet.Text = "İlaç Kaydet";
            this.btn_IlacKaydet.UseVisualStyleBackColor = true;
            this.btn_IlacKaydet.Click += new System.EventHandler(this.btn_IlacKaydet_Click);
            // 
            // btn_MuayeneKaydet
            // 
            this.btn_MuayeneKaydet.Location = new System.Drawing.Point(31, 56);
            this.btn_MuayeneKaydet.Name = "btn_MuayeneKaydet";
            this.btn_MuayeneKaydet.Size = new System.Drawing.Size(130, 29);
            this.btn_MuayeneKaydet.TabIndex = 5;
            this.btn_MuayeneKaydet.Text = "Muayene Oluştur";
            this.btn_MuayeneKaydet.UseVisualStyleBackColor = true;
            this.btn_MuayeneKaydet.Click += new System.EventHandler(this.btn_MuayeneKaydet_Click);
            // 
            // btn_HastaKaydet
            // 
            this.btn_HastaKaydet.Location = new System.Drawing.Point(40, 69);
            this.btn_HastaKaydet.Name = "btn_HastaKaydet";
            this.btn_HastaKaydet.Size = new System.Drawing.Size(130, 29);
            this.btn_HastaKaydet.TabIndex = 4;
            this.btn_HastaKaydet.Text = "Hasta Kaydet";
            this.btn_HastaKaydet.UseVisualStyleBackColor = true;
            this.btn_HastaKaydet.Click += new System.EventHandler(this.btn_HastaKaydet_Click);
            // 
            // btn_bilgi_goruntule
            // 
            this.btn_bilgi_goruntule.Location = new System.Drawing.Point(38, 534);
            this.btn_bilgi_goruntule.Name = "btn_bilgi_goruntule";
            this.btn_bilgi_goruntule.Size = new System.Drawing.Size(163, 39);
            this.btn_bilgi_goruntule.TabIndex = 8;
            this.btn_bilgi_goruntule.Text = "Yazılan Reçeteleri Göster";
            this.btn_bilgi_goruntule.UseVisualStyleBackColor = true;
            this.btn_bilgi_goruntule.Visible = false;
            this.btn_bilgi_goruntule.Click += new System.EventHandler(this.btn_bilgi_goruntule_Click);
            // 
            // btn_ilacverilenhasta
            // 
            this.btn_ilacverilenhasta.Location = new System.Drawing.Point(551, 533);
            this.btn_ilacverilenhasta.Name = "btn_ilacverilenhasta";
            this.btn_ilacverilenhasta.Size = new System.Drawing.Size(251, 39);
            this.btn_ilacverilenhasta.TabIndex = 9;
            this.btn_ilacverilenhasta.Text = "Yazılan İlacın Verildiği Hastalar";
            this.btn_ilacverilenhasta.UseVisualStyleBackColor = true;
            this.btn_ilacverilenhasta.Visible = false;
            this.btn_ilacverilenhasta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_muayene
            // 
            this.btn_muayene.Location = new System.Drawing.Point(207, 534);
            this.btn_muayene.Name = "btn_muayene";
            this.btn_muayene.Size = new System.Drawing.Size(168, 39);
            this.btn_muayene.TabIndex = 10;
            this.btn_muayene.Text = "Muayeneleri Göster";
            this.btn_muayene.UseVisualStyleBackColor = true;
            this.btn_muayene.Visible = false;
            this.btn_muayene.Click += new System.EventHandler(this.btn_muayene_Click);
            // 
            // btn_hastabilgigoster
            // 
            this.btn_hastabilgigoster.Location = new System.Drawing.Point(381, 533);
            this.btn_hastabilgigoster.Name = "btn_hastabilgigoster";
            this.btn_hastabilgigoster.Size = new System.Drawing.Size(164, 41);
            this.btn_hastabilgigoster.TabIndex = 11;
            this.btn_hastabilgigoster.Text = "Hasta Bilgi Göster";
            this.btn_hastabilgigoster.UseVisualStyleBackColor = true;
            this.btn_hastabilgigoster.Visible = false;
            this.btn_hastabilgigoster.Click += new System.EventHandler(this.button2_Click);
            // 
            // gb_eczacı
            // 
            this.gb_eczacı.Controls.Add(this.btn_IlacKaydet);
            this.gb_eczacı.Location = new System.Drawing.Point(288, 56);
            this.gb_eczacı.Name = "gb_eczacı";
            this.gb_eczacı.Size = new System.Drawing.Size(272, 111);
            this.gb_eczacı.TabIndex = 12;
            this.gb_eczacı.TabStop = false;
            this.gb_eczacı.Text = "İlaç Kaydetme Menüsü";
            this.gb_eczacı.Visible = false;
            // 
            // gb_Doctor
            // 
            this.gb_Doctor.Controls.Add(this.btn_MuayeneKaydet);
            this.gb_Doctor.Location = new System.Drawing.Point(288, 56);
            this.gb_Doctor.Name = "gb_Doctor";
            this.gb_Doctor.Size = new System.Drawing.Size(259, 125);
            this.gb_Doctor.TabIndex = 13;
            this.gb_Doctor.TabStop = false;
            this.gb_Doctor.Text = "Muayene Oluşturma Menüsü";
            this.gb_Doctor.Visible = false;
            // 
            // pgEczacı
            // 
            this.pgEczacı.Image = ((System.Drawing.Image)(resources.GetObject("pgEczacı.Image")));
            this.pgEczacı.Location = new System.Drawing.Point(256, 187);
            this.pgEczacı.Name = "pgEczacı";
            this.pgEczacı.Size = new System.Drawing.Size(300, 198);
            this.pgEczacı.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pgEczacı.TabIndex = 24;
            this.pgEczacı.TabStop = false;
            this.pgEczacı.Visible = false;
            // 
            // gb_sekreter
            // 
            this.gb_sekreter.Controls.Add(this.btn_HastaKaydet);
            this.gb_sekreter.Location = new System.Drawing.Point(288, 56);
            this.gb_sekreter.Name = "gb_sekreter";
            this.gb_sekreter.Size = new System.Drawing.Size(260, 110);
            this.gb_sekreter.TabIndex = 14;
            this.gb_sekreter.TabStop = false;
            this.gb_sekreter.Text = "Hasta Eklemem Menüsü";
            this.gb_sekreter.Visible = false;
            // 
            // btn_hastayaverilenilac
            // 
            this.btn_hastayaverilenilac.Location = new System.Drawing.Point(283, 593);
            this.btn_hastayaverilenilac.Name = "btn_hastayaverilenilac";
            this.btn_hastayaverilenilac.Size = new System.Drawing.Size(251, 39);
            this.btn_hastayaverilenilac.TabIndex = 15;
            this.btn_hastayaverilenilac.Text = "Hastaya Verilen İlaçlar";
            this.btn_hastayaverilenilac.UseVisualStyleBackColor = true;
            this.btn_hastayaverilenilac.Visible = false;
            this.btn_hastayaverilenilac.Click += new System.EventHandler(this.btn_hastayaverilenilac_Click);
            // 
            // lblyazı
            // 
            this.lblyazı.AutoSize = true;
            this.lblyazı.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblyazı.Location = new System.Drawing.Point(227, 308);
            this.lblyazı.Name = "lblyazı";
            this.lblyazı.Size = new System.Drawing.Size(407, 46);
            this.lblyazı.TabIndex = 16;
            this.lblyazı.Text = "Hasta Otomasyonu v1.0.0 ";
            // 
            // lblsecim
            // 
            this.lblsecim.AutoSize = true;
            this.lblsecim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblsecim.Location = new System.Drawing.Point(337, 399);
            this.lblsecim.Name = "lblsecim";
            this.lblsecim.Size = new System.Drawing.Size(170, 23);
            this.lblsecim.TabIndex = 17;
            this.lblsecim.Text = "Lütfen Seçim Yapınız.";
            // 
            // rb_sekreter
            // 
            this.rb_sekreter.AutoSize = true;
            this.rb_sekreter.Location = new System.Drawing.Point(217, 50);
            this.rb_sekreter.Name = "rb_sekreter";
            this.rb_sekreter.Size = new System.Drawing.Size(84, 24);
            this.rb_sekreter.TabIndex = 19;
            this.rb_sekreter.Text = "Sekreter";
            this.rb_sekreter.UseVisualStyleBackColor = true;
            this.rb_sekreter.CheckedChanged += new System.EventHandler(this.checkissekreter);
            // 
            // rb_eczacı
            // 
            this.rb_eczacı.AutoSize = true;
            this.rb_eczacı.Location = new System.Drawing.Point(307, 50);
            this.rb_eczacı.Name = "rb_eczacı";
            this.rb_eczacı.Size = new System.Drawing.Size(71, 24);
            this.rb_eczacı.TabIndex = 20;
            this.rb_eczacı.Text = "Eczacı";
            this.rb_eczacı.UseVisualStyleBackColor = true;
            this.rb_eczacı.CheckedChanged += new System.EventHandler(this.checkiseczacı);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rb_doktor);
            this.groupBox1.Controls.Add(this.rb_eczacı);
            this.groupBox1.Controls.Add(this.rb_sekreter);
            this.groupBox1.Location = new System.Drawing.Point(227, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 102);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Seçin";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(39, 50);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 24);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Seçiniz";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.checkisseciniz);
            // 
            // rb_doktor
            // 
            this.rb_doktor.AutoSize = true;
            this.rb_doktor.Location = new System.Drawing.Point(135, 50);
            this.rb_doktor.Name = "rb_doktor";
            this.rb_doktor.Size = new System.Drawing.Size(76, 24);
            this.rb_doktor.TabIndex = 21;
            this.rb_doktor.Text = "Doktor";
            this.rb_doktor.UseVisualStyleBackColor = true;
            this.rb_doktor.CheckedChanged += new System.EventHandler(this.checkisdoctor);
            // 
            // pb_hastaoto
            // 
            this.pb_hastaoto.Image = ((System.Drawing.Image)(resources.GetObject("pb_hastaoto.Image")));
            this.pb_hastaoto.Location = new System.Drawing.Point(256, 12);
            this.pb_hastaoto.Name = "pb_hastaoto";
            this.pb_hastaoto.Size = new System.Drawing.Size(359, 293);
            this.pb_hastaoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_hastaoto.TabIndex = 22;
            this.pb_hastaoto.TabStop = false;
            // 
            // pgDoctor
            // 
            this.pgDoctor.Image = ((System.Drawing.Image)(resources.GetObject("pgDoctor.Image")));
            this.pgDoctor.Location = new System.Drawing.Point(256, 187);
            this.pgDoctor.Name = "pgDoctor";
            this.pgDoctor.Size = new System.Drawing.Size(300, 198);
            this.pgDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pgDoctor.TabIndex = 23;
            this.pgDoctor.TabStop = false;
            this.pgDoctor.Visible = false;
            // 
            // pgSekreter
            // 
            this.pgSekreter.Image = ((System.Drawing.Image)(resources.GetObject("pgSekreter.Image")));
            this.pgSekreter.Location = new System.Drawing.Point(256, 187);
            this.pgSekreter.Name = "pgSekreter";
            this.pgSekreter.Size = new System.Drawing.Size(300, 198);
            this.pgSekreter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pgSekreter.TabIndex = 25;
            this.pgSekreter.TabStop = false;
            this.pgSekreter.Visible = false;
            // 
            // frm_mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 661);
            this.Controls.Add(this.pgSekreter);
            this.Controls.Add(this.pgDoctor);
            this.Controls.Add(this.pb_hastaoto);
            this.Controls.Add(this.pgEczacı);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_sekreter);
            this.Controls.Add(this.gb_eczacı);
            this.Controls.Add(this.lblsecim);
            this.Controls.Add(this.lblyazı);
            this.Controls.Add(this.btn_hastayaverilenilac);
            this.Controls.Add(this.gb_Doctor);
            this.Controls.Add(this.btn_hastabilgigoster);
            this.Controls.Add(this.btn_muayene);
            this.Controls.Add(this.btn_ilacverilenhasta);
            this.Controls.Add(this.btn_bilgi_goruntule);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_mainPage";
            this.Text = "MainPage";
            this.gb_eczacı.ResumeLayout(false);
            this.gb_Doctor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pgEczacı)).EndInit();
            this.gb_sekreter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hastaoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgSekreter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_IlacKaydet;
        private Button btn_MuayeneKaydet;
        private Button btn_HastaKaydet;
        private Button btn_bilgi_goruntule;
        private Button btn_ilacverilenhasta;
        private Button btn_muayene;
        private Button btn_hastabilgigoster;
        private GroupBox gb_eczacı;
        private GroupBox gb_Doctor;
        private GroupBox gb_sekreter;
        private Button btn_hastayaverilenilac;
        private Label lblyazı;
        private Label lblsecim;
        private RadioButton rb_sekreter;
        private RadioButton rb_eczacı;
        private GroupBox groupBox1;
        private RadioButton rb_doktor;
        private RadioButton radioButton1;
        private PictureBox pb_hastaoto;
        private PictureBox pgEczacı;
        private PictureBox pgDoctor;
        private PictureBox pgSekreter;
    }
}