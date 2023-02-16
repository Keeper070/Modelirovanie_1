using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelirovanie_1
{
    public partial class MainForm : Form
    {
        private string _inputStr;

        private readonly Dictionary<string, char> _dictionaryForFunction;
        private readonly Dictionary<char, string> _dictionaryForNumber;

        private bool _mode;
        private const int MilliSeconds = 1000;

        public MainForm()
        {
            InitializeComponent();
            _dictionaryForFunction = new Dictionary<string, char>
            {
                {"sin", 'а'},
                {"cos", 'б'},
                {"arcsin", 'в'},
                {"arccos", 'г'},
                {"^", 'д'}
            };
            _dictionaryForNumber = new Dictionary<char, string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label_input_main(object sender, EventArgs e)
        {
            var input = new Input(this);
            input.Show();
        }

        public void ShowInputData(Input input)
        {
            var buffer = new StringBuilder();
            foreach (var t in input.InputStr)
                buffer.Append(t);

            _inputStr = buffer.ToString();
            var result = new StringBuilder();
            foreach (var c in _inputStr)
                result.Append(c);
            label_input.Text = result.ToString();
        }

        private void button_to_input(object sender, EventArgs e) => label_input_main(sender, e);

        // Перевод из инфиксной формы в постфиксную
        public async Task<string> TranslateToPostfix(string input)
        {
            var stack = new Stack<char>();
            var queue = new Queue<char>();
            var workString = input;

            // Перевод из цифр и формул в буквы
            workString = Translate(workString);

            var index = 0;
            while (workString.Length != index)
            {
                var element = workString[index];

                switch (element)
                {
                    case '(':
                        stack.Push(element);
                        break;
                    case ')':
                        await Pop(stack, queue, element);

                        if (index + 1 < workString.Length && workString[index + 1] == 'д')
                        {
                            stack.Push(workString[++index]);
                        }

                        break;
                }

                // Для цифр
                if (char.IsUpper(element))
                    queue.Enqueue(element);
                else
                    switch (element)
                    {
                        case '/':
                        case '*':
                        case 'а':
                        case 'б':
                        case 'в':
                        case 'г':
                        case 'д':
                        {
                            if (stack.Count != 0 && stack.Peek() != 'д' &&
                                (stack.Peek() == '*' || stack.Peek() == '/' ||
                                 _dictionaryForFunction.ContainsValue(stack.Peek())))
                                await Pop(stack, queue, element);
                            stack.Push(element);
                            break;
                        }
                        case '+':
                        case '-':
                        {
                            if (stack.Count == 0 || stack.Peek() == '(')
                                stack.Push(element);
                            else if (stack.Peek() == '/' || stack.Peek() == '*' ||
                                     _dictionaryForFunction.ContainsValue(stack.Peek()))
                            {
                                await Pop(stack, queue, element);
                                stack.Push(element);
                            }
                            else
                            {
                                queue.Enqueue(stack.Pop());
                                stack.Push(element);
                            }

                            break;
                        }
                    }

                await ShowStack(stack);

                if (_mode)
                    await Task.Delay(MilliSeconds);

                index++;
            }

            if (stack.Count != 0)
                for (var i = stack.Count - 1; i >= 0; i--)
                {
                    if (stack.Peek() != '(')
                        queue.Enqueue(stack.Pop());
                    else
                        stack.Pop();
                    await ShowStack(stack);
                }

            var result = new StringBuilder();
            foreach (var c in queue)
                result.Append(c);
            return result.ToString();
        }

        private async Task Pop(Stack<char> stack, Queue<char> queue, char element)
        {
            for (var i = stack.Count - 1; i >= 0; i--)
            {
                if (stack.Peek() == '(')
                {
                    if (element == ')' && (element != '-' || element != '+'))
                        stack.Pop();
                    return;
                }

                if (element != ')' && (stack.Peek() == '+' || stack.Peek() == '-'))
                    return;

                queue.Enqueue(stack.Pop());

                if (_mode)
                    await Task.Delay(MilliSeconds);
            }
        }

        // Перевод из цифр и формул в буквы
        private string Translate(string workString)
        {
            var ch = 'A';
            var index = 0;
            var result = new StringBuilder();

            while (index != workString.Length)
            {
                if (char.IsDigit(workString[index]))
                {
                    var buffer = new StringBuilder().Append(workString[index]);
                    while (++index != workString.Length && char.IsDigit(workString[index]))
                        buffer.Append(workString[index]);
                    _dictionaryForNumber.Add(ch, buffer.ToString());
                    result.Append(ch);
                    ch++;
                }
                else if (char.IsLetter(workString[index]) || workString[index] == '^')
                {
                    var c = ' ';
                    switch (workString[index])
                    {
                        case 's':
                            c = _dictionaryForFunction[workString.Substring(index, 3)];
                            break;
                        case 'c':
                            c = _dictionaryForFunction[workString.Substring(index, 3)];
                            break;
                        // arc sin && arc cos
                        case 'a':
                            c = _dictionaryForFunction[workString.Substring(index, 6)];
                            index += 3;
                            break;
                        case '^':
                            c = _dictionaryForFunction[workString.Substring(index, 1)];
                            index -= 2;
                            break;
                    }

                    index += 3;
                    result.Append(c);
                }
                else
                {
                    result.Append(workString[index]);
                    index++;
                }
            }

            return result.ToString();
        }

        private async Task ShowStack(Stack<char> stack)
        {
            label_stack.Text = "";
            foreach (var c in stack)
                label_stack.Text = label_stack.Text + "\n" + c;

            if (_mode)
                await Task.Delay(MilliSeconds);
        }

        private async void button_Start(object sender, EventArgs e)
        {
            _dictionaryForNumber.Clear();
            label_postfix.Text = await TranslateToPostfix(_inputStr);
        }

        private void radioButton_Auto(object sender, EventArgs e) => _mode = false;

        private void radioButton_Step(object sender, EventArgs e) => _mode = true;


        private async void button_Stop(object sender, EventArgs e)
        {
        }
        
        private async void button_Tact(object sender, EventArgs e)
        {
        }
    }
}