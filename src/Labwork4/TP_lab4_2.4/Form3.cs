using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using TP_lab4_2_class;

namespace TP_lab4_2._4
{
    public partial class Form3 : Form
    {   //размерность по координате Х
        public int X;
        //размерность по координате У
        public int Y;
        //условно недостижимое число
        private int INF = 999999999;
        //массив
        public int[,] array = new int[500, 500];
        //проверка на существоание массива
        public bool arrayExist = false;
        //экземпляр класса Tmas
        Tmas c = new Tmas();
        public Form3()
        {
            InitializeComponent();
        }
        //создание массива
        public void getArr(string x, string y, string low, string up)
        {
            array = c.getArr(x, y, low, up);
            X = c.x;
            Y = c.y;
            if (array[0, 0] == INF)
            {
                if (array[1,1] == 0)
                {
                    MessageBox.Show("Количество столбцов не соответсвует формату", "Error");
                }
                else if (array[1, 1] == 1)
                {
                     MessageBox.Show("Количество рядков выходит за границы (0,500)", "Error");
                }
                else if (array[1, 1] == 2)
                {
                    MessageBox.Show("Количество столбцов не соответсвует формату", "Error");
                }
                else if (array[1, 1] == 3)
                {
                    MessageBox.Show("Количество рядков выходит за границы (0,500)", "Error");
                }
                else if (array[1, 1] == 4)
                {
                    MessageBox.Show("Нижняя граница не соответсвует формату", "Error");
                }
                else if (array[1, 1] == 5)
                {
                    MessageBox.Show("Нижняя граница выходит за границы (0,100)", "Error");
                }
                else if (array[1, 1] == 6)
                {
                    MessageBox.Show("Верхняя граница не соответсвует формату", "Error");
                }
                else if (array[1, 1] == 7)
                {
                    MessageBox.Show("Верхняя граница выходит за границы (0,100)", "Error");
                }
                else if (array[1, 1] == 8)
                {
                    MessageBox.Show("Нижняя граница больше верхей границы", "Error");
                }
                else if (array[1,1] == 10)
                {
                    MessageBox.Show("1`2345", "Error");
                }
            }
            else
            {
                arrayExist = true;
                getData(array);
            }
        }
        //заполнение dataGridView1 массивом
        public void getData(int[,] arrayForData)
        {
            dataGridView1.RowCount = X;
            dataGridView1.ColumnCount = Y;
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arrayForData[i, j];
                }
            }
        }
        //первая операция
        public void op1()
        {
            if (arrayExist)
            {
                string info = c.operation1();
                MessageBox.Show(info, "Result");
            }
            else
            {
                MessageBox.Show("Array do not exist", "Error");
            }
        }
        //вторая операция
        public void op2()
        {
            if (arrayExist)
            {
                array = c.operation2();
                getData(array);
            }
            else
            {
                MessageBox.Show("Array do not exist", "Error");
            }
        }
        //третья операция
        public void op3(string C)
        {
            if (arrayExist)
            {
                array = c.operation3(C);
                if (array[0, 0] == INF)
                {
                    MessageBox.Show("C incorect", "Error");
                }
                else
                {
                    getData(array);
                }
            }
            else
            {
                MessageBox.Show("Array do not exist", "Error");
            }
        }


        //закрытие формы
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
