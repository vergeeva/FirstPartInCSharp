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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ComplexDecision.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Size = new Size(376, 459);
            ComplexDecision.Hide();

            double a, b, c, d, x1, x2;
            try
            {
                a = Convert.ToDouble(A.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка в коэффициенте А, исправьте ее");
                return;
            }
            try
            {
                b = Convert.ToDouble(B.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка в коэффициенте B, исправьте ее");
                return;
            }
            try
            {
                c = Convert.ToDouble(C.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка в коэффициенте C, исправьте ее");
                return;
            }
            d = b * b - 4 * a * c;
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                X1.Text = Convert.ToString(x1);
                X2.Text = Convert.ToString(x2);
            }
            else if (d == 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                X1.Text = Convert.ToString(x1);
                X2.Text = "";
            }
            else
            {
                X1.Text = "Решений нет";
                X2.Text = "";
                x1 = (-b ) / (2 * a);
                part1.Text = Convert.ToString(x1);
                x2 = Math.Sqrt((-d) / (2 * a));
                part2.Text = Convert.ToString(x2);
                Size = new Size(645, 459);
                ComplexDecision.Show();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form Frm = new Form3();
            Frm.ShowDialog();
        }
    }
}
