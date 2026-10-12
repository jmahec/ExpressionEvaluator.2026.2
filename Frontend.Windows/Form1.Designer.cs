namespace Frontend.Windows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnOpenParenthesis = new Button();
            btnCloseParenthesis = new Button();
            btnDelete = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnClear = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnPow = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnResult = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.Green;
            txtDisplay.BorderStyle = BorderStyle.FixedSingle;
            txtDisplay.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(12, 14);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(526, 50);
            txtDisplay.TabIndex = 0;
            txtDisplay.TabStop = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.White;
            btn7.FlatAppearance.BorderColor = Color.Gainsboro;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.ForeColor = Color.Black;
            btn7.Location = new Point(12, 80);
            btn7.Name = "btn7";
            btn7.Size = new Size(70, 60);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnInput_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.White;
            btn8.FlatAppearance.BorderColor = Color.Gainsboro;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.ForeColor = Color.Black;
            btn8.Location = new Point(88, 80);
            btn8.Name = "btn8";
            btn8.Size = new Size(70, 60);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnInput_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.White;
            btn9.FlatAppearance.BorderColor = Color.Gainsboro;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.ForeColor = Color.Black;
            btn9.Location = new Point(164, 80);
            btn9.Name = "btn9";
            btn9.Size = new Size(70, 60);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnInput_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnOpenParenthesis.FlatAppearance.BorderColor = Color.Gainsboro;
            btnOpenParenthesis.FlatStyle = FlatStyle.Flat;
            btnOpenParenthesis.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenParenthesis.ForeColor = Color.Black;
            btnOpenParenthesis.Location = new Point(240, 80);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(70, 60);
            btnOpenParenthesis.TabIndex = 4;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnInput_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnCloseParenthesis.FlatAppearance.BorderColor = Color.Gainsboro;
            btnCloseParenthesis.FlatStyle = FlatStyle.Flat;
            btnCloseParenthesis.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseParenthesis.ForeColor = Color.Black;
            btnCloseParenthesis.Location = new Point(316, 80);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(70, 60);
            btnCloseParenthesis.TabIndex = 5;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnInput_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.FlatAppearance.BorderColor = Color.Gainsboro;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(392, 80);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 60);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.White;
            btn4.FlatAppearance.BorderColor = Color.Gainsboro;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.ForeColor = Color.Black;
            btn4.Location = new Point(12, 146);
            btn4.Name = "btn4";
            btn4.Size = new Size(70, 60);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnInput_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.White;
            btn5.FlatAppearance.BorderColor = Color.Gainsboro;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.ForeColor = Color.Black;
            btn5.Location = new Point(88, 146);
            btn5.Name = "btn5";
            btn5.Size = new Size(70, 60);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnInput_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.White;
            btn6.FlatAppearance.BorderColor = Color.Gainsboro;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.ForeColor = Color.Black;
            btn6.Location = new Point(164, 146);
            btn6.Name = "btn6";
            btn6.Size = new Size(70, 60);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnInput_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiply.FlatAppearance.BorderColor = Color.Gainsboro;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.ForeColor = Color.Black;
            btnMultiply.Location = new Point(240, 146);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(70, 60);
            btnMultiply.TabIndex = 10;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnInput_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 128, 0);
            btnDivide.FlatAppearance.BorderColor = Color.Gainsboro;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.ForeColor = Color.Black;
            btnDivide.Location = new Point(316, 146);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(70, 60);
            btnDivide.TabIndex = 11;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnInput_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.FlatAppearance.BorderColor = Color.Gainsboro;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(392, 146);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(146, 60);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.FlatAppearance.BorderColor = Color.Gainsboro;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(12, 212);
            btn1.Name = "btn1";
            btn1.Size = new Size(70, 60);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnInput_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.White;
            btn2.FlatAppearance.BorderColor = Color.Gainsboro;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(88, 212);
            btn2.Name = "btn2";
            btn2.Size = new Size(70, 60);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnInput_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.FlatAppearance.BorderColor = Color.Gainsboro;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.Black;
            btn3.Location = new Point(164, 212);
            btn3.Name = "btn3";
            btn3.Size = new Size(70, 60);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnInput_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlus.FlatAppearance.BorderColor = Color.Gainsboro;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.ForeColor = Color.Black;
            btnPlus.Location = new Point(240, 212);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(70, 60);
            btnPlus.TabIndex = 16;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnInput_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnMinus.FlatAppearance.BorderColor = Color.Gainsboro;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.ForeColor = Color.Black;
            btnMinus.Location = new Point(316, 212);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(70, 60);
            btnMinus.TabIndex = 17;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnInput_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.FromArgb(255, 128, 0);
            btnPow.FlatAppearance.BorderColor = Color.Gainsboro;
            btnPow.FlatStyle = FlatStyle.Flat;
            btnPow.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPow.ForeColor = Color.Black;
            btnPow.Location = new Point(392, 212);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(146, 60);
            btnPow.TabIndex = 18;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnInput_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.White;
            btn0.FlatAppearance.BorderColor = Color.Gainsboro;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.ForeColor = Color.Black;
            btn0.Location = new Point(12, 278);
            btn0.Name = "btn0";
            btn0.Size = new Size(146, 60);
            btn0.TabIndex = 19;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnInput_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.White;
            btnDot.FlatAppearance.BorderColor = Color.Gainsboro;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.ForeColor = Color.Black;
            btnDot.Location = new Point(164, 278);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(70, 60);
            btnDot.TabIndex = 20;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnInput_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(255, 128, 0);
            btnResult.FlatAppearance.BorderColor = Color.Gainsboro;
            btnResult.FlatStyle = FlatStyle.Flat;
            btnResult.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResult.ForeColor = Color.Black;
            btnResult.Location = new Point(240, 278);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(298, 60);
            btnResult.TabIndex = 21;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(550, 350);
            Controls.Add(txtDisplay);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnDelete);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnClear);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnPow);
            Controls.Add(btn0);
            Controls.Add(btnDot);
            Controls.Add(btnResult);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Functions Evaluator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnOpenParenthesis;
        private Button btnCloseParenthesis;
        private Button btnDelete;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnClear;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnPow;
        private Button btn0;
        private Button btnDot;
        private Button btnResult;
    }
}
