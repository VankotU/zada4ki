using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
        }

        private void btn_InsertFirst_Click(object sender, EventArgs e)
        {
            int index = listBox1.Items.Count / 2;
            //celochisleno delenie 7/2=3!
            listBox1.Items.Insert(index,textBox1.Text);
        }

        private void btn_RemoveFirst_Click(object sender, EventArgs e)
        {
                listBox1.Items.RemoveAt(0);
        }

        private void btn_RemoveLast_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
        }

        private void btn_RemoveText_Click(object sender, EventArgs e)
        {
            /* if(listBox1.Items.Contains(textBox1.Text))
             {
                 listBox1.Items.Remove(textBox1.Text);
             }
             else
             {
                 MessageBox.Show("Nqama element za iztrivane");
             }*/

            while (listBox1.Items.Contains(textBox1.Text))
            {
                listBox1.Items.Remove(textBox1.Text);
            }

        }
    }
}
