using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASVT_ALTAY_SPOT_ve_VERESİYE_TAKİP.DL;


using System.Data;

using System.Windows.Forms;
namespace ASVT_ALTAY_SPOT_ve_VERESİYE_TAKİP.BL
{
 public static class BLogic
    { 
        public static bool MüşteriEkle(Musteri m)
        {
            try
            {
                int res = DataLayer.MüşteriEkle(m);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet MüşteriGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.MüşteriGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static void MusteriEkle(object m)
        {
            throw new NotImplementedException();
        }

        internal static bool MüşteriGüncelle(Musteri m)
        {
            try
            {
                int res = DataLayer.MüşteriGüncelle(m);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool SiparisEkle(object siparis)
        {
            throw new NotImplementedException();
        }

        internal static bool MüşteriSil(string id)
        {
            try
            {
                int res = DataLayer.MüşteriSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }


        internal static bool UrunEkle(Urun u)
        {
            try
            {
                int res = DataLayer.UrunEkle(u);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet UrunGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.UrunGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool UrunGüncelle(Urun u)
        {
            try
            {
                int res = DataLayer.UrunGüncelle(u);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool UrunSil(string id)
        {
            try
            {
                int res = DataLayer.UrunSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool SatisSil(string id)
        {
            try
            {
                int res = DataLayer.SatisSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool SiparisEkle(Siparis s)
        {
            try
            {
                int res = DataLayer.SiparisEkle(s);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }
        internal static bool SiparisGüncelle(Siparis s)
        {
            try
            {
                int res = DataLayer.SiparisGüncelle(s);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }



        internal static bool OdemeEkle(Odeme o)
        {
            try
            {
                int res = DataLayer.OdemeEkle(o);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

     
        
        internal static bool OdemeGüncelle(Odeme o)
        {
            try
            {
                int res = DataLayer.OdemeGüncelle(o);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool OdemeSil(string id)
        {
            try
            {
                int res = DataLayer.OdemeSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }
    }
}
