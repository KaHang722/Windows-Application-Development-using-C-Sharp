using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Ka_Hang_Chan
{
    internal class Calculator
    {
        public decimal operand1 { get; set; }
        public string operator1 { get; set; }
        public decimal operand2 { get; set; }
        public decimal showresult { get; set; }

        public decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            decimal result = 0m;
            if (operator1 == "+")
            {
                result = operand1 + operand2;
            }
            else if (operator1 == "-")
            {
                result = operand1 - operand2;
            }
            else if (operator1 == "*" || operator1 == "x")
            {
                result = operand1 * operand2;
            }
            else if (operator1 == "/" || operator1 == "÷")
            {
                result = operand1 / operand2;
            }
            return result;
        }
    }
}
