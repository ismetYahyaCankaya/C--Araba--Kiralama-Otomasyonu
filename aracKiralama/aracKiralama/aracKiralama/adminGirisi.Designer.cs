namespace aracKiralama
{
    partial class adminGirisi
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
            this.label2 = new System.Windows.Forms.Label();
            this.adText = new System.Windows.Forms.TextBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.adminGirisButon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cikisYapButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(91, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre: ";
            // 
            // adText
            // 
            this.adText.Location = new System.Drawing.Point(138, 47);
            this.adText.Name = "adText";
            this.adText.Size = new System.Drawing.Size(127, 20);
            this.adText.TabIndex = 2;
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(138, 80);
            this.sifreText.Name = "sifreText";
            this.sifreText.PasswordChar = '*';
            this.sifreText.Size = new System.Drawing.Size(127, 20);
            this.sifreText.TabIndex = 3;
            // 
            // adminGirisButon
            // 
            this.adminGirisButon.Location = new System.Drawing.Point(95, 118);
            this.adminGirisButon.Name = "adminGirisButon";
            this.adminGirisButon.Size = new System.Drawing.Size(90, 36);
            this.adminGirisButon.TabIndex = 4;
            this.adminGirisButon.Text = "Giriş Yap";
            this.adminGirisButon.UseVisualStyleBackColor = true;
            this.adminGirisButon.Click += new System.EventHandler(this.adminGirisButon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(110, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Admin Giriş Paneli";
            // 
            // cikisYapButon
            // 
            this.cikisYapButon.Location = new System.Drawing.Point(201, 118);
            this.cikisYapButon.Name = "cikisYapButon";
            this.cikisYapButon.Size = new System.Drawing.Size(90, 36);
            this.cikisYapButon.TabIndex = 14;
            this.cikisYapButon.Text = "Anasayfa";
            this.cikisYapButon.UseVisualStyleBackColor = true;
            this.cikisYapButon.Click += new System.EventHandler(this.cikisYapButon_Click);
            // 
            // adminGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(376, 166);
            this.Controls.Add(this.cikisYapButon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminGirisButon);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.adText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminGirisi";
            this.Text = "Admin Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adText;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Button adminGirisButon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cikisYapButon;
    }
}