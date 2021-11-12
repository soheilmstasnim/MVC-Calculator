using System;
using System.Collections.Generic;
using System.Text;

namespace Services.CalculationExceptions {
   public class CalculateException: Exception  {
        public CalculateException(string message) : base(message) {

        }
        public CalculateException(string message, Exception ex): base(message, ex) {

        }
    }
}
