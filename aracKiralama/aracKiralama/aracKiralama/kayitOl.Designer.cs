namespace aracKiralama
{
    partial class kayitOl
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
            this.adText = new System.Windows.Forms.TextBox();
            this.soyadText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tcText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.musteriKayitButon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(151, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad: ";
            // 
            // adText
            // 
            this.adText.Location = new System.Drawing.Point(203, 70);
            this.adText.Name = "adText";
            this.adText.Size = new System.Drawing.Size(134, 20);
            this.adText.TabIndex = 1;
            // 
            // soyadText
            // 
            this.soyadText.Location = new System.Drawing.Point(203, 112);
            this.soyadText.Name = "soyadText";
            this.soyadText.Size = new System.Drawing.Size(134, 20);
            this.soyadText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(124, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad: ";
            // 
            // tcText
            // 
            this.tcText.Location = new System.Drawing.Point(203, 154);
            this.tcText.Name = "tcText";
            this.tcText.Size = new System.Drawing.Size(134, 20);
            this.tcText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(153, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC: ";
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(203, 192);
            this.sifreText.Name = "sifreText";
            this.sifreText.PasswordChar = '*';
            this.sifreText.Size = new System.Drawing.Size(134, 20);
            this.sifreText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(137, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şifre: ";
            // 
            // musteriKayitButon
            // 
            this.musteriKayitButon.Location = new System.Drawing.Point(203, 235);
            this.musteriKayitButon.Name = "musteriKayitButon";
            this.musteriKayitButon.Size = new System.Drawing.Size(134, 34);
            this.musteriKayitButon.TabIndex = 8;
            this.musteriKayitButon.Text = "Kayıt Ol";
            this.musteriKayitButon.UseVisualStyleBackColor = true;
            this.musteriKayitButon.Click += new System.EventHandler(this.musteriKayitButon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(165, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Müşteri Kayıt Paneli";
            // 
            // kayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 306);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.musteriKayitButon);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tcText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyadText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adText);
            this.Controls.Add(this.label1);
            this.Name = "kayitOl";
            this.Text = "Kayıt Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adText;
        private System.Windows.Forms.TextBox soyadText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tcText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button musteriKayitButon;
        private System.Windows.Forms.Label label5;
    }
}