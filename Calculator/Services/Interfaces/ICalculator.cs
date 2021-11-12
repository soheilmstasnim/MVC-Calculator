using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces {
    public interface ICalculator {
        string Calculate(string firstOperand, char calcOperator, string secondOperand);
        string CheckOperation(string firstOperand, char calcOperator, string secondOperand);
    }
}
