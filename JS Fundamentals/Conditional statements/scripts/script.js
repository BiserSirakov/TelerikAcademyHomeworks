//Problem 1. Exchange if greater
//Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
//As a result print the values a and b, separated by a space.

function Exchange() {
	var a = document.getElementById('input1a').value,
		b = document.getElementById('input1b').value;

	if (a > b) {
		document.getElementById('result1').innerHTML = b + " " + a;
	}
	else {
		document.getElementById('result1').innerHTML = a + " " + b;
	}
}

//Problem 2. Multiplication Sign
//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

function Product() {
	var a = document.getElementById('input2a').value,
		b = document.getElementById('input2b').value,
		c = document.getElementById('input2c').value,
		numbers = [a, b, c],
		counter = 0;

	for (var i = 0; i < numbers.length; i++) {

        if (numbers[i]) {
            if (numbers[i] < 0) {
                counter++;
            }
        }
    }

    if (counter % 2 == 0) {
        document.getElementById('result2').innerHTML = '+';
    }
    else {
        document.getElementById('result2').innerHTML = '-';
    }

	if (a == '0' || b == '0' || c == '0') {
		document.getElementById('result2').innerHTML = '0';
	}
}

//Problem 3. The biggest of Three
//Write a script that finds the biggest of three numbers.
//Use nested if statements.

function Biggest() {
	var a = document.getElementById('input3a').value,
		b = document.getElementById('input3b').value,
		c = document.getElementById('input3c').value,
		biggest;

	if (a >= b && a >= c) {
		biggest = a;
	}
	else if (b >= a && b >= c) {
		biggest = b;
	}
	else if (c >= a && c >= b) {
		biggest = c;
	}

	document.getElementById('result3').innerHTML = biggest.toString();
}

//Problem 4. Sort 3 numbers
//Sort 3 real values in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

function Sort() {
	var a = document.getElementById('input4a').value,
		b = document.getElementById('input4b').value,
		c = document.getElementById('input4c').value,
		max,
		mid,
		min;

	if (a >= b && a >= c) {
		max = a;

		if (b >= c) {
			mid = b;
			min = c;
		}
		else if (c >= b) {
			mid = c;
			min = b;
		}
	}
	else if (b >= a && b >= c) {
		max = b;

		if (a >= c) {
			mid = a;
			min = c;
		}
		else if (c >= a) {
			mid = c;
			min = a;
		}
	}
	else if (c >= b && c >= a) {
		max = c;

		if (a >= b) {
			mid = a;
			min = b;
		}
		else if (b >= a) {
			mid = b;
			min = a;
		}
	}

	document.getElementById('result4').innerHTML = max + " " + mid + " " + min;
}

//Problem 5. Digit as word
//Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.

function DigitAsWord() {
	var input = document.getElementById('input5').value,
		result;

	switch (input) {
		case '0':
			result = 'zero';
			break;
		case '1':
			result = 'one';
			break;
		case '2':
			result = 'two';
			break;
		case '3':
			result = 'three';
			break;
		case '4':
			result = 'four';
			break;
		case '5':
			result = 'five';
			break;
		case '6':
			result = 'six';
			break;
		case '7':
			result = 'seven';
			break;
		case '8':
			result = 'eight';
			break;
		case '9':
			result = 'nine';
			break;
		default:
			result = 'not a digit';
			break;
	}

	document.getElementById('result5').innerHTML = result;
}

//Problem 6. Quadratic equation
//Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Calculates and prints its real roots.
//Note: Quadratic equations may have 0, 1 or 2 real roots.

function Quadratic() {
	var a = document.getElementById('input6a').value * 1,
		c = document.getElementById('input6c').value * 1,
		b = document.getElementById('input6b').value * 1,
		d = b * b - 4 * a * c;

	if (a == 0) {
		document.getElementById('result6').innerHTML = "no quadratic equation";
	}
	else {
		if (d > 0) {
			document.getElementById('result6').innerHTML = "x1 = " + ((-b + Math.sqrt(d)) / (2 * a)) + " x2 = " + ((-b - Math.sqrt(d)) / (2 * a));
		}
		else if (d == 0) {
			document.getElementById('result6').innerHTML = "x1 = x2 = " + (-b / (2 * a));
		}
		else if (d < 0) {
			document.getElementById('result6').innerHTML = "no real roots";
		}
	}
}

