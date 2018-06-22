using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformasi
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program ini dibuat untuk memenuhi tugas akhir [ Aljabar Geometri ]\n\nNama\t\t:: Muhammad Thomas Fadhila Yahya\nKelas\t\t:: TI15Hx\nNPM\t\t:: 15312574\nDosen Pengampu\t:: Very Hendra Saputra, S.Si., M.Pd\nJurusan\t\t:: Teknik Informatika\n\n\t\t:: Perguruan Tinggi Teknokrat ::", "Tentang");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Form4();
            form4.Closed += (s, args) => this.Close();
            form4.ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
