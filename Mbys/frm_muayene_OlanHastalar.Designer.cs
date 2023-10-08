namespace Mbys
{
    partial class frm_muayene_OlanHastalar
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
            this.dgv_muayenelistele = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muayenelistele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_muayenelistele
            // 
            this.dgv_muayenelistele.AllowUserToAddRows = false;
            this.dgv_muayenelistele.AllowUserToDeleteRows = false;
            this.dgv_muayenelistele.BackgroundColor = System.Drawing.Color.White;
            this.dgv_muayenelistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muayenelistele.Location = new System.Drawing.Point(37, 139);
            this.dgv_muayenelistele.Name = "dgv_muayenelistele";
            this.dgv_muayenelistele.ReadOnly = true;
            this.dgv_muayenelistele.RowHeadersWidth = 51;
            this.dgv_muayenelistele.RowTemplate.Height = 29;
            this.dgv_muayenelistele.Size = new System.Drawing.Size(973, 201);
            this.dgv_muayenelistele.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(125, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Muayene Olan Hastalar";
            // 
            // frm_muayene_OlanHastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_muayenelistele);
            this.Name = "frm_muayene_OlanHastalar";
            this.Text = "frm_muayene_OlanHastalar";
            this.Load += new System.EventHandler(this.frm_muayene_OlanHastalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muayenelistele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_muayenelistele;
        private Label label1;
    }
}