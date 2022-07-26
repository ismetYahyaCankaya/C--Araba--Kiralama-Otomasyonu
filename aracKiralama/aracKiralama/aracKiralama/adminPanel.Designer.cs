namespace aracKiralama
{
    partial class adminPanel
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
            this.adSoyadLabel = new System.Windows.Forms.Label();
            this.aracEkleButon = new System.Windows.Forms.Button();
            this.musteriEngelleButon = new System.Windows.Forms.Button();
            this.aracSilButon = new System.Windows.Forms.Button();
            this.cikisButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adSoyadLabel
            // 
            this.adSoyadLabel.AutoSize = true;
            this.adSoyadLabel.Location = new System.Drawing.Point(30, 9);
            this.adSoyadLabel.Name = "adSoyadLabel";
            this.adSoyadLabel.Size = new System.Drawing.Size(0, 13);
            this.adSoyadLabel.TabIndex = 0;
            // 
            // aracEkleButon
            // 
            this.aracEkleButon.Location = new System.Drawing.Point(21, 58);
            this.aracEkleButon.Name = "aracEkleButon";
            this.aracEkleButon.Size = new System.Drawing.Size(144, 69);
            this.aracEkleButon.TabIndex = 1;
            this.aracEkleButon.Text = "Araç Ekle";
            this.aracEkleButon.UseVisualStyleBackColor = true;
            this.aracEkleButon.Click += new System.EventHandler(this.aracEkleButon_Click);
            // 
            // musteriEngelleButon
            // 
            this.musteriEngelleButon.Location = new System.Drawing.Point(377, 58);
            this.musteriEngelleButon.Name = "musteriEngelleButon";
            this.musteriEngelleButon.Size = new System.Drawing.Size(144, 69);
            this.musteriEngelleButon.TabIndex = 2;
            this.musteriEngelleButon.Text = "Müşteri Engelle";
            this.musteriEngelleButon.UseVisualStyleBackColor = true;
            this.musteriEngelleButon.Click += new System.EventHandler(this.musteriEngelleButon_Click);
            // 
            // aracSilButon
            // 
            this.aracSilButon.Location = new System.Drawing.Point(198, 58);
            this.aracSilButon.Name = "aracSilButon";
            this.aracSilButon.Size = new System.Drawing.Size(144, 69);
            this.aracSilButon.TabIndex = 4;
            this.aracSilButon.Text = "Araç Sil";
            this.aracSilButon.UseVisualStyleBackColor = true;
            this.aracSilButon.Click += new System.EventHandler(this.aracSilButon_Click);
            // 
            // cikisButon
            // 
            this.cikisButon.Location = new System.Drawing.Point(198, 151);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(144, 57);
            this.cikisButon.TabIndex = 5;
            this.cikisButon.Text = "Çıkış";
            this.cikisButon.UseVisualStyleBackColor = true;
            this.cikisButon.Click += new System.EventHandler(this.cikisButon_Click);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(543, 232);
            this.Controls.Add(this.cikisButon);
            this.Controls.Add(this.aracSilButon);
            this.Controls.Add(this.musteriEngelleButon);
            this.Controls.Add(this.aracEkleButon);
            this.Controls.Add(this.adSoyadLabel);
            this.Name = "adminPanel";
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.adminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adSoyadLabel;
        private System.Windows.Forms.Button aracEkleButon;
        private System.Windows.Forms.Button musteriEngelleButon;
        private System.Windows.Forms.Button aracSilButon;
        private System.Windows.Forms.Button cikisButon;
    }
}