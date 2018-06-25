using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TP_lab4_2_class
{
    public class Tmas
    {
        //массив
        public int[,] array = new int[500, 500];
        //нижнее ограничение размера
        readonly int lowerBorder = 0;
        //верхнее ограничение размера
        readonly int upperBorder = 500;
        //условно недостежимое число
        readonly int INF = 999999999;
        //размерность по координате х
        public int x = 0;
        //размерность по координате у
        public int y = 0;
        //создание массива
        public int[,] getArr(string X, string Y, string lower, string upper)
        {
            if (checkAll(X, Y, lower, upper) == 9)
            {
                Random rand = new Random();
                x = int.Parse(X);
                y = int.Parse(Y);
                int Lower = int.Parse(lower);
                int Upper = int.Parse(upper);
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        array[i, j] = rand.Next(Lower, Upper + 1);
                    }
                }
                return array;
            }
            else
            {
                int[,] arrayForError = new int[2, 2];
                arrayForError[0, 0] = INF;
                arrayForError[1, 1] = checkAll(X,Y, lower, upper);
                return arrayForError;
            }
        }
        //проверка данных
        public int checkAll(string X, string Y, string lower, string upper)
        {
            if ((X == "") && (Y == "") && (lower == "") && (upper == ""))
            {
                return 10;
            }
            else if (!checkText(X))
            {
                return 0;
            }
            else if ((upperBorder < (double.Parse(X)) || lowerBorder > (double.Parse(X))))
            {
                return 1;
            }
            else if (!checkText(Y))
            {
                return 2;
            }
            else if ((upperBorder < (double.Parse(Y))) || lowerBorder > (double.Parse(Y)))
            {
                return 3;
            }
            else if (!checkText(lower))
            {
                return 4;
            }
            else if ((0 > (double.Parse(lower))) || 100 < (double.Parse(lower)))
            {
                return 5;
            }
            else if (!checkText(upper))
            {
                return 6;
            }
            else if ((0 > (double.Parse(upper))) || 100 < (double.Parse(upper)))
            {
                return 7;
            }
            else if ((double.Parse(upper)) < (double.Parse(lower)))
            {
                return 8;
            }
            else
            {
                return 9;
            }
        }
        //проверка данных на соответствие формату
        public bool checkText(string textToCheck)
        {
            if (textToCheck == "")
            {
                return false;
            }
            string pattern = @"^\d{0,3}$";
            Match m = Regex.Match(textToCheck, pattern);
            if (m.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //проверка числа С на соответсвие формату
        public bool checkTextC(string textToCheck)
        {
            if (textToCheck == "")
            {
                return false;
            }
            string pattern = @"^[+|-]?\d{1,3}$";
            Match m = Regex.Match(textToCheck, pattern);
            if (m.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //проверка числа С
        public bool checkC(string c)
        {
            if (!checkTextC(c))
            {
                return false;
            }
            else if ((100 < (double.Parse(c))) || (-100 > (double.Parse(c)))) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //первая операция
        public string operation1()
        {
            int num = 100;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (((i + j) % 2 == 0) && (num > array[i, j]))
                    {
                        num = array[i, j];
                    }
                }
            }
            return $"Minimal element is {num}";
        }
        //вторая операция
        public int[,] operation2()
        {
            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    for (int k = 0; k < x-1; k++)
                    {
                        if (array[i, k] > array[i, k+1])
                        {
                            int z = array[i, k];
                            array[i, k] = array[i, k + 1];
                            array[i, k+1] = z;
                        }
                    }
                }
            }
            return array;
        }
        //третья операция
        public int[,] operation3(string C)
        {
            if (checkC(C))
            {
                int c = int.Parse(C);
                Random rand = new Random();
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        array[i, j] = array[i, j] + c;
                    }
                }
                return array;
            }
            else
            {
                int[,] arrayForError = new int[1, 1];
                arrayForError[0, 1] = INF;
                return arrayForError;
            }

        }
    }
}
