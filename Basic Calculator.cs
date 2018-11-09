using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double res, val, num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
          num1 = Convert.ToDouble(textBox1.Text);

            val = 1;

            textBox1.Clear();

          
        }

        private void button5_Click(object sender, EventArgs e)
        {
             num1 = Convert.ToDouble(textBox1.Text);

            val = 2;

            textBox1.Clear();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
             num1 = Convert.ToDouble(textBox1.Text);

            val = 3;

            textBox1.Clear();

        }

        private void button13_Click(object sender, EventArgs e)
        {
             num1 = Convert.ToDouble(textBox1.Text);

            val = 4;

            textBox1.Clear();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);

            switch(val)
            {
                case 1: res = num1 + num2;
                    break;
                case 2: res = num1 - num2;
                    break;
                case 3: res = num1 * num2;
                    break;
                case 4:
                    {
                        if(num1 == 0)
                        {
                            MessageBox.Show("Division Not Possible");
                        }
                        else
                        {
                            res = num1 / num2;
                        }
                    }
                    break;
            }

            String str = Convert.ToString(res);

            textBox1.Text = str;
        }
    }
}
