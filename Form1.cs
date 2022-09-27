using System.Text;
using System.Text.RegularExpressions;
using System.Xml.XPath;

namespace SD_320_W22SD_Assignment
{
    public partial class Form1 : Form
    {
        public int StoredOperand { get; set; }
        public char StoredOperation { get; set; }
        public StringBuilder CalculatorInput { get; set; } = new StringBuilder();
        public int Result { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void textbox_CalculatorInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
            {
                CalculatorInput.Append(e.KeyChar);
            }
            else if(!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                StoredOperand = Int32.Parse(CalculatorInput.ToString());
                if(e.KeyChar != '=')
                {
                    CalculatorInput.Clear().Append(0);
                }
                StoredOperation = e.KeyChar;
                label_Equation.Text = $"{StoredOperand} {StoredOperation}";
                textbox_CalculatorInput.Text = "";
                
            }

            if(StoredOperation == '=' && Int32.Parse(CalculatorInput.ToString()) > 0)
            {
                switch (StoredOperation)
                {
                    case '+':
                        Result = Int32.Parse(StoredOperand.ToString()) + Int32.Parse(CalculatorInput.ToString());
                        break;
                    case '-':
                        Result = Int32.Parse(StoredOperand.ToString()) - Int32.Parse(CalculatorInput.ToString());
                        break;
                    case '/':
                        Result = Int32.Parse(StoredOperand.ToString()) / Int32.Parse(CalculatorInput.ToString());
                        break;
                    case '*':
                        Result = Int32.Parse(StoredOperand.ToString()) * Int32.Parse(CalculatorInput.ToString());
                        break;
                    default:
                        StoredOperation = ' ';
                        break;
                }
            }
            
            
        }

        private void button_ClearCalculatorInput_Click(object sender, EventArgs e)
        {
            StoredOperand = 0;
            textbox_CalculatorInput.Text = StoredOperand.ToString();
        }
    }
}