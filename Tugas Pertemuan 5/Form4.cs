using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tugas_Pertemuan_5
{
    public partial class Form4 : Form
    {
        private int buy, menuprice, ukprice, i;
        private String menu, size, sugarlvl, icelvl;
        string s;
        String[] toppings = { "Bubble", "Grass Jelly", "Nata de coco", "Whipped cream", "Choco chips", "Oreo" };

        int[] topprice = { 3000, 3500, 2500, 1000, 1500, 2000 };

        String[] top_buy = new String[6];
        int[] top_pricey = new int[6];

        public Form4()
        {
            InitializeComponent();
        }

        private void expresso_CheckedChanged(object sender, EventArgs e)
        {
            if (expresso.Checked)
            {
                latte.Checked = false;
                cappucino.Checked = false;
                menuprice = 10000;
            }
        }

        private void latte_CheckedChanged(object sender, EventArgs e)
        {
            if (latte.Checked)
            {
                expresso.Checked = false;
                cappucino.Checked = false;
                menuprice = 15000;
            }
        }

        private void cappucino_CheckedChanged(object sender, EventArgs e)
        {
            if (cappucino.Checked)
            {
                latte.Checked = false;
                expresso.Checked = false;
                menuprice = 12000;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (expresso.Checked)
            {
                menuprice = 10000;
            }

            if (latte.Checked)
            {
                menuprice = 15000;
            }

            if (cappucino.Checked)
            {
                menuprice = 12000;
            }
            buy += menuprice;


            if (radioButton1.Checked == true)
            {
                size = "Medium";
                ukprice = 0;
            }
            if (radioButton2.Checked == true)
            {
                size = "Large";
                ukprice = 3000;
            }
            buy += ukprice;

            sugarlvl = comboBox1.Text;
            icelvl = comboBox2.Text;

            if (checkedListBox1.CheckedItems.Count != 0)
            {
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    if (item == "Bubble")
                    {
                        i = 0;
                    }
                    else if (item == "Grass Jelly")
                    {
                        i = 1;
                    }
                    else if (item == "Nata de coco")
                    {
                        i = 2;
                    }
                    else if (item == "Whipped cream")
                    {
                        i = 3;
                    }
                    else if (item == "Choco chip")
                    {
                        i = 4;
                    }
                    else if (item == "Oreo")
                    {
                        i = 5;
                    }
                    buy += topprice[i];
                    s = s + item.ToString() + " : " + " + " + topprice[i] + "\n";
                }


            }
            else

            {
                MessageBox.Show("Silahkan pilih menu Anda dahulu.");
            }

            MessageBox.Show("| PESANAN ANDA |" +
                        "\n\nHarga Pesanan : " + menuprice +
                        "\nUkuran " + size + " : " + " + " + ukprice +
                        "\nSugar Level " + sugarlvl + " : + 0" +
                        "\nIce Level " + icelvl + " : + 0" +
                        "\nTopping : \n" + s +
                        "\nTotal harga = " + buy +
                        "\n\nTerima kasih. Order berhasil :)");

            buy = 0;
            menu = s = sugarlvl = icelvl = size = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
