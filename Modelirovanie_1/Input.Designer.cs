﻿using System.ComponentModel;

namespace Modelirovanie_1
{
    partial class Input
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttom_move_left = new System.Windows.Forms.Button();
            this.buttom_move_right = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.number_1 = new System.Windows.Forms.Button();
            this.number_2 = new System.Windows.Forms.Button();
            this.number_3 = new System.Windows.Forms.Button();
            this.number_4 = new System.Windows.Forms.Button();
            this.number_5 = new System.Windows.Forms.Button();
            this.number_6 = new System.Windows.Forms.Button();
            this.number_RSk = new System.Windows.Forms.Button();
            this.number_plus = new System.Windows.Forms.Button();
            this.number_minus = new System.Windows.Forms.Button();
            this.number_multiplu = new System.Windows.Forms.Button();
            this.number_devesion = new System.Windows.Forms.Button();
            this.number_sin = new System.Windows.Forms.Button();
            this.number_cos = new System.Windows.Forms.Button();
            this.number_arcsin = new System.Windows.Forms.Button();
            this.number_asrccos = new System.Windows.Forms.Button();
            this.number_stepen = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.number_LSk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttom_move_left
            // 
            this.buttom_move_left.Location = new System.Drawing.Point(223, 137);
            this.buttom_move_left.Name = "buttom_move_left";
            this.buttom_move_left.Size = new System.Drawing.Size(75, 67);
            this.buttom_move_left.TabIndex = 1;
            this.buttom_move_left.Text = "<-";
            this.buttom_move_left.UseVisualStyleBackColor = true;
            this.buttom_move_left.Click += new System.EventHandler(this.button_move_left_Click);
            // 
            // buttom_move_right
            // 
            this.buttom_move_right.Location = new System.Drawing.Point(364, 137);
            this.buttom_move_right.Name = "buttom_move_right";
            this.buttom_move_right.Size = new System.Drawing.Size(75, 67);
            this.buttom_move_right.TabIndex = 2;
            this.buttom_move_right.Text = "->";
            this.buttom_move_right.UseVisualStyleBackColor = true;
            this.buttom_move_right.Click += new System.EventHandler(this.button_move_right_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(501, 137);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 67);
            this.button_clear.TabIndex = 3;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // number_1
            // 
            this.number_1.Location = new System.Drawing.Point(11, 19);
            this.number_1.Name = "number_1";
            this.number_1.Size = new System.Drawing.Size(75, 59);
            this.number_1.TabIndex = 4;
            this.number_1.Text = "1";
            this.number_1.UseVisualStyleBackColor = true;
            this.number_1.Click += new System.EventHandler(this.number_1_Click);
            // 
            // number_2
            // 
            this.number_2.Location = new System.Drawing.Point(98, 19);
            this.number_2.Name = "number_2";
            this.number_2.Size = new System.Drawing.Size(75, 59);
            this.number_2.TabIndex = 5;
            this.number_2.Text = "2";
            this.number_2.UseVisualStyleBackColor = true;
            this.number_2.Click += new System.EventHandler(this.number_2_Click);
            // 
            // number_3
            // 
            this.number_3.Location = new System.Drawing.Point(196, 19);
            this.number_3.Name = "number_3";
            this.number_3.Size = new System.Drawing.Size(75, 59);
            this.number_3.TabIndex = 6;
            this.number_3.Text = "3";
            this.number_3.UseVisualStyleBackColor = true;
            this.number_3.Click += new System.EventHandler(this.number_3_Click);
            // 
            // number_4
            // 
            this.number_4.Location = new System.Drawing.Point(6, 97);
            this.number_4.Name = "number_4";
            this.number_4.Size = new System.Drawing.Size(75, 59);
            this.number_4.TabIndex = 7;
            this.number_4.Text = "4";
            this.number_4.UseVisualStyleBackColor = true;
            this.number_4.Click += new System.EventHandler(this.number_4_Click);
            // 
            // number_5
            // 
            this.number_5.Location = new System.Drawing.Point(98, 97);
            this.number_5.Name = "number_5";
            this.number_5.Size = new System.Drawing.Size(75, 59);
            this.number_5.TabIndex = 8;
            this.number_5.Text = "5";
            this.number_5.UseVisualStyleBackColor = true;
            this.number_5.Click += new System.EventHandler(this.number_5_Click);
            // 
            // number_6
            // 
            this.number_6.Location = new System.Drawing.Point(196, 97);
            this.number_6.Name = "number_6";
            this.number_6.Size = new System.Drawing.Size(75, 59);
            this.number_6.TabIndex = 9;
            this.number_6.Text = "6";
            this.number_6.UseVisualStyleBackColor = true;
            this.number_6.Click += new System.EventHandler(this.number_6_Click);
            // 
            // number_RSk
            // 
            this.number_RSk.Location = new System.Drawing.Point(283, 97);
            this.number_RSk.Name = "number_RSk";
            this.number_RSk.Size = new System.Drawing.Size(83, 59);
            this.number_RSk.TabIndex = 15;
            this.number_RSk.Text = ")";
            this.number_RSk.UseVisualStyleBackColor = true;
            this.number_RSk.Click += new System.EventHandler(this.number_right_bracket_Click);
            // 
            // number_plus
            // 
            this.number_plus.Location = new System.Drawing.Point(10, 15);
            this.number_plus.Name = "number_plus";
            this.number_plus.Size = new System.Drawing.Size(75, 61);
            this.number_plus.TabIndex = 16;
            this.number_plus.Text = "+";
            this.number_plus.UseVisualStyleBackColor = true;
            this.number_plus.Click += new System.EventHandler(this.number_plus_Click);
            // 
            // number_minus
            // 
            this.number_minus.Location = new System.Drawing.Point(10, 81);
            this.number_minus.Name = "number_minus";
            this.number_minus.Size = new System.Drawing.Size(75, 61);
            this.number_minus.TabIndex = 17;
            this.number_minus.Text = "-";
            this.number_minus.UseVisualStyleBackColor = true;
            this.number_minus.Click += new System.EventHandler(this.number_minus_Click);
            // 
            // number_multiplu
            // 
            this.number_multiplu.Location = new System.Drawing.Point(10, 149);
            this.number_multiplu.Name = "number_multiplu";
            this.number_multiplu.Size = new System.Drawing.Size(75, 61);
            this.number_multiplu.TabIndex = 18;
            this.number_multiplu.Text = "*";
            this.number_multiplu.UseVisualStyleBackColor = true;
            this.number_multiplu.Click += new System.EventHandler(this.number_multiplication_Click);
            // 
            // number_devesion
            // 
            this.number_devesion.Location = new System.Drawing.Point(102, 149);
            this.number_devesion.Name = "number_devesion";
            this.number_devesion.Size = new System.Drawing.Size(75, 61);
            this.number_devesion.TabIndex = 19;
            this.number_devesion.Text = "/";
            this.number_devesion.UseVisualStyleBackColor = true;
            this.number_devesion.Click += new System.EventHandler(this.number_division_Click);
            // 
            // number_sin
            // 
            this.number_sin.Location = new System.Drawing.Point(102, 15);
            this.number_sin.Name = "number_sin";
            this.number_sin.Size = new System.Drawing.Size(75, 61);
            this.number_sin.TabIndex = 20;
            this.number_sin.Text = "sin";
            this.number_sin.UseVisualStyleBackColor = true;
            this.number_sin.Click += new System.EventHandler(this.number_sin_Click);
            // 
            // number_cos
            // 
            this.number_cos.Location = new System.Drawing.Point(102, 81);
            this.number_cos.Name = "number_cos";
            this.number_cos.Size = new System.Drawing.Size(75, 61);
            this.number_cos.TabIndex = 21;
            this.number_cos.Text = "cos";
            this.number_cos.UseVisualStyleBackColor = true;
            this.number_cos.Click += new System.EventHandler(this.number_cos_Click);
            // 
            // number_arcsin
            // 
            this.number_arcsin.Location = new System.Drawing.Point(192, 15);
            this.number_arcsin.Name = "number_arcsin";
            this.number_arcsin.Size = new System.Drawing.Size(79, 61);
            this.number_arcsin.TabIndex = 22;
            this.number_arcsin.Text = "arcsin";
            this.number_arcsin.UseVisualStyleBackColor = true;
            this.number_arcsin.Click += new System.EventHandler(this.number_arc_sin_Click);
            // 
            // number_asrccos
            // 
            this.number_asrccos.Location = new System.Drawing.Point(196, 81);
            this.number_asrccos.Name = "number_asrccos";
            this.number_asrccos.Size = new System.Drawing.Size(75, 61);
            this.number_asrccos.TabIndex = 23;
            this.number_asrccos.Text = "arccos";
            this.number_asrccos.UseVisualStyleBackColor = true;
            this.number_asrccos.Click += new System.EventHandler(this.number_arc_cos_Click);
            // 
            // number_stepen
            // 
            this.number_stepen.Location = new System.Drawing.Point(196, 148);
            this.number_stepen.Name = "number_stepen";
            this.number_stepen.Size = new System.Drawing.Size(79, 61);
            this.number_stepen.TabIndex = 24;
            this.number_stepen.Text = "^";
            this.number_stepen.UseVisualStyleBackColor = true;
            this.number_stepen.Click += new System.EventHandler(this.number_degree_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(298, 149);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 61);
            this.button25.TabIndex = 25;
            this.button25.Text = "button25";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(298, 14);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 61);
            this.button26.TabIndex = 26;
            this.button26.Text = "button26";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(298, 81);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 61);
            this.button27.TabIndex = 27;
            this.button27.Text = "button27";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // textBox_input
            // 
            this.textBox_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_input.Location = new System.Drawing.Point(12, 22);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(748, 109);
            this.textBox_input.TabIndex = 30;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.number_3);
            this.groupBox1.Controls.Add(this.number_4);
            this.groupBox1.Controls.Add(this.number_2);
            this.groupBox1.Controls.Add(this.number_5);
            this.groupBox1.Controls.Add(this.number_1);
            this.groupBox1.Controls.Add(this.number_6);
            this.groupBox1.Controls.Add(this.number_LSk);
            this.groupBox1.Controls.Add(this.number_RSk);
            this.groupBox1.Location = new System.Drawing.Point(1, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 174);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Буквы";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // number_LSk
            // 
            this.number_LSk.Location = new System.Drawing.Point(283, 17);
            this.number_LSk.Name = "number_LSk";
            this.number_LSk.Size = new System.Drawing.Size(83, 61);
            this.number_LSk.TabIndex = 13;
            this.number_LSk.Text = "(";
            this.number_LSk.UseVisualStyleBackColor = true;
            this.number_LSk.Click += new System.EventHandler(this.number_left_bracket_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.number_cos);
            this.groupBox2.Controls.Add(this.number_plus);
            this.groupBox2.Controls.Add(this.number_minus);
            this.groupBox2.Controls.Add(this.number_multiplu);
            this.groupBox2.Controls.Add(this.number_devesion);
            this.groupBox2.Controls.Add(this.button27);
            this.groupBox2.Controls.Add(this.number_sin);
            this.groupBox2.Controls.Add(this.button26);
            this.groupBox2.Controls.Add(this.number_arcsin);
            this.groupBox2.Controls.Add(this.button25);
            this.groupBox2.Controls.Add(this.number_asrccos);
            this.groupBox2.Controls.Add(this.number_stepen);
            this.groupBox2.Location = new System.Drawing.Point(373, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 231);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Символы";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(182, 570);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(105, 62);
            this.button_close.TabIndex = 29;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(52, 570);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(105, 62);
            this.button_ok.TabIndex = 28;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 644);
            this.Controls.Add(this.buttom_move_left);
            this.Controls.Add(this.buttom_move_right);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_ok);
            this.Name = "Input";
            this.Text = "Мастер функций";
            this.Load += new System.EventHandler(this.Input_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TextBox textBox_input;

        private System.Windows.Forms.Button number_minus;

        private System.Windows.Forms.Button number_plus;

        private System.Windows.Forms.Button number_5;

        private System.Windows.Forms.Button number_6;

        private System.Windows.Forms.Button number_4;

        private System.Windows.Forms.Button number_3;

        private System.Windows.Forms.Button number_2;

        private System.Windows.Forms.Button number_LSk;
        private System.Windows.Forms.Button number_RSk;

        private System.Windows.Forms.Button number_1;

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_close;

        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button number_multiplu;
        private System.Windows.Forms.Button number_devesion;
        private System.Windows.Forms.Button number_sin;
        private System.Windows.Forms.Button number_cos;
        private System.Windows.Forms.Button number_arcsin;
        private System.Windows.Forms.Button number_asrccos;
        private System.Windows.Forms.Button number_stepen;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;

        private System.Windows.Forms.Button buttom_move_left;
        private System.Windows.Forms.Button buttom_move_right;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;

        #endregion
    }
}