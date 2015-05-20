//Problem 1. Odd or Even
//Write an expression that checks if given integer is odd or even.

function IsEvenOrOdd() {
	var inputNum = document.getElementById('input1').value;

	if (isNaN(inputNum)) {
		document.getElementById('result1').innerHTML = "Wrong input!";
	}
	else {
		if (inputNum % 2 == 0) {
			document.getElementById('result1').innerHTML = "Even";
		}
		else {
			document.getElementById('result1').innerHTML = "Odd";
		}
	}
}

//Problem 2. Divisible by 7 and 5
//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

function IsDivisible() {
	var inputNum = document.getElementById('input2').value;

	if (isNaN(inputNum)) {
		document.getElementById('result2').innerHTML = "Wrong input!";
	}
	else {
		if (inputNum % 5 == 0 && inputNum % 7 == 0) {
			document.getElementById('result2').innerHTML = "True";
		}
		else {
			document.getElementById('result2').innerHTML = "False";
		}
	}
}

//Problem 3. Rectangle area
//Write an expression that calculates rectangle’s area by given width and height.

function RecArea() {
	var width = document.getElementById('width').value;
	var height = document.getElementById('height').value;

	document.getElementById('result3').innerHTML = "Area: " + width * height;
}

//Problem 4. Third digit
//Write an expression that checks for given integer if its third digit (right-to-left) is 7.

function IsSeven() {
	var inputNum = document.getElementById('input4').value;

	if (inputNum < 0) {
		inputNum *= -1;
	}

	var result = Math.floor((inputNum / 100) % 10);

	if (result == 7) {
		document.getElementById('result4').innerHTML = "True";
	}
	else {
		document.getElementById('result4').innerHTML = "False";
	}
}

//Problem 5. Third bit
//Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

function ThirdBit() {
	var inputNum = document.getElementById('input5').value,
		binary = Number(inputNum).toString(2),
		mask = 1,
		bitPosition = 3,
		result = (inputNum >> bitPosition) & mask;

	document.getElementById('result5').innerHTML = "Binary: " + binary + " Third bit: " + result.toString();
}

//Problem 6. Point in Circle
//Write an expression that checks if given point P(x, y) is within a circle K(O, 5).

function Point() {
	var x = document.getElementById('inputX').value,
		y = document.getElementById('inputY').value,
		result = Math.sqrt(x * x + y * y) <= 5;

	document.getElementById('result6').innerHTML = result.toString();
}

//Problem 7. Is prime
//Write an expression that checks if given positive integer number n (n ≤ 100) is prime.

function IsPrime() {
	var inputNum = document.getElementById('input7').value;

	for (var i = 2; i < Math.sqrt(inputNum); i++) {

        if (inputNum % i == 0) {
            document.getElementById('result7').innerHTML = 'Not prime';
            return;
        }

        document.getElementById('result7').innerHTML = 'Prime';
    }
}

//Problem 8. Trapezoid area
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

function TrapezoidArea() {
	var a = Number(document.getElementById('a').value),
		b = Number(document.getElementById('b').value),
		h = Number(document.getElementById('h').value);

	var result = (a + b) * h / 2;

	document.getElementById('result8').innerHTML = result.toString();
}
	
//Problem 9. Point in Circle and outside Rectangle
//Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

function PointOutsideR() {
	var x = document.getElementById('x9').value,
		y = document.getElementById('y9').value,
		radius = 3,
	    withinCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= radius*radius,
        outsideRect = ((x < -1) || (x > 5) || (y > 1) || (y < -1)),
        checkCondition = withinCircle && outsideRect;
		
		if (checkCondition) {
			document.getElementById('result9').innerHTML = "Yes";
		}
		else {
			document.getElementById('result9').innerHTML = "No";
		}
}