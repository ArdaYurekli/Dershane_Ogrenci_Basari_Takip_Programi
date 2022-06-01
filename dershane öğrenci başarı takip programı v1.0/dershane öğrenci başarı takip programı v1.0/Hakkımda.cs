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
    public partial class Hakkımda : Form
    {
        public Hakkımda()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            anasayfa frm = new anasayfa();
            frm.Show();
            this.Hide();
        }
    }
}
