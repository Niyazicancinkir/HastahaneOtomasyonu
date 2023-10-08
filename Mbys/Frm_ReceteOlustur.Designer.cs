namespace Mbys
{
    partial class Frm_ReceteOlustur
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lbl_rceteNO = new System.Windows.Forms.Label();
            this.msk_Receteno = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_IlacAdet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_IlacTipi = new System.Windows.Forms.ComboBox();
            this.msk_IlacAdi = new System.Windows.Forms.MaskedTextBox();
            this.lbl_tipi = new System.Windows.Forms.Label();
            this.lbl_warn = new System.Windows.Forms.Label();
            this.msk_ReceteTani = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Tani = new System.Windows.Forms.Label();
            this.lbl_muayaneTarihi = new System.Windows.Forms.Label();
            this.msk_ReceteMuayaneTarihi = new System.Windows.Forms.MaskedTextBox();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.msk_ReceteTc = new System.Windows.Forms.MaskedTextBox();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_Adi = new System.Windows.Forms.Label();
            this.msk_ReceteSoyad = new System.Windows.Forms.MaskedTextBox();
            this.msk_ReceteAdi = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(474, 232);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(176, 128);
            this.listView1.TabIndex = 58;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 130;
            // 
            // lbl_rceteNO
            // 
            this.lbl_rceteNO.AutoSize = true;
            this.lbl_rceteNO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_rceteNO.Location = new System.Drawing.Point(357, 170);
            this.lbl_rceteNO.Name = "lbl_rceteNO";
            this.lbl_rceteNO.Size = new System.Drawing.Size(69, 15);
            this.lbl_rceteNO.TabIndex = 57;
            this.lbl_rceteNO.Text = "Reçete No:";
            // 
            // msk_Receteno
            // 
            this.msk_Receteno.Location = new System.Drawing.Point(474, 167);
            this.msk_Receteno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_Receteno.Name = "msk_Receteno";
            this.msk_Receteno.ReadOnly = true;
            this.msk_Receteno.Size = new System.Drawing.Size(114, 23);
            this.msk_Receteno.TabIndex = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_IlacAdet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_IlacTipi);
            this.groupBox1.Controls.Add(this.msk_IlacAdi);
            this.groupBox1.Controls.Add(this.lbl_tipi);
            this.groupBox1.Controls.Add(this.lbl_warn);
            this.groupBox1.Location = new System.Drawing.Point(151, 221);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(280, 137);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlaçlar";
            // 
            // cmb_IlacAdet
            // 
            this.cmb_IlacAdet.FormattingEnabled = true;
            this.cmb_IlacAdet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "Belirtilmemiş"});
            this.cmb_IlacAdet.Location = new System.Drawing.Point(110, 88);
            this.cmb_IlacAdet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_IlacAdet.Name = "cmb_IlacAdet";
            this.cmb_IlacAdet.Size = new System.Drawing.Size(110, 23);
            this.cmb_IlacAdet.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "Adet";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 41;
            this.button1.Text = "İlaç Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ad:";
            // 
            // cmb_IlacTipi
            // 
            this.cmb_IlacTipi.FormattingEnabled = true;
            this.cmb_IlacTipi.Items.AddRange(new object[] {
            "Ampul",
            "Draje",
            "Şurup ",
            "Tablet",
            "Belirtilmemiş"});
            this.cmb_IlacTipi.Location = new System.Drawing.Point(110, 63);
            this.cmb_IlacTipi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_IlacTipi.Name = "cmb_IlacTipi";
            this.cmb_IlacTipi.Size = new System.Drawing.Size(110, 23);
            this.cmb_IlacTipi.TabIndex = 40;
            // 
            // msk_IlacAdi
            // 
            this.msk_IlacAdi.Location = new System.Drawing.Point(110, 34);
            this.msk_IlacAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_IlacAdi.Name = "msk_IlacAdi";
            this.msk_IlacAdi.Size = new System.Drawing.Size(110, 23);
            this.msk_IlacAdi.TabIndex = 39;
            // 
            // lbl_tipi
            // 
            this.lbl_tipi.AutoSize = true;
            this.lbl_tipi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tipi.Location = new System.Drawing.Point(17, 62);
            this.lbl_tipi.Name = "lbl_tipi";
            this.lbl_tipi.Size = new System.Drawing.Size(30, 15);
            this.lbl_tipi.TabIndex = 38;
            this.lbl_tipi.Text = "Tipi:";
            // 
            // lbl_warn
            // 
            this.lbl_warn.AutoSize = true;
            this.lbl_warn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_warn.Location = new System.Drawing.Point(85, 110);
            this.lbl_warn.Name = "lbl_warn";
            this.lbl_warn.Size = new System.Drawing.Size(146, 15);
            this.lbl_warn.TabIndex = 45;
            this.lbl_warn.Text = "5\'ten fazla ilaç yazılamaz.";
            this.lbl_warn.Visible = false;
            // 
            // msk_ReceteTani
            // 
            this.msk_ReceteTani.Location = new System.Drawing.Point(193, 168);
            this.msk_ReceteTani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_ReceteTani.Name = "msk_ReceteTani";
            this.msk_ReceteTani.ReadOnly = true;
            this.msk_ReceteTani.Size = new System.Drawing.Size(148, 23);
            this.msk_ReceteTani.TabIndex = 54;
            // 
            // lbl_Tani
            // 
            this.lbl_Tani.AutoSize = true;
            this.lbl_Tani.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tani.Location = new System.Drawing.Point(151, 170);
            this.lbl_Tani.Name = "lbl_Tani";
            this.lbl_Tani.Size = new System.Drawing.Size(32, 15);
            this.lbl_Tani.TabIndex = 53;
            this.lbl_Tani.Text = "Tanı:";
            // 
            // lbl_muayaneTarihi
            // 
            this.lbl_muayaneTarihi.AutoSize = true;
            this.lbl_muayaneTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_muayaneTarihi.Location = new System.Drawing.Point(357, 127);
            this.lbl_muayaneTarihi.Name = "lbl_muayaneTarihi";
            this.lbl_muayaneTarihi.Size = new System.Drawing.Size(93, 15);
            this.lbl_muayaneTarihi.TabIndex = 51;
            this.lbl_muayaneTarihi.Text = "Muayane Tarihi:";
            // 
            // msk_ReceteMuayaneTarihi
            // 
            this.msk_ReceteMuayaneTarihi.Location = new System.Drawing.Point(474, 129);
            this.msk_ReceteMuayaneTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_ReceteMuayaneTarihi.Name = "msk_ReceteMuayaneTarihi";
            this.msk_ReceteMuayaneTarihi.ReadOnly = true;
            this.msk_ReceteMuayaneTarihi.Size = new System.Drawing.Size(148, 23);
            this.msk_ReceteMuayaneTarihi.TabIndex = 52;
            this.msk_ReceteMuayaneTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tc.Location = new System.Drawing.Point(151, 124);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(22, 15);
            this.lbl_tc.TabIndex = 49;
            this.lbl_tc.Text = "Tc:";
            // 
            // msk_ReceteTc
            // 
            this.msk_ReceteTc.Location = new System.Drawing.Point(193, 121);
            this.msk_ReceteTc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_ReceteTc.Mask = "00000000000";
            this.msk_ReceteTc.Name = "msk_ReceteTc";
            this.msk_ReceteTc.ReadOnly = true;
            this.msk_ReceteTc.Size = new System.Drawing.Size(110, 23);
            this.msk_ReceteTc.TabIndex = 50;
            this.msk_ReceteTc.ValidatingType = typeof(int);
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_soyad.Location = new System.Drawing.Point(357, 99);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(46, 15);
            this.lbl_soyad.TabIndex = 46;
            this.lbl_soyad.Text = "Soyadı:";
            // 
            // lbl_Adi
            // 
            this.lbl_Adi.AutoSize = true;
            this.lbl_Adi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Adi.Location = new System.Drawing.Point(151, 94);
            this.lbl_Adi.Name = "lbl_Adi";
            this.lbl_Adi.Size = new System.Drawing.Size(28, 15);
            this.lbl_Adi.TabIndex = 45;
            this.lbl_Adi.Text = "Adı:";
            // 
            // msk_ReceteSoyad
            // 
            this.msk_ReceteSoyad.Location = new System.Drawing.Point(474, 99);
            this.msk_ReceteSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_ReceteSoyad.Name = "msk_ReceteSoyad";
            this.msk_ReceteSoyad.ReadOnly = true;
            this.msk_ReceteSoyad.Size = new System.Drawing.Size(110, 23);
            this.msk_ReceteSoyad.TabIndex = 48;
            // 
            // msk_ReceteAdi
            // 
            this.msk_ReceteAdi.Location = new System.Drawing.Point(193, 91);
            this.msk_ReceteAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_ReceteAdi.Name = "msk_ReceteAdi";
            this.msk_ReceteAdi.ReadOnly = true;
            this.msk_ReceteAdi.Size = new System.Drawing.Size(110, 23);
            this.msk_ReceteAdi.TabIndex = 47;
            // 
            // Frm_ReceteOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl_rceteNO);
            this.Controls.Add(this.msk_Receteno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.msk_ReceteTani);
            this.Controls.Add(this.lbl_Tani);
            this.Controls.Add(this.lbl_muayaneTarihi);
            this.Controls.Add(this.msk_ReceteMuayaneTarihi);
            this.Controls.Add(this.lbl_tc);
            this.Controls.Add(this.msk_ReceteTc);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_Adi);
            this.Controls.Add(this.msk_ReceteSoyad);
            this.Controls.Add(this.msk_ReceteAdi);
            this.Name = "Frm_ReceteOlustur";
            this.Text = "Frm_ReceteOlustur";
            this.Load += new System.EventHandler(this.Frm_ReceteOlustur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        public Label lbl_rceteNO;
        public MaskedTextBox msk_Receteno;
        public GroupBox groupBox1;
        private ComboBox cmb_IlacAdet;
        private Label label2;
        private Button button1;
        private Label label1;
        private ComboBox cmb_IlacTipi;
        public MaskedTextBox msk_IlacAdi;
        private Label lbl_tipi;
        private Label lbl_warn;
        public MaskedTextBox msk_ReceteTani;
        public Label lbl_Tani;
        public Label lbl_muayaneTarihi;
        public MaskedTextBox msk_ReceteMuayaneTarihi;
        public Label lbl_tc;
        public MaskedTextBox msk_ReceteTc;
        public Label lbl_soyad;
        public Label lbl_Adi;
        public MaskedTextBox msk_ReceteSoyad;
        public MaskedTextBox msk_ReceteAdi;
    }
}