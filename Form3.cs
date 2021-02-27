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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            switch (s)
            {
                case "Бунин":
                    textBox2.Text = "Здравствуйте, Иван Евгеньевич";
                    break;
                case "Вергеева":
                    textBox2.Text = "Здравствуйте, Анастасия Олеговна";
                    break;
                case "Ефремов":
                    textBox2.Text = "Здравствуйте, Лев Владимирович";
                    break;
                case "Зуева":
                    textBox2.Text = "Здравствуйте, Анна Васильевна";
                    break;
                case "Иванов":
                    textBox2.Text = "Здравствуйте, Марк Вадимович";
                    break;
                case "Мельникова":
                    textBox2.Text = "Здравствуйте, Екатерина Андреевна";
                    break;
                case "Панов":
                    textBox2.Text = "Здравствуйте, Кирилл Эдуардович";
                    break;
                case "Таверова":
                    textBox2.Text = "Здравствуйте, Елизавета Игоревна";
                    break;
                case "Такенова":
                    textBox2.Text = "Здравствуйте, Дана Жакслыковна";
                    break;
                case "Полупанова":
                    textBox2.Text = "Здравствуйте, Екатерина Сергеевна";
                    break;
                default:
                    textBox2.Text = "Извините, мы не знакомы";
                    break;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Frm = new Form4();
            Frm.ShowDialog();
        }
    }
}
