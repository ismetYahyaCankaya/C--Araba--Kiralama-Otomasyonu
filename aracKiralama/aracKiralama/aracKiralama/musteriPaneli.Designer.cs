namespace aracKiralama
{
    partial class musteriPaneli
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
            this.renkFiltreCombo = new System.Windows.Forms.ComboBox();
            this.durumFiltreCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.araclarDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.markaFiltreCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modelFiltreCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cikisButon = new System.Windows.Forms.Button();
            this.alButon = new System.Windows.Forms.Button();
            this.aracResimPB = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.araclarDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracResimPB)).BeginInit();
            this.SuspendLayout();
            // 
            // adSoyadLabel
            // 
            this.adSoyadLabel.AutoSize = true;
            this.adSoyadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adSoyadLabel.Location = new System.Drawing.Point(12, 9);
            this.adSoyadLabel.Name = "adSoyadLabel";
            this.adSoyadLabel.Size = new System.Drawing.Size(36, 16);
            this.adSoyadLabel.TabIndex = 0;
            this.adSoyadLabel.Text = "hglbl";
            // 
            // renkFiltreCombo
            // 
            this.renkFiltreCombo.FormattingEnabled = true;
            this.renkFiltreCombo.Location = new System.Drawing.Point(113, 85);
            this.renkFiltreCombo.Name = "renkFiltreCombo";
            this.renkFiltreCombo.Size = new System.Drawing.Size(116, 21);
            this.renkFiltreCombo.TabIndex = 1;
            this.renkFiltreCombo.SelectedIndexChanged += new System.EventHandler(this.renkFiltreCombo_SelectedIndexChanged);
            // 
            // durumFiltreCombo
            // 
            this.durumFiltreCombo.FormattingEnabled = true;
            this.durumFiltreCombo.Location = new System.Drawing.Point(112, 127);
            this.durumFiltreCombo.Name = "durumFiltreCombo";
            this.durumFiltreCombo.Size = new System.Drawing.Size(116, 21);
            this.durumFiltreCombo.TabIndex = 4;
            this.durumFiltreCombo.SelectedIndexChanged += new System.EventHandler(this.durumFiltreCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Renk: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Durum: ";
            // 
            // araclarDGV
            // 
            this.araclarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.araclarDGV.Location = new System.Drawing.Point(252, 48);
            this.araclarDGV.Name = "araclarDGV";
            this.araclarDGV.Size = new System.Drawing.Size(339, 195);
            this.araclarDGV.TabIndex = 7;
            this.araclarDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.araclarDGV_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Marka: ";
            // 
            // markaFiltreCombo
            // 
            this.markaFiltreCombo.FormattingEnabled = true;
            this.markaFiltreCombo.Location = new System.Drawing.Point(114, 173);
            this.markaFiltreCombo.Name = "markaFiltreCombo";
            this.markaFiltreCombo.Size = new System.Drawing.Size(116, 21);
            this.markaFiltreCombo.TabIndex = 8;
            this.markaFiltreCombo.SelectedIndexChanged += new System.EventHandler(this.markaFiltreCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Model: ";
            // 
            // modelFiltreCombo
            // 
            this.modelFiltreCombo.FormattingEnabled = true;
            this.modelFiltreCombo.Location = new System.Drawing.Point(114, 222);
            this.modelFiltreCombo.Name = "modelFiltreCombo";
            this.modelFiltreCombo.Size = new System.Drawing.Size(116, 21);
            this.modelFiltreCombo.TabIndex = 10;
            this.modelFiltreCombo.SelectedIndexChanged += new System.EventHandler(this.modelFiltreCombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Filtre";
            // 
            // cikisButon
            // 
            this.cikisButon.Location = new System.Drawing.Point(426, 272);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(120, 37);
            this.cikisButon.TabIndex = 13;
            this.cikisButon.Text = "Çıkış";
            this.cikisButon.UseVisualStyleBackColor = true;
            this.cikisButon.Click += new System.EventHandler(this.cikisButon_Click);
            // 
            // alButon
            // 
            this.alButon.Location = new System.Drawing.Point(279, 272);
            this.alButon.Name = "alButon";
            this.alButon.Size = new System.Drawing.Size(126, 37);
            this.alButon.TabIndex = 14;
            this.alButon.Text = "Satın Al / Kirala";
            this.alButon.UseVisualStyleBackColor = true;
            this.alButon.Click += new System.EventHandler(this.alButon_Click);
            // 
            // aracResimPB
            // 
            this.aracResimPB.Location = new System.Drawing.Point(616, 95);
            this.aracResimPB.Name = "aracResimPB";
            this.aracResimPB.Size = new System.Drawing.Size(164, 119);
            this.aracResimPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aracResimPB.TabIndex = 15;
            this.aracResimPB.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(640, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Araç Resmi; ";
            // 
            // musteriPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 343);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aracResimPB);
            this.Controls.Add(this.alButon);
            this.Controls.Add(this.cikisButon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modelFiltreCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.markaFiltreCombo);
            this.Controls.Add(this.araclarDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.durumFiltreCombo);
            this.Controls.Add(this.renkFiltreCombo);
            this.Controls.Add(this.adSoyadLabel);
            this.Name = "musteriPaneli";
            this.Text = "Müşteri Paneli";
            this.Load += new System.EventHandler(this.musteriPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.araclarDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracResimPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adSoyadLabel;
        private System.Windows.Forms.ComboBox renkFiltreCombo;
        private System.Windows.Forms.ComboBox durumFiltreCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView araclarDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox markaFiltreCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox modelFiltreCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cikisButon;
        private System.Windows.Forms.Button alButon;
        private System.Windows.Forms.PictureBox aracResimPB;
        private System.Windows.Forms.Label label6;
    }
}