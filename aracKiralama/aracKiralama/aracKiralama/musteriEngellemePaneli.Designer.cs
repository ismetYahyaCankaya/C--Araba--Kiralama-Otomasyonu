namespace aracKiralama
{
    partial class musteriEngellemePaneli
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
            this.musterilerDGV = new System.Windows.Forms.DataGridView();
            this.engelleButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // musterilerDGV
            // 
            this.musterilerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musterilerDGV.Location = new System.Drawing.Point(28, 60);
            this.musterilerDGV.Name = "musterilerDGV";
            this.musterilerDGV.Size = new System.Drawing.Size(533, 148);
            this.musterilerDGV.TabIndex = 0;
            this.musterilerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musterilerDGV_CellContentClick);
            // 
            // engelleButon
            // 
            this.engelleButon.Location = new System.Drawing.Point(244, 224);
            this.engelleButon.Name = "engelleButon";
            this.engelleButon.Size = new System.Drawing.Size(108, 33);
            this.engelleButon.TabIndex = 1;
            this.engelleButon.Text = "Engelle";
            this.engelleButon.UseVisualStyleBackColor = true;
            this.engelleButon.Click += new System.EventHandler(this.engelleButon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(173, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Engellenecek Müşteriyi Seçin";
            // 
            // menuButon
            // 
            this.menuButon.Location = new System.Drawing.Point(451, 223);
            this.menuButon.Name = "menuButon";
            this.menuButon.Size = new System.Drawing.Size(90, 34);
            this.menuButon.TabIndex = 4;
            this.menuButon.Text = "Menü";
            this.menuButon.UseVisualStyleBackColor = true;
            this.menuButon.Click += new System.EventHandler(this.menuButon_Click);
            // 
            // musteriEngellemePaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(583, 304);
            this.Controls.Add(this.menuButon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.engelleButon);
            this.Controls.Add(this.musterilerDGV);
            this.Name = "musteriEngellemePaneli";
            this.Text = "Müşteri Engelleme Paneli";
            this.Load += new System.EventHandler(this.musteriEngellemePaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musterilerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView musterilerDGV;
        private System.Windows.Forms.Button engelleButon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button menuButon;
    }
}