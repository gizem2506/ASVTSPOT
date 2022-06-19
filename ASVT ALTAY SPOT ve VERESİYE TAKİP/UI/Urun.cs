using System;
using System.Windows.Forms;

namespace ASVT_ALTAY_SPOT_ve_VERESİYE_TAKİP.UL
{
    public partial class Urun : Form
    {
        public bool Güncelleme { get; private set; }

        public Urun()
        {
            InitializeComponent();
        }

       // public Urun Urun { get; set; }
        ////Ürün eklem formunda alanların kontrolü yapılmıştır.
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(cbMarka)) return;
            if (!ErrorControl(txtModel)) return;
            if (!ErrorControl(nmFiyat)) return;
            if (!ErrorControl(txtAğırlık)) return;
            if (!ErrorControl(cbRenk)) return;

           /* Urun.Marka = cbMarka.SelectedItem.ToString(); 
            Urun.Model = txtModel.Text;
            Urun.Ağırlık = txtAğırlık.Value;
            Urun.Fiyat = (double)nmFiyat.Value;
            Urun.Renk = cbRenk.SelectedItem.ToString(); ;
           */
            DialogResult = DialogResult.OK;
        }
   
        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Tüm alanları doldurunuz!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            if (c is NumericUpDown)
            {
                if (!(((NumericUpDown)c).Value == 0))
                {
                    errorProvider1.SetError(c, "Lütfen Fiyat Giriniz");
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

        private void Urun_Load(object sender, EventArgs e)
        {
            /*txtID.Text = Urun.ID.ToString();
            if (Güncelleme)
            {
                cbMarka.Text = Urun.Marka;
                txtModel.Text = Urun.Model;
                nmFiyat.Value = (decimal)Urun.Fiyat;
                txtAğırlık.Text = Urun.Ağırlık;
                cbRenk.Text = Urun.Renk;
            */

            }
        }
    }
    

