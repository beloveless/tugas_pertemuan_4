using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Pertemuan_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm1 = new Form1();
            myForm1.Closed += (s, args) => this.Close();
            myForm1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kasirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm4 = new Form4();
            myForm4.Closed += (s, args) => this.Close();
            myForm4.Show();
        }
    }
}
