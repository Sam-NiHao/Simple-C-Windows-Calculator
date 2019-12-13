using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double ResultValue = 0;
        string OperationPerformed = "";
        bool IsOperationPerformed = false;
        bool EqualFlag = false;

        public Calculator()
        {
            InitializeComponent();
        }

        #region Logic for all the buttons
        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            CleanTextResult();

            IsOperationPerformed = false;

            CheckTextEqualsDot(button);

            label1.Focus();
        }
        private void CleanTextResult()
        {
            if (EqualFlag)
            {
                textResult.Clear();
                EqualFlag = false;
            }

            if (textResult.Text == "0" || IsOperationPerformed)
            {
                textResult.Clear();
            }
        }
        private void CheckTextEqualsDot(Button button)
        {
            if (button.Text == ".")
            {
                CheckTextResultContainsDot(button);
            }
            else
            {
                textResult.Text = textResult.Text + button.Text;
            }
        }
        private void CheckTextResultContainsDot(Button button)
        {
            if (!textResult.Text.Contains("."))
            {
                CheckTextResultEqualEmpty(button);
            }
        }
        private void CheckTextResultEqualEmpty(Button button)
        {
            if (textResult.Text == "")
            {
                textResult.Text = "0" + button.Text;
            }
            else
            {
                textResult.Text = textResult.Text + button.Text;
            }
        }
        #endregion

        #region Logic for all the operators
        private void OperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            CheckCondition(button);

            OperationPerformed = button.Text;
            historyTextBox.Text = ResultValue + " " + OperationPerformed;
        }
        private void CheckCondition(Button button)
        {
            if (IsOperationPerformed)
            {
                return;
            }

            if (ResultValue != 0)
            {
                CheckHistoryTextBox(button);
            }
            else
            {
                ResultValue = double.Parse(textResult.Text, CultureInfo.InvariantCulture);
                ChangeCondition(button);
            }
        }
        private void CheckHistoryTextBox(Button button)
        {
            if (historyTextBox.Text == "")
            {
                ResultValue = double.Parse(textResult.Text, CultureInfo.InvariantCulture);
                ChangeCondition(button);
            }
            else
            {
                buttonEqual.PerformClick();
                ChangeCondition(button);
            }
        }
        private void ChangeCondition(Button button)
        {
            IsOperationPerformed = true;
            OperationPerformed = button.Text;
            historyTextBox.Text = ResultValue + " " + OperationPerformed;
        }
        #endregion

        #region Logic for the equal button 
        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            historyTextBox.Text = "";

            Calculation(OperationPerformed);

            IsOperationPerformed = false;
            ResultValue = double.Parse(textResult.Text);
            historyTextBox.Text = "";
            EqualFlag = true;
        }
        private void Calculation(string operation)
        {
            switch (operation)
            {
                case "+":
                    textResult.Text = (ResultValue + double.Parse(textResult.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "-":
                    textResult.Text = (ResultValue - double.Parse(textResult.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "*":
                    textResult.Text = (ResultValue * double.Parse(textResult.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "/":
                    textResult.Text = (ResultValue / double.Parse(textResult.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                default:
                    break;
            }
        }
        #endregion

        private void ButtonClearEntry_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
            label1.Focus();
        }
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
            ResultValue = 0;
            historyTextBox.Text = "";
            label1.Focus();
        }
        private void ButtonsKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Back ? true : false)
            {
                buttonRemove.PerformClick();
            }
            else
            {
                switch (e.KeyChar.ToString())
                {
                    case "0":
                        buttonZero.PerformClick();
                        break;
                    case "1":
                        buttonOne.PerformClick();
                        break;
                    case "2":
                        buttonTwo.PerformClick();
                        break;
                    case "3":
                        buttonThree.PerformClick();
                        break;
                    case "4":
                        buttonFour.PerformClick();
                        break;
                    case "5":
                        buttonFive.PerformClick();
                        break;
                    case "6":
                        buttonSix.PerformClick();
                        break;
                    case "7":
                        buttonSeven.PerformClick();
                        break;
                    case "8":
                        buttonEight.PerformClick();
                        break;
                    case "9":
                        buttonNine.PerformClick();
                        break;
                    case "+":
                        buttonPlus.PerformClick();
                        break;
                    case "-":
                        buttonMinus.PerformClick();
                        break;
                    case "*":
                        buttonMultiplication.PerformClick();
                        break;
                    case "/":
                        buttonDivision.PerformClick();
                        break;
                    case ".":
                        buttonPoint.PerformClick();
                        break;
                    case "=":
                        buttonEqual.PerformClick();
                        break;
                    case " ":
                        buttonEqual.PerformClick();
                        break;
                    case "\r":
                        buttonEqual.PerformClick();
                        break;
                    default:
                        break;
                }
            }
        }
        private void BackspaceClick(object sender, EventArgs e)
        {
            if (textResult.Text.Length > 0)
            {
                textResult.Text = textResult.Text.Remove(textResult.Text.Length - 1, 1);
            }

            if (textResult.Text == "")
            {
                textResult.Text = "0";
            }

            label1.Focus();
        }
    }
}