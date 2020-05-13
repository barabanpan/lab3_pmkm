using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class CalcForm : Form
    {
        private double tempNumber = 0;
        public CalcForm()
        {
            InitializeComponent();
        }

        private void buttonLeftParenthesis_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + "(";
        }

        private void buttonRightParenthesis_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + ")";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + "0";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + "/";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + "*";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + "-";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + "+";
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBoxExpression.Text.Length > 0)
            {
                textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - 1);
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + "%";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = AnalyzerClass.Estimate(textBoxExpression.Text);
        }
        //private void buttonEqual_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        MessageBox.Show("Enter key pressed");
        //    }
            
        //}

        private void buttonM_Click(object sender, EventArgs e)
        {
            double number;
            if(Double.TryParse(textBoxResult.Text, out number))
            {
                tempNumber = tempNumber + Convert.ToDouble(textBoxResult.Text);
            }
            else
            {
                textBoxResult.Text = "Cannot be converted to a number";
            }
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            tempNumber = 0;
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text + tempNumber.ToString();
        }
        
        private void buttonEscape_Click(object sender, EventArgs e)
        {
            CalcForm.ActiveForm.Close();
        }
    }
}
