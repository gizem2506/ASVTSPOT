using ASVT_ALTAY_SPOT_ve_VERESİYE_TAKİP.UI;
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
    public partial class Ödeme : Form
    {
        public Ödeme()
        {
            InitializeComponent();
        }
        public Odeme Odeme { get; set; }
        //Ödeme alanı kontrolü yapılmıştır.
        private void btnOk_Click(object sender, EventArgs e)
        {

            if (cbodeme.SelectedItem == null)
            {
                errorProvider1.SetError(cbodeme, "Lütfen ödeme türünü seçiniz!");
                cbodeme.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(cbodeme, "");
            }
            Odeme.ÖdemeTarihi = dtödeme.Value;
            Odeme.ÖdemeTürü = cbodeme.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Ödeme_Load(object sender, EventArgs e)
        {
            
            
                dtödeme.Value = Odeme.ÖdemeTarihi;
                cbodeme.SelectedItem = Odeme.ÖdemeTürü;
                
            
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Müşteriler frm = new Müşteriler();
            if (frm.ShowDialog() == DialogResult.OK) ;
            
        }
    }
    }

