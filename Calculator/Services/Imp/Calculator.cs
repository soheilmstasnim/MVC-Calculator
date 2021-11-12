using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Services.Common;
using System.Text.RegularExpressions;
using Services.CalculationExceptions;
namespace Services.Imp {
    public class Calculator : ICalculator {

        #region Publices
        public string CheckOperation(string firstOperand, char calcOperator, string secondOperand) {
            // Regex pattern should be in a setting file and send to javascript too, but i think it's enough for test
            var re = new Regex(@"(^-?\d+$)|(^-?\d+\.\d+$)|(^-?\d+\.$)");
            if (!re.IsMatch(firstOperand))
                return "First operand is not all num";
            if (!re.IsMatch(secondOperand))
                return "Second operand is not all num";
            return string.Empty;
        }
        public string Calculate(string firstOperand, char calcOperator, string secondOperand) {
            try {
                switch (calcOperator) {
                    case Helper.Operator.Add:
                        return add(firstOperand, secondOperand);
                    case Helper.Operator.Mines:
                        return mines(firstOperand, secondOperand);
                    case Helper.Operator.Multiply:
                        return multiply(firstOperand, secondOperand);
                    case Helper.Operator.Devide:
                        return devide(firstOperand, secondOperand);
                    default:
                        throw new CalculateException("This Operator is not implemented");
                }
            }
            catch (CalculateException cex) {
                throw cex;
            }
            catch (Exception ex) {
                // log(ex)
                throw new CalculateException("Something went wrong, plz see logs", ex);
            }

        }

        #endregion

        #region Privates
        private string add(string firstOperand, string secondOperand) {
            var result = Convert.ToDouble(firstOperand.Trim()) + Convert.ToDouble(secondOperand.Trim());
            return result.ToString();
        }
        private string mines(string firstOperand, string secondOperand) {
            var result = Convert.ToDouble(firstOperand.Trim()) - Convert.ToDouble(secondOperand.Trim());
            return result.ToString();
        }
        private string multiply(string firstOperand, string secondOperand) {
            var result = Convert.ToDouble(firstOperand.Trim()) * Convert.ToDouble(secondOperand.Trim());
            return result.ToString();
        }
        private string devide(string firstOperand, string secondOperand) {
            if (Convert.ToDouble(secondOperand.Trim()) == 0)
               throw new CalculateException("Can not devide by Zero");

            var result = Convert.ToDouble(firstOperand.Trim()) / Convert.ToDouble(secondOperand.Trim());
            return result.ToString();
        }

        #endregion
    }
}

