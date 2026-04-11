//Calulator Logic
function calculate(operation) {
    const num1Input = document.getElementById('firstNumber');
    const num2Input = document.getElementById('secondNumber');
    const resultDisplay = document.getElementById('result');

    const val1 = operation === 'divide' ? parseFloat(num1Input.value) : parseInt(num1Input.value);
    const val2 = operation === 'divide' ? parseFloat(num2Input.value) : parseInt(num2Input.value);

    // Validation
    if (isNaN(val1) || isNaN(val2)) {
        resultDisplay.textContent = "Please enter valid numbers";
        return;
    }

    let result;
    let symbol;

    switch (operation) {
        case 'add':
            result = val1 + val2;
            symbol = '+';
            break;
        case 'subtract':
            result = val1 - val2;
            symbol = '-';
            break;
        case 'multiply':
            result = val1 * val2;
            symbol = '×';
            break;
        case 'divide':
            if (val2 === 0) {
                resultDisplay.textContent = "Cannot divide by zero";
                return;
            }

            result = val1 / val2;
            symbol = '÷';

            if (result % 1 !== 0) {
                result = parseFloat(result.toFixed(2));
            }
            break;
        default:
            return;
    }


    resultDisplay.textContent = `${val1} ${symbol} ${val2} = ${result}`;


    resultDisplay.style.animation = 'none';
    resultDisplay.offsetHeight; 
    resultDisplay.style.animation = 'fadeIn 0.3s ease-out';
}


const style = document.createElement('style');
style.textContent = `
    @keyframes fadeIn {
        from { opacity: 0; transform: translateY(5px); }
        to { opacity: 1; transform: translateY(0); }
    }
`;
document.head.appendChild(style);
