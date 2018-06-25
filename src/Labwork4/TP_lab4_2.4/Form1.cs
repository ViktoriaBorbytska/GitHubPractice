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
using System.IO;


namespace TP_lab4_2._4
{
    public partial class Form1 : Form
    {   // условно недостежимое число
        readonly int INF = 999999999;
        //єкземпляр 3 формі
        Form3 f3 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }
        //вызов информации
        private void info_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
        //создание массива
        private void getArr_Click(object sender, EventArgs e)
        {
            f3.getArr(ydem.Text, xdem.Text, textBox1.Text, textBox2.Text);
            if (f3.array[0, 0] != INF){
                f3.Show();
            }
        }
        //первая операция
        private void op1_Click(object sender, EventArgs e)
        {
            f3.op1();
        }
        //вторая операция
        private void op2_Click(object sender, EventArgs e)
        {
            f3.op2();
        }
        //третья операция
        private void op3_Click(object sender, EventArgs e)
        {
            f3.op3(Cnum.Text);

        }
        //открытие из файла
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opener = new OpenFileDialog();
            opener.RestoreDirectory = true;
            opener.Filter = "json files (*.json)|*.json";
            opener.FilterIndex = 2;
            opener.Title = "Reading from file";

            if (opener.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    if (!ReadFromFile(opener.FileName)) throw new Exception();
                }
                catch (Exception)
                {
                    MessageBox.Show("Reading from file causes an error");
                    return;
                }
                MessageBox.Show("Data has been succesfully read from the " + opener.FileName + " file");
                f3.arrayExist = true;
            }
        }
        //вспомогательный метод для открытия из файла
        public bool ReadFromFile(string path)
        {
            try
            {
                using (StreamReader fs = new StreamReader(File.Open(path, FileMode.Open)))
                {
                    f3.array = JsonConvert.DeserializeObject<int[,]>(fs.ReadToEnd());
                }

                if (f3.array == null) throw new Exception();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        //метод сохранения
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saver = new SaveFileDialog();
            saver.RestoreDirectory = true;
            saver.Filter = "json files (*.json)|*.json";
            saver.FilterIndex = 2;
            saver.Title = "Saving in file";

            if (saver.ShowDialog() == DialogResult.OK)
            {
                if (!Path.GetExtension(saver.FileName).Equals(".json"))
                {
                    MessageBox.Show("Incorect data. Required format - *.json .");
                    return;
                }

                try
                {
                    SaveArrInFile(saver.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Saving in file causes an error");
                    return;
                }
                MessageBox.Show("Data has been succesfully saved in the " + saver.FileName + " file");
                f3.arrayExist = true;
            }
        }
        //вспомогательный метод для сохранения
        public bool SaveArrInFile(string path)
        {
            try
            {
                using (StreamWriter fs = new StreamWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    fs.WriteLine(JsonConvert.SerializeObject(f3.array));
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
