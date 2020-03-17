using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            checkvalue();

            if (radioButton1.Checked == true)
            {
                double sum;
                sum= int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                MessageBox.Show("sum: " + sum);         
            }

            else if (radioButton2.Checked == true)
            {
                double product;
                product = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                MessageBox.Show("product: " + product);
            }

            else if (radioButton3.Checked == true)
            {
                double quotient;
                quotient = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
                MessageBox.Show("quotient: " + quotient);
            }

            else if (radioButton4.Checked == true)
            {
                double difference;
                difference = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                MessageBox.Show("difference: " + difference);
            }

        }

        public void checkvalue()
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter an integer");
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please enter an integer");
                textBox2.Focus();
            }
        }

    }
}
