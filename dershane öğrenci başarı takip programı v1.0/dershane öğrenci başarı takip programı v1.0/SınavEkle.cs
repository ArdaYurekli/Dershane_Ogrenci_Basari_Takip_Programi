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
    public partial class SınavEkle : Form
    {

        public SınavEkle()
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

        void SınavGetir()
        {
            dt.Clear();
            MySqlDataAdapter adapter =
                new MySqlDataAdapter("Select * from sınav", baglanti);
            adapter.Fill(dt);
            dgSınav.DataSource = dt;
            dgSınav.Columns[0].HeaderText = "Ögrenci Ad";
            dgSınav.Columns[1].HeaderText = "Ögrenci Soyad";
            dgSınav.Columns[2].HeaderText = "Sınav Adı";
            dgSınav.Columns[3].HeaderText = "Sınav Tarihi";
            dgSınav.Columns[4].HeaderText = "Sınav Notu";



        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Öğrenci_İşlemleri frm = new Öğrenci_İşlemleri();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand komut = new MySqlCommand();
                komut.CommandText = "insert into sınav(ÖgrenciAd,ÖgrenciSoyad,SınavAd, SınavTarihi,SınavNotu) " +
                    "values('"+txtadisınav.Text+ "','" + txtsoyadisınav.Text + "','" + txtsınavad.Text + "','" + txtsınavtarih.Text + "','" + txtsınavnotu.Text + "')";
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();
                SınavGetir();
                MessageBox.Show("Veri eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi. Hata : " + hata.Message.ToString());
            }
        }
        string dbcontrol = "Server=localhost;Database=dershane;Uid=root;Pwd=ardayurekli2006";
        private void SınavEkle_Load(object sender, EventArgs e)
        {
           

            baglantiAcKapa();
            SınavGetir();
            
        }

        private void dgSınav_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsınavnotu_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgSınav_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtadisınav.Text = dgSınav.CurrentRow.Cells[0].Value.ToString();
            txtsoyadisınav.Text = dgSınav.CurrentRow.Cells[1].Value.ToString();
            txtsınavad.Text = dgSınav.CurrentRow.Cells[2].Value.ToString();
            txtsınavtarih.Text = dgSınav.CurrentRow.Cells[3].Value.ToString();
            txtsınavnotu.Text = dgSınav.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmdsil = new MySqlCommand();
                cmdsil.Connection = baglanti;
                cmdsil.CommandText = "delete from sınav where ÖgrenciAd='" +
                    txtadiS2.Text + "'";
                int kayitsayisi = cmdsil.ExecuteNonQuery();
                if (kayitsayisi == 0)
                    MessageBox.Show("Silinecek Ögrenci Adı  bulunamadı!", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    SınavGetir(); 
                    MessageBox.Show("Ögrenci başarıyla silindi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi. Hata : " + hata.Message.ToString());
            }
        }

        private void txtadiS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
