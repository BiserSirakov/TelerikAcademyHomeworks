//Problem 1. Increase array members
//Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.

function problem1() {
    var numbers = [];

    for (var i = 0; i < 20; i += 1) {
        numbers[i] = i * 5;
    }

    document.getElementById('result1').innerHTML = numbers.join(', ');
}

//Problem 2. Lexicographically comparison
//Write a script that compares two char arrays lexicographically (letter by letter).

function problem2() {
    var first = document.getElementById('input2.1').value,
        second = document.getElementById('input2.2').value,
        result = '';

    if (first !== '' && second !== '') {
        for (var i = 0; i < Math.min(first.length, second.length); i += 1) {
            if (first[i] < second[i]) {
                result = first + ' < ' + second;
                break;
            }

            if (first[i] > second[i]) {
                result = second + ' < ' + first;
                break;
            }
        }

        if (result === '') {
            if (first.length < second.length) {
                result = first + ' < ' + second;
            } else if (first.length > second.length) {
                result = second + ' < ' + first;
            } else {
                result = first + ' = ' + second;
            }
        }

        document.getElementById('result2').innerHTML = result;

    } else {
        document.getElementById('result2').innerHTML = 'Please enter two strings';
    }

    document.getElementById('input2.1').value = '';
    document.getElementById('input2.2').value = '';
}

//Problem 3. Maximal sequence
//Write a script that finds the maximal sequence of equal elements in an array.

function problem3() {
    var input = document.getElementById('input3').value
            .split(', ')
            .map(Number),
        result,
        max = 1,
        currentMax = 1,
        maxEndIndex = 0;

    for (var i = 1; i < input.length; i += 1) {
        if (input[i] === input[i - 1]) {
            currentMax += 1;

            if (currentMax > max) {
                max = currentMax;
                maxEndIndex = i;
            }
        } else {
            currentMax = 1;
        }
    }

    result = input.splice(maxEndIndex - max + 1, max).join(', '); // removing the other numbers ( which are not equal )

    document.getElementById('result3').innerHTML = result;
}

//Problem 4. Maximal increasing sequence
//Write a script that finds the maximal increasing sequence in an array.

function problem4() {
    var input = document.getElementById('input4').value
            .split(', ')
            .map(Number),
        max = 1,
        currentMax = 1,
        maxEndIndex = 0,
        result;

    for (var i = 0; i < input.length; i += 1) {
        if (input[i] > input[i - 1]) {
            currentMax += 1;

            if (currentMax > max) {
                max = currentMax;
                maxEndIndex = i;
            }

        } else {
            currentMax = 1;
        }
    }

    result = input.splice(maxEndIndex - max + 1, max).join(', ');
    document.getElementById('result4').innerHTML = result;
}

//Problem 5. Selection sort
//Sorting an array means to arrange its elements in increasing order.
//Write a script to sort an array.
//Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
//Hint: Use a second array

function problem5() {
    var input = document.getElementById('input5').value
            .split(', ')
            .map(Number),
        temp,
        result = '';

    for (var i = 0; i < input.length; i += 1) {
        for (var j = i + 1; j < input.length; j += 1) {
            if (input[i] > input[j]) {
                temp = input[j];
                input[j] = input[i];
                input[i] = temp;
            }
        }
    }

    result += input.join(', ');
    document.getElementById('result5').innerHTML = result;
}

//Problem 6. Most frequent number
//Write a script that finds the most frequent number in an array.

function problem6() {
    var input = document.getElementById('input6').value
            .split(', ')
            .map(Number),
        mostFrequent,
        current,
        mostFrequentCount = 0,
        currentCount;

    for (var i = 0; i < input.length; i += 1) {
        current = input[i];
        currentCount = 0;

        for (var j = i; j < input.length; j += 1) {
            if (input[j] === current) {
                currentCount += 1;

                if (currentCount > mostFrequentCount) {
                    mostFrequentCount = currentCount;
                    mostFrequent = current;
                }
            }
        }
    }

    document.getElementById('result6').innerHTML = 'The most frequent number is ' + mostFrequent + ' (' + mostFrequentCount + ' times)';
}

//Problem 7. Binary search
//Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.

function problem7() {
    var input = document.getElementById('input7').value
            .split(', ')
            .map(Number),
        number = document.getElementById('input7num').value,
        indexOf,
        num,
        result;

    input.sort(function (a, b) {
        return a - b;
    });

    number *= 1;
    indexOf = binSearch(input, number, 0, input.length - 1);

    result = 'The index of ' + number + ' is (-1 if not found): ' + indexOf;

    document.getElementById('result7').innerHTML = result;

    function binSearch(array, number, start, end) {
        if (array[start] > number || number > array[end]) {
            return (-1);
        }

        var middle = ((end + start) / 2) | 0;

        if (array[middle] === number) {
            return middle;
        } else {
            if (array[middle] > number) {
                return binSearch(array, number, start, (middle - 1));
            } else {
                return binSearch(array, number, (middle + 1), end);
            }
        }
    }
}