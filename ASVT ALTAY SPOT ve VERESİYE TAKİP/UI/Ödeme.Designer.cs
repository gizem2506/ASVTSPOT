
namespace ASVT_ALTAY_SPOT_ve_VERESİYE_TAKİP.UL
{
    partial class Ödeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ödeme));
            this.dtödeme = new System.Windows.Forms.DateTimePicker();
            this.ÖdemeTarihi = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.textodemeID = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.Label();
            this.ÖdemeID = new System.Windows.Forms.Label();
            this.ÖdemeTürü = new System.Windows.Forms.Label();
            this.cbodeme = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMüşteriSeç = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtödeme
            // 
            this.dtödeme.Location = new System.Drawing.Point(260, 137);
            this.dtödeme.Name = "dtödeme";
            this.dtödeme.Size = new System.Drawing.Size(278, 22);
            this.dtödeme.TabIndex = 1;
            // 
            // ÖdemeTarihi
            // 
            this.ÖdemeTarihi.BackColor = System.Drawing.SystemColors.Control;
            this.ÖdemeTarihi.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ÖdemeTarihi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ÖdemeTarihi.Location = new System.Drawing.Point(86, 133);
            this.ÖdemeTarihi.Name = "ÖdemeTarihi";
            this.ÖdemeTarihi.Size = new System.Drawing.Size(169, 33);
            this.ÖdemeTarihi.TabIndex = 52;
            this.ÖdemeTarihi.Text = "Ödeme Tarihi :";
            this.ÖdemeTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Lucida Calligraphy", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(413, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "İptal Et";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Lucida Calligraphy", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(277, 216);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 29);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ödeme Yap";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // textodemeID
            // 
            this.textodemeID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textodemeID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textodemeID.Location = new System.Drawing.Point(260, 90);
            this.textodemeID.Multiline = true;
            this.textodemeID.Name = "textodemeID";
            this.textodemeID.ReadOnly = true;
            this.textodemeID.Size = new System.Drawing.Size(278, 28);
            this.textodemeID.TabIndex = 0;
            this.textodemeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFiyat
            // 
            this.txtFiyat.BackColor = System.Drawing.SystemColors.Control;
            this.txtFiyat.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiyat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFiyat.Location = new System.Drawing.Point(76, 322);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(169, 35);
            this.txtFiyat.TabIndex = 46;
            this.txtFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ÖdemeID
            // 
            this.ÖdemeID.BackColor = System.Drawing.SystemColors.Control;
            this.ÖdemeID.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ÖdemeID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ÖdemeID.Location = new System.Drawing.Point(86, 90);
            this.ÖdemeID.Name = "ÖdemeID";
            this.ÖdemeID.Size = new System.Drawing.Size(169, 35);
            this.ÖdemeID.TabIndex = 48;
            this.ÖdemeID.Text = "Ödeme ID :";
            this.ÖdemeID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ÖdemeTürü
            // 
            this.ÖdemeTürü.BackColor = System.Drawing.SystemColors.Control;
            this.ÖdemeTürü.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ÖdemeTürü.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ÖdemeTürü.Location = new System.Drawing.Point(86, 166);
            this.ÖdemeTürü.Name = "ÖdemeTürü";
            this.ÖdemeTürü.Size = new System.Drawing.Size(169, 41);
            this.ÖdemeTürü.TabIndex = 53;
            this.ÖdemeTürü.Text = "Ödeme Türü :";
            this.ÖdemeTürü.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbodeme
            // 
            this.cbodeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodeme.FormattingEnabled = true;
            this.cbodeme.Items.AddRange(new object[] {
            "Banka Kartı",
            "Kredi Kartı",
            "Nakit",
            "Senet "});
            this.cbodeme.Location = new System.Drawing.Point(260, 176);
            this.cbodeme.Name = "cbodeme";
            this.cbodeme.Size = new System.Drawing.Size(278, 24);
            this.cbodeme.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMüşteriSeç
            // 
            this.btnMüşteriSeç.Location = new System.Drawing.Point(316, 270);
            this.btnMüşteriSeç.Name = "btnMüşteriSeç";
            this.btnMüşteriSeç.Size = new System.Drawing.Size(167, 29);
            this.btnMüşteriSeç.TabIndex = 54;
            this.btnMüşteriSeç.Text = "Müşteri Seç";
            this.btnMüşteriSeç.UseVisualStyleBackColor = true;
            this.btnMüşteriSeç.Click += new System.EventHandler(this.btnMüşteriSeç_Click);
            // 
            // Ödeme
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(615, 357);
            this.Controls.Add(this.btnMüşteriSeç);
            this.Controls.Add(this.cbodeme);
            this.Controls.Add(this.ÖdemeTürü);
            this.Controls.Add(this.dtödeme);
            this.Controls.Add(this.ÖdemeTarihi);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textodemeID);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.ÖdemeID);
            this.DoubleBuffered = true;
            this.Name = "Ödeme";
            this.Text = "Ödeme Sayfası";
            this.Load += new System.EventHandler(this.Ödeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtödeme;
        private System.Windows.Forms.Label ÖdemeTarihi;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox textodemeID;
        private System.Windows.Forms.Label txtFiyat;
        private System.Windows.Forms.Label ÖdemeID;
        private System.Windows.Forms.Label ÖdemeTürü;
        private System.Windows.Forms.ComboBox cbodeme;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnMüşteriSeç;
    }
}