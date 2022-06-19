using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASVT_ALTAY_SPOT_ve_VERESİYE_TAKİP.UL
{
    public partial class MusteriEkleDüzenle : Form
    {
        public MusteriEkleDüzenle()
        {
            InitializeComponent();
        }
        //Müşteri ekleme formunda alanların kontrolü yapılmıştır.

        public Musteri Musteri { get; set; }
        public bool Güncelleme { get; private set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
          
            if (!ErrorControl(txtAdı)) return;
            if (!ErrorControl(txtSoyadı)) return;
            if (!ErrorControl(txtTelefon)) return;
            if (!ErrorControl(txtMail)) return;
            if (!ErrorControl(txtAdresi)) return;

            Musteri.Ad = txtAdı.Text;
            Musteri.Soyad = txtSoyadı.Text;
            Musteri.Telefon = txtTelefon.Text;
            Musteri.Mail = txtMail.Text;
            Musteri.Adres = txtAdresi.Text;
            DialogResult = DialogResult.OK;
        }
     
        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Tüm alanları doldurunuz");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "Telefon numarası boş bırakılamaz");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void MusteriEkleDüzenle_Load(object sender, EventArgs e)
        {
            txtID.Text = Musteri.ID.ToString();
            if (Güncelleme)
            {
                txtAd.Text = Musteri.Ad;
                txtSoy.Text = Musteri.Soyad;
                txtTel.Text = Musteri.Telefon;
                txtMail.Text = Musteri.Mail;
                txtAdres.Text = Musteri.Adres;

            }
        }
    }
}








