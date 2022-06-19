using ASVT_ALTAY_SPOT_ve_VERESİYE_TAKİP.BL;
using ASVT_ALTAY_SPOT_ve_VERESİYE_TAKİP.UI;
using ASVT_ALTAY_SPOT_ve_VERESİYE_TAKİP.UL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ASVT_ALTAY_SPOT_ve_VERESİYE_TAKİP
{
    public partial class AnaForm : Form
    {
        private object m;

        public AnaForm()
        {
            InitializeComponent();
        }

        Müşteriler mf = new Müşteriler();
        Ürünler uf = new Ürünler();
        private void btnMüşteriler_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();
        }
        private void btnMüşteriler_Click_1(object sender, EventArgs e)
        {
            new Müşteriler().ShowDialog();
        }

        private void btnÜrünler_Click_1(object sender, EventArgs e)
        {
            new Ürünler().ShowDialog();
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            Siparis frm = new Siparis()
            {
                Text = "Sipariş Ver",
                Siparis = new Siparis()
                {
                    ID = Guid.NewGuid()
                }
            };
        }

        private void btnÖdemeYap_Click(object sender, EventArgs e)
        {
            Ödeme frm = new Ödeme()
            {
                Text = "Ödeme Yap",
                Odeme = new Odeme()
                {
                    ID = Guid.NewGuid()
                }
            };
        }

        private void btnSiparisDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            Siparis frm = new Siparis()
            {
                Text = "Sipariş Güncelle",
                Güncelleme = true,
                Siparis = new Siparis()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    UrunID = Guid.Parse(row.Cells[2].Value.ToString()),
                    Fiyat = double.Parse(row.Cells[7].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[8].Value.ToString()),

                },
            };

            var sonuc = frm.ShowDialog();
            // if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SiparisGüncelle(frm.Siparis);

                if (b)
                {
                    row.Cells[1].Value = frm.Siparis.MusteriID;
                    row.Cells[2].Value = frm.Siparis.UrunID;
                    row.Cells[7].Value = frm.Siparis.Fiyat;
                    row.Cells[8].Value = frm.Siparis.Tarih;

                }
            }

        }

        private void btnSatisSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisSil(ID);

                if (b)
                {



                }
            }
        }
    }
}
    

