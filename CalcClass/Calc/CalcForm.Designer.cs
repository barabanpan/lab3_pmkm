namespace Calc
{
    partial class CalcForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonRightParenthesis = new System.Windows.Forms.Button();
            this.buttonLeftParenthesis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonUnary = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.buttonEscape = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expression";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonC);
            this.groupBox1.Controls.Add(this.buttonBackspace);
            this.groupBox1.Controls.Add(this.buttonRightParenthesis);
            this.groupBox1.Controls.Add(this.buttonLeftParenthesis);
            this.groupBox1.Location = new System.Drawing.Point(11, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editing";
            // 
            // buttonC
            // 
            this.buttonC.ForeColor = System.Drawing.Color.Red;
            this.buttonC.Location = new System.Drawing.Point(214, 19);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(46, 28);
            this.buttonC.TabIndex = 3;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.ForeColor = System.Drawing.Color.Red;
            this.buttonBackspace.Location = new System.Drawing.Point(129, 19);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(79, 28);
            this.buttonBackspace.TabIndex = 2;
            this.buttonBackspace.Text = "Backspace";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonRightParenthesis
            // 
            this.buttonRightParenthesis.Location = new System.Drawing.Point(51, 19);
            this.buttonRightParenthesis.Name = "buttonRightParenthesis";
            this.buttonRightParenthesis.Size = new System.Drawing.Size(39, 28);
            this.buttonRightParenthesis.TabIndex = 1;
            this.buttonRightParenthesis.Text = ")";
            this.buttonRightParenthesis.UseVisualStyleBackColor = true;
            this.buttonRightParenthesis.Click += new System.EventHandler(this.buttonRightParenthesis_Click);
            // 
            // buttonLeftParenthesis
            // 
            this.buttonLeftParenthesis.Location = new System.Drawing.Point(6, 19);
            this.buttonLeftParenthesis.Name = "buttonLeftParenthesis";
            this.buttonLeftParenthesis.Size = new System.Drawing.Size(39, 28);
            this.buttonLeftParenthesis.TabIndex = 0;
            this.buttonLeftParenthesis.Text = "(";
            this.buttonLeftParenthesis.UseVisualStyleBackColor = true;
            this.buttonLeftParenthesis.Click += new System.EventHandler(this.buttonLeftParenthesis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.ForeColor = System.Drawing.Color.Red;
            this.buttonDiv.Location = new System.Drawing.Point(152, 121);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(39, 28);
            this.buttonDiv.TabIndex = 7;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.ForeColor = System.Drawing.Color.Red;
            this.buttonMult.Location = new System.Drawing.Point(152, 155);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(39, 28);
            this.buttonMult.TabIndex = 11;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(107, 155);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 28);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(62, 155);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 28);
            this.button5.TabIndex = 9;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.ForeColor = System.Drawing.Color.Red;
            this.buttonSub.Location = new System.Drawing.Point(152, 189);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(39, 28);
            this.buttonSub.TabIndex = 15;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(107, 189);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(39, 28);
            this.button9.TabIndex = 14;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(62, 189);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(39, 28);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 189);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 28);
            this.button7.TabIndex = 12;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.ForeColor = System.Drawing.Color.Red;
            this.buttonAdd.Location = new System.Drawing.Point(152, 223);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(39, 28);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Location = new System.Drawing.Point(107, 223);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(39, 28);
            this.buttonMod.TabIndex = 18;
            this.buttonMod.Text = "mod";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // button0
            // 
            this.button0.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button0.Location = new System.Drawing.Point(62, 223);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(39, 28);
            this.button0.TabIndex = 17;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonUnary
            // 
            this.buttonUnary.Location = new System.Drawing.Point(15, 223);
            this.buttonUnary.Name = "buttonUnary";
            this.buttonUnary.Size = new System.Drawing.Size(39, 28);
            this.buttonUnary.TabIndex = 16;
            this.buttonUnary.Text = "+/-";
            this.buttonUnary.UseVisualStyleBackColor = true;
            this.buttonUnary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonUnary_MouseDown);
            this.buttonUnary.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonUnary_MouseUp);
            // 
            // buttonEqual
            // 
            this.buttonEqual.ForeColor = System.Drawing.Color.Red;
            this.buttonEqual.Location = new System.Drawing.Point(232, 223);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(39, 28);
            this.buttonEqual.TabIndex = 23;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.ForeColor = System.Drawing.Color.Blue;
            this.buttonMC.Location = new System.Drawing.Point(232, 189);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(39, 28);
            this.buttonMC.TabIndex = 22;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // buttonM
            // 
            this.buttonM.ForeColor = System.Drawing.Color.Blue;
            this.buttonM.Location = new System.Drawing.Point(232, 155);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(39, 28);
            this.buttonM.TabIndex = 21;
            this.buttonM.Text = "M+";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // buttonMR
            // 
            this.buttonMR.ForeColor = System.Drawing.Color.Blue;
            this.buttonMR.Location = new System.Drawing.Point(232, 121);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(39, 28);
            this.buttonMR.TabIndex = 20;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            this.buttonMR.Click += new System.EventHandler(this.buttonMR_Click);
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.Location = new System.Drawing.Point(76, 9);
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(195, 20);
            this.textBoxExpression.TabIndex = 24;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Location = new System.Drawing.Point(76, 35);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(195, 20);
            this.textBoxResult.TabIndex = 25;
            this.textBoxResult.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Location = new System.Drawing.Point(11, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 55);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editing";
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.Color.Red;
            this.button10.Location = new System.Drawing.Point(214, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(46, 28);
            this.button10.TabIndex = 3;
            this.button10.Text = "C";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // button11
            // 
            this.button11.ForeColor = System.Drawing.Color.Red;
            this.button11.Location = new System.Drawing.Point(129, 19);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(79, 28);
            this.button11.TabIndex = 2;
            this.button11.Text = "Backspace";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(51, 19);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(39, 28);
            this.button12.TabIndex = 1;
            this.button12.Text = ")";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.buttonRightParenthesis_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(6, 19);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(39, 28);
            this.button13.TabIndex = 0;
            this.button13.Text = "(";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.buttonLeftParenthesis_Click);
            // 
            // buttonEscape
            // 
            this.buttonEscape.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEscape.ForeColor = System.Drawing.Color.Red;
            this.buttonEscape.Location = new System.Drawing.Point(289, 121);
            this.buttonEscape.Name = "buttonEscape";
            this.buttonEscape.Size = new System.Drawing.Size(39, 28);
            this.buttonEscape.TabIndex = 26;
            this.buttonEscape.Text = "Esc";
            this.buttonEscape.UseVisualStyleBackColor = true;
            this.buttonEscape.Click += new System.EventHandler(this.buttonEscape_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CalcForm
            // 
            this.AcceptButton = this.buttonEqual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonEscape;
            this.ClientSize = new System.Drawing.Size(283, 266);
            this.Controls.Add(this.buttonEscape);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxExpression);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonUnary);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "CalcForm";
            this.Text = "Calc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonRightParenthesis;
        private System.Windows.Forms.Button buttonLeftParenthesis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonUnary;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button buttonEscape;
        private System.Windows.Forms.Timer timer1;
    }
}

