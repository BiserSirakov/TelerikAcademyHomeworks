//Problem 1. English digit
//Write a function that returns the last digit of given integer as an English word.

function problem1() {
    var input = document.getElementById('input1').value,
        result;

    if (input !== '' && !isNaN(input)) {

        switch (input[input.length - 1]) {
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
        }

        document.getElementById('result1').innerHTML = result;

    } else {
        document.getElementById('result1').innerHTML = 'Invalid input!';
    }
}

//Problem 2. Reverse number
//Write a function that reverses the digits of given decimal number.

function problem2() {
    var input = document.getElementById('input2').value,
        result = '',
        i;

    if (input !== '' && !isNaN(input)) {
        for (i = input.length - 1; i >= 0; i -= 1) {
            result += input[i];
        }

        document.getElementById('result2').innerHTML = result;
    }
    else {
        document.getElementById('result2').innerHTML = 'Invalid input!';
    }
}

//Problem 3. Occurrences of word
//Write a function that finds all the occurrences of word in a text.
//The search can be case sensitive or case insensitive.
//Use function overloading.

function problem3() {
    var text = document.getElementById('input3text').value,
        word = document.getElementById('input3word').value,
        splittedText,
        count = 0,
        result,
        i;

    splittedText = text.replace(/[\.,-\/#!$%\^&\*;:{}=\-_`~()]/g, "").replace(/\s{2,}/g, " ").split(' ');

    if (document.getElementById('check').checked) {
        for (i = 0; i < splittedText.length; i += 1) {
            if (word === splittedText[i]) {
                count += 1;
            }
        }
    }
    else {
        for (i = 0; i < splittedText.length; i += 1) {
            if (word.toLowerCase() === splittedText[i].toLowerCase()) {
                count += 1;
            }
        }
    }

    if (count == 1) {
        result = ' occurence';
    }
    else if (count > 1) {
        result = ' occurences';
    }

    document.getElementById('result3').innerHTML = count + result;
}

//Problem 4. Number of elements
//Write a function to count the number of div elements on the web page

function problem4() {
    var divs = document.getElementsByTagName('div'),
        result;

    if (divs.length == 1) {
        result = ' div';
    }
    else if (divs.length > 1) {
        result = ' divs';
    }

    document.getElementById('result4').innerHTML = divs.length + result;
}

//Problem 5. Appearance count
//Write a function that counts how many times given number appears in given array.
//Write a test function to check if the function is working correctly.

function problem5() {
    var numbers = document.getElementById('input5').value
        .split(', ')
        .map(Number),
        number = document.getElementById('input5number').value,
        count = 0,
        result,
        i,
        len;

    number *= 1;

    for (i = 0, len = numbers.length; i < len; i += 1) {
        if (number == numbers[i]) {
            count += 1;
        }
    }

    if (count == 1) {
        result = ' time';
    }
    else if (count > 1) {
        result = ' times';
    }

    document.getElementById('result5').innerHTML = count + result;
}

//Problem 6. Larger than neighbours
//Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).

function problem6() {
    var numbers = document.getElementById('input6').value
        .split(', ')
        .map(Number),
        index = document.getElementById('input6index').value * 1,
        element = numbers[index],
        result;

    if (index == 0 || index == numbers.length - 1) {
        result = 'The element has no neighbours';
    } else {
        if (element >= numbers[index - 1] && element >= numbers[index + 1]) {
            result = 'The element is bigger';
        }
        else {
            result = 'The element is not bigger';
        }
    }

    document.getElementById('result6').innerHTML = result;
}

//Problem 7. First larger than neighbours
//Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
//Use the function from the previous exercise.

function problem7() {
    var numbers = document.getElementById('input7').value
        .split(', ')
        .map(Number),
        result,
        i,
        len;

    for (i = 1, len = numbers.length; i < len - 1; i += 1) {
        if (numbers[i] >= numbers[i - 1] && numbers[i] >= numbers[i + 1]) {
            result = i;
            break;
        } else {
            result = -1;
        }
    }

    document.getElementById('result7').innerHTML = result;
}