using System;
using System.Data;
using System.Linq.Expressions;

namespace Calculator

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OutputTextBox.Text = string.Empty;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<char> CalculationString = new List<char>(OutputTextBox.Text);
                int Length = CalculationString.Count;
                CalculationString.RemoveAt(Length - 1);
                OutputTextBox.Text = string.Empty;
                foreach (char character in CalculationString)
                {
                    OutputTextBox.Text += character;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + "7";
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + "8";
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + "9";
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + "4";
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + "5";
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + "6";
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + "1";
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + "2";
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + "3";
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + "0";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + "+";
        }

        private void Button_Subtract_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + "-";
        }

        private void Button_Multiply_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + "*";
        }

        private void Button_Divide_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + "/";
        }

        private void Button_Decimal_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + ".";
        }

        private void EvaluateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(OutputTextBox.Text, null);
                OutputTextBox.Text = result.ToString();
            }
            catch (System.OverflowException)
            {
                OutputTextBox.Text = "Overflow Error";
            }
            catch (System.DivideByZeroException)
            {
                OutputTextBox.Text = "Zero Division Error";
            }
            catch (System.Data.SyntaxErrorException)
            {
                OutputTextBox.Text = "Syntax Error";
            }
        }

        private void LeftParaButton_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + "(";
        }

        private void RightParaButton_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "Overflow Error" || OutputTextBox.Text == "Zero Division Error" || OutputTextBox.Text == "Syntax Error")
            {
                OutputTextBox.Text = string.Empty;
            }
            OutputTextBox.Text = OutputTextBox.Text + ")";
        }
    }
}