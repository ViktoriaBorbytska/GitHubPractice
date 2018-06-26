using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2._4_Lab1
{
    public partial class lab1 : Form
    {

        public lab1()
        {
            InitializeComponent();
        }
        private double num1;
        private double num2;
        private bool needEqual = false;
        //список действий
        public enum actions
        {
            add,
            sub,
            multiply,
            div,
            sin,
            fact,
            sqr
        }
        actions staus;
        public double addFunk(double x, double y)
        {
            return x + y;
        }
        //метод считающий факториал
        public double getFactorial(double num)
        {
            if (num == 0)
            {
                num = 1;
            }
            else
            {
                for (double i = num - 1; i > 0; i--)
                {
                    num = num * i;
                }
            }
            return num;
        }
        //метод проверяющий число на соответствие границе значения
        public bool checkNum(double num)
        {
            if(num > 400000 || num < -200000)
            {
                MessageBox.Show("Число выходит за допустимые рамки!", "Сообщение");
                textBox1.Text = "";
                return false;
            }
            else
            {
                return true;
            }
        }
        //метод проверяющий число на соответсвие шаблону
        public bool formatCheck (string textFromTextBox1)
        {
            string pattern = @"^[+|-]?\d+[\,]?[\d+]{0,3}$";
            Match m = Regex.Match(textFromTextBox1, pattern);
            if(m.Success)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Число не соответсвует формату!", "Сообщение");
                textBox1.Text = "";
                return false;
            }
        }
        //метод запомиающий первое число
        public void defaultActions(actions action)
        {
            if (textBox1.Text != "")
            {
                if (formatCheck(textBox1.Text))
                {
                    if (checkNum(double.Parse(textBox1.Text)))
                    {
                        num1 = double.Parse(textBox1.Text);
                        textBox1.Text = "";
                        label1.Text = "Ввод слогаемых";
                        needEqual = true;
                        staus = action;
                    }
                }
            }
            else
                MessageBox.Show("Введите первое число!", "Сообщение");
        }
        //проводит вычисление базовых функций
        public void getResult (double num2)
        {
            switch (staus)
            {
                case actions.add:
                    textBox1.Text = String.Format("{0:0.###}", (num1 + num2));
                    label1.Text = "Результат:";
                    break;
                case actions.sub:
                    textBox1.Text = String.Format("{0:0.###}", (num1 - num2));
                    label1.Text = "Результат:";
                    break;
                case actions.multiply:
                    textBox1.Text = String.Format("{0:0.###}", (num1 * num2));
                    label1.Text = "Результат:";
                    break;
                case actions.div:
                    if (num2 == 0)
                        MessageBox.Show("Делитель не может быть равен 0!", "Сообщение");
                    else
                    {
                        textBox1.Text = String.Format("{0:0.###}", (num1 / num2));
                        label1.Text = "Результат:";
                    }
                    break;
                default:
                    break;
            }
        }
        //Вызывает метод defaultActions с действием +
        private void add_Click(object sender, EventArgs e)
        {
            defaultActions(actions.add);
        }
        //Вызывает метод defaultActions с действием -
        private void sub_Click(object sender, EventArgs e)
        {
            defaultActions(actions.sub);
        }
        //Вызывает метод defaultActions с действием *
        private void multiply_Click(object sender, EventArgs e)
        {
            defaultActions(actions.multiply);
        }
        //Вызывает метод defaultActions с действием -
        private void div_Click(object sender, EventArgs e)
        {
            defaultActions(actions.div);
        }
        //Вызывает метод getResult со вторым числом
        private void equal_Click(object sender, EventArgs e)
        {
            if (needEqual)
            {
                if (textBox1.Text != "")
                {
                    if (checkNum(double.Parse(textBox1.Text)))
                    {
                        num2 = double.Parse(textBox1.Text);
                        getResult(num2);
                    }
                }
                else
                    MessageBox.Show("Введите второе число!", "Сообщение");
                needEqual = false;
            }
            else
                MessageBox.Show("Применимо только после использования базовых функций(+, -, *, /)", "Сообщение");
        }
        //Считает результат в зависимости от нажатой специальной кнопки (sin, sqrt, fact)
        public void specialActions(actions action)
        {
            if (textBox1.Text != "")
            {
                if (formatCheck(textBox1.Text))
                {
                    if (checkNum(double.Parse(textBox1.Text)))
                    {
                        num1 = double.Parse(textBox1.Text);
                        switch (action)
                        {
                            case actions.sin:
                                textBox1.Text = String.Format("{0:0.###}", Math.Sin(num1));
                                label1.Text = "Результат:";
                                break;
                            case actions.sqr:
                                textBox1.Text = String.Format("{0:0.###}", Math.Sqrt(num1));
                                label1.Text = "Результат:";
                                break;
                            case actions.fact:
                                textBox1.Text = String.Format("{0:0.###}", getFactorial(num1));
                                label1.Text = "Результат:";
                                break;
                        }
                        needEqual = false;
                    }
                }
            }
            else
                MessageBox.Show("Введите первое число!", "Сообщение");
        }
        //Вызывает метод specialActions с действием sqr
        private void square_Click(object sender, EventArgs e)
        {
            specialActions(actions.sqr);  
        }
        //Вызывает метод specialActions с действием sin
        private void sin_Click(object sender, EventArgs e)
        {
            specialActions(actions.sin);
        }
        //Вызывает метод specialActions с действием fact
        private void factorial_Click(object sender, EventArgs e)
        {
            specialActions(actions.fact);
        }


    }
}
