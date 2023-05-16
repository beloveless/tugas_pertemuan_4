using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tugas_Pertemuan_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text =="admin" && password.Text == "adminpass")
            {
                MessageBox.Show("Kamu berhasil login");
                this.Hide();
                var myForm3 = new Form3();
                myForm3.Closed += (s, args) => this.Close();
                myForm3.Show();

            }
            else if (username.Text == "user" || password.Text == "userpass")
            {
                MessageBox.Show("Kamu berhasil login");
                this.Hide();
                var myForm2 = new Form2();
                myForm2.Closed += (s, args) => this.Close();
                myForm2.Show();
            }
            else if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Silakan isi form login terlebih dahulu.");
            }
            else
            {
                MessageBox.Show("Username atau Password Anda salah.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}