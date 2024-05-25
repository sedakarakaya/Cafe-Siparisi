namespace CafeSiparis
{
    partial class SiparisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisForm));
            this.SiparisGroupBox = new System.Windows.Forms.GroupBox();
            this.kolaEksiButton = new System.Windows.Forms.Button();
            this.kolaArtiButton = new System.Windows.Forms.Button();
            this.kolaSayisiLabel = new System.Windows.Forms.Label();
            this.kolaLabel = new System.Windows.Forms.Label();
            this.kahveEksiButton = new System.Windows.Forms.Button();
            this.kahveArtiButton = new System.Windows.Forms.Button();
            this.kahveSayisiLabel = new System.Windows.Forms.Label();
            this.kahveLabel = new System.Windows.Forms.Label();
            this.cayEksiButton = new System.Windows.Forms.Button();
            this.cayArtiButton = new System.Windows.Forms.Button();
            this.caySayisiLabel = new System.Windows.Forms.Label();
            this.çayLabel = new System.Windows.Forms.Label();
            this.sifirlaButton = new System.Windows.Forms.Button();
            this.siparisiTamamlaButton = new System.Windows.Forms.Button();
            this.cikisButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SiparisGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SiparisGroupBox
            // 
            this.SiparisGroupBox.Controls.Add(this.kolaEksiButton);
            this.SiparisGroupBox.Controls.Add(this.kolaArtiButton);
            this.SiparisGroupBox.Controls.Add(this.kolaSayisiLabel);
            this.SiparisGroupBox.Controls.Add(this.kolaLabel);
            this.SiparisGroupBox.Controls.Add(this.kahveEksiButton);
            this.SiparisGroupBox.Controls.Add(this.kahveArtiButton);
            this.SiparisGroupBox.Controls.Add(this.kahveSayisiLabel);
            this.SiparisGroupBox.Controls.Add(this.kahveLabel);
            this.SiparisGroupBox.Controls.Add(this.cayEksiButton);
            this.SiparisGroupBox.Controls.Add(this.cayArtiButton);
            this.SiparisGroupBox.Controls.Add(this.caySayisiLabel);
            this.SiparisGroupBox.Controls.Add(this.çayLabel);
            this.SiparisGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SiparisGroupBox.Name = "SiparisGroupBox";
            this.SiparisGroupBox.Size = new System.Drawing.Size(270, 153);
            this.SiparisGroupBox.TabIndex = 0;
            this.SiparisGroupBox.TabStop = false;
            this.SiparisGroupBox.Text = "SİPARİŞ";
            // 
            // kolaEksiButton
            // 
            this.kolaEksiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolaEksiButton.Location = new System.Drawing.Point(189, 100);
            this.kolaEksiButton.Name = "kolaEksiButton";
            this.kolaEksiButton.Size = new System.Drawing.Size(26, 26);
            this.kolaEksiButton.TabIndex = 11;
            this.kolaEksiButton.Text = "-";
            this.kolaEksiButton.UseVisualStyleBackColor = true;
            this.kolaEksiButton.Click += new System.EventHandler(this.kolaEksiButton_Click);
            // 
            // kolaArtiButton
            // 
            this.kolaArtiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolaArtiButton.Location = new System.Drawing.Point(155, 100);
            this.kolaArtiButton.Name = "kolaArtiButton";
            this.kolaArtiButton.Size = new System.Drawing.Size(28, 26);
            this.kolaArtiButton.TabIndex = 10;
            this.kolaArtiButton.Text = "+";
            this.kolaArtiButton.UseVisualStyleBackColor = true;
            this.kolaArtiButton.Click += new System.EventHandler(this.kolaArtiButton_Click);
            // 
            // kolaSayisiLabel
            // 
            this.kolaSayisiLabel.AutoSize = true;
            this.kolaSayisiLabel.Location = new System.Drawing.Point(106, 106);
            this.kolaSayisiLabel.Name = "kolaSayisiLabel";
            this.kolaSayisiLabel.Size = new System.Drawing.Size(14, 16);
            this.kolaSayisiLabel.TabIndex = 9;
            this.kolaSayisiLabel.Text = "0";
            // 
            // kolaLabel
            // 
            this.kolaLabel.AutoSize = true;
            this.kolaLabel.Location = new System.Drawing.Point(40, 106);
            this.kolaLabel.Name = "kolaLabel";
            this.kolaLabel.Size = new System.Drawing.Size(41, 16);
            this.kolaLabel.TabIndex = 8;
            this.kolaLabel.Text = "KOLA";
            // 
            // kahveEksiButton
            // 
            this.kahveEksiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kahveEksiButton.Location = new System.Drawing.Point(189, 68);
            this.kahveEksiButton.Name = "kahveEksiButton";
            this.kahveEksiButton.Size = new System.Drawing.Size(26, 26);
            this.kahveEksiButton.TabIndex = 7;
            this.kahveEksiButton.Text = "-";
            this.kahveEksiButton.UseVisualStyleBackColor = true;
            this.kahveEksiButton.Click += new System.EventHandler(this.kahveEksiButton_Click);
            // 
            // kahveArtiButton
            // 
            this.kahveArtiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kahveArtiButton.Location = new System.Drawing.Point(155, 68);
            this.kahveArtiButton.Name = "kahveArtiButton";
            this.kahveArtiButton.Size = new System.Drawing.Size(28, 26);
            this.kahveArtiButton.TabIndex = 6;
            this.kahveArtiButton.Text = "+";
            this.kahveArtiButton.UseVisualStyleBackColor = true;
            this.kahveArtiButton.Click += new System.EventHandler(this.kahveArtiButton_Click);
            // 
            // kahveSayisiLabel
            // 
            this.kahveSayisiLabel.AutoSize = true;
            this.kahveSayisiLabel.Location = new System.Drawing.Point(106, 74);
            this.kahveSayisiLabel.Name = "kahveSayisiLabel";
            this.kahveSayisiLabel.Size = new System.Drawing.Size(14, 16);
            this.kahveSayisiLabel.TabIndex = 5;
            this.kahveSayisiLabel.Text = "0";
            // 
            // kahveLabel
            // 
            this.kahveLabel.AutoSize = true;
            this.kahveLabel.Location = new System.Drawing.Point(40, 74);
            this.kahveLabel.Name = "kahveLabel";
            this.kahveLabel.Size = new System.Drawing.Size(52, 16);
            this.kahveLabel.TabIndex = 4;
            this.kahveLabel.Text = "KAHVE";
            // 
            // cayEksiButton
            // 
            this.cayEksiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cayEksiButton.Location = new System.Drawing.Point(189, 36);
            this.cayEksiButton.Name = "cayEksiButton";
            this.cayEksiButton.Size = new System.Drawing.Size(26, 26);
            this.cayEksiButton.TabIndex = 3;
            this.cayEksiButton.Text = "-";
            this.cayEksiButton.UseVisualStyleBackColor = true;
            this.cayEksiButton.Click += new System.EventHandler(this.cayEksiLabel_Click);
            // 
            // cayArtiButton
            // 
            this.cayArtiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cayArtiButton.Location = new System.Drawing.Point(155, 36);
            this.cayArtiButton.Name = "cayArtiButton";
            this.cayArtiButton.Size = new System.Drawing.Size(28, 26);
            this.cayArtiButton.TabIndex = 2;
            this.cayArtiButton.Text = "+";
            this.cayArtiButton.UseVisualStyleBackColor = true;
            this.cayArtiButton.Click += new System.EventHandler(this.cayArtiLabel_Click);
            // 
            // caySayisiLabel
            // 
            this.caySayisiLabel.AutoSize = true;
            this.caySayisiLabel.Location = new System.Drawing.Point(106, 42);
            this.caySayisiLabel.Name = "caySayisiLabel";
            this.caySayisiLabel.Size = new System.Drawing.Size(14, 16);
            this.caySayisiLabel.TabIndex = 1;
            this.caySayisiLabel.Text = "0";
            // 
            // çayLabel
            // 
            this.çayLabel.AutoSize = true;
            this.çayLabel.Location = new System.Drawing.Point(40, 42);
            this.çayLabel.Name = "çayLabel";
            this.çayLabel.Size = new System.Drawing.Size(34, 16);
            this.çayLabel.TabIndex = 0;
            this.çayLabel.Text = "ÇAY";
            // 
            // sifirlaButton
            // 
            this.sifirlaButton.Image = ((System.Drawing.Image)(resources.GetObject("sifirlaButton.Image")));
            this.sifirlaButton.Location = new System.Drawing.Point(11, 179);
            this.sifirlaButton.Name = "sifirlaButton";
            this.sifirlaButton.Size = new System.Drawing.Size(100, 63);
            this.sifirlaButton.TabIndex = 1;
            this.sifirlaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sifirlaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sifirlaButton.UseVisualStyleBackColor = true;
            this.sifirlaButton.Click += new System.EventHandler(this.sifirlaButton_Click);
            // 
            // siparisiTamamlaButton
            // 
            this.siparisiTamamlaButton.Image = ((System.Drawing.Image)(resources.GetObject("siparisiTamamlaButton.Image")));
            this.siparisiTamamlaButton.Location = new System.Drawing.Point(118, 179);
            this.siparisiTamamlaButton.Name = "siparisiTamamlaButton";
            this.siparisiTamamlaButton.Size = new System.Drawing.Size(223, 67);
            this.siparisiTamamlaButton.TabIndex = 2;
            this.siparisiTamamlaButton.UseVisualStyleBackColor = true;
            this.siparisiTamamlaButton.Click += new System.EventHandler(this.siparisiTamamlaButton_Click);
            // 
            // cikisButton
            // 
            this.cikisButton.Image = ((System.Drawing.Image)(resources.GetObject("cikisButton.Image")));
            this.cikisButton.Location = new System.Drawing.Point(350, 179);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(85, 67);
            this.cikisButton.TabIndex = 3;
            this.cikisButton.UseVisualStyleBackColor = true;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(288, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 257);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.siparisiTamamlaButton);
            this.Controls.Add(this.sifirlaButton);
            this.Controls.Add(this.SiparisGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SiparisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SİPARİŞ EKRANI";
            this.SiparisGroupBox.ResumeLayout(false);
            this.SiparisGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SiparisGroupBox;
        private System.Windows.Forms.Button cayEksiButton;
        private System.Windows.Forms.Button cayArtiButton;
        private System.Windows.Forms.Label caySayisiLabel;
        private System.Windows.Forms.Label çayLabel;
        private System.Windows.Forms.Button kolaEksiButton;
        private System.Windows.Forms.Button kolaArtiButton;
        private System.Windows.Forms.Label kolaSayisiLabel;
        private System.Windows.Forms.Label kolaLabel;
        private System.Windows.Forms.Button kahveEksiButton;
        private System.Windows.Forms.Button kahveArtiButton;
        private System.Windows.Forms.Label kahveSayisiLabel;
        private System.Windows.Forms.Label kahveLabel;
        private System.Windows.Forms.Button sifirlaButton;
        private System.Windows.Forms.Button siparisiTamamlaButton;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

