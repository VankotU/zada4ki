using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forma_zavedenie_muchenie
{
    public partial class cenorazpis : Form
    {
        public cenorazpis()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cenorazpis_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double menta = double.Parse(label37.Text);
            double shopska = double.Parse(label20.Text);
            double turshiq = double.Parse(label21.Text);
            double mlechna = double.Parse(label22.Text);
            double kafe = double.Parse(label23.Text);
            double chai = double.Parse(label24.Text);
            double greqna = double.Parse(label25.Text);
            double frape = double.Parse(label26.Text);
            double gazirana = double.Parse(label27.Text);
            double voda = double.Parse(label28.Text);
            double kebapche = double.Parse(label29.Text);
            double kartof = double.Parse(label30.Text);
            double agneshko = double.Parse(label31.Text);
            double torta = double.Parse(label32.Text);
            double sladoled = double.Parse(label33.Text);
            double krem = double.Parse(label34.Text);
            double whiskey = double.Parse(label35.Text);
            double vodka = double.Parse(label36.Text);
            double shopska1 = double.Parse(textBox1.Text);
            double turshiq1 = double.Parse(textBox2.Text);
            double mlechna1 = double.Parse(textBox3.Text);
            double kafe1 = double.Parse(textBox4.Text);
            double chai1 = double.Parse(textBox5.Text);
            double greqna1 = double.Parse(textBox6.Text);
            double frape1 = double.Parse(textBox7.Text);
            double gazirana1 = double.Parse(textBox8.Text);
            double voda1 = double.Parse(textBox9.Text);
            double kebapche1 = double.Parse(textBox10.Text);
            double kartof1 = double.Parse(textBox11.Text);
            double agneshko1 = double.Parse(textBox12.Text);
            double torta1 = double.Parse(textBox13.Text);
            double sladoled1 = double.Parse(textBox15.Text);
            double krem1 = double.Parse(textBox14.Text);
            double whiskey1 = double.Parse(textBox16.Text);
            double vodka1 = double.Parse(textBox17.Text);
            double menta1 = double.Parse(textBox18.Text);
            double formula4 = torta * torta1 + sladoled * sladoled1 + krem * krem1 + whiskey * whiskey1;
            double formula =  chai * chai1 + greqna * greqna1 + frape * frape1 + gazirana * gazirana1;
            double formula3 = shopska * shopska1 + turshiq * turshiq1 + mlechna * mlechna1 + kafe * kafe1;
             double formula2 = voda * voda1 + kebapche * kebapche1 + kartof * kartof1 + agneshko * agneshko1;
            double formula5 = vodka * vodka1 + menta * menta1; 
            MessageBox.Show("duljite:" + (formula+formula2+formula3+formula4+formula5));


        }

        private void label20_Click(object sender, EventArgs e)
        {
            
        }

        private void label21_Click(object sender, EventArgs e)
        {
            
        }

        private void label22_Click(object sender, EventArgs e)
        {
           
        }

        private void label23_Click(object sender, EventArgs e)
        {
         
        }

        private void label24_Click(object sender, EventArgs e)
        {
            
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {
            
        }

        private void label27_Click(object sender, EventArgs e)
        {
            
        }

        private void label28_Click(object sender, EventArgs e)
        {
            
        }

        private void label29_Click(object sender, EventArgs e)
        {
            
        }

        private void label30_Click(object sender, EventArgs e)
        {
            
        }

        private void label31_Click(object sender, EventArgs e)
        {
            
        }

        private void label32_Click(object sender, EventArgs e)
        {
           
        }

        private void label33_Click(object sender, EventArgs e)
        {
            
        }

        private void label34_Click(object sender, EventArgs e)
        {
            
        }

        private void label35_Click(object sender, EventArgs e)
        {
            
        }

        private void label36_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString()=="кеш")
            {

                TextBox textbox23 = new TextBox();

            }
        }
    }
}
