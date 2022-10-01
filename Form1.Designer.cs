namespace SD_320_W22SD_Assignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textbox_CalculatorInput = new System.Windows.Forms.TextBox();
            this.button_PositiveNegativeOperand = new System.Windows.Forms.Button();
            this.button_AppendZeroValueToInput = new System.Windows.Forms.Button();
            this.button_AppendDecimalPointToInput = new System.Windows.Forms.Button();
            this.button_EquivalentSign = new System.Windows.Forms.Button();
            this.button_AppendOneToInput = new System.Windows.Forms.Button();
            this.button_AppendTwoValueToInput = new System.Windows.Forms.Button();
            this.button_AppendThreeValueToInput = new System.Windows.Forms.Button();
            this.button_AdditionOperation = new System.Windows.Forms.Button();
            this.button_AppendFourToInput = new System.Windows.Forms.Button();
            this.button_AppendFiveValueToInput = new System.Windows.Forms.Button();
            this.button_AppendSixValueToInput = new System.Windows.Forms.Button();
            this.button_SubtractionOperation = new System.Windows.Forms.Button();
            this.button_AppendSevenToInput = new System.Windows.Forms.Button();
            this.button_AppendEightValueToInput = new System.Windows.Forms.Button();
            this.button_AppendNineValueToInput = new System.Windows.Forms.Button();
            this.button_MultiplicationOperation = new System.Windows.Forms.Button();
            this.button_ConvertIntToBinary = new System.Windows.Forms.Button();
            this.button_DivisionOperation = new System.Windows.Forms.Button();
            this.button_ConvertBinaryToDecimal = new System.Windows.Forms.Button();
            this.button_ConvertDecimalToLocational = new System.Windows.Forms.Button();
            this.button_ClearCalculatorInput = new System.Windows.Forms.Button();
            this.label_Equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textbox_CalculatorInput
            // 
            this.textbox_CalculatorInput.AccessibleDescription = "Textbox for inputting numbers and math operations";
            this.textbox_CalculatorInput.AccessibleName = "Calculator Input Textbox";
            this.textbox_CalculatorInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textbox_CalculatorInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_CalculatorInput.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textbox_CalculatorInput.ForeColor = System.Drawing.SystemColors.Window;
            this.textbox_CalculatorInput.Location = new System.Drawing.Point(4, 40);
            this.textbox_CalculatorInput.Name = "textbox_CalculatorInput";
            this.textbox_CalculatorInput.Size = new System.Drawing.Size(521, 71);
            this.textbox_CalculatorInput.TabIndex = 0;
            this.textbox_CalculatorInput.Text = "0";
            this.textbox_CalculatorInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textbox_CalculatorInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_CalculatorInput_KeyPress);
            // 
            // button_PositiveNegativeOperand
            // 
            this.button_PositiveNegativeOperand.AccessibleDescription = "Button that makes the operand positive or negative";
            this.button_PositiveNegativeOperand.AccessibleName = "Postive Negative Operand Button";
            this.button_PositiveNegativeOperand.BackColor = System.Drawing.SystemColors.InfoText;
            this.button_PositiveNegativeOperand.FlatAppearance.BorderSize = 0;
            this.button_PositiveNegativeOperand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PositiveNegativeOperand.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_PositiveNegativeOperand.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_PositiveNegativeOperand.Location = new System.Drawing.Point(4, 482);
            this.button_PositiveNegativeOperand.Name = "button_PositiveNegativeOperand";
            this.button_PositiveNegativeOperand.Size = new System.Drawing.Size(122, 76);
            this.button_PositiveNegativeOperand.TabIndex = 1;
            this.button_PositiveNegativeOperand.Text = "+/-";
            this.button_PositiveNegativeOperand.UseVisualStyleBackColor = false;
            this.button_PositiveNegativeOperand.Click += new System.EventHandler(this.button_PositiveNegativeOperand_Click);
            // 
            // button_AppendZeroValueToInput
            // 
            this.button_AppendZeroValueToInput.AccessibleDescription = "Button for appending a zero value to input";
            this.button_AppendZeroValueToInput.AccessibleName = "Append Zero Button";
            this.button_AppendZeroValueToInput.BackColor = System.Drawing.SystemColors.InfoText;
            this.button_AppendZeroValueToInput.FlatAppearance.BorderSize = 0;
            this.button_AppendZeroValueToInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AppendZeroValueToInput.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AppendZeroValueToInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AppendZeroValueToInput.Location = new System.Drawing.Point(129, 482);
            this.button_AppendZeroValueToInput.Name = "button_AppendZeroValueToInput";
            this.button_AppendZeroValueToInput.Size = new System.Drawing.Size(130, 76);
            this.button_AppendZeroValueToInput.TabIndex = 2;
            this.button_AppendZeroValueToInput.Text = "0";
            this.button_AppendZeroValueToInput.UseVisualStyleBackColor = false;
            this.button_AppendZeroValueToInput.Click += new System.EventHandler(this.button_AppendZeroValueToInput_Click);
            // 
            // button_AppendDecimalPointToInput
            // 
            this.button_AppendDecimalPointToInput.AccessibleDescription = "Button for Adding a Decimal point to Input";
            this.button_AppendDecimalPointToInput.AccessibleName = "Append Decimal Point Value Button";
            this.button_AppendDecimalPointToInput.BackColor = System.Drawing.SystemColors.InfoText;
            this.button_AppendDecimalPointToInput.FlatAppearance.BorderSize = 0;
            this.button_AppendDecimalPointToInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AppendDecimalPointToInput.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AppendDecimalPointToInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AppendDecimalPointToInput.Location = new System.Drawing.Point(262, 482);
            this.button_AppendDecimalPointToInput.Name = "button_AppendDecimalPointToInput";
            this.button_AppendDecimalPointToInput.Size = new System.Drawing.Size(130, 76);
            this.button_AppendDecimalPointToInput.TabIndex = 3;
            this.button_AppendDecimalPointToInput.Text = ".";
            this.button_AppendDecimalPointToInput.UseVisualStyleBackColor = false;
            this.button_AppendDecimalPointToInput.Click += new System.EventHandler(this.button_AppendDecimalPointToInput_Click);
            // 
            // button_EquivalentSign
            // 
            this.button_EquivalentSign.AccessibleDescription = "Button that will initiate the mathematical operations";
            this.button_EquivalentSign.AccessibleName = "Equivalent Sign Button";
            this.button_EquivalentSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(68)))), ((int)(((byte)(119)))));
            this.button_EquivalentSign.FlatAppearance.BorderSize = 0;
            this.button_EquivalentSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EquivalentSign.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_EquivalentSign.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_EquivalentSign.Location = new System.Drawing.Point(395, 482);
            this.button_EquivalentSign.Name = "button_EquivalentSign";
            this.button_EquivalentSign.Size = new System.Drawing.Size(130, 76);
            this.button_EquivalentSign.TabIndex = 4;
            this.button_EquivalentSign.Text = "=";
            this.button_EquivalentSign.UseVisualStyleBackColor = false;
            this.button_EquivalentSign.Click += new System.EventHandler(this.button_EquivalentSign_Click);
            // 
            // button_AppendOneToInput
            // 
            this.button_AppendOneToInput.AccessibleDescription = "Button that append one value to the input";
            this.button_AppendOneToInput.AccessibleName = "Append One Button";
            this.button_AppendOneToInput.BackColor = System.Drawing.SystemColors.InfoText;
            this.button_AppendOneToInput.FlatAppearance.BorderSize = 0;
            this.button_AppendOneToInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AppendOneToInput.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AppendOneToInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AppendOneToInput.Location = new System.Drawing.Point(4, 402);
            this.button_AppendOneToInput.Name = "button_AppendOneToInput";
            this.button_AppendOneToInput.Size = new System.Drawing.Size(122, 76);
            this.button_AppendOneToInput.TabIndex = 5;
            this.button_AppendOneToInput.Text = "1";
            this.button_AppendOneToInput.UseVisualStyleBackColor = false;
            this.button_AppendOneToInput.Click += new System.EventHandler(this.button_AppendOneToInput_Click);
            // 
            // button_AppendTwoValueToInput
            // 
            this.button_AppendTwoValueToInput.AccessibleDescription = "Button that append two value to the input";
            this.button_AppendTwoValueToInput.AccessibleName = "Append Two Button";
            this.button_AppendTwoValueToInput.BackColor = System.Drawing.SystemColors.InfoText;
            this.button_AppendTwoValueToInput.FlatAppearance.BorderSize = 0;
            this.button_AppendTwoValueToInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AppendTwoValueToInput.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AppendTwoValueToInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AppendTwoValueToInput.Location = new System.Drawing.Point(129, 402);
            this.button_AppendTwoValueToInput.Name = "button_AppendTwoValueToInput";
            this.button_AppendTwoValueToInput.Size = new System.Drawing.Size(130, 76);
            this.button_AppendTwoValueToInput.TabIndex = 6;
            this.button_AppendTwoValueToInput.Text = "2";
            this.button_AppendTwoValueToInput.UseVisualStyleBackColor = false;
            this.button_AppendTwoValueToInput.Click += new System.EventHandler(this.button_AppendTwoValueToInput_Click);
            // 
            // button_AppendThreeValueToInput
            // 
            this.button_AppendThreeValueToInput.AccessibleDescription = "Button that append three value to the input";
            this.button_AppendThreeValueToInput.AccessibleName = "Append Three Value Button";
            this.button_AppendThreeValueToInput.BackColor = System.Drawing.SystemColors.InfoText;
            this.button_AppendThreeValueToInput.FlatAppearance.BorderSize = 0;
            this.button_AppendThreeValueToInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AppendThreeValueToInput.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AppendThreeValueToInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AppendThreeValueToInput.Location = new System.Drawing.Point(262, 402);
            this.button_AppendThreeValueToInput.Name = "button_AppendThreeValueToInput";
            this.button_AppendThreeValueToInput.Size = new System.Drawing.Size(130, 76);
            this.button_AppendThreeValueToInput.TabIndex = 7;
            this.button_AppendThreeValueToInput.Text = "3";
            this.button_AppendThreeValueToInput.UseVisualStyleBackColor = false;
            this.button_AppendThreeValueToInput.Click += new System.EventHandler(this.button_AppendThreeValueToInput_Click);
            // 
            // button_AdditionOperation
            // 
            this.button_AdditionOperation.AccessibleDescription = "Button that puts addition math operation to the input";
            this.button_AdditionOperation.AccessibleName = "Addition Operation Button";
            this.button_AdditionOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button_AdditionOperation.FlatAppearance.BorderSize = 0;
            this.button_AdditionOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AdditionOperation.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AdditionOperation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AdditionOperation.Location = new System.Drawing.Point(395, 402);
            this.button_AdditionOperation.Name = "button_AdditionOperation";
            this.button_AdditionOperation.Size = new System.Drawing.Size(130, 76);
            this.button_AdditionOperation.TabIndex = 8;
            this.button_AdditionOperation.Text = "+";
            this.button_AdditionOperation.UseVisualStyleBackColor = false;
            this.button_AdditionOperation.Click += new System.EventHandler(this.button_AdditionOperation_Click);
            // 
            // button_AppendFourToInput
            // 
            this.button_AppendFourToInput.AccessibleDescription = "Button that append four value to the input";
            this.button_AppendFourToInput.AccessibleName = "Append Four Button";
            this.button_AppendFourToInput.BackColor = System.Drawing.SystemColors.InfoText;
            this.button_AppendFourToInput.FlatAppearance.BorderSize = 0;
            this.button_AppendFourToInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AppendFourToInput.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AppendFourToInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AppendFourToInput.Location = new System.Drawing.Point(4, 322);
            this.button_AppendFourToInput.Name = "button_AppendFourToInput";
            this.button_AppendFourToInput.Size = new System.Drawing.Size(122, 76);
            this.button_AppendFourToInput.TabIndex = 9;
            this.button_AppendFourToInput.Text = "4";
            this.button_AppendFourToInput.UseVisualStyleBackColor = false;
            this.button_AppendFourToInput.Click += new System.EventHandler(this.button_AppendFourToInput_Click);
            // 
            // button_AppendFiveValueToInput
            // 
            this.button_AppendFiveValueToInput.AccessibleDescription = "Button that append five value to the input";
            this.button_AppendFiveValueToInput.AccessibleName = "Append Five Button";
            this.button_AppendFiveValueToInput.BackColor = System.Drawing.SystemColors.InfoText;
            this.button_AppendFiveValueToInput.FlatAppearance.BorderSize = 0;
            this.button_AppendFiveValueToInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AppendFiveValueToInput.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AppendFiveValueToInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AppendFiveValueToInput.Location = new System.Drawing.Point(129, 322);
            this.button_AppendFiveValueToInput.Name = "button_AppendFiveValueToInput";
            this.button_AppendFiveValueToInput.Size = new System.Drawing.Size(130, 76);
            this.button_AppendFiveValueToInput.TabIndex = 10;
            this.button_AppendFiveValueToInput.Text = "5";
            this.button_AppendFiveValueToInput.UseVisualStyleBackColor = false;
            this.button_AppendFiveValueToInput.Click += new System.EventHandler(this.button_AppendFiveValueToInput_Click);
            // 
            // button_AppendSixValueToInput
            // 
            this.button_AppendSixValueToInput.AccessibleDescription = "Button that append six value to the input";
            this.button_AppendSixValueToInput.AccessibleName = "Append Six Value Button";
            this.button_AppendSixValueToInput.BackColor = System.Drawing.SystemColors.InfoText;
            this.button_AppendSixValueToInput.FlatAppearance.BorderSize = 0;
            this.button_AppendSixValueToInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AppendSixValueToInput.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AppendSixValueToInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AppendSixValueToInput.Location = new System.Drawing.Point(262, 322);
            this.button_AppendSixValueToInput.Name = "button_AppendSixValueToInput";
            this.button_AppendSixValueToInput.Size = new System.Drawing.Size(130, 76);
            this.button_AppendSixValueToInput.TabIndex = 11;
            this.button_AppendSixValueToInput.Text = "6";
            this.button_AppendSixValueToInput.UseVisualStyleBackColor = false;
            this.button_AppendSixValueToInput.Click += new System.EventHandler(this.button_AppendSixValueToInput_Click);
            // 
            // button_SubtractionOperation
            // 
            this.button_SubtractionOperation.AccessibleDescription = "Button that puts subtraction math operation to the input";
            this.button_SubtractionOperation.AccessibleName = "Subtraction Operation Button";
            this.button_SubtractionOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button_SubtractionOperation.FlatAppearance.BorderSize = 0;
            this.button_SubtractionOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SubtractionOperation.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_SubtractionOperation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_SubtractionOperation.Location = new System.Drawing.Point(395, 322);
            this.button_SubtractionOperation.Name = "button_SubtractionOperation";
            this.button_SubtractionOperation.Size = new System.Drawing.Size(130, 76);
            this.button_SubtractionOperation.TabIndex = 12;
            this.button_SubtractionOperation.Text = "-";
            this.button_SubtractionOperation.UseVisualStyleBackColor = false;
            this.button_SubtractionOperation.Click += new System.EventHandler(this.button_SubtractionOperation_Click);
            // 
            // button_AppendSevenToInput
            // 
            this.button_AppendSevenToInput.AccessibleDescription = "Button that append seven value to the input";
            this.button_AppendSevenToInput.AccessibleName = "Append Seven Button";
            this.button_AppendSevenToInput.BackColor = System.Drawing.SystemColors.InfoText;
            this.button_AppendSevenToInput.FlatAppearance.BorderSize = 0;
            this.button_AppendSevenToInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AppendSevenToInput.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AppendSevenToInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AppendSevenToInput.Location = new System.Drawing.Point(4, 242);
            this.button_AppendSevenToInput.Name = "button_AppendSevenToInput";
            this.button_AppendSevenToInput.Size = new System.Drawing.Size(122, 76);
            this.button_AppendSevenToInput.TabIndex = 13;
            this.button_AppendSevenToInput.Text = "7";
            this.button_AppendSevenToInput.UseVisualStyleBackColor = false;
            this.button_AppendSevenToInput.Click += new System.EventHandler(this.button_AppendSevenToInput_Click);
            // 
            // button_AppendEightValueToInput
            // 
            this.button_AppendEightValueToInput.AccessibleDescription = "Button that append Eight value to the input";
            this.button_AppendEightValueToInput.AccessibleName = "Append Eight Button";
            this.button_AppendEightValueToInput.BackColor = System.Drawing.SystemColors.InfoText;
            this.button_AppendEightValueToInput.FlatAppearance.BorderSize = 0;
            this.button_AppendEightValueToInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AppendEightValueToInput.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AppendEightValueToInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AppendEightValueToInput.Location = new System.Drawing.Point(129, 242);
            this.button_AppendEightValueToInput.Name = "button_AppendEightValueToInput";
            this.button_AppendEightValueToInput.Size = new System.Drawing.Size(130, 76);
            this.button_AppendEightValueToInput.TabIndex = 14;
            this.button_AppendEightValueToInput.Text = "8";
            this.button_AppendEightValueToInput.UseVisualStyleBackColor = false;
            this.button_AppendEightValueToInput.Click += new System.EventHandler(this.button_AppendEightValueToInput_Click);
            // 
            // button_AppendNineValueToInput
            // 
            this.button_AppendNineValueToInput.AccessibleDescription = "Button that append nine value to the input";
            this.button_AppendNineValueToInput.AccessibleName = "Append Nine Value Button";
            this.button_AppendNineValueToInput.BackColor = System.Drawing.SystemColors.InfoText;
            this.button_AppendNineValueToInput.FlatAppearance.BorderSize = 0;
            this.button_AppendNineValueToInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AppendNineValueToInput.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AppendNineValueToInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AppendNineValueToInput.Location = new System.Drawing.Point(262, 242);
            this.button_AppendNineValueToInput.Name = "button_AppendNineValueToInput";
            this.button_AppendNineValueToInput.Size = new System.Drawing.Size(130, 76);
            this.button_AppendNineValueToInput.TabIndex = 15;
            this.button_AppendNineValueToInput.Text = "9";
            this.button_AppendNineValueToInput.UseVisualStyleBackColor = false;
            this.button_AppendNineValueToInput.Click += new System.EventHandler(this.button_AppendNineValueToInput_Click);
            // 
            // button_MultiplicationOperation
            // 
            this.button_MultiplicationOperation.AccessibleDescription = "Button that puts multiplication math operation to the input";
            this.button_MultiplicationOperation.AccessibleName = "Multiplication Operation Button";
            this.button_MultiplicationOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button_MultiplicationOperation.FlatAppearance.BorderSize = 0;
            this.button_MultiplicationOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MultiplicationOperation.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_MultiplicationOperation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_MultiplicationOperation.Location = new System.Drawing.Point(395, 242);
            this.button_MultiplicationOperation.Name = "button_MultiplicationOperation";
            this.button_MultiplicationOperation.Size = new System.Drawing.Size(130, 76);
            this.button_MultiplicationOperation.TabIndex = 16;
            this.button_MultiplicationOperation.Text = "x";
            this.button_MultiplicationOperation.UseVisualStyleBackColor = false;
            this.button_MultiplicationOperation.Click += new System.EventHandler(this.button_MultiplicationOperation_Click);
            // 
            // button_ConvertIntToBinary
            // 
            this.button_ConvertIntToBinary.AccessibleDescription = "Button that converts an integer to binary";
            this.button_ConvertIntToBinary.AccessibleName = "Int to Binary Convert Button";
            this.button_ConvertIntToBinary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button_ConvertIntToBinary.FlatAppearance.BorderSize = 0;
            this.button_ConvertIntToBinary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ConvertIntToBinary.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ConvertIntToBinary.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_ConvertIntToBinary.Location = new System.Drawing.Point(4, 162);
            this.button_ConvertIntToBinary.Name = "button_ConvertIntToBinary";
            this.button_ConvertIntToBinary.Size = new System.Drawing.Size(122, 76);
            this.button_ConvertIntToBinary.TabIndex = 17;
            this.button_ConvertIntToBinary.Text = "BIN";
            this.button_ConvertIntToBinary.UseVisualStyleBackColor = false;
            this.button_ConvertIntToBinary.Click += new System.EventHandler(this.button_ConvertIntToBinary_Click);
            // 
            // button_DivisionOperation
            // 
            this.button_DivisionOperation.AccessibleDescription = "Button that puts division math operation to the input";
            this.button_DivisionOperation.AccessibleName = "Division Operation Button";
            this.button_DivisionOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button_DivisionOperation.FlatAppearance.BorderSize = 0;
            this.button_DivisionOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DivisionOperation.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_DivisionOperation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_DivisionOperation.Location = new System.Drawing.Point(395, 162);
            this.button_DivisionOperation.Name = "button_DivisionOperation";
            this.button_DivisionOperation.Size = new System.Drawing.Size(130, 76);
            this.button_DivisionOperation.TabIndex = 18;
            this.button_DivisionOperation.Text = "÷";
            this.button_DivisionOperation.UseVisualStyleBackColor = false;
            this.button_DivisionOperation.Click += new System.EventHandler(this.button_DivisionOperation_Click);
            // 
            // button_ConvertBinaryToDecimal
            // 
            this.button_ConvertBinaryToDecimal.AccessibleDescription = "Button that converts a binary to decimal";
            this.button_ConvertBinaryToDecimal.AccessibleName = "Binary to Decimal Convert Button";
            this.button_ConvertBinaryToDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button_ConvertBinaryToDecimal.FlatAppearance.BorderSize = 0;
            this.button_ConvertBinaryToDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ConvertBinaryToDecimal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ConvertBinaryToDecimal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_ConvertBinaryToDecimal.Location = new System.Drawing.Point(129, 162);
            this.button_ConvertBinaryToDecimal.Name = "button_ConvertBinaryToDecimal";
            this.button_ConvertBinaryToDecimal.Size = new System.Drawing.Size(130, 76);
            this.button_ConvertBinaryToDecimal.TabIndex = 19;
            this.button_ConvertBinaryToDecimal.Text = "DEC";
            this.button_ConvertBinaryToDecimal.UseVisualStyleBackColor = false;
            this.button_ConvertBinaryToDecimal.Click += new System.EventHandler(this.button_ConvertBinaryToDecimal_Click);
            // 
            // button_ConvertDecimalToLocational
            // 
            this.button_ConvertDecimalToLocational.AccessibleDescription = "Button that converts a decimal to locational";
            this.button_ConvertDecimalToLocational.AccessibleName = "Decimal To Locational Convert Button";
            this.button_ConvertDecimalToLocational.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button_ConvertDecimalToLocational.FlatAppearance.BorderSize = 0;
            this.button_ConvertDecimalToLocational.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ConvertDecimalToLocational.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ConvertDecimalToLocational.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_ConvertDecimalToLocational.Location = new System.Drawing.Point(262, 162);
            this.button_ConvertDecimalToLocational.Name = "button_ConvertDecimalToLocational";
            this.button_ConvertDecimalToLocational.Size = new System.Drawing.Size(130, 76);
            this.button_ConvertDecimalToLocational.TabIndex = 20;
            this.button_ConvertDecimalToLocational.Text = "LOC";
            this.button_ConvertDecimalToLocational.UseVisualStyleBackColor = false;
            this.button_ConvertDecimalToLocational.Click += new System.EventHandler(this.button_ConvertDecimalToLocational_Click);
            // 
            // button_ClearCalculatorInput
            // 
            this.button_ClearCalculatorInput.AccessibleDescription = "Button that clears the input fields for the";
            this.button_ClearCalculatorInput.AccessibleName = "Clear Calculator Input";
            this.button_ClearCalculatorInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button_ClearCalculatorInput.FlatAppearance.BorderSize = 0;
            this.button_ClearCalculatorInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ClearCalculatorInput.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ClearCalculatorInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_ClearCalculatorInput.Location = new System.Drawing.Point(395, 117);
            this.button_ClearCalculatorInput.Name = "button_ClearCalculatorInput";
            this.button_ClearCalculatorInput.Size = new System.Drawing.Size(130, 39);
            this.button_ClearCalculatorInput.TabIndex = 21;
            this.button_ClearCalculatorInput.Text = "Clear";
            this.button_ClearCalculatorInput.UseVisualStyleBackColor = false;
            this.button_ClearCalculatorInput.Click += new System.EventHandler(this.button_ClearCalculatorInput_Click);
            // 
            // label_Equation
            // 
            this.label_Equation.AccessibleDescription = "Label for displaying mathematical equations";
            this.label_Equation.AccessibleName = "Equation Label";
            this.label_Equation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Equation.Location = new System.Drawing.Point(5, 4);
            this.label_Equation.Name = "label_Equation";
            this.label_Equation.Size = new System.Drawing.Size(520, 33);
            this.label_Equation.TabIndex = 22;
            this.label_Equation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(530, 561);
            this.Controls.Add(this.label_Equation);
            this.Controls.Add(this.button_ClearCalculatorInput);
            this.Controls.Add(this.button_ConvertDecimalToLocational);
            this.Controls.Add(this.button_ConvertBinaryToDecimal);
            this.Controls.Add(this.button_DivisionOperation);
            this.Controls.Add(this.button_ConvertIntToBinary);
            this.Controls.Add(this.button_MultiplicationOperation);
            this.Controls.Add(this.button_AppendNineValueToInput);
            this.Controls.Add(this.button_AppendEightValueToInput);
            this.Controls.Add(this.button_AppendSevenToInput);
            this.Controls.Add(this.button_SubtractionOperation);
            this.Controls.Add(this.button_AppendSixValueToInput);
            this.Controls.Add(this.button_AppendFiveValueToInput);
            this.Controls.Add(this.button_AppendFourToInput);
            this.Controls.Add(this.button_AdditionOperation);
            this.Controls.Add(this.button_AppendThreeValueToInput);
            this.Controls.Add(this.button_AppendTwoValueToInput);
            this.Controls.Add(this.button_AppendOneToInput);
            this.Controls.Add(this.button_EquivalentSign);
            this.Controls.Add(this.button_AppendDecimalPointToInput);
            this.Controls.Add(this.button_AppendZeroValueToInput);
            this.Controls.Add(this.button_PositiveNegativeOperand);
            this.Controls.Add(this.textbox_CalculatorInput);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textbox_CalculatorInput;
        private Button button_PositiveNegativeOperand;
        private Button button_AppendZeroValueToInput;
        private Button button_AppendDecimalPointToInput;
        private Button button_EquivalentSign;
        private Button button_AppendOneToInput;
        private Button button_AppendTwoValueToInput;
        private Button button_AppendThreeValueToInput;
        private Button button_AdditionOperation;
        private Button button_AppendFourToInput;
        private Button button_AppendFiveValueToInput;
        private Button button_AppendSixValueToInput;
        private Button button_SubtractionOperation;
        private Button button_AppendSevenToInput;
        private Button button_AppendEightValueToInput;
        private Button button_AppendNineValueToInput;
        private Button button_MultiplicationOperation;
        private Button button_ConvertIntToBinary;
        private Button button_DivisionOperation;
        private Button button_ConvertBinaryToDecimal;
        private Button button_ConvertDecimalToLocational;
        private Button button_ClearCalculatorInput;
        private Label label_Equation;
    }
}