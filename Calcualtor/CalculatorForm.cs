using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calcualtor
{
    public partial class CalculatorForm : Form
    {
        private Operators _currentOperator;
        private double _firstValue;
        private double _secondValue;
        public CalculatorForm()
        {
            InitializeComponent();
            _currentOperator = Operators.None;
        }
        private void Btn_Number(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (lInput.Text == "0")
                lInput.Text = button.Text;
            else
                lInput.Text += button.Text;
        }
        private void bDot_Click(object sender, EventArgs e)
        {
            if (lInput.Text.Contains(".")) return;
            lInput.Text += bDot.Text;
        }
        private void bPow_Click(object sender, EventArgs e)
        {
            double input = double.Parse(lInput.Text);
            double result = Math.Pow(input, 2);
            lInput.Text = result.ToString();
        }
        private void bSqrt_Click(object sender, EventArgs e)
        {
            double input = double.Parse(lInput.Text);
            double result = Math.Sqrt(input);
            lInput.Text = result.ToString();
        }
        private void bPlus_Click(object sender, EventArgs e)
        {
            _firstValue = double.Parse(lInput.Text);
            _currentOperator = Operators.Plus;
            lInput.Text = "0";
        }
        private void bMinus_Click(object sender, EventArgs e)
        {
            _firstValue = double.Parse(lInput.Text);
            _currentOperator = Operators.Minus;
            lInput.Text = "0";
        }
        private void bMultiple_Click(object sender, EventArgs e)
        {
            _firstValue = double.Parse(lInput.Text);
            _currentOperator = Operators.Multiple;
            lInput.Text = "0";
        }
        private void bDevide_Click(object sender, EventArgs e)
        {
            _firstValue = double.Parse(lInput.Text);
            _currentOperator = Operators.Devide;
            lInput.Text = "0";
        }
        private void bResult_Click(object sender, EventArgs e)
        {
            _secondValue = double.Parse(lInput.Text);
            double result = 0;

            switch (_currentOperator)
            {
                case Operators.Plus:
                    result = _firstValue + _secondValue;
                    break;
                case Operators.Minus:
                    result = _firstValue - _secondValue;
                    break;
                case Operators.Multiple:
                    result = _firstValue * _secondValue;
                    break;
                case Operators.Devide:
                    try
                    {
                        result = _firstValue / _secondValue;
                    }
                    catch (Exception)
                    {
                        _secondValue = 0;
                        MessageBox.Show("Calculator", "You can't devide on 0");
                    }
                    break;
                default:
                    return;
            }
            _currentOperator = Operators.None;
            lInput.Text = result.ToString();
        }
        private void bClear_Click(object sender, EventArgs e)
        {
            _firstValue = _secondValue = 0;
            lInput.Text = "0";
            _currentOperator = Operators.None;
        }
        private void bSign_Click(object sender, EventArgs e)
        {
            double value = double.Parse(lInput.Text);
            lInput.Text = (value * -1).ToString();
        }
    }
}
