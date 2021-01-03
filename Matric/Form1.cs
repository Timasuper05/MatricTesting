using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int r = Convert.ToInt16(numericUpDown1.Value);
            //создаём
            int[,] Matrix = new int[r, r];

            //заполняем случайными числами от 0 до 100
            Random random = new Random();
            int rand;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    rand = random.Next(1,3);
                    if(rand == 2) { rand = 6; } else { rand = 8; }
                    
                    Matrix[i, j] = rand;
                }
            }
            string sum = "";
            //Выводим матрицу на экран
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    sum+= Matrix[i, j];
                }
                
                listBox1.Items.Add(sum);
                sum = "";
            }
            
        }
    }
    }

