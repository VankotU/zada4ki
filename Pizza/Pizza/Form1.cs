using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typePizza = comboBox1.Text;
            string sizePizza = "";
            string extras = "";
            if (typePizza == "")
            {
                MessageBox.Show("Ne si vuvel pizza!");
            }
            if (rb_Golqma.Checked)
            {
                sizePizza = "Goqlma";
            }
            if (rb_Sredna.Checked)
            {
                sizePizza = "Sredna";
            }
            if (rb_Malka.Checked)
            {
                sizePizza = "Malka";
            }
            if (cb_Ketchup.Checked)
            {
                extras = cb_Ketchup.Text;
            }
            if (cb_Mayoneza.Checked)
            {
                extras = cb_Mayoneza.Text;
            }
            if (cb_Gorchica.Checked)
            {
                extras = cb_Gorchica.Text;
            }
            if (sizePizza == "")
            {
                MessageBox.Show("Ne si vuvel razmer na picata!");
                rb_Malka.Checked = true;
                return;
            }
            if (string.IsNullOrEmpty(extras))
            {
                extras = "Nqma dobavki";
            }
            DialogResult result = MessageBox.Show($"Vie izbrahte {sizePizza} pica {typePizza} s dobavki - {extras}, Potvurjdavate li?","Zaqvka za poruchka", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Izprateno");
                Application.Restart();
            }
        }
    }
}
