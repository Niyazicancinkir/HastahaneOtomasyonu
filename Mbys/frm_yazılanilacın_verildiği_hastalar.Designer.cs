namespace Mbys
{
    partial class frm_yazılanilacın_verildiği_hastalar
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
            this.dgv_ilaclistele = new System.Windows.Forms.DataGridView();
            this.txt_AranacakIlac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIlacAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ilaclistele)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ilaclistele
            // 
            this.dgv_ilaclistele.AllowUserToAddRows = false;
            this.dgv_ilaclistele.AllowUserToDeleteRows = false;
            this.dgv_ilaclistele.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ilaclistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ilaclistele.GridColor = System.Drawing.Color.Blue;
            this.dgv_ilaclistele.Location = new System.Drawing.Point(12, 336);
            this.dgv_ilaclistele.Name = "dgv_ilaclistele";
            this.dgv_ilaclistele.ReadOnly = true;
            this.dgv_ilaclistele.RowHeadersWidth = 51;
            this.dgv_ilaclistele.RowTemplate.Height = 29;
            this.dgv_ilaclistele.Size = new System.Drawing.Size(1048, 230);
            this.dgv_ilaclistele.TabIndex = 0;
            // 
            // txt_AranacakIlac
            // 
            this.txt_AranacakIlac.Location = new System.Drawing.Point(26, 111);
            this.txt_AranacakIlac.Name = "txt_AranacakIlac";
            this.txt_AranacakIlac.Size = new System.Drawing.Size(184, 27);
            this.txt_AranacakIlac.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(139, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "İlacın Verilidiği Hastalar";
            // 
            // btnIlacAra
            // 
            this.btnIlacAra.Location = new System.Drawing.Point(51, 165);
            this.btnIlacAra.Name = "btnIlacAra";
            this.btnIlacAra.Size = new System.Drawing.Size(94, 29);
            this.btnIlacAra.TabIndex = 3;
            this.btnIlacAra.Text = "Sorgula";
            this.btnIlacAra.UseVisualStyleBackColor = true;
            this.btnIlacAra.Click += new System.EventHandler(this.btnIlacAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "İlaç Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnIlacAra);
            this.groupBox1.Controls.Add(this.txt_AranacakIlac);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 218);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlaç Sorgulama";
            // 
            // frm_yazılanilacın_verildiği_hastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 597);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ilaclistele);
            this.Name = "frm_yazılanilacın_verildiği_hastalar";
            this.Text = "frm_yazılanilacın_verildiği_hastalar";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ilaclistele)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_ilaclistele;
        private TextBox txt_AranacakIlac;
        private Label label1;
        private Button btnIlacAra;
        private Label label2;
        private GroupBox groupBox1;
    }
}