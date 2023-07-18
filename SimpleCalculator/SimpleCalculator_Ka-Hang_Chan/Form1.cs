namespace SimpleCalculator_Ka_Hang_Chan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
            string operator1 = Convert.ToString(txtOperator.Text);
            decimal operand2 = Convert.ToDecimal(txtOperand2.Text);
            decimal showresult = this.Calculate(operand1, operator1, operand2);
            txtResult.Text = showresult.ToString("f4");
            txtOperand1.Focus();

        }
        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            decimal result = 0;

            if (operator1 == "+")
            {
                result = operand1 + operand2;
            }else if (operator1 == "-")
            {
                result = operand1 - operand2;
            }else if (operator1 == "*")
            {
                result = operand1 * operand2;
            }else if (operator1 == "/")
            {
                result = operand1 / operand2;
            }
            return result;

        }

        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            txtResult.Clear();
        }
    }
}