namespace Assignment1_Ka_Hang_Chan
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculator c = new Calculator();

        private bool IsDecimal(TextBox textBox)
        {
            decimal num = 0m;
            if (Decimal.TryParse(textBox.Text, out num))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Operand should be a decimal number", "Error");
                textBox.Focus();
                return false;
            }
        }

        private bool IsPresent(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("The field should have a value", "Error");
                textBox.Focus();
                return false;
            }
        }

        private bool IsOperator(TextBox textBox)
        {
            if (textBox.Text == "+" || textBox.Text == "-" || textBox.Text == "*" || textBox.Text == "x" || textBox.Text == "/" || textBox.Text == "÷")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid operator", "Error");
                textBox.Focus();
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsPresent(txtOperand1) && IsPresent(txtOperator) && IsPresent(txtOperand2) && IsDecimal(txtOperand1) && IsDecimal(txtOperand2) && IsOperator(txtOperator))
            {
                c.operand1 = Convert.ToDecimal(txtOperand1.Text);
                c.operator1 = Convert.ToString(txtOperator.Text);
                c.operand2 = Convert.ToDecimal(txtOperand2.Text);
                c.showresult = c.Calculate(c.operand1, c.operator1, c.operand2);
                txtResult.Text = c.showresult.ToString("f4");
                txtOperand1.Focus();
            }
        }

        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            txtResult.Clear();
        }
    }
}