using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursHamming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCodeHammingButton_Click(object sender, EventArgs e)
        {
            string inputText;
            int textLength;
            string hammingCode;
            int hammingLength;
            int countControlBit;
            int[] controlBits;
            int[,] hammingTable;

            if (!checkBinaryText(inputTextBox.Text)) return;
            if (inputTextBox.Text == "") return;
            inputText = inputTextBox.Text; //-- исходный текст
            textLength = inputText.Length;

            //выводим код хэмминга с пустыми контрольными битами
            hammingCode = "";
            int powerOfTwo = 1; //контрольные биты находятся в целых логарифмах по основанию два
            int power = 0;
            for (int i = 0, j = 0;i < textLength;) // i-порядок введёной строки j-порядок кода хэмминга
            {

                if (j+1 == powerOfTwo)
                {
                    power++;
                    powerOfTwo = (int)Math.Pow(2,power);
                    hammingCode += '0';
                }
                else
                {
                    hammingCode += inputText[i];
                    i++;
                }
                j++;
            }
            hammingLength = hammingCode.Length;
            countControlBit = hammingCode.Length - textLength;
            controlBits = new int[countControlBit];
            hammingTable = new int[countControlBit, hammingLength];

            //заполнение таблицы хэмминга
            for (int i = 0; i < hammingLength; i++)
            {
                //каждая строка это число в двоичной системе, написанное сверху вниз, оставшиеся клетки заполнены нулями автоматически
                string column = Convert.ToString(i+1, 2);
                column = new string(column.Reverse().ToArray()); //переворот строки
                for (int j = 0; j < column.Length; j++)
                {
                    hammingTable[j,i] = column[j] - '0';
                }
            }
            //расчет контрольных бит
            for (int i = 0; i < countControlBit; i++)
            {
                int temp = 0;
                for (int j = 0; j < hammingLength; j++)
                {
                    temp +=  hammingTable[i,j] * hammingCode[j];
                }
                controlBits[i] = temp % 2;
            }
            //подстановка контрольных бит в код хэмминга
            for (int i = 0; i < countControlBit; i++)
            {
                int tempLocation = (int)Math.Pow(2, i) - 1;
                hammingCode = hammingCode.Remove(tempLocation, 1).Insert(tempLocation, controlBits[i].ToString());
            }
            firstHammingTextBox.Text = hammingCode;
        }

        bool checkBinaryText(string text) 
        {
            for (int i = 0; i < text.Length; i++)
            {

                if ((text[i] != '1') && (text[i] != '0'))
                {
                    MessageBox.Show(
                        "В полях ввода допускаются значения только 1 или 0.",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    return false;
                }
            }
            return true;
        }

        private void fixCodeButton_Click(object sender, EventArgs e)
        {
            if (!checkBinaryText(firstHammingTextBox.Text)) return;
            if (firstHammingTextBox.Text == "") return;

            string hammingCode = firstHammingTextBox.Text;
            string emptyHammingCode;
            int hammingLength = hammingCode.Length;
            int countControlBit;
            int[,] hammingTable;
            int[] controlBits;
            int[] oldControlBits;
            int[] locationControlBits;
            int locationError;

            //считаем количество контрольных бит
            countControlBit = (int)Math.Ceiling(Math.Log(hammingLength + 1, 2));
            controlBits = new int[countControlBit];
            oldControlBits = new int[countControlBit];
            locationControlBits = new int[countControlBit];

            //заполнение таблицы хэмминга
            hammingTable = new int[countControlBit, hammingLength];
            for (int i = 0; i < hammingLength; i++)
            {
                //каждая строка это число в двоичной системе, написанное сверху вниз, оставшиеся клетки заполнены нулями автоматически
                string column = Convert.ToString(i + 1, 2);
                column = new string(column.Reverse().ToArray()); //переворот строки
                for (int j = 0; j < column.Length; j++)
                {
                    hammingTable[j, i] = column[j] - '0';
                }
            }

            //получаем уже имеющиеся контрольные биты
            for (int i = 0; i < countControlBit; i++)
            {
                int tempLocation = (int)Math.Pow(2, i);
                locationControlBits[i] = tempLocation;
                oldControlBits[i] = hammingCode[tempLocation - 1] - '0';
            }

            //зануляем контрольные биты для их пересчёта
            emptyHammingCode = hammingCode;
            for (int i = 0; i < countControlBit; i++)
            {
                int tempLocation = locationControlBits[i] - 1;
                emptyHammingCode = emptyHammingCode.Remove(tempLocation, 1).Insert(tempLocation, "0");
            }

            //пересчитываем нулевые контрольные биты
            for (int i = 0; i < countControlBit; i++)
            {
                int temp = 0;
                for (int j = 0; j < hammingLength; j++)
                {
                    temp += hammingTable[i, j] * (emptyHammingCode[j] - '0');
                }
                controlBits[i] = temp % 2;
            }

            // проверка на ошибку, ищем элемент с ошибкой
            locationError = 0;
            for (int i = 0; i < countControlBit; i++)
            {
                if (controlBits[i] != oldControlBits[i]) locationError += locationControlBits[i];
            }
            if (locationError == 0)  //ошибки нет
            {
                ErrorStatusTextBox.Text = "Ошибка не обнаружена";
                correctHammingTextBox.Text = "";
                return;
            }
            locationError--;

            //замена ошибочного бита
            if (hammingCode[locationError] == '0')
            {
                hammingCode = hammingCode.Remove(locationError, 1).Insert(locationError, "1");
            }
            else if (hammingCode[locationError] == '1')
            {
                hammingCode = hammingCode.Remove(locationError, 1).Insert(locationError, "0");
            }
            ErrorStatusTextBox.Text = "Обнаружена ошибка в разряде #" + (locationError+1) + ". Ошибка устранена.";
            correctHammingTextBox.Text = hammingCode;
            return;
        }
    }
}
