namespace aracKiralama
{
    partial class aracSilmePaneli
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.aracSilButon = new System.Windows.Forms.Button();
            this.menuButon = new System.Windows.Forms.Button();
            this.aracKiralamaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.araclarDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araclarDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kaldırılacak Aracı Seçin: ";
            // 
            // aracSilButon
            // 
            this.aracSilButon.Location = new System.Drawing.Point(202, 234);
            this.aracSilButon.Name = "aracSilButon";
            this.aracSilButon.Size = new System.Drawing.Size(90, 34);
            this.aracSilButon.TabIndex = 2;
            this.aracSilButon.Text = "Araç Sil";
            this.aracSilButon.UseVisualStyleBackColor = true;
            this.aracSilButon.Click += new System.EventHandler(this.aracSilButon_Click);
            // 
            // menuButon
            // 
            this.menuButon.Location = new System.Drawing.Point(362, 234);
            this.menuButon.Name = "menuButon";
            this.menuButon.Size = new System.Drawing.Size(90, 34);
            this.menuButon.TabIndex = 3;
            this.menuButon.Text = "Menü";
            this.menuButon.UseVisualStyleBackColor = true;
            this.menuButon.Click += new System.EventHandler(this.menuButon_Click);
            // 
            // araclarDGV
            // 
            this.araclarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.araclarDGV.Location = new System.Drawing.Point(59, 64);
            this.araclarDGV.Name = "araclarDGV";
            this.araclarDGV.Size = new System.Drawing.Size(393, 147);
            this.araclarDGV.TabIndex = 4;
            this.araclarDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.araclarDGV_CellContentClick);
            // 
            // aracSilmePaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(505, 296);
            this.Controls.Add(this.araclarDGV);
            this.Controls.Add(this.menuButon);
            this.Controls.Add(this.aracSilButon);
            this.Controls.Add(this.label1);
            this.Name = "aracSilmePaneli";
            this.Text = "Araç Silme Paneli";
            this.Load += new System.EventHandler(this.aracSilmePaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araclarDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aracSilButon;
        private System.Windows.Forms.Button menuButon;
        private System.Windows.Forms.BindingSource aracKiralamaDataSetBindingSource;
        private System.Windows.Forms.DataGridView araclarDGV;
    }
}