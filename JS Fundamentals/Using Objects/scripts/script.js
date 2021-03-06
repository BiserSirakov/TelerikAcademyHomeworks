//Problem 1. Planar coordinates
//Write functions for working with shapes in standard Planar coordinate system.
//Points are represented by coordinates P(X, Y)
//Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
//Calculate the distance between two points.
//Check if three segment lines can form a triangle.

function problem1() {
    var x1 = document.getElementById('input1x1').value,
        y1 = document.getElementById('input1y1').value,
        x2 = document.getElementById('input1x2').value,
        y2 = document.getElementById('input1y2').value,
        x3 = document.getElementById('input1x3').value,
        y3 = document.getElementById('input1y3').value,
        x4 = document.getElementById('input1x4').value,
        y4 = document.getElementById('input1y4').value,
        x5 = document.getElementById('input1x5').value,
        y5 = document.getElementById('input1y5').value,
        x6 = document.getElementById('input1x6').value,
        y6 = document.getElementById('input1y6').value,
        pointA = buildPoint('A', x1, y1),
        pointB = buildPoint('B', x2, y2),
        pointC = buildPoint('C', x3, y3),
        pointD = buildPoint('D', x4, y4),
        pointE = buildPoint('E', x5, y5),
        pointF = buildPoint('F', x6, y6),
        lineAB = buildLine('AB', pointA, pointB),
        lineCD = buildLine('CD', pointC, pointD),
        lineEF = buildLine('EF', pointE, pointF),
        i;

    for (i = 1; i <= 6; i += 1) {
        if (isNaN(document.getElementById('input1x' + i).value) ||
            document.getElementById('input1x' + i).value === '' ||
            isNaN(document.getElementById('input1y' + i).value) ||
            document.getElementById('input1y' + i).value === '') {
            document.getElementById('result1').innerHTML = 'Invalid input';
            return;
        }
    }

    document.getElementById('A').innerHTML = pointA.toString();
    document.getElementById('B').innerHTML = pointB.toString();
    document.getElementById('C').innerHTML = pointC.toString();
    document.getElementById('D').innerHTML = pointD.toString();
    document.getElementById('E').innerHTML = pointE.toString();
    document.getElementById('F').innerHTML = pointF.toString();

    document.getElementById('AB').innerHTML = lineAB.toString() + ' length: ' + lineAB.length;
    document.getElementById('CD').innerHTML = lineCD.toString() + ' length: ' + lineCD.length;
    document.getElementById('EF').innerHTML = lineEF.toString() + ' length: ' + lineEF.length;

    if (canFormTriangle(lineAB, lineCD, lineEF)) {
        document.getElementById('result1').innerHTML = 'The lines can form a triangle !';
    } else {
        document.getElementById('result1').innerHTML = 'The lines can not form a triangle !';
    }
}

function buildPoint(letter, x, y) {
    return {
        letter: letter,
        x: x,
        y: y,
        toString: function () {
            return this.letter + '(' + this.x + ',' + this.y + ')';
        }
    };
}

function buildLine(letters, point1, point2) {
    return {
        letters: letters,
        beginning: point1,
        ending: point2,
        length: calculateDistance(point1, point2),
        toString: function () {
            return this.letters + '(' + this.beginning.toString() + ',' + this.ending.toString() + ')';
        }
    };
}

function calculateDistance(point1, point2) {
    return Math.sqrt((point1.x - point2.x) * (point1.x - point2.x) + (point1.y - point2.y) * (point1.y - point2.y));
}

function canFormTriangle(line1, line2, line3) {
    if ((line1.length + line2.length > line3.length) &&
        (line1.length + line3.length > line2.length) &&
        (line2.length + line3.length > line1.length)) {
        return true;
    } else {
        return false;
    }
}

//Problem 2. Remove elements
//Write a function that removes all elements with a given value.
//Attach it to the array type.
//Read about prototype and how to attach methods.
//
//var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
//arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];

Array.prototype.remove = function (value) {
    while (this.indexOf(value) >= 0) {
        this.splice(this.indexOf(value), 1);
    }

    return this;
};

function problem2() {
    var arr = document.getElementById('input2arr').value.split(', '),
        element = document.getElementById('input2elem').value;

    document.getElementById('result2').innerHTML = arr.remove(element);
}

//Problem 3. Deep copy
//Write a function that makes a deep copy of an object.
//The function should work for both primitive and reference types.

function problem3() {
    var obj = {
            stringProperty: 'this is a string',
            numberProperty: 5,
            arrayProperty: [1, 2, 3, 4, 5],
            objectProperty: {
                a: 5,
                b: 7,
                c: [1, 2, 3]
            }
        },
        copy = createDeepCopy(obj),
        result = '',
        prop;

    result += 'Properties of the copy:<br /><br />';

    for (prop in copy) {
        result += (prop + ': ' + copy[prop] + '<br />');
        console.log(prop + ': ' + copy[prop]);
    }

    result += '<br />Change a reference type property of the original object:<br />';

    obj.arrayProperty[0] = 'This is changed';

    result += 'Object.arrayProperty: ' + obj.arrayProperty + '<br />The copy is not changed:<br />copy.arrayProperty: ' + copy.arrayProperty;

    document.getElementById('result3').innerHTML = result;
}

