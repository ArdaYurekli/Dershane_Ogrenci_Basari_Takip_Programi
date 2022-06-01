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
    public partial class öğrenciekleme2 : Form
    {
        public öğrenciekleme2()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti =
        new MySqlConnection(
            "Server=localhost;Database=dershane;Uid=root;Pwd=ardayurekli2006;"
            );

        DataTable dt = new DataTable();

        int id = 0;


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
            dgöğrenciler.Columns[2].HeaderText = "Telefon";
            dgöğrenciler.Columns[3].HeaderText = "Doğum Tarihi";
            


        }

        private void btnögrenciekle_Click(object sender, EventArgs e)
        {
             try
            {

                MySqlCommand komut = new MySqlCommand();
                komut.CommandText = "insert into öğrenci_eklee(Ad, Soyad, tel, Dogumtarihi) values ('"+txtadi.Text+ "','" + txtsoyadi.Text + "','" + txttel.Text + "','" + txtdogumtarihi.Text + "')";
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                MessageBox.Show("Veri eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi. Hata : " + hata.Message.ToString());
            }
        }

        private void öğrenciekleme2_Load(object sender, EventArgs e)
        {
            baglantiAcKapa();
            ogrencileriGetir();



        }
        MySqlCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            
            cmd = new MySqlCommand("Update öğrenci_eklee set Ad='" + txtadiG.Text + "',Soyad='" + txtsoyadiG.Text + "',tel='" + txttelG.Text + "',Dogumtarihi='" + txtdogumtarihiG.Text + "'", baglanti);

            int sonuc = cmd.ExecuteNonQuery();
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

        private void dgöğrenciler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtadiG.Text = dgöğrenciler.CurrentRow.Cells[0].Value.ToString();
            txtsoyadiG.Text = dgöğrenciler.CurrentRow.Cells[1].Value.ToString();
            txttelG.Text = dgöğrenciler.CurrentRow.Cells[2].Value.ToString();
            txtdogumtarihiG.Text = dgöğrenciler.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmdsil = new MySqlCommand();
                cmdsil.Connection = baglanti;
                cmdsil.CommandText = "delete from öğrenci_eklee where Ad='" +
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

        private void dgöğrenciler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             Öğrenci_İşlemleri frm = new Öğrenci_İşlemleri();
            frm.Show();
            this.Hide();
        }
    }
}
