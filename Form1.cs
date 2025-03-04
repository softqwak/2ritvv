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
        private Stack<char> stack = new Stack<char>();
        private List<(string, string, Stack<char>)> transitions = new List<(string, string, Stack<char>)>();
        private string partWord = "";
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
            tbxTransitions.Text = "";
            if (txtWord.Text != "" && await isPolindromeCheck(txtWord.Text))
            {

            }
            foreach(var item in transitions)
            {
                string magazine = "";
                Stack<char> stack = new Stack<char>(item.Item3);
                while (stack.Count != 0)
                {
                    magazine += stack.Pop();
                }
                tbxTransitions.Text += $"({item.Item1}, {item.Item2}, {magazine}Z0)\r\n";
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private async Task<bool> isPolindromeCheck(string word)
        {
            await Task.Run(async () => {
                for(int i = 0; i < word.Length - 1; i++)
                {
                    char symbol = word[i];
                    string partWord = word.Substring(i);
                    if (isMiddleOfWord)
                    {
                        // Логика после пройденой середины слова

                    }
                    else
                    {
                        // Логика до прохождения середины слова
                        stack.Push(symbol); // Запись символов в 
                        //if (stack != null)
                            transitions.Add((currentState, partWord, new Stack<char>(stack)));
                        await isMiddleOfWordCheck(partWord, stack); // Проверка на середину слова
                    }
                }
            });
            return false;
        }

        private async Task isMiddleOfWordCheck(string partWord, Stack<char> stack)
        { 
            await Task.Run(() =>
            {
                foreach (char symbol in partWord)
                {
                    if (stack.Count == 0)
                    {
                        isMiddleOfWord = false;
                        return;
                    }
                    char symbolForStack = stack.Pop();

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
