using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_klas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmb_pizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_pizza.Text == "Kaprichoza")
            {
                pictureBox1.Image = Image.FromFile("OI.jpg");
            }
            if (cmb_pizza.Text == "Havaiska")
            {
                pictureBox1.Image = Image.FromFile("hawai.jpg");
            }
            if (cmb_pizza.Text == "Kuatro stadjoe")
            {
                pictureBox1.Image = Image.FromFile("cuatro.jpg");
            }
            if (cmb_pizza.Text == "Formadjo")
            {
                pictureBox1.Image = Image.FromFile("formaggio.jpg");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string size = "";
            string payment = "";
            string extras = "";

            if (rb_big.Checked)
            {
                size = rb_big.Text;
            }
            if (rb_small.Checked)
            {
                size = rb_small.Text;
            }
            if (rb_family.Checked)
            {
                size = rb_family.Text;
            }

            if (rb_card.Checked)
            {
                payment = rb_card.Text;
            }
            if (rb_cash.Checked)
            {
                payment = rb_cash.Text;
            }
        }
    }
}
