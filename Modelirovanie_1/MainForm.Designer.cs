﻿
namespace Modelirovanie_1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_input = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label_input = new System.Windows.Forms.Label();
            this.label_postfix_symbol = new System.Windows.Forms.Label();
            this.buttonTact = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label_stack = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_postfix_number = new System.Windows.Forms.Label();
            this.label_input_change = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_input
            // 
            this.but_input.Location = new System.Drawing.Point(455, 33);
            this.but_input.Name = "but_input";
            this.but_input.Size = new System.Drawing.Size(299, 22);
            this.but_input.TabIndex = 0;
            this.but_input.Text = "Задать";
            this.but_input.UseVisualStyleBackColor = true;
            this.but_input.Click += new System.EventHandler(this.button_to_input);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(455, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Входная строка (в инфиксной форме)";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выходная строка (в постфиксной форме)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(71, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Стек";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Режим";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(14, 486);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(260, 24);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Пошаговый (управляемый пользоавателем)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_Step);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(14, 513);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(260, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Автоматический";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_Auto);
            // 
            // label_input
            // 
            this.label_input.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_input.Location = new System.Drawing.Point(455, 91);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(299, 23);
            this.label_input.TabIndex = 8;
            this.label_input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_input.Click += new System.EventHandler(this.label_input_main);
            // 
            // label_postfix_symbol
            // 
            this.label_postfix_symbol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_postfix_symbol.Location = new System.Drawing.Point(14, 91);
            this.label_postfix_symbol.Name = "label_postfix_symbol";
            this.label_postfix_symbol.Size = new System.Drawing.Size(222, 23);
            this.label_postfix_symbol.TabIndex = 9;
            // 
            // buttonTact
            // 
            this.buttonTact.Location = new System.Drawing.Point(490, 513);
            this.buttonTact.Name = "buttonTact";
            this.buttonTact.Size = new System.Drawing.Size(75, 23);
            this.buttonTact.TabIndex = 10;
            this.buttonTact.Text = "Такт";
            this.buttonTact.UseVisualStyleBackColor = true;
            this.buttonTact.Click += new System.EventHandler(this.button_Tact);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(571, 513);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Старт";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Start);
            // 
            // label_stack
            // 
            this.label_stack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_stack.Location = new System.Drawing.Point(14, 141);
            this.label_stack.Name = "label_stack";
            this.label_stack.Size = new System.Drawing.Size(222, 286);
            this.label_stack.TabIndex = 13;
            this.label_stack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_stack.Click += new System.EventHandler(this.label_stack_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(455, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Исходная строка";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(14, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "С символами";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(255, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "С цифрами";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_postfix_number
            // 
            this.label_postfix_number.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_postfix_number.Location = new System.Drawing.Point(255, 91);
            this.label_postfix_number.Name = "label_postfix_number";
            this.label_postfix_number.Size = new System.Drawing.Size(183, 23);
            this.label_postfix_number.TabIndex = 17;
            // 
            // label_input_change
            // 
            this.label_input_change.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_input_change.Location = new System.Drawing.Point(455, 141);
            this.label_input_change.Name = "label_input_change";
            this.label_input_change.Size = new System.Drawing.Size(299, 23);
            this.label_input_change.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.label_input_change);
            this.Controls.Add(this.label_postfix_number);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_stack);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonTact);
            this.Controls.Add(this.label_postfix_symbol);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_input);
            this.Name = "MainForm";
            this.Text = "Мультимедийная обучающая программа \"Трансляция алгeбраических выражений\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label_input_change;

        private System.Windows.Forms.Label label_postfix_number;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label_stack;

        private System.Windows.Forms.Button but_input;

        private System.Windows.Forms.Button buttonTact;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Label label_postfix_symbol;

        private System.Windows.Forms.Label label_input;

        private System.Windows.Forms.RadioButton radioButton2;

        private System.Windows.Forms.RadioButton radioButton1;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button Задать;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        #endregion
    }
}

