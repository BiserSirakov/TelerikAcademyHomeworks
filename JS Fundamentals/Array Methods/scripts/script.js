//Problem 1. Make person
//Write a function for creating persons.
//Each person must have firstname, lastname, age and gender (true is female, false is male)
//Generate an array with ten person with different names, ages and genders

function problem1() {
    var people = generatePeople();

    people.forEach(function (item) {
        console.log(item);
    });

    console.log('');
}

function createPerson(fname, lname, age, gender) {
    return {
        firstname: fname,
        lastname: lname,
        age: age,
        gender: gender
    };
}

function generatePeople() {
    var arr = [],
        firstNames = ['Asen', 'Angel', 'Boris', 'Georgi', 'Marin', 'Ana', 'Eli', 'Elena', 'Gergana', 'Mariika'],
        lastNames = ['Ivanov', 'Dimitrov', 'Petrov', 'Georgiev', 'Nikolov', 'Borisova', 'Gigova', 'Atanasova', 'Ivanova', 'Georgieva'],
        i,
        len = 10;

    for (i = 0; i < len; i += 1) {
        arr[i] = createPerson(firstNames[i], lastNames[i], Math.floor(Math.random() * (80 - 10) + 10), (i > 4));
    }

    return arr;
}

//Problem 2. People of age
//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
//Use only array methods and no regular loops (for, while)

function problem2() {
    var people = generatePeople();

    people.forEach(function (item) {
        console.log(item);
    });

    console.log(people.every(function (item) {
        return item.age >= 18;
    }));

    console.log('');
}

//Problem 3. Underage people
//Write a function that prints all underaged persons of an array of person
//Use Array#filter and Array#forEach
//Use only array methods and no regular loops (for, while)

function problem3() {
    var people = generatePeople();

    people.forEach(function (item) {
        console.log(item);
    });

    console.log(people.filter(function (item) {
        return item.age < 18;
    }));

    console.log('');
}

//Problem 4. Average age of females
//Write a function that calculates the average age of all females, extracted from an array of persons
//Use Array#filter
//Use only array methods and no regular loops (for, while)

function problem4() {
    var people = generatePeople(),
        females = people.filter(function (item) {
            return item.gender;
        });

    females.forEach(function (item) {
        console.log(item);
    });

    console.log('');

    console.log('Average age of females : ' + females.reduce(function(sum, item) {
        return sum + item.age / females.length;
    }, 0));
}

//Problem 5. Youngest person
//Write a function that finds the youngest male person in a given array of people and prints his full name
//Use only array methods and no regular loops (for, while)
//Use Array#find

function problem5() {
    var people = generatePeople();

    people.forEach(function(item) {
        console.log(item);
    });

    if (!Array.prototype.find) {
        Array.prototype.find = function(callback) {
            var i, len = this.length;
            for (i = 0; i < len; i += 1) {
                if (callback(this[i], i, this)) {
                    return this[i];
                }
            }
        };
    }

    var youngestMale = people.sort(function(x, y) {
        return x.age - y.age;
    }).find(function(item) {
        return !item.gender;
    });

    console.log(youngestMale.firstname + ' ' + youngestMale.lastname);

    console.log('');
}

//Problem 6. Group people
//Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
//Use Array#reduce
//Use only array methods and no regular loops (for, while)
//    Example:
//
//        result = {
//            'a': [{
//                firstname: 'Asen',
//                /* ... */
//            }, {
//                firstname: 'Anakonda',
//                /* ... */
//            }],
//            'j': [{
//                firstname: 'John',
//                /* ... */
//            }]
//        };

function problem6() {
    var people = generatePeople(),
        result = people.reduce(function(obj, item) {
        if (obj[item.firstname[0]]) {
            obj[item.firstname[0]].push(item);
        } else {
            obj[item.firstname[0]] = [item];
        }
        return obj;
    }, {});

    console.log(result);
}