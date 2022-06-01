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
using System.Data;

namespace dershane_öğrenci_başarı_takip_programı_v1._0
{
    public partial class giriş_ekranı : Form
    {
        metot mtt = new metot();
        public giriş_ekranı()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=dershane;Uid=root;Pwd=ardayurekli2006;");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            anasayfa frm = new anasayfa();
            frm.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (mtt.kullanici_kontrol(comboUyeler.Text, txtparola.Text) == 1)
            {
                MessageBox.Show("Giriş Başarılı", "Bilgilendirme Ekranı", MessageBoxButtons.OK);

                Öğrenci_İşlemleri bilgi = new Öğrenci_İşlemleri();
                bilgi.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("hata");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ÜyeOlmak frm = new ÜyeOlmak();
            frm.Show();
            this.Hide();
        }
    }
}
