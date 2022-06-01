using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace dershane_öğrenci_başarı_takip_programı_v1._0
{
    public partial class öğrenciListele : Form
    {
        public öğrenciListele()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti =
        new MySqlConnection(
            "Server=localhost;Database=dershane;Uid=root;Pwd=ardayurekli2006;"
            );

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Öğrenci_İşlemleri frm = new Öğrenci_İşlemleri();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            }
        string dbcontrol = "Server=localhost;Database=dershane;Uid=root;Pwd=ardayurekli2006";
        private void başarı_Load(object sender, EventArgs e)
        {
            using (var baglan = new MySqlConnection(dbcontrol))
            {
                using (var adap = new MySqlDataAdapter("SELECT * FROM sınav", baglan))
                {
                    try
                    {
                        baglan.Open();
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
    }
        }
}
