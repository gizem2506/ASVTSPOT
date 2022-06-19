using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ASVT_ALTAY_SPOT_ve_VERESİYE_TAKİP.DL
{
    
        public static class DataLayer
        {
            static MySqlConnection conn = new MySqlConnection(
                new MySqlConnectionStringBuilder()
                {
                    Server = "127.0.0.1",
                    Database = "gizem",
                    UserID = "root",
                    Password = "",

                }.ConnectionString
             );

            public static int MüşteriEkle(Musteri m)
            {

                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    MySqlCommand komut = new MySqlCommand("abc_MusteriEkle", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@id", m.ID);
                    komut.Parameters.AddWithValue("@ad", m.Ad);
                    komut.Parameters.AddWithValue("@soy", m.Soyad);
                    komut.Parameters.AddWithValue("@tel", m.Telefon);
                    komut.Parameters.AddWithValue("@mail", m.Mail);
                    komut.Parameters.AddWithValue("@adr", m.Adres);

                    int res = komut.ExecuteNonQuery();
                    return res;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                }

            }

            internal static int MüşteriSil(string id)
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    MySqlCommand komut = new MySqlCommand("abc_MusteriSil", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@id", id);

                    int res = komut.ExecuteNonQuery();
                    return res;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                }
            }


            internal static int MüşteriGüncelle(Musteri m)
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    MySqlCommand komut = new MySqlCommand("abc_MusteriGuncelle", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@id", m.ID);
                    komut.Parameters.AddWithValue("@ad", m.Ad);
                    komut.Parameters.AddWithValue("@soy", m.Soyad);
                    komut.Parameters.AddWithValue("@tel", m.Telefon);
                    komut.Parameters.AddWithValue("@mail", m.Mail);
                    komut.Parameters.AddWithValue("@adr", m.Adres);

                    int res = komut.ExecuteNonQuery();
                    return res;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                }
            }




            internal static int UrunSil(string id)
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    MySqlCommand komut = new MySqlCommand("abc_UrunSil", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@id", id);

                    int res = komut.ExecuteNonQuery();
                    return res;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                }
            }

            internal static int SatisSil(string id)
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    MySqlCommand komut = new MySqlCommand("abc_SiparisSil", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@id", id);

                    int res = komut.ExecuteNonQuery();
                    return res;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                }
            }


            internal static int UrunGüncelle(Urun u)
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    MySqlCommand komut = new MySqlCommand("abc_UrunGuncelle", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@id", u.ID);
                    komut.Parameters.AddWithValue("@marka", u.Marka);
                    komut.Parameters.AddWithValue("@model", u.Model);
                    komut.Parameters.AddWithValue("@fiyat", u.Fiyat);
                    komut.Parameters.AddWithValue("@ağırlık", u.Ağırlık);
                    komut.Parameters.AddWithValue("@renk", u.Renk);
                   

                    int res = komut.ExecuteNonQuery();
                    return res;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                }
            }


            internal static DataSet MüşteriGetir(string filtre)
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    MySqlCommand komut;
                    if (string.IsNullOrEmpty(filtre))
                    {
                        komut = new MySqlCommand("abc_MusterilerHepsi", conn);
                        komut.CommandType = System.Data.CommandType.StoredProcedure;
                    }
                    else
                    {
                        komut = new MySqlCommand("abc_MusteriBul", conn);
                        komut.CommandType = System.Data.CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@filtre", filtre);
                    }

                    DataSet dataSet = new DataSet();
                    MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                    adp.Fill(dataSet);

                    return dataSet;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                }
            }
            internal static int UrunEkle(Urun u)
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    MySqlCommand komut = new MySqlCommand("abc_UrunEkle", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@id", u.ID);
                    komut.Parameters.AddWithValue("@marka", u.Marka);
                    komut.Parameters.AddWithValue("@model", u.Model);
                    komut.Parameters.AddWithValue("@fiyat", u.Fiyat);
                    komut.Parameters.AddWithValue("@ağırlık", u.Ağırlık);
                    komut.Parameters.AddWithValue("@renk", u.Renk);

                    int res = komut.ExecuteNonQuery();
                    return res;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                }
            }
            internal static DataSet UrunGetir(string filtre)
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    MySqlCommand komut;
                    if (string.IsNullOrEmpty(filtre))
                    {
                        komut = new MySqlCommand("abc_UrunlerHepsi", conn);
                        komut.CommandType = System.Data.CommandType.StoredProcedure;
                    }
                    else
                    {
                        komut = new MySqlCommand("abc_UrunBul", conn);
                        komut.CommandType = System.Data.CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@filtre", filtre);
                    }

                    DataSet dataSet = new DataSet();
                    MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                    adp.Fill(dataSet);

                    return dataSet;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                }
            }

            internal static int SiparisEkle(Siparis s)
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    MySqlCommand komut = new MySqlCommand("abc_SiparisEkle", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@sid", s.ID);
                    komut.Parameters.AddWithValue("@mid", s.Musteri);
                    komut.Parameters.AddWithValue("@uid", s.Urun);
                    komut.Parameters.AddWithValue("@tarih", s.SiparişTarihi);
                    komut.Parameters.AddWithValue("@adet", s.Adet);
            
              
                    int res = komut.ExecuteNonQuery();
                    return res;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                }

            }

            internal static int OdemeEkle(Odeme o)
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    MySqlCommand komut = new MySqlCommand("abc_OdemeEkle", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@oid", o.ID);
                    komut.Parameters.AddWithValue("@tarih", o.ÖdemeTarihi);
                    komut.Parameters.AddWithValue("@tür", o.ÖdemeTürü);
                  
                

                    int res = komut.ExecuteNonQuery();
                    return res;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                }
            }
            internal static int OdemeGüncelle(Odeme o)
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    MySqlCommand komut = new MySqlCommand("abc_OdemeGuncelle", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@oid", o.ID);
                    komut.Parameters.AddWithValue("@tarih", o.ÖdemeTarihi);
                    komut.Parameters.AddWithValue("@tür", o.ÖdemeTürü);

                    int res = komut.ExecuteNonQuery();
                    return res;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                }
            }

            internal static int SiparisGüncelle(Siparis s)
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    MySqlCommand komut = new MySqlCommand("abc_SiparisGuncelle", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@sid", s.ID);
                    komut.Parameters.AddWithValue("@mid", s.Musteri);
                    komut.Parameters.AddWithValue("@uid", s.Urun);
                    komut.Parameters.AddWithValue("@tarih", s.SiparişTarihi);
                    komut.Parameters.AddWithValue("@adet", s.Adet);


                    int res = komut.ExecuteNonQuery();
                    return res;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                }
            }
            internal static int OdemeSil(string id)
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    MySqlCommand komut = new MySqlCommand("abc_OdemeSil", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@oid", id);


                    int res = komut.ExecuteNonQuery();
                    return res;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                        conn.Close();
                }
            }


        }

    }
