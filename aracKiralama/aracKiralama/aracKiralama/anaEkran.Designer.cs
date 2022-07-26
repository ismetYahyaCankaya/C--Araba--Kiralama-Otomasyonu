namespace aracKiralama
{
    partial class anaEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminGirisButon = new System.Windows.Forms.Button();
            this.musteriGirisButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminGirisButon
            // 
            this.adminGirisButon.Location = new System.Drawing.Point(175, 132);
            this.adminGirisButon.Name = "adminGirisButon";
            this.adminGirisButon.Size = new System.Drawing.Size(148, 80);
            this.adminGirisButon.TabIndex = 0;
            this.adminGirisButon.Text = "Admin Girişi";
            this.adminGirisButon.UseVisualStyleBackColor = true;
            this.adminGirisButon.Click += new System.EventHandler(this.adminGirisButon_Click);
            // 
            // musteriGirisButon
            // 
            this.musteriGirisButon.Location = new System.Drawing.Point(368, 132);
            this.musteriGirisButon.Name = "musteriGirisButon";
            this.musteriGirisButon.Size = new System.Drawing.Size(148, 80);
            this.musteriGirisButon.TabIndex = 1;
            this.musteriGirisButon.Text = "Müşteri Girişi";
            this.musteriGirisButon.UseVisualStyleBackColor = true;
            this.musteriGirisButon.Click += new System.EventHandler(this.musteriGirisButon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 324);
            this.Controls.Add(this.musteriGirisButon);
            this.Controls.Add(this.adminGirisButon);
            this.Name = "Form1";
            this.Text = "Araç Kiralama Otomasyonu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminGirisButon;
        private System.Windows.Forms.Button musteriGirisButon;
    }
}

