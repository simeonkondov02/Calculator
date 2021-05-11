using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nums = new List<double>();
        }

        string input, operation;

        readonly List<double> nums;

        double result, memory;

        #region NumberButtons
        private void _0Button_Click(object sender, EventArgs e)
        {
            input += 0;
            PrintNumbers("0");
        }

        private void _1Button_Click(object sender, EventArgs e)
        {
            input += 1;
            PrintNumbers("1");
        }

        private void _2Button_Click(object sender, EventArgs e)
        {
            input += 2;
            PrintNumbers("2");
        }

        private void _3Button_Click(object sender, EventArgs e)
        {
            input += 3;
            PrintNumbers("3");
        }

        private void _4Button_Click(object sender, EventArgs e)
        {
            input += 4;
            PrintNumbers("4");
        }

        private void _5Button_Click(object sender, EventArgs e)
        {
            input += 5;
            PrintNumbers("5");
        }

        private void _6Button_Click(object sender, EventArgs e)
        {
            input += 6;
            PrintNumbers("6");
        }

        private void _7Button_Click(object sender, EventArgs e)
        {
            input += 7;
            PrintNumbers("7");
        }

        private void _8Button_Click(object sender, EventArgs e)
        {
            input += 8;
            PrintNumbers("8");
        }

        private void _9Button_Click(object sender, EventArgs e)
        {
            input += 9;
            PrintNumbers("9");
        }


        private void PointButton_Click(object sender, EventArgs e)
        {
            input += ".";
            PrintNumbers(".");
        }
        #endregion

        #region OperationButtons
        private void DivisionButton_Click(object sender, EventArgs e)
        {
            NextOperation(" / ");
            operation = "/";
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            NextOperation(" * ");
            operation = "*";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            NextOperation(" - ");
            operation = "-";
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            NextOperation(" + ");
            operation = "+";
        }

        private void HypocriticallyButton_Click(object sender, EventArgs e)
        {
            NextOperation(" / 1 ");
            operation = "1/";
        }

        private void DegreeButton_Click(object sender, EventArgs e)
        {
            NextOperation(" ^ ");
            operation = "^";
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            NextOperation(" sqrt ");
            operation = "sqrt";
        }
        #endregion

        void PrintNumbers(string output)
        {
            resultTextBox.Text += output;
        }

        void NextOperation(string operation)
        {
            if (operationsTextBox.Text.Length == 0)
            {
                operationsTextBox.Text += resultTextBox.Text;
            }
            
            double n = double.Parse(resultTextBox.Text);
            n = Math.Abs(n);

            nums.Add(n);

            operationsTextBox.Text += operation;
            
            resultTextBox.Clear();
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0" && operation == "/")
            {
                MessageBox.Show("You can't reduce by 0", "Logical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                resultTextBox.Clear();
                nums.RemoveAt(nums.Count - 1);
            }
            else
            {
                int index;

                operationsTextBox.Text += resultTextBox.Text;

                if (resultTextBox.Text.Length > 0)
                {
                    nums.Add(double.Parse(resultTextBox.Text));
                }

                index = nums.Count - 1;

                if (operation == "sqrt" || operation == "1/")
                {
                    result = GetResult(nums.ElementAt(nums.Count - 1));
                }
                else
                {
                    result = GetResult(nums.ElementAt(nums.Count - 1), nums.ElementAt(nums.Count - 2));
                }

                resultTextBox.Text = result.ToString();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();

            nums.RemoveAt(nums.Count - 1);
        }


        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            operationsTextBox.Clear();
            resultTextBox.Clear();

            nums.Clear();
        }

        private void MAddButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text.Length > 0)
            {
                memory = double.Parse(resultTextBox.Text);

                mrButton.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                mrButton.ForeColor = SystemColors.ActiveCaptionText;
            }
        }

        private void MRemoveButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
        }

        private void MCButton_Click(object sender, EventArgs e)
        {
            memory = 0;

            mrButton.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            mrButton.ForeColor = SystemColors.ControlText;
        }

        private void MRButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = memory.ToString();
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text.Length > 0)
            {
                resultTextBox.Text = resultTextBox.Text.Remove(resultTextBox.Text.Length - 1);
            }
        }

        private void NegativeButton_Click(object sender, EventArgs e)
        {
            double reversedNum = double.Parse(resultTextBox.Text) * -1;

            resultTextBox.Text = reversedNum.ToString();
        }

        private double GetResult(double a, double b)
        {
            switch (operation)
            {
                case "+":
                    return a + b;

                case "-":
                    return (a - b) * -1;

                case "*":
                    return a * b;

                case "/":
                    return a / b;

                case "^":
                    return Math.Pow(a, b);

                default:
                    return 0;
            }
        }

        private double GetResult(double a)
        {
            switch (operation)
            {
                case "1/":
                    return 1 / a;

                case "sqrt":
                    return Math.Sqrt(2);

                default:
                    return 0;
            }
        }
    }
}
