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
            string emptyHamming;
            int hammingLength;
            int countControlBit;
            int[] controlBits; //
            int[,] hammingTable;

            if (!checkBinaryText(inputTextBox.Text))
            {
                MessageBox.Show(
                    "В полях ввода допускаются значения только 1 или 0.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if (inputTextBox.Text == "") return;
            inputText = inputTextBox.Text; //-- исходный текст
            textLength = inputText.Length;

            //выводим код хэмминга с пустыми контрольными битами
            emptyHamming = "";
            int powerOfTwo = 1; //контрольные биты находятся в целых логарифмах по основанию два
            int power = 0;
            for (int i = 0, j = 0;i < textLength;) // i-порядок введёной строки j-порядок кода хэмминга
            {

                if (j+1 == powerOfTwo)
                {
                    power++;
                    powerOfTwo = (int)Math.Pow(2,power);
                    emptyHamming += '0';
                }
                else
                {
                    emptyHamming += inputText[i];
                    i++;
                }
                j++;
            }
            hammingLength = emptyHamming.Length;
            countControlBit = emptyHamming.Length - textLength;
            controlBits = new int[countControlBit];
            hammingTable = new int[countControlBit, hammingLength];

            //заполнение таблицы хэмминга и расчёт контрольных бит
            //заранее заполнение таблицы нулями
            for (int i = 0; i < hammingLength; i++)
            {
                //каждая строка это число в двоичной системе, написанное сверху вниз, оставшиеся клетки заполнены нулями автоматически
                string column = Convert.ToString(i+1, 2);
                column = new string(column.Reverse().ToArray());
                for (int j = 0; j < column.Length; j++)
                {
                    hammingTable[j,i] = column[j] - '0';
                }
            }

        }

        bool checkBinaryText(string text) 
        {
            for (int i = 0; i < text.Length; i++)
            {

                if ((text[i] != '1') && (text[i] != '0')) return false;
            }
            return true;
        }

        private void fixCodeButton_Click(object sender, EventArgs e)
        {
            if (!checkBinaryText(firstHammingTextBox.Text))
            {
                MessageBox.Show(
                    "В полях ввода допускаются значения только 1 или 0.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if (firstHammingTextBox.Text == "") return;
        }
    }
}
