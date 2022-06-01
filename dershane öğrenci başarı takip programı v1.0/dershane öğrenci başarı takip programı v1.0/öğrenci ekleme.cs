using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace dershane_öğrenci_başarı_takip_programı_v1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti =
         new MySqlConnection(
             "Server=localhost;Database=dershane;Uid=root;Pwd=ardayurekli2006;"
             );
       

        DataTable dt = new DataTable();

        



        void baglantiAcKapa()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                else if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                if (baglanti.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Bağlantı açıldı");
                }
                else
                {
                   // MessageBox.Show("Bağlantı kapatıldı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata meydana geldi. Hata : "
                    + ex.Message.ToString());
            }
        }

        void ogrencileriGetir()
        {
            dt.Clear();
            MySqlDataAdapter adapter =
                new MySqlDataAdapter("Select * from öğrenci_eklee", baglanti);
            adapter.Fill(dt);
            dgöğrenciler.DataSource = dt;
            dgöğrenciler.Columns[0].HeaderText = "Ad";
            dgöğrenciler.Columns[1].HeaderText = "Soyad";
            dgöğrenciler.Columns[2].HeaderText = "tel";
            dgöğrenciler.Columns[3].HeaderText = "Doğum Tarihi";
            
           

        }

        private void btnögrenciekle_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand komut = new MySqlCommand();
                komut.CommandText = "insert into öğrenci_eklee(Ad, Soyad, tel, Dogumtarihi, dogumyeri) " +
                    "values('" + txtadi.Text + "', '" +
                    txtsoyadi.Text + "','" +
                   txtdogumtarihi + "','" +
                    txtdogumyeri.Text + "') ";
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                MessageBox.Show("Veri eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi. Hata : " + hata.Message.ToString());
            }
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {
            baglantiAcKapa();
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Öğrenci_İşlemleri frm = new Öğrenci_İşlemleri();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgöğrenciler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmdGuncelle =
         new MySqlCommand();
            cmdGuncelle.Connection = baglanti;
            cmdGuncelle.CommandText =
                "update öğrenci_eklee set Öğrenci Adi='" +
                txtadiG.Text + "', Öğrenci Soyadi='" +
                txtsoyadiG.Text + "' Telefon'" +
                txttelG + "', Öğrenci Dogum Tarihi='" +
                txtdogumtarihiG + "', Öğrenci Dogum Yeri='" +
                txttxtdogumyeriG
                + "'";

            int sonuc = cmdGuncelle.ExecuteNonQuery();
            if (sonuc != 0)
            {
                ogrencileriGetir();
                MessageBox.Show("Veri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veri güncellenemedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmdsil = new MySqlCommand();
                cmdsil.Connection = baglanti;
                cmdsil.CommandText = "delete from öğrenci_eklee where Öğrenci Adı='" +
                    txtadiS.Text + "'";
                int kayitsayisi = cmdsil.ExecuteNonQuery();
                if (kayitsayisi == 0)
                    MessageBox.Show("Silinecek Öğrenci Adı  bulunamadı!", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    ogrencileriGetir();
                    MessageBox.Show("Öğrenci başarıyla silindi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi. Hata : " + hata.Message.ToString());
            }




        }
    }
    }

