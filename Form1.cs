using System.Text.RegularExpressions;

namespace SD_320_W22SD_Assignment
{
    public partial class Form1 : Form
    {
        public int StoredOperand { get; set; }
        public char StoredOperation { get; set; }
        public int CalculatorInput { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void textbox_CalculatorInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), "[^0-9]"))
            {
                StoredOperand.ToString().Append(e.KeyChar);
            }
        }

        //private void textbox_CalculatorInput_TextChanged(object sender, EventArgs e)
        //{
        //    if (Regex.IsMatch(textbox_CalculatorInput.Text, "[^0-9]"))
        //    {
        //        try
        //        {
        //            CalculatorInput = Int32.Parse(textbox_CalculatorInput.Text);
        //        }
        //        catch
        //        {
        //        }
        //    }
        //}

        private void button_ClearCalculatorInput_Click(object sender, EventArgs e)
        {
            StoredOperand = 0;
            textbox_CalculatorInput.Text = StoredOperand.ToString();
        }
    }
}