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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (double x = 1; x <= 3; x *= 1.1)
            {
                listBox1.Items.Add(Convert.ToString(x));
            }

            for (double x = 0; x <= 2 * Math.PI; x += 0.1)
            { // Задает цикл по x,
              // начальное условие 0, конечное 2*pi, приращение 0.1
                double y = Math.Sin(x); // вычисление значения функции
                int n = dataGridView1.Rows.Add();// Добавление строки в
                                                 // dataGridView n – номер добавленной строки
                dataGridView1.Rows[n].Cells[0].Value = Convert.ToString(x); // Запол-
                                                                            // нение ячейки dataGridView, номер столбца начинается с 0
                dataGridView1.Rows[n].Cells[1].Value = Convert.ToString(y);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double s = 0, x = 1, eps;
            eps = Convert.ToDouble(textBox1.Text);
            do
            {
                s += 1 / x;
                x *= 2;
            } while (1 / x > eps / 2);
            textBox2.Text = Convert.ToString(s);
        }
    }
}
