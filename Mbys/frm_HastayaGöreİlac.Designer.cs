namespace Mbys
{
    partial class frm_HastayaGöreİlac
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
            this.txt_ReceteNo = new System.Windows.Forms.TextBox();
            this.btn_sorgula = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc No Giriniz:";
            // 
            // txt_ReceteNo
            // 
            this.txt_ReceteNo.Location = new System.Drawing.Point(212, 32);
            this.txt_ReceteNo.Name = "txt_ReceteNo";
            this.txt_ReceteNo.Size = new System.Drawing.Size(125, 27);
            this.txt_ReceteNo.TabIndex = 1;
            // 
            // btn_sorgula
            // 
            this.btn_sorgula.Location = new System.Drawing.Point(369, 35);
            this.btn_sorgula.Name = "btn_sorgula";
            this.btn_sorgula.Size = new System.Drawing.Size(94, 29);
            this.btn_sorgula.TabIndex = 2;
            this.btn_sorgula.Text = "Sorgu";
            this.btn_sorgula.UseVisualStyleBackColor = true;
            this.btn_sorgula.Click += new System.EventHandler(this.btn_sorgula_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(572, 188);
            this.dataGridView1.TabIndex = 3;
            // 
            // frm_HastayaGöreİlac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_sorgula);
            this.Controls.Add(this.txt_ReceteNo);
            this.Controls.Add(this.label1);
            this.Name = "frm_HastayaGöreİlac";
            this.Text = "frm_HastayaGöreİlac";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_ReceteNo;
        private Button btn_sorgula;
        private DataGridView dataGridView1;
    }
}