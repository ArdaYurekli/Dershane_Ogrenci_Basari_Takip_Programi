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
    public partial class ÜyeOlmak : Form
    {
        public ÜyeOlmak()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text != "" && txtşifre.Text != "")
                try
                {
                    baglanti.Open();
                    MySqlCommand komut = new MySqlCommand();
                    komut.CommandText = "insert into kullanıcılar(K_Ad,şifre)" + "values('" + txtkullaniciadi.Text + "','" +
                         txtşifre.Text + "')";
                    komut.Connection = baglanti;
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarıyla Olundu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    anasayfa geçiş = new anasayfa();
                    geçiş.Show();
                    this.Hide();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Kayıt Olunamadı" + hata.Message.ToString());


                }
            else
                MessageBox.Show("Bos Bırakmayınız");
        }

        private void ÜyeOlmak_Load(object sender, EventArgs e)
        {

        }
    }
}
