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
        public string lek { get; set; }


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

        double menta ;
        double shopska ;
        double turshiq;
        double mlechna;
        double kafe;
        double chai;
        double greqna;
        double frape;
        double gazirana;
        double voda;
        double kebapche;
        double kartof;
        double agneshko;
        double torta;
        double sladoled;
        double krem;
        double whiskey;
        double vodka;
        double shopska1;
        double turshiq1;
        double mlechna1;
        double kafe1;
        double chai1;
        double greqna1;
        double frape1;
        double gazirana1;
        double voda1;
        double kebapche1;
        double kartof1;
        double agneshko1;
        double torta1;
        double sladoled1;
        double krem1;
        double whiskey1;
        double vodka1;
        double menta1;
        double formula4 ;
        double formula;
        double formula3;
        double formula2;
        double formula5;
        double bakshish;
        private void button1_Click(object sender, EventArgs e)
        {
             menta = double.Parse(label37.Text);
             shopska = double.Parse(label20.Text);
             turshiq = double.Parse(label21.Text);
             mlechna = double.Parse(label22.Text);
             kafe = double.Parse(label23.Text);
             chai = double.Parse(label24.Text);
             greqna = double.Parse(label25.Text);
             frape = double.Parse(label26.Text);
             gazirana = double.Parse(label27.Text);
             voda = double.Parse(label28.Text);
             kebapche = double.Parse(label29.Text);
             kartof = double.Parse(label30.Text);
             agneshko = double.Parse(label31.Text);
             torta = double.Parse(label32.Text);
             sladoled = double.Parse(label33.Text);
             krem = double.Parse(label34.Text);
             whiskey = double.Parse(label35.Text);
             vodka = double.Parse(label36.Text);
             shopska1 = double.Parse(textBox1.Text);
             turshiq1 = double.Parse(textBox2.Text);
             mlechna1 = double.Parse(textBox3.Text);
             kafe1 = double.Parse(textBox4.Text);
             chai1 = double.Parse(textBox5.Text);
             greqna1 = double.Parse(textBox6.Text);
             frape1 = double.Parse(textBox7.Text);
             gazirana1 = double.Parse(textBox8.Text);
             voda1 = double.Parse(textBox9.Text);
             kebapche1 = double.Parse(textBox10.Text);
             kartof1 = double.Parse(textBox11.Text);
             agneshko1 = double.Parse(textBox12.Text);
             torta1 = double.Parse(textBox13.Text);
             sladoled1 = double.Parse(textBox15.Text);
             krem1 = double.Parse(textBox14.Text);
             whiskey1 = double.Parse(textBox16.Text);
             vodka1 = double.Parse(textBox17.Text);
             menta1 = double.Parse(textBox18.Text);
             formula4 = torta * torta1 + sladoled * sladoled1 + krem * krem1 + whiskey * whiskey1;
             formula =  chai * chai1 + greqna * greqna1 + frape * frape1 + gazirana * gazirana1;
             formula3 = shopska * shopska1 + turshiq * turshiq1 + mlechna * mlechna1 + kafe * kafe1;
              formula2 = voda * voda1 + kebapche * kebapche1 + kartof * kartof1 + agneshko * agneshko1;
             formula5 = vodka * vodka1 + menta * menta1;
             bakshish =double.Parse(textBox19.Text);
            if ((formula + formula2 + formula3 + formula4 + formula5) > 100)
            {
                MessageBox.Show("Сметката е над 100 лв. премахни нещо! ");
            }
            else
            {
               MessageBox.Show("duljite:" + (formula+formula2+formula3+formula4+formula5+bakshish)); 
            }

            


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
          
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }
        public static string value1 = " ";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            value1 = textBox1.Text;
            //if ()
            {

            }
            Form2 forma = new Form2();
            forma.Closed += (s, args) => this.Close();
            forma.Show();

            forma.BringToFront();
            forma.batio = textBox1.Text;
            
           
            
        }

        private void label40_Click(object sender, EventArgs e)
        {
            menta = double.Parse(label37.Text);
            shopska = double.Parse(label20.Text);
            turshiq = double.Parse(label21.Text);
            mlechna = double.Parse(label22.Text);
            kafe = double.Parse(label23.Text);
            chai = double.Parse(label24.Text);
            greqna = double.Parse(label25.Text);
            frape = double.Parse(label26.Text);
            gazirana = double.Parse(label27.Text);
            voda = double.Parse(label28.Text);
            kebapche = double.Parse(label29.Text);
            kartof = double.Parse(label30.Text);
            agneshko = double.Parse(label31.Text);
            torta = double.Parse(label32.Text);
            sladoled = double.Parse(label33.Text);
            krem = double.Parse(label34.Text);
            whiskey = double.Parse(label35.Text);
            vodka = double.Parse(label36.Text);
            shopska1 = double.Parse(textBox1.Text);
            turshiq1 = double.Parse(textBox2.Text);
            mlechna1 = double.Parse(textBox3.Text);
            kafe1 = double.Parse(textBox4.Text);
            chai1 = double.Parse(textBox5.Text);
            greqna1 = double.Parse(textBox6.Text);
            frape1 = double.Parse(textBox7.Text);
            gazirana1 = double.Parse(textBox8.Text);
            voda1 = double.Parse(textBox9.Text);
            kebapche1 = double.Parse(textBox10.Text);
            kartof1 = double.Parse(textBox11.Text);
            agneshko1 = double.Parse(textBox12.Text);
            torta1 = double.Parse(textBox13.Text);
            sladoled1 = double.Parse(textBox15.Text);
            krem1 = double.Parse(textBox14.Text);
            whiskey1 = double.Parse(textBox16.Text);
            vodka1 = double.Parse(textBox17.Text);
            menta1 = double.Parse(textBox18.Text);
            formula4 = torta * torta1 + sladoled * sladoled1 + krem * krem1 + whiskey * whiskey1;
            formula = chai * chai1 + greqna * greqna1 + frape * frape1 + gazirana * gazirana1;
            formula3 = shopska * shopska1 + turshiq * turshiq1 + mlechna * mlechna1 + kafe * kafe1;
            formula2 = voda * voda1 + kebapche * kebapche1 + kartof * kartof1 + agneshko * agneshko1;
            formula5 = vodka * vodka1 + menta * menta1;
            bakshish = double.Parse(textBox19.Text);
if ((formula + formula2 + formula3 + formula4 + formula5) > 100)
            {
                MessageBox.Show("Сметката е над 100 лв. премахни нещо! ");
            }
          else
            {
label40.Text="duljite:" + (formula + formula2 + formula3 + formula4 + formula5 + bakshish);
            }
            
            
        }
    }
}
