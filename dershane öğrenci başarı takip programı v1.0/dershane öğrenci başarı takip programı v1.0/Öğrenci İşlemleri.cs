using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dershane_öğrenci_başarı_takip_programı_v1._0
{
    public partial class Öğrenci_İşlemleri : Form
    {
        public Öğrenci_İşlemleri()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            anasayfa frm = new anasayfa();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             öğrenciekleme2 frm = new öğrenciekleme2();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SınavEkle frm = new SınavEkle();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            öğrenciListele frm = new öğrenciListele();
            frm.Show();
            this.Hide();
        }
    }
}
