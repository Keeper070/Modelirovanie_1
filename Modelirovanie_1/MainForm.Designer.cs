
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label_input = new System.Windows.Forms.Label();
            this.label_postfix = new System.Windows.Forms.Label();
            this.buttonTact = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label_stack = new System.Windows.Forms.Label();
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
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выходная строка (в постфиксной форме)";
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
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(352, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Таблица принятия решений:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label_postfix
            // 
            this.label_postfix.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_postfix.Location = new System.Drawing.Point(14, 91);
            this.label_postfix.Name = "label_postfix";
            this.label_postfix.Size = new System.Drawing.Size(403, 23);
            this.label_postfix.TabIndex = 9;
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
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(652, 513);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 12;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.button_Stop);
            // 
            // label_stack
            // 
            this.label_stack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_stack.Location = new System.Drawing.Point(14, 141);
            this.label_stack.Name = "label_stack";
            this.label_stack.Size = new System.Drawing.Size(222, 286);
            this.label_stack.TabIndex = 13;
            this.label_stack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.label_stack);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonTact);
            this.Controls.Add(this.label_postfix);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_input);
            this.Name = "MainForm";
            this.Text = "Мультимедийная обучающая программа \"Трансляция алегбраческих выражений\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label_stack;

        private System.Windows.Forms.Button but_input;

        private System.Windows.Forms.Button buttonTact;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonStop;

        private System.Windows.Forms.Label label_postfix;

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

