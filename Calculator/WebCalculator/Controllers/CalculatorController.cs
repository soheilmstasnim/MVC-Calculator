using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCalculator.Models;
using Services.Interfaces;
using Services.CalculationExceptions;
namespace WebCalculator.Controllers {
    public class CalculatorController : Controller {
        public ICalculator CalculatorService { get; }

        public CalculatorController(ICalculator calculatorService) {
            CalculatorService = calculatorService;
        }
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public PartialViewResult Calculate(string firstOperand, string calcOperator, string secondOperand) {
            try {

                var chkResult = CalculatorService.CheckOperation(firstOperand, Convert.ToChar(calcOperator), secondOperand);
                if (!string.IsNullOrEmpty(chkResult)) {
                   return calculatorDisplayResult(chkResult, false);
                }

                var result = CalculatorService.Calculate(firstOperand, Convert.ToChar(calcOperator), secondOperand);
                return calculatorDisplayResult(result, true);
            }

            catch (CalculateException ex) {
                return calculatorDisplayResult(ex.Message, false); ;
            }

        }

        private PartialViewResult calculatorDisplayResult(string response, bool isOk) {
            return PartialView("_CalculatorDisplayResult", new ResponseModel<string>
            {
                IsSucceed = isOk,
                ResponseMessage = (isOk ? string.Empty : response),
                Value = (isOk ?  response: string.Empty)
            });
        }
    }
}
