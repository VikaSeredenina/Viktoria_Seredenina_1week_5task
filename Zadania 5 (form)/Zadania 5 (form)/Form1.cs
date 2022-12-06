using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadania_5__form_
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double x)
    {
        try
        {
            //если х не попадает в область определения, то генерируется исключение 
            if ((x * x + 2 * x + 1) == 0 || (x * x + 2 * x + 1) < 0) throw new Exception(); //оператор throw создает исключение 
            else return ((3 * x + 4) / (Math.Sqrt(x * x + 2 * x + 1)));
        }
        catch
        {
            throw;
        }
    }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
               double a = double.Parse(textBox1.Text);
              double  b = double.Parse(textBox2.Text);
                double h = double.Parse(textBox3.Text);
                if (a > b)
                {
                    MessageBox.Show("'a' не может быть больше 'b'");
                    return;
                }

             h = double.Parse(textBox3.Text);
                if (h <= 0)
                {
                    MessageBox.Show("Шаг должен быть больше 0!");
                    return;
                }

                for (double i = a; i <= b; i += h)
                    try
                    {
                        richTextBox1.Text += $"y({Math.Round(i, 2)})={Math.Round(f(i), 4)}" + Environment.NewLine;
                    }
                    catch
                    {
                        richTextBox1.Text += $"y({i})=функция не определена" + Environment.NewLine;
                    }
             }

            catch (FormatException)
            {

                MessageBox.Show("Некорректные данные");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Clear();
            textBox2.Text = "";
            textBox2.Clear();
            textBox3.Text = "";
            textBox3.Clear();
            richTextBox1.Text = "";
            richTextBox1.Clear();
        }
    }
}

