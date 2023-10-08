namespace Mbys
{
    partial class Bilgi_Görüntüleme
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
            this.dgv_recetegoster = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recetegoster)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_recetegoster
            // 
            this.dgv_recetegoster.AllowUserToAddRows = false;
            this.dgv_recetegoster.AllowUserToDeleteRows = false;
            this.dgv_recetegoster.BackgroundColor = System.Drawing.Color.White;
            this.dgv_recetegoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_recetegoster.GridColor = System.Drawing.Color.Blue;
            this.dgv_recetegoster.Location = new System.Drawing.Point(36, 112);
            this.dgv_recetegoster.Name = "dgv_recetegoster";
            this.dgv_recetegoster.ReadOnly = true;
            this.dgv_recetegoster.RowHeadersWidth = 51;
            this.dgv_recetegoster.RowTemplate.Height = 29;
            this.dgv_recetegoster.Size = new System.Drawing.Size(1283, 316);
            this.dgv_recetegoster.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(414, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarih Sıralı Reçete ";
            // 
            // Bilgi_Görüntüleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_recetegoster);
            this.Name = "Bilgi_Görüntüleme";
            this.Text = "Bilgi_Görüntüleme";
            this.Load += new System.EventHandler(this.Bilgi_Görüntüleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recetegoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_recetegoster;
        private Label label1;
    }
}