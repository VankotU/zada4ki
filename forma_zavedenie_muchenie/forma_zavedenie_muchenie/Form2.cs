using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forma_zavedenie_muchenie
{
    public partial class Form2 : Form
    {
        public string batio { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cenorazpis forma = new cenorazpis();
            

        }
    }
}
