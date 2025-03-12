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

        private string currentState = "Q0";
        private Stack<char> stack = new Stack<char>();
        private List<(string, string, Stack<char>)> transitions = new List<(string, string, Stack<char>)>();
        private string partWord = "";
        private bool isMiddleOfWord = false;
        private bool isPolindrome = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnCheck_Click(sender, e);
        }


        private async void btnCheck_Click(object sender, EventArgs e)
        {
            tbxTransitions.Clear();
            transitions.Clear();
            stack.Clear();
            isPolindrome = false;

            if (await isPolindromeCheck(txtWord.Text))
            {
                lblResult.Text = "Палиндром!";
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                lblResult.Text = "Непалиндром!";
                lblResult.ForeColor = Color.Red;
            }
            foreach (var item in transitions)
            {
                string magazine = null;
                Stack<char> stack = new Stack<char>(item.Item3.Reverse());
                while (stack.Count != 0)
                {
                    magazine += stack.Pop();
                }
                tbxTransitions.Text += $"|{item.Item1}, {(item.Item2.Any() ? item.Item2 : "ε")}, {magazine ?? "ε"} Z₀)\r\n";
            }
        }


        private async Task<bool> isPolindromeCheck(string word)
        {
            await Task.Run(async () =>
            {
                transitions.Add((currentState, word, new Stack<char>(stack.Reverse())));
                await isMiddleOfWordCheck(word, stack); // Проверка на середину слова
                for (int i = 0; i <= word.Length - 1; i++)
                {
                    char symbol = word[i];
                    string partWord = word.Substring(i + 1);
                    stack.Push(symbol); // Запись символов в стэк
                    transitions.Add((currentState, partWord, new Stack<char>(stack.Reverse())));
                    await isMiddleOfWordCheck(partWord, stack); // Проверка на середину
                }
            });
            if (isPolindrome == true && word.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private async Task isMiddleOfWordCheck(string word, Stack<char> stack)
        {
            await Task.Run(() =>
            {
                Stack<char> tempStack = new Stack<char>(stack.Reverse());
                int i = 0;
                string partWord = "";
                double x = 20;
                for (; i <= word.Length - 1; i++)
                {
                    char symbol = word[i];
                    partWord = word.Substring(i);
                    transitions.Add(($"{"\\____ (Q1".PadLeft((int)x, ' ')}", partWord, new Stack<char>(tempStack.Reverse())));
                    x += 20;

                    try
                    {
                        char symbolForStack = tempStack.Pop();
                        if (symbolForStack != symbol)
                        {
                            partWord = word.Substring(i + 1);
                            transitions.Add(($"{"\\____ (Q2".PadLeft((int)x, ' ')}", partWord, new Stack<char>(tempStack.Reverse())));
                            x += 20;
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        transitions.Add(($"{"\\____ (Q2".PadLeft((int)x, ' ')}", partWord, new Stack<char>(tempStack.Reverse())));
                        x += 20;
                        return;
                    }
                }
                partWord = word.Substring(i);
                if (tempStack.Count == 0 && partWord.Length == 0)
                    isPolindrome = true;
                transitions.Add(($"{"\\____ (Q2".PadLeft((int)x, ' ')}", partWord, new Stack<char>(tempStack.Reverse())));
                x += 20;

            });
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void tbxTransitions_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
