using System.Text;
using System.Text.RegularExpressions;
using System.Xml.XPath;

namespace SD_320_W22SD_Assignment
{
    public partial class Form1 : Form
    {
        public double StoredOperand { get; set; } = 0;
        public char StoredOperation { get; set; }
        public StringBuilder CalculatorInput { get; set; } = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void textbox_CalculatorInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex newRegex = new Regex(@"[*+/=-]");
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                CalculatorInput.Append(e.KeyChar);
            }
            else if (newRegex.IsMatch(e.KeyChar.ToString()) || e.KeyChar == 13)
            {
                e.Handled = true;
                if (StoredOperand != 0 && CalculatorInput.Length != 0)
                {
                    ComputeEquation();
                }
                else if (StoredOperand == 0 && CalculatorInput.Length != 0)
                {
                    StoredOperand = double.Parse(CalculatorInput.ToString());
                }
                CalculatorInput.Clear();
                textbox_CalculatorInput.Clear();
                StoredOperation = e.KeyChar;
                label_Equation.Text = $"{StoredOperand} {StoredOperation}";
            }
        }

        private void ComputeEquation()
        {
            switch (StoredOperation)
            {
                case '+':
                    StoredOperand += double.Parse(CalculatorInput.ToString());
                    break;
                case '-':
                    StoredOperand -= double.Parse(CalculatorInput.ToString());
                    break;
                case '/':
                    StoredOperand /= double.Parse(CalculatorInput.ToString());
                    break;
                case '*':
                    StoredOperand *= double.Parse(CalculatorInput.ToString());
                    break;

            }
        }

        #region Numpad Operations
        private void button_ClearCalculatorInput_Click(object sender, EventArgs e)
        {
            StoredOperand = 0;
            label_Equation.Text = "";
            CalculatorInput.Clear();
            textbox_CalculatorInput.Text = CalculatorInput.ToString();
            ShowKeys();
            button_ConvertBinaryToDecimal.Show();
            button_ConvertIntToBinary.Show();
            button_BinaryTab.BackColor = Color.Transparent;
            button_DecimalTab.BackColor = Color.Transparent;
            button_LocTab.BackColor = Color.Transparent;
        }

        private void button_PositiveNegativeOperand_Click(object sender, EventArgs e)
        {
            if (CalculatorInput.Length != 0)
            {
                CalculatorInput.Clear();
                CalculatorInput.Append(Int32.Parse(textbox_CalculatorInput.Text) * -1);
                textbox_CalculatorInput.Text = CalculatorInput.ToString();
            }
        }

        private void button_AdditionOperation_Click(object sender, EventArgs e)
        {
            if (StoredOperand != 0 && CalculatorInput.Length != 0)
            {
                ComputeEquation();
            }
            else if (StoredOperand == 0 && CalculatorInput.Length != 0)
            {
                StoredOperand = double.Parse(CalculatorInput.ToString());
            }
            StoredOperation = '+';
            CalculatorInput.Clear();
            textbox_CalculatorInput.Clear();
            label_Equation.Text = $"{StoredOperand} {StoredOperation}";
        }

        private void button_AppendZeroValueToInput_Click(object sender, EventArgs e)
        {
            CalculatorInput.Append('0');
            textbox_CalculatorInput.Text = CalculatorInput.ToString();
        }

        private void button_AppendDecimalPointToInput_Click(object sender, EventArgs e)
        {
            if (!CalculatorInput.ToString().Contains('.'))
            {
                CalculatorInput.Append('.');
                textbox_CalculatorInput.Text = CalculatorInput.ToString();
            }
        }

        private void button_AppendOneToInput_Click(object sender, EventArgs e)
        {
            CalculatorInput.Append('1');
            textbox_CalculatorInput.Text = CalculatorInput.ToString();
        }

        private void button_AppendTwoValueToInput_Click(object sender, EventArgs e)
        {
            CalculatorInput.Append('2');
            textbox_CalculatorInput.Text = CalculatorInput.ToString();
        }

        private void button_AppendThreeValueToInput_Click(object sender, EventArgs e)
        {
            CalculatorInput.Append('3');
            textbox_CalculatorInput.Text = CalculatorInput.ToString();
        }

        private void button_AppendFourToInput_Click(object sender, EventArgs e)
        {
            CalculatorInput.Append('4');
            textbox_CalculatorInput.Text = CalculatorInput.ToString();
        }

        private void button_AppendFiveValueToInput_Click(object sender, EventArgs e)
        {
            CalculatorInput.Append('5');
            textbox_CalculatorInput.Text = CalculatorInput.ToString();
        }

        private void button_AppendSixValueToInput_Click(object sender, EventArgs e)
        {
            CalculatorInput.Append('6');
            textbox_CalculatorInput.Text = CalculatorInput.ToString();
        }

        private void button_AppendSevenToInput_Click(object sender, EventArgs e)
        {
            CalculatorInput.Append('7');
            textbox_CalculatorInput.Text = CalculatorInput.ToString();
        }

        private void button_AppendEightValueToInput_Click(object sender, EventArgs e)
        {
            CalculatorInput.Append('8');
            textbox_CalculatorInput.Text = CalculatorInput.ToString();
        }

        private void button_AppendNineValueToInput_Click(object sender, EventArgs e)
        {
            CalculatorInput.Append('9');
            textbox_CalculatorInput.Text = CalculatorInput.ToString();
        }
        #endregion

        #region Convert Operations
        private void button_ConvertIntToBinary_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textbox_CalculatorInput.Text) > 0)
            {
                string binVal = Convert.ToString(Int32.Parse(textbox_CalculatorInput.Text), 2);
                CalculatorInput.Clear();
                CalculatorInput.Append(binVal);
                textbox_CalculatorInput.Text = CalculatorInput.ToString();
                button_BinaryTab.BackColor = Color.FromArgb(15, 68, 119);
                button_LocTab.BackColor = Color.Transparent;
                button_DecimalTab.BackColor = Color.Transparent;
                HideKeys();
                button_AppendZeroValueToInput.Show();
                button_AppendOneToInput.Show();
            }
        }

        private void button_ConvertBinaryToDecimal_Click(object sender, EventArgs e)
        {
            Regex binRegex = new Regex(@"[2-9]");
            if (decimal.Parse(textbox_CalculatorInput.Text) > 0 && !binRegex.IsMatch(textbox_CalculatorInput.Text))
            {
                int num = Convert.ToInt32(CalculatorInput.ToString(), 2);
                CalculatorInput.Clear();
                CalculatorInput.Append(num);
                textbox_CalculatorInput.Text = CalculatorInput.ToString();
                button_DecimalTab.BackColor = Color.FromArgb(15, 68, 119);
                button_BinaryTab.BackColor = Color.Transparent;
                button_LocTab.BackColor = Color.Transparent;
                ShowKeys();
            }
        }

        private void button_ConvertDecimalToLocational_Click(object sender, EventArgs e)
        {
            Regex numRegex = new Regex(@"[0-9]");
            if (numRegex.IsMatch(textbox_CalculatorInput.Text) && !textbox_CalculatorInput.Text.Contains(".") && Int32.Parse(textbox_CalculatorInput.Text) > 0)
            {
                long num = long.Parse(CalculatorInput.ToString());
                char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                int counter = 26;
                StringBuilder locVal = new StringBuilder();
                List<int> counterNum = new List<int>();
                while (num != 0)
                {
                    int val = (int)Math.Pow(2, counter);
                    long total = num - val;
                    if (total < 0)
                    {
                        counter--;
                    }
                    else if (total > 0)
                    {
                        num -= val;
                        counterNum.Add(counter);
                    }
                    else
                    {
                        num -= val;
                        counterNum.Add(counter);
                        counter--;
                    }
                };
                counterNum.ForEach(num =>
                {
                    locVal.Append(alphabet[num]);
                });

                textbox_CalculatorInput.Text = locVal.ToString();
                button_DecimalTab.BackColor = Color.Transparent;
                button_BinaryTab.BackColor = Color.Transparent;
                button_LocTab.BackColor = Color.FromArgb(15, 68, 119);
                HideKeys();
                button_ConvertBinaryToDecimal.Hide();
                button_ConvertIntToBinary.Hide();
            }
        }
        #endregion

        #region Math Operations
        private void button_SubtractionOperation_Click(object sender, EventArgs e)
        {
            if (StoredOperand != 0 && CalculatorInput.Length != 0)
            {
                ComputeEquation();
            }
            else if (StoredOperand == 0 && CalculatorInput.Length != 0)
            {
                StoredOperand = double.Parse(CalculatorInput.ToString());
            }
            StoredOperation = '-';
            CalculatorInput.Clear();
            textbox_CalculatorInput.Clear();
            label_Equation.Text = $"{StoredOperand} {StoredOperation}";
        }

        private void button_MultiplicationOperation_Click(object sender, EventArgs e)
        {
            if (StoredOperand != 0 && CalculatorInput.Length != 0)
            {
                ComputeEquation();
            }
            else if (StoredOperand == 0 && CalculatorInput.Length != 0)
            {
                StoredOperand = double.Parse(CalculatorInput.ToString());
            }
            StoredOperation = '*';
            CalculatorInput.Clear();
            textbox_CalculatorInput.Clear();
            label_Equation.Text = $"{StoredOperand} {StoredOperation}";
        }

        private void button_DivisionOperation_Click(object sender, EventArgs e)
        {
            if (StoredOperand != 0 && CalculatorInput.Length != 0)
            {
                ComputeEquation();
            }
            else if (StoredOperand == 0 && CalculatorInput.Length != 0)
            {
                StoredOperand = double.Parse(CalculatorInput.ToString());
            }
            StoredOperation = '/';
            CalculatorInput.Clear();
            textbox_CalculatorInput.Clear();
            label_Equation.Text = $"{StoredOperand} {StoredOperation}";
        }

        private void button_EquivalentSign_Click(object sender, EventArgs e)
        {
            ComputeEquation();
            StoredOperation = ' ';
            CalculatorInput.Clear();
            textbox_CalculatorInput.Clear();
            label_Equation.Text = $"{StoredOperand} {StoredOperation}";
        }

        #endregion

        #region Options
        void HideKeys()
        {
            button_PositiveNegativeOperand.Hide();
            button_AppendZeroValueToInput.Hide();
            button_AppendOneToInput.Hide();
            button_AppendTwoValueToInput.Hide();
            button_AppendThreeValueToInput.Hide();
            button_AppendFourToInput.Hide();
            button_AppendFiveValueToInput.Hide();
            button_AppendSixValueToInput.Hide();
            button_AppendSevenToInput.Hide();
            button_AppendEightValueToInput.Hide();
            button_AppendNineValueToInput.Hide();
            button_AdditionOperation.Hide();
            button_EquivalentSign.Hide();
            button_SubtractionOperation.Hide();
            button_MultiplicationOperation.Hide();
            button_DivisionOperation.Hide();
            button_AppendDecimalPointToInput.Hide();
        }

        void ShowKeys()
        {
            button_PositiveNegativeOperand.Show();
            button_AppendZeroValueToInput.Show();
            button_AppendOneToInput.Show();
            button_AppendTwoValueToInput.Show();
            button_AppendThreeValueToInput.Show();
            button_AppendFourToInput.Show();
            button_AppendFiveValueToInput.Show();
            button_AppendSixValueToInput.Show();
            button_AppendSevenToInput.Show();
            button_AppendEightValueToInput.Show();
            button_AppendNineValueToInput.Show();
            button_AdditionOperation.Show();
            button_EquivalentSign.Show();
            button_SubtractionOperation.Show();
            button_MultiplicationOperation.Show();
            button_DivisionOperation.Show();
            button_AppendDecimalPointToInput.Show();
        }
        #endregion
    }
}