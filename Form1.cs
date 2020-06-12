using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double enterednumber1;
        string operationtype;

        //button 0
        private void zero_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + "0";
        }

        //button 1
        private void one_Click(object sender, EventArgs e)
        {        
            if(TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "1";
            }
            else
            {
                TextBox.Text = TextBox.Text + "1";
            }
        }

        //button 2
        private void two_Click(object sender, EventArgs e)
        {
            if(TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "2";
            }
            else
            {
                TextBox.Text = TextBox.Text + "2";
            }
        }

        //button 3
        private void three_Click(object sender, EventArgs e)
        {

            if(TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "3";
            }
            else
            {
                TextBox.Text = TextBox.Text + "3";
            }
        }

        //button 4
        private void four_Click(object sender, EventArgs e)
        {
            if(TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "4";
            }
            else
            {
                TextBox.Text = TextBox.Text + "4";
            }
        }

        //button 5
        private void five_Click(object sender, EventArgs e)
        {
            if(TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "5";
            }
            else
            {
                TextBox.Text = TextBox.Text + "5";
            }
        }

        //button 6
        private void six_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "6";
            }
            else
            {
                TextBox.Text = TextBox.Text + "6";
            }
        }

        //button 7
        private void seven_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "7";
            }
            else
            {
                TextBox.Text = TextBox.Text + "7";
            }
        }

        //button 8
        private void eight_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "8";
            }
            else
            {
                TextBox.Text = TextBox.Text + "8";
            }
        }

        //button 9
        private void nine_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "9";
            }
            else
            {
                TextBox.Text = TextBox.Text + "9";
            }
        }

       
       //button Addition 
        private void add_Click(object sender,EventArgs e)
        {
            enterednumber1 = Convert.ToDouble(TextBox.Text);
            TextBox.Text = "0";
            operationtype = "+";
        }

        //button Subtraction
        private void sub_Click(object sender,EventArgs e)
        {
            enterednumber1 = Convert.ToDouble(TextBox.Text);
            TextBox.Text = "0";
            operationtype = "-";
        }

        //button Multiplication
        private void multiplion_Click(object sender, EventArgs e)
        {
            enterednumber1 = Convert.ToDouble(TextBox.Text);
            TextBox.Text = "0";
            operationtype = "*";
        }

        //button Divide
        private void div_Click(object sender, EventArgs e)
        {
            enterednumber1 = Convert.ToDouble(TextBox.Text);
            TextBox.Text = "";
            operationtype = "/";
        }

        //button ClearTextBox
        private void clear_Click(object sender,EventArgs e)
        {
            TextBox.Text = "0";
        }

        //button Dot
        private void dot_Click(object sender,EventArgs e)
        {
            TextBox.Text = TextBox.Text + ".";
        }

        //Calculation Section

            private void equals_Click(object sender, EventArgs e)
        {
            double enterednumber2;
            double result;

            enterednumber2 = Convert.ToDouble(TextBox.Text);

            if(operationtype == "+")
            {
                result = (enterednumber1 + enterednumber2);
                TextBox.Text = Convert.ToString(result);
                enterednumber1 = result;
            }

            if (operationtype == "-")
            {
            
                result = (enterednumber1 - enterednumber2);
                TextBox.Text = Convert.ToString(result);
                enterednumber1 = result;
            }

            if (operationtype == "*")
            {
                result = (enterednumber1 * enterednumber2);
                TextBox.Text = Convert.ToString(result);
                enterednumber1 = result;
            }

            if (operationtype == "/")
            {
               if(enterednumber2 == 0)
                {
                    TextBox.Text = "Number cannot be divided by zero because the result is infinite!";
                }
                else
                {
                    result = (enterednumber1 / enterednumber2);
                    TextBox.Text = Convert.ToString(result);
                    enterednumber1 = result;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {     
            
        }
    }
}
