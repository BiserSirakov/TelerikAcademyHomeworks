//Problem 1. Numbers
//Write a script that prints all the numbers from 1 to N.

function FromOneToN() {
	var input = document.getElementById('input1').value * 1;
	
	for (var i = 1; i <= input; i++) {
		jsConsole.write(i + " ");
	}
}

//Problem 2. Numbers not divisible
//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

function FromOneToN2() {
	var input = document.getElementById('input2').value * 1;
	
	for (var i = 1; i <= input; i++) {
		if (i % 3 != 0 && i % 7 != 0) {
			jsConsole.write(i + " ");
		}
	}
}

//Problem 3. Min/Max of sequence
//Write a script that finds the max and min number from a sequence of numbers.

function MinAndMax() {
    var input = document.getElementById('input3').value.split(', ').map(Number);
	
	for (var i = 0; i < input.length; i++) {
		var element = input[i];
		jsConsole.write(element + " ");
	}
}

//Problem 4. Lexicographically smallest
//Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.