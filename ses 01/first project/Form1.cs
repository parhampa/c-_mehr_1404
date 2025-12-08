using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 5;
            int c = a / b;
            MessageBox.Show(a.ToString());
            MessageBox.Show(b.ToString());
            MessageBox.Show(c.ToString());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 5;
            int c = a / b;

            MessageBox.Show(a.ToString()+"/"+b.ToString()+ "=" + c.ToString());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int tst;
            if(int.TryParse(textBox1.Text,out tst) == false)
            {
                MessageBox.Show("please check first input");
                return;
            }
            if (int.TryParse(textBox2.Text, out tst) == false)
            {
                MessageBox.Show("please check second input");
                return;
            }
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = a + b;
            textBox3.Text = c.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int tst;
            if (int.TryParse(textBox1.Text, out tst) == false)
            {
                MessageBox.Show("please check first input");
                return;
            }
            if (int.TryParse(textBox2.Text, out tst) == false)
            {
                MessageBox.Show("please check second input");
                return;
            }
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = a - b;
            textBox3.Text = c.ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int tst;
            if (int.TryParse(textBox1.Text, out tst) == false)
            {
                MessageBox.Show("please check first input");
                return;
            }
            if (int.TryParse(textBox2.Text, out tst) == false)
            {
                MessageBox.Show("please check second input");
                return;
            }
            decimal a = int.Parse(textBox1.Text);
            decimal b = int.Parse(textBox2.Text);
            decimal c = a / b;
            textBox3.Text = c.ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int tst;
            if (int.TryParse(textBox1.Text, out tst) == false)
            {
                MessageBox.Show("please check first input");
                return;
            }
            if (int.TryParse(textBox2.Text, out tst) == false)
            {
                MessageBox.Show("please check second input");
                return;
            }
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = a * b;
            textBox3.Text = c.ToString();
        }
    }
}