function createDeepCopy(obj) {
    if (obj === null || typeof(obj) !== 'object') {
        return obj;
    }

    var copy = obj.constructor();

    for (var prop in obj) {
        copy[prop] = createDeepCopy(obj[prop]);
    }

    return copy;
}

//Problem 4. Has property
//Write a function that checks if a given object contains a given property.
//
//var obj  = �;
//var hasProp = hasProperty(obj, 'length');

function problem4() {
    var obj = {
        stringProperty: 'this is a string',
        numberProperty: 5,
        arrayProperty: [1, 2, 3, 4, 5],
        objectProperty: {
            a: 5,
            b: 7,
            c: [1, 2, 3]
        }
    };

    hasProperty(obj, 'arrayProperty');
}

function hasProperty(obj, prop) {
    if (prop in obj) {
        document.getElementById('result4').innerHTML = 'The object contains the property ' + prop + ' with value: ' + obj[prop];
    } else {
        document.getElementById('result4').innerHTML = 'The object does not contain the property ' + prop;
    }
}

//Problem 5. Youngest person
//Write a function that finds the youngest person in a given array of people and prints his/hers full name
//Each person has properties firstname, lastname and age.
//
//Example:
//
//var people = [
//    { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
//    { firstname : 'Bay', lastname: 'Ivan', age: 81},� ];

function problem5() {
    var gosho = createPerson('Gosho', 'Petrov', 32),
        ivan = createPerson('Bay', 'Ivan', 81),
        pesho = createPerson('Pesho', 'Georgiev', 44),
        joro = createPerson('Zaeka', 'Joro', 5),
        people = [ivan, joro, pesho, gosho],
        len,
        i,
        youngest = people[0];

    for (i = 1, len = people.length; i < len; i += 1) {
        if (people[i].age <= youngest.age) {
            youngest = people[i];
        }
    }

    document.getElementById('result5').innerHTML = 'The youngest guy is ' + youngest.firstname + ' ' + youngest.lastname;
}

function createPerson(fname, lname, age) {
    return {
        firstname: fname,
        lastname: lname,
        age: age
    };
}

//Problem 6.
//Write a function that groups an array of people by age, first or last name.
//The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
//Use function overloading (i.e. just one function)
//
//Example:
//
//var people = {�};
//var groupedByFname = group(people, 'firstname');
//var groupedByAge= group(people, 'age');

function problem6() {
    var gosho = createPerson('Gosho', 'Petrov', 32),
        ivan = createPerson('Bay', 'Ivan', 81),
        pesho = createPerson('Pesho', 'Georgiev', 44),
        joro = createPerson('Zaeka', 'Joro', 5),
        people = [ivan, joro, pesho, gosho],
        groupedByFirstName = group(people, 'firstname'),
        groupedByLastName = group(people, 'lastname'),
        groupedByAge = group(people, 'age'),
        resultConsole = '',
        resultHTML = '',
        prop;

    resultConsole += '\nGrouped by first name:\n\n';
    resultHTML += '<br />Grouped by first name:<br /><br />';
    for (prop in groupedByFirstName) {
        resultConsole += (prop + ': ' + printArrayOfObjects(groupedByFirstName[prop], 'console'));
        resultHTML += (prop + ': ' + printArrayOfObjects(groupedByFirstName[prop], 'html'));
    }
    resultConsole += '\nGrouped by last name:\n\n';
    resultHTML += '<br />Grouped by last name:<br /><br />';
    for (prop in groupedByLastName) {
        resultConsole += (prop + ': ' + printArrayOfObjects(groupedByLastName[prop], 'console'));
        resultHTML += (prop + ': ' + printArrayOfObjects(groupedByLastName[prop], 'HTML'));
    }
    resultConsole += '\nGrouped by age:\n\n';
    resultHTML += '<br />Grouped by age:<br /><br />';
    for (prop in groupedByAge) {
        resultConsole += (prop + ': ' + printArrayOfObjects(groupedByAge[prop], 'console'));
        resultHTML += (prop + ': ' + printArrayOfObjects(groupedByAge[prop], 'HTML'));
    }

    document.getElementById('result6').innerHTML = resultHTML;
}

function group(array, property) {
    var i,
        len = array.length,
        prop,
        result = {};

    if (property === 'firstname') {
        for (i = 0; i < len; i += 1) {
            if (result[array[i].firstname]) {
                result[array[i].firstname].push(array[i]);
            } else {
                result[array[i].firstname] = [array[i]];
            }
        }
        return result;
    }

    if (property === 'lastname') {
        for (i = 0; i < len; i += 1) {
            if (result[array[i].lastname]) {
                result[array[i].lastname].push(array[i]);
            } else {
                result[array[i].lastname] = [array[i]];
            }
        }
        return result;
    }

    if (property === 'age') {
        for (i = 0; i < len; i += 1) {
            if (result[array[i].age]) {
                result[array[i].age].push(array[i]);
            } else {
                result[array[i].age] = [array[i]];
            }
        }
        return result;
    }
}

function printArrayOfObjects(array, type) {
    var result = '',
        prop,
        len = array.length;

    for (i = 0; i < len; i += 1) {
        for (prop in array[i]) {
            result += (prop + ': ' +
            array[i][prop] + '; ');
        }
        if (type === 'console') {
            result += '\n';
            if (i < len - 1) {
                result += '\t';
            }
        } else {
            result += '<br />';
            if (i < len - 1) {
                result += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            }
        }

    }
    return result;
}