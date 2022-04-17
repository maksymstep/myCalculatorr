using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalculatorr
{
    public partial class Form1 : Form
    {
        long resmemory = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
            textBox1.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
            textBox1.Text += "%";
            textBox1.Focus();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
            textBox1.Text += button16.Text;
            textBox1.Focus();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
            textBox1.Text += button15.Text;
            textBox1.Focus();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
            textBox1.Text += button14.Text;
            textBox1.Focus();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
            textBox1.Text += buttonDiv.Text;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
            textBox1.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
            textBox1.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
            textBox1.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
            textBox1.Focus();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
                return;
            resmemory = 0;
            textBox2.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
                return;
            resmemory += Convert.ToInt64(textBox2.Text);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = resmemory.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            resmemory = 0;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            textBox1.Focus();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
            textBox1.Text += button22.Text;
            textBox1.Focus();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
            textBox1.Text += button21.Text;
            textBox1.Focus();
        }
    }
}
