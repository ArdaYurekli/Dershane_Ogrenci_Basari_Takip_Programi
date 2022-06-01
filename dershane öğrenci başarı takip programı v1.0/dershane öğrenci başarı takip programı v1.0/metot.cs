using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dershane_öğrenci_başarı_takip_programı_v1._0
{
    class metot
    {
        #region kullanıcı kontrol
        string kullanıcılar = "Server=localhost;Database=dershane;Uid=root;Pwd=ardayurekli2006;";

        public int kullanici_kontrol(string k_adı, string sifre)

        {
            int sayi = 0;

            using (var baglanti = new MySqlConnection(kullanıcılar))
            {
                using (var cmd = new MySqlCommand($"SELECT k_Ad,şifre FROM kullanıcılar WHERE k_Ad='{k_adı}'AND şifre='{sifre}'", baglanti))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {
                            string d_k = dtr["K_Ad"].ToString();
                            string d_ş = dtr["şifre"].ToString();
                            if (d_k == k_adı && d_ş == sifre)
                            {
                                sayi = 1;
                            }
                            else
                            {
                                sayi = 0;

                            }

                        }
                    }
                    catch
                    {
                        sayi = 0;

                    }

                }
            }
            return sayi;
        }
    }
}

#endregion

