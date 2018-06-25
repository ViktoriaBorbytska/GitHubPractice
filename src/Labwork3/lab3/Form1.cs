using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using ArrayClassLibrary;

namespace lab3
{
    public partial class ArrayProcessingForm : Form
    {
        public ArrayProcessingForm()
        {
            InitializeComponent();
        }
        // объявление переменных и констант
        private int numOfElems;
        private static int RANGE = 1000;
        int[] array = new int[RANGE];
        arrayProcessingClass arrayProcess = new arrayProcessingClass();
        // метод, блокирующий введение запрещенных символов с клавиатуры
        public void inputBlockage(object sender, KeyPressEventArgs e)
        {
            // проверка введенных данных на совпадение с разрешенными символами
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
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
        // обработчик событий, реагирующий на нажатие клавиши Generate
        private void generateArrayClick(object sender, EventArgs e)
        {
            // очищение строк в таблице GridView
            dataGridView1.Rows.Clear();
            // если первый элемент поданного массива равен 999999 (признак ошибки)
            if (arrayProcess.getArray(numOfElemsBox.Text, lowerBoundBox.Text, upperBoundBox.Text)[0] == 999999)
            {
                // чтение второго элемента поданного массива (каждое значение - отдельная ошибка)
                switch (arrayProcess.getArray(numOfElemsBox.Text, lowerBoundBox.Text, upperBoundBox.Text)[1])
                {
                    // вывод сообщения об ошибке
                    case 0:
                        MessageBox.Show("Invalid range!", "Error!");
                        break;
                    // вывод сообщения об ошибке
                    case 1:
                        MessageBox.Show("Invalid range!", "Error!");
                        break;
                    // вывод сообщения об ошибке
                    case 2:
                        MessageBox.Show("Invalid lower bound!", "Error!");
                        break;
                    // вывод сообщения об ошибке
                    case 3:
                        MessageBox.Show("Invalid lower bound range!", "Error!");
                        break;
                    // вывод сообщения об ошибке
                    case 4:
                        MessageBox.Show("Invalid upper bound!", "Error!");
                        break;
                    // вывод сообщения об ошибке
                    case 5:
                        MessageBox.Show("Invalid upper bound range!", "Error!");
                        break;
                    // вывод сообщения об ошибке
                    case 6:
                        MessageBox.Show("Lower bound is bigger than upper bound!", "Error!");
                        break;
                }
            }
            // если признака ошибки нет
            else
            {
                // перевод данных в тип int
                numOfElems = Convert.ToInt32(numOfElemsBox.Text);
                // генерация массива
                array = arrayProcess.getArray(numOfElemsBox.Text, lowerBoundBox.Text, upperBoundBox.Text);
            }
            // отображение массива в таблице GridView
            getGridView();
            // отображение массива в строке
            arrayDataBox.Text = getArrayString();
        }
        // обработчик событий, реагирующий на нажатие клавиши Function 1
        private void func1Click(object sender, EventArgs e)
        {
            // вызов метода, реализующего выполнение первой функции
            arrayDataBox.Text = arrayProcess.function1();
        }
        // обработчик событий, реагирующий на нажатие клавиши Function 2
        private void func2Click(object sender, EventArgs e)
        {
            // если в переданном массиве первый элемент содержит признак ошибки
            if (arrayProcess.function2()[0] == 99999)
            {
                // вывод сообщения об ошибке
                arrayDataBox.Text = "Array doesn't exist!";
            }
            else
            {
                // очищение строк таблицы GridView
                dataGridView1.Rows.Clear();
                // вызов метода, реализующего выполнение второй функции
                array = arrayProcess.function2();
                // перевод данных в тип int
                numOfElems = Convert.ToInt32(numOfElemsBox.Text);
                // отображение массива в таблице GridView
                getGridView();
                // отображение массива в строке
                arrayDataBox.Text = getArrayString();
            }
        }
        // обработчик событий, реагирующий на нажатие клавиши Function 3
        private void func3Click(object sender, EventArgs e)
        {
            // вызов метода, реализующего выполнение третьей функции
            arrayDataBox.Text = arrayProcess.function3(cValueBox.Text);
        }
        // обработчик событий, реагирующий на нажатие клавиши Function 4
        private void func4Click(object sender, EventArgs e)
        {
            // вызов метода, реализующего выполнение четвертой функции
            arrayDataBox.Text = arrayProcess.function4();
        }
        // метод, реализующий вывод массива в GridView
        private void getGridView()
        {
            for (int i = 0; i < numOfElems; i++)
            {
                dataGridView1.Rows.Add(new object[] { i, array[i] });
            }

        }
        // метод, реализующий вывод массива в строку
        public string getArrayString()
        {
            if (numOfElems == 0)
            {
                return "";
            }
            string arrStr = "";
            for (int i = 0; i < numOfElems; i++)
            {
                arrStr += array[i] + " ";
            }
            return arrStr;
        }
        // обработчик событий, реагирующий на нажатие клавиши Open
        private void openButtonClick(object sender, EventArgs e)
        {
            // очищение строк таблицы GridView
            dataGridView1.Rows.Clear();
            {
                // число выводимых чисел
                string[] s = new string[RANGE];
                // open - имя компонента OpenFileDialog
                string fname = "";
                 // задание начальной директории
                openFileDialog1.InitialDirectory = "c:\\";
                // задание свойства Filter
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                // задание свойства FilterIndex – выбор исходного типа файла
                openFileDialog1.FilterIndex = 1;
                // свойство Title задает название окна диалога выбора файла
                openFileDialog1.Title = "Open file";
                // демонстрация окна диалога выбора файла с помощью метода ShowDialog()
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // получение имени файла для выбора данных
                    fname = openFileDialog1.FileName;
                }
                try
                {
                    // запись в массив s строк из файла методом ReadAllLines
                    s = File.ReadAllLines(fname);
                    numOfElems = s.Length;
                    for (int i = 0; i < numOfElems; ++i)
                    {
                        // получение массива чисел
                        array[i] = Convert.ToInt32(s[i]);
                    }
                    // копирование массива
                    arrayProcess.array = array;
                    // вывод массива в GridView
                    getGridView();
                    // вывод массива в строку
                    arrayDataBox.Text = getArrayString();
                }
                // отлавливание ошибок
                catch (Exception ex)
                {
                    // вывод сообщения об ошибке
                    MessageBox.Show(ex.ToString(), "Message");
                }

            }
        }
        // обработчик событий, реагирующий на нажатие клавиши Save
        private void saveButtonClick(object sender, EventArgs e)
        {
            // save - имя компонента SaveFileDialog
            string Fname = "";
            // задание начальной директории
            saveFileDialog1.InitialDirectory = "c:\\";
            // задание свойства Filter
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // задание свойства FilterIndex – выбор исходного типа файла
            saveFileDialog1.FilterIndex = 2;
            // свойство Title задает название окна диалога выбора файла
            saveFileDialog1.Title = "Save file as";
            // демонстрация окна диалога выбора файла с помощью метода ShowDialog()
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // получение имени файла для сохранения данных
                Fname = saveFileDialog1.FileName;
                // выделение памяти для объекта типа FileStream в режиме создания
                // и запись информации в него, связывание его и имени Fname
                FileStream fs = new FileStream(Fname, FileMode.Create, FileAccess.Write);
                if (fs != null)// в случае успеха
                {// создание объекта типа StreamWriter и ассоциирование его с объектом fs
                    StreamWriter wr = new StreamWriter(fs);
                    for (int i = 0; i < numOfElems; ++i)
                    {
                        wr.WriteLine(array[i]);
                    }
                    // перенос данных из объекта fs в файл
                    wr.Flush();
                    // закрытие объектов wr и fs
                    wr.Close();
                    fs.Close();
                }
            }
        }
        // обработчик событий, реагирующий на нажатие клавиш в numOfElemsBox
        private void numOfElemsBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            // вызов метода, реализующего блокировку ввода запрещенных символов
            inputBlockage(sender, e);
        }
        // обработчик событий, реагирующий на нажатие клавиш в lowerBoundBox
        private void lowerBoundBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            // вызов метода, реализующего блокировку ввода запрещенных символов
            inputBlockage(sender, e);
        }
        // обработчик событий, реагирующий на нажатие клавиш в upperBoundBox
        private void upperBoundBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            // вызов метода, реализующего блокировку ввода запрещенных символов
            inputBlockage(sender, e);
        }
        // обработчик событий, реагирующий на нажатие клавиш в сValueBox
        private void cValueBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            // вызов метода, реализующего блокировку ввода запрещенных символов
            inputBlockage(sender, e);
        }
    }
}
