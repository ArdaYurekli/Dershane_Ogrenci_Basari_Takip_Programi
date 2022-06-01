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
    public partial class anasayfa : Form
    {
        public anasayfa()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            giriş_ekranı frm = new giriş_ekranı();
            frm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            ÜyeOlmak frm = new ÜyeOlmak();
            frm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hakkımda frm = new Hakkımda();
            frm.Show();
            this.Hide();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            baglantiAcKapa();
        }
    }
}
