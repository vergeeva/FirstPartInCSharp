using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Первая_пара
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            try
            { 
                a = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка в первом слагаемом, исправьте ее");
                return;
            }
            try
            {
                b = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка во втором слагаемом, исправьте ее");
                return;
            }
            c = a + b;
            textBox3.Text = Convert.ToString(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Frm = new Form4();
            Frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, c;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка в уменьшаемом, исправьте ее");
                return;
            }
            try
            {
                b = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка в вычитаемом, исправьте ее");
                return;
            }
            c = a - b;
            textBox3.Text = Convert.ToString(c);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double a, b, c;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка в первом множителе, исправьте ее");
                return;
            }
            try
            {
                b = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка во втором множителе, исправьте ее");
                return;
            }
            c = a * b;
            textBox3.Text = Convert.ToString(c);
        }

        private void button5_Click(object sender, EventArgs e)
        { 
            double a, b, c;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка в делимом, исправьте ее");
                return;
            }
            try
            {
                b = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка во втором делителе, исправьте ее");
                return;
            }

            if (b != 0)
            {
                c = a / b;
                textBox3.Text = Convert.ToString(c);
            }
            else 
            {
                MessageBox.Show("На ноль делить нельзя");
                textBox2.Text = "";
            }


        }
    }
}

