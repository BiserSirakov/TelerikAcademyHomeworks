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
    var numbers = document.getElementById('input3').value.split(', ').map(Number),
        min,
        max;

    min = max = numbers[0];

    for (var i = 0; i < numbers.length; i++) {
        if (numbers[i] > max) {
            max = numbers[i];
        }

        if (numbers[i] < min) {
            min = numbers[i];
        }
    }

    jsConsole.writeLine("Min: " + min + " Max: " + max);
}

//Problem 4. Lexicographically smallest
//Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

function problem4() {
    var smallest = 'zzz',
        largest = '',
        result,
        prop;

    for (prop in document) {
        if (prop < smallest) {
            smallest = prop;
        }
        if (prop > largest) {
            largest = prop;
        }
    }

    jsConsole.writeLine('Document: smallest: ' + smallest + '; largest: ' + largest);

    smallest = 'zzz';
    largest = '';

    for (prop in window) {
        if (prop < smallest) {
            smallest = prop;
        }
        if (prop > largest) {
            largest = prop;
        }
    }

    jsConsole.writeLine('Window: smallest: ' + smallest + '; largest: ' + largest);

    smallest = 'zzz';
    largest = '';

    for (prop in navigator) {
        if (prop < smallest) {
            smallest = prop;
        }
        if (prop > largest) {
            largest = prop;
        }
    }

    jsConsole.writeLine('Navigator: smallest: ' + smallest + '; largest: ' + largest);
}