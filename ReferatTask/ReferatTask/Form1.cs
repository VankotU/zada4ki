using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferatTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtBox_Number.Text);
            if (number >= 0 && number <= 100 && number % 10 == 0)
            {
                progressBar1.Value = number;
            }
            else
            {
                MessageBox.Show("Невалидно число. Моля, въведете число между 0 и 100, което се дели на 10 без остатък.");
                txtBox_Number.Focus();
                return;
            }
        }
    }
}
