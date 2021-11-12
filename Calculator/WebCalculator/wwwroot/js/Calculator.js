/// <reference path="calculatorservice/calculatorservice.js" />
const allOperands = ['-', '+', '*', '/'];
var operator = '';
var firstOperand = '';
var secondoperand = '';
var waitForSecondOperator = false;

$(document).ready(function () {
    initial();
})

function initial() {
    $('#display').val('0');
    firstOperand = '';
    secondoperand = '';
    operator = '';
}


function addToDisplay(input) {
    let display = $('#display');
    let displayValue = display.val();
    var reg = /(^-?\d+$)|(^-?\d+\.\d+$)|(^-?\d+\.$)/;
    if (displayValue == '0' || !reg.test(displayValue)) {
        displayValue = '';
        display.removeAttr("style");
    }

    let inputValue = $(input).val();

    displayValue += inputValue;
    display.val(displayValue);
}
function addOperator(input) {
    if (waitForSecondOperator) {
        calculate();
    }
    else {
        let inputOperator = $(input).val();
        let displayValue = $('#display').val();
        if (displayValue != '' && !waitForSecondOperator) {
            firstOperand = displayValue;
            $('#display').val('');
            operator = inputOperator;
            waitForSecondOperator = true;
        } else {
            addSecondOperator();
        }
    }
}
function addSecondOperator() {
    if (waitForSecondOperator) {
        secondoperand = $('#display').val();
        $('#display').val('');
        waitForSecondOperator = false;
    }
}
function calculate() {
    addSecondOperator();
    if (checkVariablesBeforCalulation()) {
        var service = new CalculatorService();
        service.Calculate(firstOperand, operator, secondoperand,
            onSuccess = function (data) {
                $('#divDisplay').html(data);
            },
            onFailed = function (jqXHR, data) {
                console.error("Something bad happend");
            })
    }
}
function checkVariablesBeforCalulation() {

    if (firstOperand == '') {
        alert('Please enter some values')
    }
    else if (operator == '') {
        alert('Please enter an operator');
    }
    else if (secondoperand == '') {
        alert('Please enter some values')

    }
    return true;

}