using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Modelirovanie_1
{
    public partial class Input : Form
    {
        public readonly List<char> InputStr;
        private int _index;
        private readonly MainForm _mainForm;

        public Input(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            textBox_input.Focus();
            InputStr = new List<char>();
            _index = 0;
        }

        private new void Show()
        {
            var result = new StringBuilder();
            foreach (var s in InputStr)
                result.Append(s);
            textBox_input.Text = result.ToString();
            textBox_input.SelectionStart = ++_index;
            textBox_input.Focus();
        }
        
        public void CommonBtn_Click(object sender, EventArgs e)
        {
            string msg = ((Button)sender).Text;
            textBox_input.AppendText(msg);
        }


        private void Input_Load(object sender, EventArgs e)
        {
            foreach (var item in groupBox1.Controls) //обходим все элементы формы
            {
                if (item is Button) // проверяем, что это кнопка
                {
                    ((Button)item).Click += CommonBtn_Click; //приводим к типу и устанавливаем обработчик события  
                }
            }

            foreach (var item in groupBox2.Controls) //обходим все элементы формы
            {
                if (item is Button) // проверяем, что это кнопка
                {
                    ((Button)item).Click += CommonBtn_Click; //приводим к типу и устанавливаем обработчик события  
                }
            }
        }

        //Кнопка ok
        private void button_ok_Click(object sender, EventArgs e)
        {
            if (CheckErrors())
                return;
        
            _mainForm.ShowInputData(this);
            Close();
        }

        // Кнопка закрытия формы 2
        private void button_close_Click(object sender, EventArgs e) => button_ok_Click(sender, e);

        //Право-лево работает
        #region Move

        private void button_move_left_Click(object sender, EventArgs e)
        {
            _index = _index > 0 ? _index : ++_index;
            textBox_input.SelectionStart = --_index;
            textBox_input.Focus();
        }

        private void button_move_right_Click(object sender, EventArgs e)
        {
            _index = _index <= textBox_input.Text.Length - 1 ? _index : --_index;
            textBox_input.SelectionStart = ++_index;
            textBox_input.Focus();
        }

        #endregion

        // Очистка
        private void button_clear_Click(object sender, EventArgs e)
        {
            _index = 0;
            InputStr.Clear();
            var result = new StringBuilder();
            foreach (var s in InputStr)
                result.Append(s);
            textBox_input.Text = result.ToString();
            textBox_input.SelectionStart = _index + 1;
            textBox_input.Focus();
        }
        
        
        // Поиск ошибок
        private bool CheckErrors()
        {
            var arrayOperations = new[] { '+', '-', '*', '/', '^' };
            for (var index = 0; index < textBox_input.Text.Length - 1; index++)
            {
                var c = textBox_input.Text[index];
                var c2 = textBox_input.Text[index + 1];
                
                if (arrayOperations.Contains(c) && arrayOperations.Contains(c2))
                {
                    MessageBox.Show(@"Операторы:" + c + c2 + @" идут подряд!", @"Ошибка!",
                        MessageBoxButtons.OK);
                    return true;
                }
                if (c == '(' && c2 == ')')
                {
                    MessageBox.Show(@"В скобках ничего не указано!", @"Ошибка!",
                        MessageBoxButtons.OK);
                    return true;
                }

                if (char.IsDigit(c) && c2 == '(')
                {
                    MessageBox.Show(@"Между переменной " + c + @" и скобкой отсутствует знак!", @"Ошибка!",
                        MessageBoxButtons.OK);
                    return true;
                }
                if (arrayOperations.Contains(textBox_input.Text[textBox_input.Text.Length - 1]))
                {
                    MessageBox.Show(@"Оператор:" + c2 + @" идет последний!", @"Ошибка!",
                        MessageBoxButtons.OK);
                    return true;
                }
            }
            return false;
        }
        


        //Ниже все пустое

        #region Symbol

        private void number_1_Click(object sender, EventArgs e)
        {
        }

        private void number_2_Click(object sender, EventArgs e)
        {
        }

        private void number_3_Click(object sender, EventArgs e)
        {
        }

        private void number_4_Click(object sender, EventArgs e)
        {
        }

        private void number_5_Click(object sender, EventArgs e)
        {
        }

        private void number_6_Click(object sender, EventArgs e)
        {
        }

        private void number_left_bracket_Click(object sender, EventArgs e)
        {
        }

        private void number_right_bracket_Click(object sender, EventArgs e)
        {
        }

        #endregion

        #region Operation

        private void number_plus_Click(object sender, EventArgs e)
        {
        }

        private void number_minus_Click(object sender, EventArgs e)
        {
        }

        private void number_multiplication_Click(object sender, EventArgs e)
        {
        }

        private void number_division_Click(object sender, EventArgs e)
        {
        }

        #endregion

        #region Function

        private void number_sin_Click(object sender, EventArgs e)
        {
        }

        private void number_cos_Click(object sender, EventArgs e)
        {
        }

        private void number_arc_sin_Click(object sender, EventArgs e)
        {
        }

        private void number_arc_cos_Click(object sender, EventArgs e)
        {
        }

        private void number_degree_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
    }
}