using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // объявление переменных
        private double aCoeff;
        private double bCoeff;
        private double cCoeff;
        private double discriminant;
        private static int MIN = -100000;
        private static int MAX = 100000;
        // объявление переменной для хранения текущего метода
        private MethodChoice currentMethod = MethodChoice.first;
        // объявление перечисления методов
        enum MethodChoice
        {
            first,
            second,
            third
        }
        // метод, реализующий очищение всех полей
        public void clear()
        {
            textBoxA.Text = "";
            textBoxB.Text = "";
            textBoxC.Text = "";
            textBoxX1.Text = "";
            textBoxX2.Text = "";
        }
        // метод, проводящий сравнение введенных данных с паттерном
        public bool formatVerification(string input)
        {
            // паттерн
            string pattern = @"^[+|-]?\d+[\.]?[\d]{0,3}$";
            // сравнение с паттерном
            Match m = Regex.Match(input, pattern);
            if (m.Success)
            {
                return true;
            }
            else
            {
                clear();
                return false;
            }
        }
        // метод, проводящий контроль вводимых данных
        public bool inputVerification(string aInput, string bInput, string cInput)
        {
            // проверка корректности введенных данных
            if (!formatVerification(aInput))
            {
                // вывод сообщения об ошибке
                MessageBox.Show("Incorrect input!", "Error");
                return false;
            }
            else if ((MAX < (double.Parse(aInput))) || MIN > (double.Parse(aInput)))
            {
                MessageBox.Show("Incorrect input!", "Error");
                return false;
            }
            // проверка корректности введенных данных
            else if (!formatVerification(bInput))
            {
                // вывод сообщения об ошибке
                MessageBox.Show("Incorrect input!", "Error");
                return false;
            }
            else if ((MAX < (double.Parse(bInput))) || MIN > (double.Parse(bInput)))
            {
                MessageBox.Show("Incorrect input!", "Error");
                return false;
            }
            // проверка корректности введенных данных
            else if (!formatVerification(cInput))
            {
                // вывод сообщения об ошибке
                MessageBox.Show("Incorrect input!", "Error");
                return false;
            }
            else if ((MAX < (double.Parse(cInput))) || MIN > (double.Parse(cInput)))
            {
                MessageBox.Show("Incorrect input!", "Error");
                return false;
            }
            else
            {
                return true;
            }
        }
        // метод, блокирующий введение запрещенных символов с клавиатуры
        public void inpitBlockage(object sender, KeyPressEventArgs e)
        {
            // проверка введенных данных на совпадение с разрешенными символами
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) ||
                (e.KeyChar == '.') || (e.KeyChar == '-') || (e.KeyChar == '+'))
            {
                // ввод разрешен
                e.Handled = false;
            }
            else
            {
                // игнорировать ввод
                e.Handled = true;
            }
        }
        // метод, вычисляющий корни уравнения вторым способом
        public void rootsCalculator()
        {
            // проверка корректности входных данных
            if (inputVerification(textBoxA.Text, textBoxB.Text, textBoxC.Text))
            {
                // перевод данных в формат double
                aCoeff = double.Parse(textBoxA.Text);
                bCoeff = double.Parse(textBoxB.Text);
                cCoeff = double.Parse(textBoxC.Text);
                // проверка исключительных ситуаций, связанных с вводами 0
                if ((aCoeff == 0) && (bCoeff == 0) && (cCoeff == 0))
                {
                    MessageBox.Show("X can have any value", "Message");
                    clear();
                }
                else if ((aCoeff == 0) && (bCoeff == 0) && (cCoeff != 0))
                {
                    MessageBox.Show("Equation is incorrect", "Message");
                    clear();
                }
                else if ((aCoeff == 0) && (bCoeff != 0) && (cCoeff == 0))
                {
                    MessageBox.Show("This equation is not quadratic. Root: х = 0", "Message");
                    clear();
                }
                else if ((aCoeff == 0) && (bCoeff != 0) && (cCoeff != 0))
                {
                    MessageBox.Show($"This equation is not quadratic. Root: х = {-cCoeff / bCoeff} ", "Message");
                    clear();
                }
                else if ((aCoeff != 0) && (cCoeff == 0))
                {
                    textBoxX1.Text = "0";
                    textBoxX2.Text = string.Format("{0:0.###}", -bCoeff / aCoeff);
                }
                // расчет корней 
                else
                {
                    // расчет дискриминанта
                    discriminant = bCoeff * bCoeff - 4 * aCoeff * cCoeff;
                    // если дискриминант меньше 0
                    if (discriminant < 0)
                    {
                        // получение положительногое значение дискриминанта
                        discriminant = -discriminant;
                        // вычисление корня из дискриминанта
                        discriminant = Math.Sqrt(discriminant);
                        // вывод в соответствии с правилами записи комплексных чисел
                        textBoxX1.Text = string.Format("{0:0.###}", -bCoeff / (2 * aCoeff)) + " + " + string.Format("{0:0.###}", discriminant / (2 * aCoeff)) + "* i";
                        textBoxX2.Text = string.Format("{0:0.###}", -bCoeff / (2 * aCoeff)) + " - " + string.Format("{0:0.###}", discriminant / (2 * aCoeff)) + "* i";
                    }
                    // если дискриминант равен 0
                    else if (discriminant == 0)
                    {
                        // вывод значения корня
                        textBoxX1.Text = textBoxX2.Text = string.Format("{0:0.###}", -bCoeff / (2 * aCoeff));
                    }
                    // если дискриминант больше 0
                    else
                    {
                        // вычисление корня из дискриминанта
                        discriminant = Math.Sqrt(discriminant);
                        // вывод значения корня
                        textBoxX1.Text = string.Format("{0:0.###}", (-bCoeff + discriminant) / (2 * aCoeff));
                        textBoxX2.Text = string.Format("{0:0.###}", (-bCoeff - discriminant) / (2 * aCoeff));
                    }
                }
            }
        }
        private void countButtonClick(object sender, EventArgs e)
        {
            // если выбран первый способ вычисления
            if (currentMethod == MethodChoice.first)
            {
                // проверка корректности входных данных
                if (inputVerification(textBoxA.Text, textBoxB.Text, textBoxC.Text))
                {
                    // перевод данных в формат double
                    aCoeff = double.Parse(textBoxA.Text);
                    bCoeff = double.Parse(textBoxB.Text);
                    cCoeff = double.Parse(textBoxC.Text);
                    // проверка исключительных ситуаций, связанных с вводами 0
                    if ((aCoeff == 0) && (bCoeff == 0) && (cCoeff == 0))
                    {
                        MessageBox.Show("X can have any value", "Message");
                        clear();
                    }
                    else if ((aCoeff == 0) && (bCoeff == 0) && (cCoeff != 0))
                    {
                        MessageBox.Show("Equation is incorrect", "Message");
                        clear();
                    }
                    else if ((aCoeff == 0) && (bCoeff != 0) && (cCoeff == 0))
                    {
                        MessageBox.Show("This equation is not quadratic. Root: х = 0", "Message");
                        clear();
                    }
                    else if ((aCoeff == 0) && (bCoeff != 0) && (cCoeff != 0))
                    {
                        MessageBox.Show($"This equation is not quadratic. Root: х = {-cCoeff / bCoeff} ", "Message");
                        clear();
                    }
                    else if ((aCoeff != 0) && (cCoeff == 0))
                    {
                        textBoxX1.Text = "0";
                        textBoxX2.Text = string.Format("{0:0.###}", -bCoeff / aCoeff);
                    }
                    // расчет корней 
                    else
                    {
                        // расчет дискриминанта
                        discriminant = bCoeff * bCoeff - 4 * aCoeff * cCoeff;
                        // если дискриминант меньше 0
                        if (discriminant < 0)
                        {
                            // получение положительногое значение дискриминанта
                            discriminant = -discriminant;
                            // вычисление корня из дискриминанта
                            discriminant = Math.Sqrt(discriminant);
                            // вывод в соответствии с правилами записи комплексных чисел
                            textBoxX1.Text = string.Format("{0:0.###}", -bCoeff / (2 * aCoeff)) + " + " + string.Format("{0:0.###}", discriminant / (2 * aCoeff)) + "* i";
                            textBoxX2.Text = string.Format("{0:0.###}", -bCoeff / (2 * aCoeff)) + " - " + string.Format("{0:0.###}", discriminant / (2 * aCoeff)) + "* i";
                        }
                        // если дискриминант равен 0
                        else if (discriminant == 0)
                        {
                            // вывод значения корня
                            textBoxX1.Text = textBoxX2.Text = string.Format("{0:0.###}", -bCoeff / (2 * aCoeff));
                        }
                        // если дискриминант больше 0
                        else
                        {
                            // вычисление корня из дискриминанта
                            discriminant = Math.Sqrt(discriminant);
                            // вывод значений корней
                            textBoxX1.Text = string.Format("{0:0.###}", (-bCoeff + discriminant) / (2 * aCoeff));
                            textBoxX2.Text = string.Format("{0:0.###}", (-bCoeff - discriminant) / (2 * aCoeff));
                        }
                    }
                }
            }
            // если выбран второй способ вычисления
            else if (currentMethod == MethodChoice.second)
            {
                // вызов метода, вычисляющего корни уравнения
                rootsCalculator();
            }
            // если выбран третий способ вычисления
            else
            {
                // создание экземпляра класса Class1
                Class1 classEx = new Class1(textBoxA.Text, textBoxB.Text, textBoxC.Text);
                // получение возвращенных результатов
                textBoxX1.Text = classEx.firstRootCalculator();
                textBoxX2.Text = classEx.secondRootCalculator();
            }
        }
        // обработчик событий, реагирующий на клик по кнопке “close” и реализующий закрытие окна Form1
        private void closeButtonClick(object sender, EventArgs e)
        {
            Close();
        }
        // обработчик событий, реагирующий на клик по кнопке “clear” и реализующий очищение всех полей
        private void clearButtonClick(object sender, EventArgs e)
        {
            clear();
        }
        // обработчик событий, реагирующий на выбор первого метода
        private void method1ButtonCheckedChanged(object sender, EventArgs e)
        {
            currentMethod = MethodChoice.first;
        }
        // обработчик событий, реагирующий на выбор второго метода
        private void method2ButtonCheckedChanged(object sender, EventArgs e)
        {
            currentMethod = MethodChoice.second;
        }
        // обработчик событий, реагирующий на выбор третьего метода
        private void method3ButtonCheckedChanged(object sender, EventArgs e)
        {
             currentMethod = MethodChoice.third;
        }
        // обработчик событий, реагирующий на изменение тескта в поле textBoxA и проводящий проверку данных на соответствие с допустимыми
        private void textBoxAKeyPress(object sender, KeyPressEventArgs e)
        {
            inpitBlockage(sender, e);
        }
        // обработчик событий, реагирующий на изменение тескта в поле textBoxB и проводящий проверку данных на соответствие с допустимыми
        private void textBoxBKeyPress(object sender, KeyPressEventArgs e)
        {
            inpitBlockage(sender, e);
        }
        // обработчик событий, реагирующий на изменение тескта в поле textBoxC и проводящий проверку данных на соответствие с допустимыми
        private void textBoxCKeyPress(object sender, KeyPressEventArgs e)
        {
            inpitBlockage(sender, e);
        }
    }
}
