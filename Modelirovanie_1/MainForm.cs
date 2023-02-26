using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Modelirovanie_1
{
    public partial class MainForm : Form
    {
        private string _inputStr;

        private readonly Dictionary<string, char> _dictionaryForFunction;
        private Dictionary<char, string> _dictionaryForNumber;

        private bool _mode;
        // private const int MilliSeconds = 1000;

        public MainForm()
        {
            InitializeComponent();
            _dictionaryForFunction = new Dictionary<string, char>
            {
                { "sin", 'а' },
                { "cos", 'б' },
                { "arcsin", 'в' },
                { "arccos", 'г' },
                { "^", 'д' }
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

        private Stack<char> _liveStack = new Stack<char>();
        private Queue<char> _liveQueue = new Queue<char>();
        private int _liveIndex;
        private bool _isFirst = true;
        private string _workString;

        // Перевод из инфиксной формы в постфиксную
        public string TranslateToPostfix(string input)
        {
            Stack<char> stack;
            Queue<char> queue;
            int index;

            // var stackBuff = new Stack<char>();
            // var queueBuff = new Queue<char>();

            if (_mode)
            {
                stack = _liveStack;
                queue = _liveQueue;
                index = _liveIndex;
                if (_isFirst)
                {
                    _workString = Translate(input);
                    _isFirst = false;
                }
            }
            else
            {
                stack = new Stack<char>();
                queue = new Queue<char>();
                index = 0;

                _workString = Translate(input);
            }

            while (_workString.Length != index)
            {
                var element = _workString[index];

                switch (element)
                {
                    case '(':
                        stack.Push(element);
                        break;
                    case ')':
                        Pop(stack, queue, element);

                        if (index + 1 < _workString.Length && _workString[index + 1] == 'д')
                        {
                            stack.Push(_workString[++index]);
                            _liveIndex++;
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
                                Pop(stack, queue, element);
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
                                Pop(stack, queue, element);
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

                ShowStack(stack);

                if (_mode)
                {
                    _liveIndex++;
                    // foreach (var c in queue)
                    //     queueBuff.Enqueue(c);
                    // foreach (var c in stack)
                    //     stackBuff.Push(c);
                    break;
                }

                index++;
            }

            if (!_mode || _workString.Length <= index)
            {
                if (stack.Count != 0)
                    for (var i = stack.Count - 1; i >= 0; i--)
                    {
                        if (stack.Peek() != '(')
                            queue.Enqueue(stack.Pop());
                        else
                            stack.Pop();
                        ShowStack(stack);
                    }
            }

            var result = new StringBuilder();
            foreach (var c in queue)
                result.Append(c);

            // _liveQueue = queueBuff;
            // _liveStack = stackBuff;
            if (_workString.Length <= index)
            {
                _isFirst = true;
                _dictionaryForNumber.Clear();
                _liveIndex = 0;
                _liveQueue.Clear();
                _liveStack.Clear();
            }

            return result.ToString();
        }

        private void Pop(Stack<char> stack, Queue<char> queue, char element)
        {
            for (var i = stack.Count - 1; i >= 0; i--)
            {
                if (stack.Peek() == '(')
                {
                    if (element == ')' && (element != '-' || element != '+'))
                        stack.Pop();
                    return;
                }

                if (element != ')' && (stack.Peek() == '+' || stack.Peek() == '-' ||
                                       (_dictionaryForFunction.ContainsValue(element) &&
                                        (stack.Peek() == '*' || stack.Peek() == '/'))))
                    return;

                queue.Enqueue(stack.Pop());

                // if (_mode)
                //     await Task.Delay(MilliSeconds);
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

        private void ShowStack(Stack<char> stack)
        {
            label_stack.Text = "";
            foreach (var c in stack)
            {
                label_stack.Text = label_stack.Text + "\n" + c;
            }

            // if (_mode)
            //     await Task.Delay(MilliSeconds);
        }

        private void button_Start(object sender, EventArgs e)
        {
            _dictionaryForNumber.Clear();
            label_postfix.Text = TranslateToPostfix(_inputStr);
        }

        private void radioButton_Auto(object sender, EventArgs e) => _mode = false;

        private void radioButton_Step(object sender, EventArgs e) => _mode = true;


        private void button_Stop(object sender, EventArgs e)
        {
        }

        private void button_Tact(object sender, EventArgs e)
        {
            label_postfix.Text = TranslateToPostfix(_inputStr);
        }
    }
}