//Problem 7. The biggest of five numbers
//Write a script that finds the greatest of given 5 variables.
//Use nested if statements.

function BiggestOfFive() {
	var a = document.getElementById('input7a').value,
		c = document.getElementById('input7b').value,
		b = document.getElementById('input7c').value,
		d = document.getElementById('input7d').value,
		e = document.getElementById('input7e').value,
		biggest;

	if (a >= b && a >= c && a >= d && a >= e) {
		biggest = a;
	}
	else if (b >= a && b >= c && b >= d && b >= e) {
		biggest = b;
	}
	else if (c >= a && c >= b && c >= d && c >= e) {
		biggest = c;
	}
	else if (d >= a && d >= b && d >= c && d >= e) {
		biggest = d;
	}
	else if (e >= a && e >= b && e >= c && e >= d) {
		biggest = e;
	}

	document.getElementById('result7').innerHTML = biggest.toString();
}

//Problem 8. Number as words
//Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.

function NumberAsWord() {
	var number = document.getElementById('input8').value,
		result;

	if (!isNaN(number) && number !== '' &&
        number * 1 >= 0 && number * 1 <= 999 &&
        ((number * 1) % 1 === 0)) {
        number *= 1;
        var hundreds = Math.floor(number / 100),
            tens = (Math.floor(number / 10)) % 10,
            digits = (number % 10),
            special = 10 + digits;

        switch (special) {
            case 11:
                special = "eleven";
                break;
            case 12:
                special = "twelve";
                break;
            case 13:
                special = "thirteen";
                break;
            case 14:
                special = "fourteen";
                break;
            case 15:
                special = "fifteen";
                break;
            case 16:
                special = "sixteen";
                break;
            case 17:
                special = "seventeen";
                break;
            case 18:
                special = "eighteen";
                break;
            case 19:
                special = "nineteen";
                break;
        }

        switch (hundreds) {
            case 1:
                hundreds = "one hundred ";
                break;
            case 2:
                hundreds = "two hundred ";
                break;
            case 3:
                hundreds = "three hundred ";
                break;
            case 4:
                hundreds = "four hundred ";
                break;
            case 5:
                hundreds = "five hundred ";
                break;
            case 6:
                hundreds = "six hundred ";
                break;
            case 7:
                hundreds = "seven hundred ";
                break;
            case 8:
                hundreds = "eight hundred ";
                break;
            case 9:
                hundreds = "nine hundred ";
                break;
            case 0:
                hundreds = "";
                break;
        }
        if (number % 100 !== 0 && number >= 100) {
            hundreds = hundreds + 'and ';
        }
        if (tens == 1 && digits > 0) {
            result = hundreds + special;
            hundreds = tens = digits = "";
            document.getElementById('result8').innerHTML = result;
            return;
        }

        switch (tens) {
            case 1:
                tens = "ten";
                break;
            case 2:
                tens = "twenty ";
                break;
            case 3:
                tens = "thirty ";
                break;
            case 4:
                tens = "fourty ";
                break;
            case 5:
                tens = "fifty ";
                break;
            case 6:
                tens = "sixty ";
                break;
            case 7:
                tens = "seventy ";
                break;
            case 8:
                tens = "eighty ";
                break;
            case 9:
                tens = "ninety ";
                break;
            case 0:
                tens = "";
                break;
        }

        switch (digits) {
            case 1:
                digits = "one";
                break;
            case 2:
                digits = "two";
                break;
            case 3:
                digits = "three";
                break;
            case 4:
                digits = "four";
                break;
            case 5:
                digits = "five";
                break;
            case 6:
                digits = "six";
                break;
            case 7:
                digits = "seven";
                break;
            case 8:
                digits = "eight";
                break;
            case 9:
                digits = "nine";
                break;
            default:
                digits = "";
                break;
        }

        if (number === 0) {
            result = "Zero";
            hundreds = tens = digits = "";
            document.getElementById('result8').innerHTML = result;
            return;
        }

        result = hundreds + tens + digits;
        document.getElementById('result8').innerHTML = result;
        return;
    } else {
        document.getElementById('result8').innerHTML = 'Enter an integer in the interval [0, 999]';
    }
}