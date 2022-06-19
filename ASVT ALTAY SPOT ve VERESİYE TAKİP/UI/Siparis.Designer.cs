
namespace ASVT_ALTAY_SPOT_ve_VERESİYE_TAKİP.UL
{
    partial class Siparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siparis));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.Label();
            this.Adı = new System.Windows.Forms.Label();
            this.SiparisID = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.UrunID = new System.Windows.Forms.Label();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.MusteriID = new System.Windows.Forms.Label();
            this.nmAdet = new System.Windows.Forms.NumericUpDown();
            this.nmÜcret = new System.Windows.Forms.NumericUpDown();
            this.SiparişTarihi = new System.Windows.Forms.Label();
            this.ÖdemeTarihi = new System.Windows.Forms.Label();
            this.dtsiparis = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbödemetürü = new System.Windows.Forms.ComboBox();
            this.btnMüşteriSeç = new System.Windows.Forms.Button();
            this.btnÜrünSeç = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmÜcret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Lucida Calligraphy", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(410, 329);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "İptal Et";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Lucida Calligraphy", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(293, 329);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(111, 29);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ürün Ekle";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(266, 68);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(278, 28);
            this.txtID.TabIndex = 0;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFiyat
            // 
            this.txtFiyat.BackColor = System.Drawing.SystemColors.Control;
            this.txtFiyat.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiyat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFiyat.Location = new System.Drawing.Point(81, 194);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(169, 35);
            this.txtFiyat.TabIndex = 26;
            this.txtFiyat.Text = "Ücret :";
            this.txtFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Adı
            // 
            this.Adı.BackColor = System.Drawing.SystemColors.Control;
            this.Adı.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adı.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Adı.Location = new System.Drawing.Point(92, 163);
            this.Adı.Name = "Adı";
            this.Adı.Size = new System.Drawing.Size(169, 31);
            this.Adı.TabIndex = 27;
            this.Adı.Text = "Adet : ";
            this.Adı.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SiparisID
            // 
            this.SiparisID.BackColor = System.Drawing.SystemColors.Control;
            this.SiparisID.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiparisID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SiparisID.Location = new System.Drawing.Point(92, 61);
            this.SiparisID.Name = "SiparisID";
            this.SiparisID.Size = new System.Drawing.Size(169, 35);
            this.SiparisID.TabIndex = 28;
            this.SiparisID.Text = " ID :";
            this.SiparisID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUrunID
            // 
            this.txtUrunID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUrunID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunID.Location = new System.Drawing.Point(266, 136);
            this.txtUrunID.Multiline = true;
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.ReadOnly = true;
            this.txtUrunID.Size = new System.Drawing.Size(278, 28);
            this.txtUrunID.TabIndex = 2;
            this.txtUrunID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UrunID
            // 
            this.UrunID.BackColor = System.Drawing.SystemColors.Control;
            this.UrunID.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UrunID.Location = new System.Drawing.Point(92, 129);
            this.UrunID.Name = "UrunID";
            this.UrunID.Size = new System.Drawing.Size(169, 34);
            this.UrunID.TabIndex = 30;
            this.UrunID.Text = "Ürün ID :";
            this.UrunID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMusteriID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriID.Location = new System.Drawing.Point(266, 102);
            this.txtMusteriID.Multiline = true;
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.ReadOnly = true;
            this.txtMusteriID.Size = new System.Drawing.Size(278, 28);
            this.txtMusteriID.TabIndex = 1;
            this.txtMusteriID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MusteriID
            // 
            this.MusteriID.BackColor = System.Drawing.SystemColors.Control;
            this.MusteriID.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MusteriID.Location = new System.Drawing.Point(92, 99);
            this.MusteriID.Name = "MusteriID";
            this.MusteriID.Size = new System.Drawing.Size(169, 30);
            this.MusteriID.TabIndex = 32;
            this.MusteriID.Text = "Müşteri ID :";
            this.MusteriID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nmAdet
            // 
            this.nmAdet.Location = new System.Drawing.Point(266, 172);
            this.nmAdet.Name = "nmAdet";
            this.nmAdet.Size = new System.Drawing.Size(278, 22);
            this.nmAdet.TabIndex = 3;
            // 
            // nmÜcret
            // 
            this.nmÜcret.Location = new System.Drawing.Point(266, 207);
            this.nmÜcret.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmÜcret.Name = "nmÜcret";
            this.nmÜcret.Size = new System.Drawing.Size(277, 22);
            this.nmÜcret.TabIndex = 4;
            // 
            // SiparişTarihi
            // 
            this.SiparişTarihi.BackColor = System.Drawing.SystemColors.Control;
            this.SiparişTarihi.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiparişTarihi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SiparişTarihi.Location = new System.Drawing.Point(81, 229);
            this.SiparişTarihi.Name = "SiparişTarihi";
            this.SiparişTarihi.Size = new System.Drawing.Size(169, 42);
            this.SiparişTarihi.TabIndex = 35;
            this.SiparişTarihi.Text = "Sipariş Tarihi :";
            this.SiparişTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ÖdemeTarihi
            // 
            this.ÖdemeTarihi.BackColor = System.Drawing.SystemColors.Control;
            this.ÖdemeTarihi.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ÖdemeTarihi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ÖdemeTarihi.Location = new System.Drawing.Point(81, 271);
            this.ÖdemeTarihi.Name = "ÖdemeTarihi";
            this.ÖdemeTarihi.Size = new System.Drawing.Size(169, 33);
            this.ÖdemeTarihi.TabIndex = 36;
            this.ÖdemeTarihi.Text = "Ödeme Türü :";
            this.ÖdemeTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtsiparis
            // 
            this.dtsiparis.Location = new System.Drawing.Point(266, 238);
            this.dtsiparis.Name = "dtsiparis";
            this.dtsiparis.Size = new System.Drawing.Size(277, 22);
            this.dtsiparis.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbödemetürü
            // 
            this.cbödemetürü.FormattingEnabled = true;
            this.cbödemetürü.Items.AddRange(new object[] {
            "Banka Kartı",
            "Kredi Kartı",
            "Nakit",
            "Senet"});
            this.cbödemetürü.Location = new System.Drawing.Point(266, 277);
            this.cbödemetürü.Name = "cbödemetürü";
            this.cbödemetürü.Size = new System.Drawing.Size(277, 24);
            this.cbödemetürü.TabIndex = 37;
          
            // 
            // btnMüşteriSeç
            // 
            this.btnMüşteriSeç.Location = new System.Drawing.Point(651, 133);
            this.btnMüşteriSeç.Name = "btnMüşteriSeç";
            this.btnMüşteriSeç.Size = new System.Drawing.Size(167, 29);
            this.btnMüşteriSeç.TabIndex = 38;
            this.btnMüşteriSeç.Text = "Müşteri Seç";
            this.btnMüşteriSeç.UseVisualStyleBackColor = true;
            this.btnMüşteriSeç.Click += new System.EventHandler(this.btnMüşteriSeç_Click);
            // 
            // btnÜrünSeç
            // 
            this.btnÜrünSeç.Location = new System.Drawing.Point(651, 181);
            this.btnÜrünSeç.Name = "btnÜrünSeç";
            this.btnÜrünSeç.Size = new System.Drawing.Size(167, 29);
            this.btnÜrünSeç.TabIndex = 39;
            this.btnÜrünSeç.Text = "Ürün Seç";
            this.btnÜrünSeç.UseVisualStyleBackColor = true;
            this.btnÜrünSeç.Click += new System.EventHandler(this.btnÜrünSeç_Click);
            // 
            // Siparis
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(876, 429);
            this.Controls.Add(this.btnÜrünSeç);
            this.Controls.Add(this.btnMüşteriSeç);
            this.Controls.Add(this.cbödemetürü);
            this.Controls.Add(this.dtsiparis);
            this.Controls.Add(this.ÖdemeTarihi);
            this.Controls.Add(this.SiparişTarihi);
            this.Controls.Add(this.nmÜcret);
            this.Controls.Add(this.nmAdet);
            this.Controls.Add(this.txtMusteriID);
            this.Controls.Add(this.MusteriID);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.UrunID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.Adı);
            this.Controls.Add(this.SiparisID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Siparis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sipariş Verme Sayfası";
            this.Load += new System.EventHandler(this.Siparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmÜcret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label txtFiyat;
        private System.Windows.Forms.Label Adı;
        private System.Windows.Forms.Label SiparisID;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Label UrunID;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Label MusteriID;
        private System.Windows.Forms.NumericUpDown nmAdet;
        private System.Windows.Forms.NumericUpDown nmÜcret;
        private System.Windows.Forms.Label SiparişTarihi;
        private System.Windows.Forms.Label ÖdemeTarihi;
        private System.Windows.Forms.DateTimePicker dtsiparis;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbödemetürü;
        private System.Windows.Forms.Button btnÜrünSeç;
        private System.Windows.Forms.Button btnMüşteriSeç;
    }
}