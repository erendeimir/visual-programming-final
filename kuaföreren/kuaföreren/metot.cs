using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace kuaföreren
{
    public class Metot
    {
        #region Kullanıcı Kontrol
        string ConStr = "SERVER=localhost;DATABASE=kuafor;UID=root;PWD=secret";
        public int KullaniciKontrol(string kAd, string kSifre)
        {
            int sonuc = 0;

            using (var con = new MySqlConnection(ConStr))
            {
                using (var cmd = new MySqlCommand($"SELECT k_adi, k_sifre FROM kullanicilar WHERE k_adi='{kAd}' AND k_sifre='{kSifre}'", con))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {
                            string d_k = dtr["k_adi"].ToString();
                            string d_s = dtr["k_sifre"].ToString();
                            if (d_k==kAd && d_s==kSifre)
                            {
                                sonuc = 1;
                            }
                            else
                            {
                                sonuc = 0;
                            }
                        }
                    }
                    catch 
                    {

                        sonuc = 0;
                    }
                }
            }

            return sonuc;   
        }
        #endregion
    }
}
