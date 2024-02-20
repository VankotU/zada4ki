using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_poruchka_Click(object sender, EventArgs e)
        {
            string typePizza=comboBox1.Text;
            string sizePizza="";
            string extras="";

            /*if (rb_margarita.Checked)
            {
                typePizza = "Margarita";
            }
            if (rb_kaprichoza.Checked)
            {
                typePizza = "Kaprichoza";
            }
            if (rb_kalcone.Checked)
            {
                typePizza = "Kalcone";
            }
            if (rb_kutro_stadjone.Checked)
            {
                typePizza = "Kuatro stadhone";
            }
            if (rb_pep.Checked)
            {
                typePizza = "Pepperoni";
            }
            if (rb_havaiska.Checked)
            {
                typePizza = "Havaiska";
            }
            if (rb_kf.Checked)
            {
                typePizza = "Kuatro formadjo";
            }
            if (rb_salsiche.Checked)
            {
                typePizza = "Salsiche";
            }
            if (rb_deep_dish.Checked)
            {
                typePizza = "Deep dish";
            }*/

            if (rb_malka.Checked)
            {
                sizePizza="malka";
            }
            if (rb_sredna.Checked)
            {
                sizePizza="sredna";
            }
            if (rb_golqma.Checked)
            {
                sizePizza="golqma";
            }

            if (cb_chubrika.Checked)
            {
                extras = cb_chubrika.Text;
            }
           /* else
            {
                extras ="";
            }*/

            if (cb_kechup.Checked)
            {
                extras = cb_kechup.Text;
            }
           /* else
            {
                extras ="";
            }*/

            if (cb_liuto.Checked)
            {
                extras = cb_liuto.Text;
            }
           /* else
            {
                extras ="";
            }*/

            if (cb_maioneza.Checked)
            {
                extras = cb_maioneza.Text;
            }
            /*else
            {
                extras ="";
            }*/

            if (cb_parmezan.Checked)
            {
                extras = cb_parmezan.Text;
            }
            /*else 
            {
                extras ="";
            }*/

            if (sizePizza=="")
            {
                MessageBox.Show("Ne si vuvel razmer na picata");
                rb_malka.Checked = true;
                return;
            }
            if (typePizza=="")
            {
                MessageBox.Show("Ne si vuvel pizza");
                rb_margarita.Checked=true;
                return;
            }
            if (string.IsNullOrEmpty(extras))
            {
                extras="nqma podpravki";
            }

            DialogResult result = MessageBox.Show($"Vie izbrahte {sizePizza} pica {typePizza}, Potvurjdavate li?","Potvurjdavane",MessageBoxButtons.YesNoCancel);

            if (result==DialogResult.Yes)
            {
                MessageBox.Show("Izprateno");
                Application.Restart();
            }
            if (result==DialogResult.No)
            {
                Application.Restart();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
