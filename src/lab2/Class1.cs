using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab2
{
    public class Class1
    {
        // объявление переменных
        private string aInput;
        private string bInput;
        private string cInput;
        private double aCoeff;
        private double bCoeff;
        private double cCoeff;
        private double discriminant;
        private double x1;
        private double x2;
        private static int MIN = -100000;
        private static int MAX = 100000;
        // конструктор
        public Class1(string aInput, string bInput, string cInput)
        {
            this.aInput = aInput;
            this.bInput = bInput;
            this.cInput = cInput;
        }
        // метод, расчитывающий значение первого корня уравнения
        public string firstRootCalculator()
        {
            // проверка корректности введенных данных
            if (inputVerification())
            {
                // перевод данных в формат double
                aCoeff = double.Parse(aInput);
                bCoeff = double.Parse(bInput);
                cCoeff = double.Parse(cInput);
                // проверка исключительных ситуаций, связанных с вводами 0
                if ((aCoeff == 0) && (bCoeff == 0) && (cCoeff == 0))
                {
                    return "any value";
                }
                else if ((aCoeff == 0) && (bCoeff == 0) && (cCoeff != 0))
                {
                    return "equation is incorrect";
                }
                else if ((aCoeff == 0) && (bCoeff != 0) && (cCoeff == 0))
                {
                    return "0";
                }
                else if ((aCoeff == 0) && (bCoeff != 0) && (cCoeff != 0))
                {
                    return string.Format("{0:0.###}", -cCoeff / bCoeff);
                }
                else if ((aCoeff != 0) && (cCoeff == 0))
                {
                    return "0";
                }
                // расчет корня
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
                        return string.Format("{0:0.###}", -bCoeff / (2 * aCoeff)) + " + " + string.Format("{0:0.###}", discriminant / (2 * aCoeff)) + "* i";
                    }
                    // если дискриминант равен 0
                    else if (discriminant == 0)
                    {
                        // вывод значения корня
                        x1 = -bCoeff / (2 * aCoeff);
                    }
                    // если дискриминант больше 0
                    else
                    {
                        // вычисление корня из дискриминанта
                        discriminant = Math.Sqrt(discriminant);
                        // вычисление значения корня
                        x1 = (-bCoeff + discriminant) / (2 * aCoeff);
                    }
                    // вывод значения корня
                    return string.Format("{0:0.###}", x1);
                }
            }
            // вывод сообщения об ошибке
            return "Incorrect input!";
        }
        // метод, расчитывающий значение второго корня уравнения
        public string secondRootCalculator()
        {
            // проверка корректности введенных данных
            if (inputVerification())
            {
                // перевод данных в формат double
                aCoeff = double.Parse(aInput);
                bCoeff = double.Parse(bInput);
                cCoeff = double.Parse(cInput);
                // проверка исключительных ситуаций, связанных с вводами 0
                if ((aCoeff == 0) && (bCoeff == 0) && (cCoeff == 0))
                {
                    return "any value";
                }
                else if ((aCoeff == 0) && (bCoeff == 0) && (cCoeff != 0))
                {
                    return "equation is incorrect";
                }
                else if ((aCoeff == 0) && (bCoeff != 0) && (cCoeff == 0))
                {
                    return "0";
                }
                else if ((aCoeff == 0) && (bCoeff != 0) && (cCoeff != 0))
                {
                    return string.Format("{0:0.###}", -cCoeff / bCoeff);
                }
                else if ((aCoeff != 0) && (cCoeff == 0))
                {
                    return string.Format("{0:0.###}", -bCoeff / aCoeff);
                }
                // расчет корня
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
                        return string.Format("{0:0.###}", -bCoeff / (2 * aCoeff)) + " - " + string.Format("{0:0.###}", discriminant / (2 * aCoeff)) + "* i";
                    }
                    // если дискриминант равен 0
                    else if (discriminant == 0)
                    {
                        // вывод значения корня
                        x2 = -bCoeff / (2 * aCoeff);
                    }
                    else
                    // если дискриминант больше 0
                    {
                        // вычисление корня из дискриминанта
                        discriminant = Math.Sqrt(discriminant);
                        // вычисление значения корня
                        x2 = (-bCoeff - discriminant) / (2 * aCoeff);
                    }
                    // вывод значения корня
                    return string.Format("{0:0.###}", x2);
                }
            }
            // вывод сообщения об ошибке
            return "Incorrect input!";
        }
        // метод, проводящий контроль вводимых данных
        private bool inputVerification()
        {
            // проверка корректности введенных данных
            if (!formatVerification(aInput))
            {
                return false;
            }
            // проверка корректности введенных данных
            else if ((MAX < (double.Parse(aInput)) || (MIN > (double.Parse(aInput)))))
            {
                return false;
            }
            // проверка корректности введенных данных
            else if (!formatVerification(bInput))
            {
                return false;
            }
            // проверка корректности введенных данных
            else if ((MAX < (double.Parse(bInput)) || (MIN > (double.Parse(bInput)))))
            {
                return false;
            }
            // проверка корректности введенных данных
            else if (!formatVerification(cInput))
            {
                return false;
            }
            // проверка корректности введенных данных
            else if ((MAX < (double.Parse(cInput)) || (MIN > (double.Parse(cInput)))))
            {
                return false;
            }
            else
            {
                return true;
            }
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
                return false;
            }
        }
    }
}
