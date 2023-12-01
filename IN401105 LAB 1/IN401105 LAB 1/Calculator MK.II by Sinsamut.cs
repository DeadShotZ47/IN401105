using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IN401105_LAB_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //userinput = textBoxInput.Text
            //datatype
            //double -> ทศนิยม
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "Welcome to my Calculator";

            //textBoxInput.Text = textBoxInput1.Text; +"CIS KKU";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = string.Empty;
        }

        private void buttonNumber1_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "1";
        }

        private void buttonNumber2_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput += "2";
        }

        private void buttonNumber3_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "3";
        }

        private void buttonNumber4_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "4";
        }

        private void buttonNumber5_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "5";
        }

        private void buttonNumber6_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "6";
        }

        private void buttonNumber7_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "7";
        }

        private void buttonNumber8_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "8";
        }

        private void buttonNumber9_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "9";
        }

        private void buttonNumber0_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "0";
        }
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + ".";
        }

        string number1 = string.Empty;
        string operation;
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            //Clear Input textbox
            textBoxInput.Text = string.Empty;
            //Save operation
            operation = "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            //Clear Input textbox
            textBoxInput.Text = string.Empty;
            //Save operation
            operation = "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            //Clear Input textbox
            textBoxInput.Text = string.Empty;
            //Save operation
            operation = "x";
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            //Clear Input textbox
            textBoxInput.Text = string.Empty;
            //Save operation
            operation = "÷";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string number2 = textBoxInput.Text;
            float num1 = float.Parse(number1);
            float num2 = float.Parse(number2);
            //
            try { 
                if (operation == "+")
                {

                    float output = num1 + num2;
                    textBoxInput.Text = (output).ToString();

                }
                else if (operation == "-")
                {
                    float output = num1 - num2;
                    textBoxInput.Text = (output).ToString();
                }
                else if (operation == "x")
                {
                    float output = num1 * num2;
                    textBoxInput.Text = (output).ToString();
                }
                else if (operation == "÷")
                {
                    float output = num1 / num2;
                    textBoxInput.Text = (output).ToString();
                }
            }
           
            catch (DivideByZeroException)
            {
                textBoxInput.Text = "You can't divide by Zero";
            }
        }
    }
}
