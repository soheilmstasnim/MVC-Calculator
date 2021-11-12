function CalculatorService() {
    this.Calculate = function (firstOperand,operator,secondOperand, onSuccess, onFailed) {
        $.ajax({
            url: "/Calculator/Calculate",
            type: "POST",
            data: { firstOperand: firstOperand, calcOperator: operator, secondOperand: secondOperand },
            dataType: "html",
            success: function (data) {
                onSuccess(data);
            },
            fail: function (jqXHR, data) {
                onFailed(jqXHR, data);
            }
        });
    }
}