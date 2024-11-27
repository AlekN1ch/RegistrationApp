using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationApp
{
    public partial class Form2 : Form
    {
        public static int yearStonks;
   public int prod, price, stonks;
        public bool prognozAcces;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Start();
            
           
            
        }
        public void Start()
        {
        }
        public void Test(TextBox one, TextBox two, TextBox thr)
        {
            if (one.Text == string.Empty || two.Text == string.Empty)
            {
                thr.Text = "Поля пусты";
                
            }
            else
            {
                try
                {
                    prod = int.Parse(one.Text);
                    price = int.Parse(two.Text);
                    stonks = prod * price;
                    thr.Text = stonks.ToString();
                    yearStonks += stonks;
                    
                }
                catch
                {
                    MessageBox.Show("Поля предназначенны для ввода чисел");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Test(textBox1,textBox2,textBox3);
            Test(textBox6, textBox5, textBox4);
            Test(textBox9, textBox8, textBox7);
            Test(textBox12, textBox11, textBox10);
            Test(textBox15, textBox14, textBox13);
            Test(textBox18, textBox17, textBox16);
            Test(textBox21, textBox20, textBox19);
            Test(textBox24, textBox23, textBox22);
            Test(textBox27, textBox26, textBox25);
            Test(textBox30, textBox29, textBox28);
            Test(textBox33, textBox32, textBox31);
            Test(textBox36, textBox35, textBox34);


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
