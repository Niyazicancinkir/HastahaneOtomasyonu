namespace Mbys
{
    partial class Frm_IlacKayit
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupbox_ilackayit = new System.Windows.Forms.GroupBox();
            this.btn_IlacEkle = new System.Windows.Forms.Button();
            this.msk_ilac_tipi = new System.Windows.Forms.ComboBox();
            this.lbl_tipi = new System.Windows.Forms.Label();
            this.lbl_barkodno = new System.Windows.Forms.Label();
            this.lbl_Adi = new System.Windows.Forms.Label();
            this.msk_IlacAdi = new System.Windows.Forms.MaskedTextBox();
            this.msk_ilac_barkodNo = new System.Windows.Forms.MaskedTextBox();
            this.groupbox_ilackayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(240, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 37);
            this.label2.TabIndex = 37;
            this.label2.Text = "İlac Kayıt Bilgileri";
            // 
            // groupbox_ilackayit
            // 
            this.groupbox_ilackayit.Controls.Add(this.btn_IlacEkle);
            this.groupbox_ilackayit.Controls.Add(this.msk_ilac_tipi);
            this.groupbox_ilackayit.Controls.Add(this.lbl_tipi);
            this.groupbox_ilackayit.Controls.Add(this.lbl_barkodno);
            this.groupbox_ilackayit.Controls.Add(this.lbl_Adi);
            this.groupbox_ilackayit.Controls.Add(this.msk_IlacAdi);
            this.groupbox_ilackayit.Controls.Add(this.msk_ilac_barkodNo);
            this.groupbox_ilackayit.Location = new System.Drawing.Point(211, 183);
            this.groupbox_ilackayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox_ilackayit.Name = "groupbox_ilackayit";
            this.groupbox_ilackayit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox_ilackayit.Size = new System.Drawing.Size(309, 157);
            this.groupbox_ilackayit.TabIndex = 36;
            this.groupbox_ilackayit.TabStop = false;
            this.groupbox_ilackayit.Text = "İlac Kayıt";
            // 
            // btn_IlacEkle
            // 
            this.btn_IlacEkle.Location = new System.Drawing.Point(162, 122);
            this.btn_IlacEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_IlacEkle.Name = "btn_IlacEkle";
            this.btn_IlacEkle.Size = new System.Drawing.Size(82, 22);
            this.btn_IlacEkle.TabIndex = 37;
            this.btn_IlacEkle.Text = "Ekle";
            this.btn_IlacEkle.UseVisualStyleBackColor = true;
            this.btn_IlacEkle.Click += new System.EventHandler(this.btn_IlacEkle_Click);
            // 
            // msk_ilac_tipi
            // 
            this.msk_ilac_tipi.FormattingEnabled = true;
            this.msk_ilac_tipi.Items.AddRange(new object[] {
            "Ampul",
            "Draje",
            "Şurup ",
            "Tablet",
            "Belirtilmemiş"});
            this.msk_ilac_tipi.Location = new System.Drawing.Point(162, 91);
            this.msk_ilac_tipi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_ilac_tipi.Name = "msk_ilac_tipi";
            this.msk_ilac_tipi.Size = new System.Drawing.Size(110, 23);
            this.msk_ilac_tipi.TabIndex = 36;
            // 
            // lbl_tipi
            // 
            this.lbl_tipi.AutoSize = true;
            this.lbl_tipi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tipi.Location = new System.Drawing.Point(68, 90);
            this.lbl_tipi.Name = "lbl_tipi";
            this.lbl_tipi.Size = new System.Drawing.Size(30, 15);
            this.lbl_tipi.TabIndex = 2;
            this.lbl_tipi.Text = "Tipi:";
            // 
            // lbl_barkodno
            // 
            this.lbl_barkodno.AutoSize = true;
            this.lbl_barkodno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_barkodno.Location = new System.Drawing.Point(68, 31);
            this.lbl_barkodno.Name = "lbl_barkodno";
            this.lbl_barkodno.Size = new System.Drawing.Size(69, 15);
            this.lbl_barkodno.TabIndex = 0;
            this.lbl_barkodno.Text = "Barkod No:";
            // 
            // lbl_Adi
            // 
            this.lbl_Adi.AutoSize = true;
            this.lbl_Adi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Adi.Location = new System.Drawing.Point(68, 61);
            this.lbl_Adi.Name = "lbl_Adi";
            this.lbl_Adi.Size = new System.Drawing.Size(25, 15);
            this.lbl_Adi.TabIndex = 1;
            this.lbl_Adi.Text = "Ad:";
            // 
            // msk_IlacAdi
            // 
            this.msk_IlacAdi.Location = new System.Drawing.Point(162, 62);
            this.msk_IlacAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_IlacAdi.Name = "msk_IlacAdi";
            this.msk_IlacAdi.Size = new System.Drawing.Size(110, 23);
            this.msk_IlacAdi.TabIndex = 11;
            // 
            // msk_ilac_barkodNo
            // 
            this.msk_ilac_barkodNo.Location = new System.Drawing.Point(162, 32);
            this.msk_ilac_barkodNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_ilac_barkodNo.Mask = "00000000000";
            this.msk_ilac_barkodNo.Name = "msk_ilac_barkodNo";
            this.msk_ilac_barkodNo.Size = new System.Drawing.Size(110, 23);
            this.msk_ilac_barkodNo.TabIndex = 10;
            this.msk_ilac_barkodNo.ValidatingType = typeof(int);
            // 
            // Frm_IlacKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupbox_ilackayit);
            this.Name = "Frm_IlacKayit";
            this.Text = "Frm_IlacKayit";
            this.groupbox_ilackayit.ResumeLayout(false);
            this.groupbox_ilackayit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private GroupBox groupbox_ilackayit;
        private Button btn_IlacEkle;
        private ComboBox msk_ilac_tipi;
        private Label lbl_tipi;
        private Label lbl_barkodno;
        private Label lbl_Adi;
        private MaskedTextBox msk_IlacAdi;
        private MaskedTextBox msk_ilac_barkodNo;
    }
}