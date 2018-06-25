using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ArrayClassLibrary
{
    public class arrayProcessingClass
    {
        // объявление переменных и констант
        public int numOfElems;
        private int lowerBound;
        private int upperBound;
        private int cValue;
        private static int RANGE = 1000;
        private static int LOWBOUND = 0;
        private static int UPBOUND = 6000;
        public int[] array = new int[RANGE];
        public bool IsArrayExisting = false;
        // метод, проводящий сравнение введенных данных с паттерном
        public bool formatVerification(string input)
        {
            // проверка на отсутствие введенных данных
            if (input == "")
            {
                return false;
            }
            // паттерн
            string pattern = @"^\d{0,4}$";
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
        // метод, проводящий проверку корректности значения С
        public bool cValueVerification(string cInput)
        {
            // проверка корректности введенных данных
            if (!formatVerification(cInput))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // метод, проводящий проверку корректности введенных значений
        public int inputVerification(string rangeInput, string lowerBoundInput, string upperBoundInput)
        {
            // проверка корректности введенных данных
            if (!formatVerification(rangeInput))
            {
                // вернуть 0, если введенные данные для количества элементов массива не соответствуют формату
                return 0;
            }
            else if ((RANGE < (double.Parse(rangeInput))) || 0 > (double.Parse(rangeInput)))
            {
                // вернуть 1, если введенные данные выходят за пределы диапазона допустимого количества элементов
                return 1;
            }
            else if (!formatVerification(lowerBoundInput))
            {
                // вернуть 2, если нижняя граница не соответствует формату
                return 2;
            }
            else if ((LOWBOUND > (double.Parse(lowerBoundInput))) || UPBOUND < (double.Parse(lowerBoundInput)))
            {
                // вернуть 3, если нижняя граница выходит за пределы диапазона допустимых значений
                return 3;
            }
            else if (!formatVerification(upperBoundInput))
            {
                // вернуть 4, если верхняя граница не соответствует формату
                return 4;
            }
            else if ((LOWBOUND > (double.Parse(upperBoundInput))) || UPBOUND < (double.Parse(upperBoundInput)))
            {
                // вернуть 5, если верхняя граница выходит за пределы диапазона допустимых значений
                return 5;
            }
            else if ((double.Parse(upperBoundInput)) < (double.Parse(lowerBoundInput)))
            {
                // вернуть 6, если нижняя граница больше верхней границы
                return 6;
            }
            else
            {
                // вернуть 7, если значения корректны
                return 7;
            }
        }
        // метод, реализующий генерацию массива
        public int[] getArray(string numOfElemsString, string lowerBoundString, string upperBoundString)
        {
            // проверка на корректность введенных данных
            if (inputVerification(numOfElemsString, lowerBoundString, upperBoundString) == 7)
            {
                // перевод данных в формат int
                numOfElems = int.Parse(numOfElemsString);
                lowerBound = int.Parse(lowerBoundString);
                upperBound = int.Parse(upperBoundString);
                // установка признака существования массива
                IsArrayExisting = true;
                // заполнение массива случайными значениями
                Random rand = new Random();
                for (int i = 0; i < numOfElems; i++)
                {
                    array[i] = rand.Next(lowerBound, upperBound);
                }
                return array;
            }
            // если данные были введены некорректно
            else
            {
                // вернуть массив с признаком ошибки
                int[] arrayWhenFault = new int[2] { 999999, inputVerification(numOfElemsString, lowerBoundString, upperBoundString) };
                return arrayWhenFault;
            }
        }
        // метод, реализующий первую функцию: 
        // вычислить минимальный, максимальный элементы массива и медиану массива
        public string function1()
        {
            // если признак существования массива действителен
            if (IsArrayExisting)
            {
                // присвоить стартовые значения
                int maxValue = LOWBOUND;
                int minValue = UPBOUND;
                int median = 0;
                // цикл поиска минимального и максимального значения методом перебора
                for (int i = 0; i < numOfElems; i++)
                {
                    // если текущий элемент больше максимального
                    if (array[i] > maxValue)
                    {
                        // максимальному элементу присваивается новое значение
                        maxValue = array[i];
                    }
                    // если текущий элемент меньше минимального
                    if (array[i] < minValue)
                    {
                        // минимальному элементу присваивается новое значение
                        minValue = array[i];
                    }
                }
                // создание вспомогательного массива
                int[] arrayFunc1 = array;
                // сортировка пузырьком для упорядочивания массива
                for (int i = 0; i < numOfElems; i++)
                {
                    for (int j = 0; j < numOfElems - 1; j++)
                    {
                        if (arrayFunc1[j] > arrayFunc1[j + 1])
                        {
                            int temp = arrayFunc1[j];
                            arrayFunc1[j] = arrayFunc1[j + 1];
                            arrayFunc1[j + 1] = temp;
                        }
                    }
                }
                // поиск медианы в массиве с четным количеством элементов
                if (numOfElems % 2 == 0)
                {
                    median = (arrayFunc1[numOfElems / 2] + arrayFunc1[numOfElems / 2 + 1]) / 2;
                }
                // поиск медианы в массиве с нечетным количеством элементов
                else
                {
                    median = arrayFunc1[numOfElems / 2];
                }
                // возврат результата
                return $"Min: {minValue}; Max: {maxValue}; Median: {median}";
            }
            // иначе
            else
            {
                // возврат ошибки
                return "Array doesn't exist!";
            }
        }
        // метод, реализующий вторую функцию: 
        // отсортировать элементы массива по убыванию
        public int[] function2()
        {
            // если признак существования массива действителен
            if (IsArrayExisting)
            {
                // отсортировать массив по убыванию
                for (int i = 0; i < numOfElems; i++)
                {
                    for (int j = 0; j < numOfElems - 1; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
                // возврат результата
                return array;
            }
            // иначе
            else
            {
                // возврат массива с признаком ошибки
                int[] arrayFalse = new int[] { 99999 };
                return arrayFalse;
            }
        }
        // метод, реализующий третью функцию: 
        // определить сумму и количество чисел больших С с нечетными номерам
        public string function3(string cValueString)
        {
            // если признак существования массива действителен
            if (IsArrayExisting)
            {
                // если значение С введено корректно
                if (cValueVerification(cValueString))
                {
                    // перевод данных в формат int
                    cValue = int.Parse(cValueString);
                    // присваивание начальных значений
                    int sum = 0;
                    int count = 0;
                    // цикл перебора и подсчета требуемых элементов
                    for (int i = 1; i < numOfElems; i = i + 2)
                    {
                        if (array[i] > cValue)
                        {
                            sum = sum + array[i];
                            count++;
                        }
                    }
                    // возврат результата
                    return $"Sum: {sum}. Number in total: {count}";
                }
                // иначе
                else
                {
                    // возврат ошибки
                    return "Invalid C format!";
                }
            }
            // иначе
            else
            {
                // возврат ошибки
                return "Array doesn't exist!";
            }
        }
        // метод, реализующий третью функцию: 
        // определить сумму и количество элементов массива ai, у которых число, составленное из двух первых цифр числа ai, четное. 
        public string function4()
        {
            // если признак существования массива действителен
            if (IsArrayExisting)
            {
                // присваивание начальных значений
                int sum = 0;
                int num = 0;
                int firstNum;
                // цикл перебора и подсчета требуемых элементов
                for (int i = 0; i < numOfElems; i++)
                {
                    if (array[i] <= 9)
                    {
                        if (array[i] % 2 == 0)
                        {
                            sum = sum + array[i];
                            num++;
                        }
                    }
                    else
                    {
                        string numS = Convert.ToString(array[i]);
                        firstNum = int.Parse(numS.Substring(0, 2));
                        if (firstNum % 2 == 0)
                        {
                            sum = sum + array[i];
                            num++;
                        }
                    }
                }
                // возврат результата
                return $"Sum: {sum}. Number in total: {num}";
            }
            // иначе
            else
            {
                // возврат ошибки
                return "Array doesn't exist!";
            }
        }
    }
}
