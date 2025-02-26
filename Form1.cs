using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2ritvv
{
    public partial class Form1 : Form
    {

        private string currentState = "q0";
        private Dictionary<(string, string), string> transitions = new Dictionary<(string, string), string>();
        private Stack<char> stack = new Stack<char>();
        private bool isMiddleOfWord = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtWord.Text != "" && await isPolindromeCheck(txtWord.Text))
            {

            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private async Task<bool> isPolindromeCheck(string word)
        {
            await Task.Run(async () => {
                foreach (char symbol in word)
                {
                    if (isMiddleOfWord)
                    {
                        // Логика после пройденой середины слова

                    }
                    else
                    {
                        // Логика до прохождения середины слова
                        stack.Push(symbol); // Запись символов в магазин
                        await isMiddleOfWordCheck("q1"); // Проверка на середину слова
                    }
                }
            });
            return false;
        }

        private async Task isMiddleOfWordCheck(string state, )
        { 
            await Task.Run(() =>
            {
                Stack<char> cstack = new Stack<char>(stack);
                foreach (char symbol in )
                {
                    char symbolForStack = cstack.Pop();
                    if (symbolForStack != symbol)
                    {
                        isMiddleOfWord = false;
                        return;
                    }
                }
            });
        }
    }
}
