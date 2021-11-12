using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculator.Models {
    public class ResponseModel<T> {
        public bool IsSucceed { get; set; }
        public string ResponseMessage { get; set; }
        public T Value { get; set; }
    }
}
