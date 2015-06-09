//Problem 1. Reverse string
//Write a JavaScript function that reverses a string and returns it.

function problem1() {
    var input = document.getElementById('input1').value,
        i,
        result = '';

    function reverse(str) {
        for (i = str.length - 1; i >= 0; i -= 1) {
            result += str[i];
        }

        return result;
    }

    document.getElementById('result1').innerHTML = reverse(input);
}

//Problem 2. Correct brackets
//Write a JavaScript function to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

function problem2() {
    var input = document.getElementById('input2').value.split(''),
        i,
        len,
        right = 0,
        left = 0,
        result;

    for (i = 0, len = input.length; i < len; i += 1) {
        if (input[i] === '(') {
            left += 1;
        }
        else if (input[i] === ')') {
            right += 1;
        }
    }

    result = (left === right);

    document.getElementById('result2').innerHTML = result;
}

//Problem 3. Sub-string in text
//Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
//Example:
//
//    The target sub-string is in
//
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//
//The result is: 9

function problem3() {
    var substr = document.getElementById('input3str').value,
        text = document.getElementById('input3text').value,
        i,
        len,
        count = 0;

    for (i = 0, len = text.length - substr.length; i < len; i += 1) {
        if (text.substr(i, substr.length) === substr) {
            count += 1;
        }
    }

    document.getElementById('result3').innerHTML = count + (count > 1 ? ' times' : ' time');
}

//Problem 4. Parse tags
//
//You are given a text. Write a function that changes the text in all regions:
//
//    <upcase>text</upcase> to uppercase.
//<lowcase>text</lowcase> to lowercase
//<mixcase>text</mixcase> to mix casing(random)
//Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.
//
//The expected result:
//    We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.
//
//Note: Regions can be nested.

function problem4() {
    var input = document.getElementById('input4').value;

    function parseTags(text) {
        var i,
            jump,
            random,
            originalText = text,
            currentStateArr = [],
            newText = [],
            len;

        for (i = 0, len = text.length; i < len; i += 1) {
            if (text[i] === '<') {
                switch (text[i + 1]) {
                    case 'u':
                        currentStateArr.push('u');
                        jump = text.indexOf('>', i);
                        i = jump + 1;
                        break;
                    case 'l':
                        currentStateArr.push('l');
                        jump = text.indexOf('>', i);
                        i = jump + 1;
                        break;
                    case 'm':
                        currentStateArr.push('m');
                        jump = text.indexOf('>', i);
                        i = jump + 1;
                        break;
                    case '/':
                        currentStateArr.pop();
                        jump = text.indexOf('>', i);
                        i = jump + 1;
                        break;
                }
            }
            switch (currentStateArr[currentStateArr.length - 1]) {
                case undefined:
                    newText.push(text[i]);
                    break;
                case 'u':
                    newText.push(text[i].toUpperCase());
                    break;
                case 'l':
                    newText.push(text[i].toLowerCase());
                    break;
                case 'm':
                    random = Math.random();
                    if (random < 0.5) {
                        newText.push(text[i].toLowerCase());
                        break;
                    } else {
                        newText.push(text[i].toUpperCase());
                        break;
                    }
            }
        }
        return newText.join('');
    }

    document.getElementById('result4').innerHTML = parseTags(input);
}

//Problem 5. nbsp
//
//Write a function that replaces non breaking white-spaces in a text with &nbsp;

function problem5() {
    var input = document.getElementById('input5').value;

    function replaceWhiteSpace(text) {
        return (text.split(/\s/g).join('&nbsp;'));
    }

    document.getElementById('result5').innerHTML = replaceWhiteSpace(input);
}

//Problem 6. Extract text from HTML
//
//Write a function that extracts the content of a html page given as text.
//    The function should return anything that is in a tag, without the tags.
//    Example:
//
//<html>
//<head>
//<title>Sample site</title>
//</head>
//<body>
//<div>text
//<div>more text</div>
//and more...
//</div>
//in body
//</body>
//</html>
//Result: Sample sitetextmore textand more...in body

function problem6() {
    var input = document.getElementById('input6').value;

    function extractText(html) {
        var len,
            result = '',
            i;

        for (i = 0, len = html.length; i < len; i += 1) {
            if (html[i] === '<') {
                i = html.indexOf('>', i);
            }

            if (html[i] !== '>') {
                result += html[i];
            }
        }
        return result;
    }

    document.getElementById('result6').innerHTML = extractText(input);
}

//Problem 7. Parse URL
//
//Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Return the elements in a JSON object.
//    Example:
//
//URL	result
//http://telerikacademy.com/Courses/Courses/Details/239	{ protocol: http,
//    server: telerikacademy.com
//resource: /Courses/Courses/Details/239

function problem7() {
    var input = document.getElementById('input7').value,
        result = parseUrl(input);

    function parseUrl(url) {
        var indexOfSlash = url.indexOf('/'),
            indexOfSecondSlash = url.indexOf('/', indexOfSlash + 1),
            indexOfThirdSlash = url.indexOf('/', indexOfSecondSlash + 1),
            result = {};

        result.protocol = url.substring(0, url.indexOf(':'));
        result.server = url.substring(indexOfSecondSlash + 1, indexOfThirdSlash);
        result.resource = url.substring(indexOfThirdSlash);

        return result;
    }

    function printObj(obj) {
        var prop,
            result = '';

        for (prop in obj) {
            result += ('&nbsp;&nbsp;&nbsp;&nbsp;' + prop + ': ' + obj[prop]);
            if (prop !== 'resource') {
                result += ',<br>';
            } else {
                result += '<br>';
            }
        }

        return result;
    }

    document.getElementById('result7').innerHTML = '{<br />' + printObj(result) + '}';
}

//Problem 8. Replace tags
//
//Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

function problem8() {
    var input = document.getElementById('input8').value;

    function replaceTag(html) {
        while (html.indexOf('<a href') >= 0) {
            html = html.replace('<a href="', '[URL=').
                replace('">', ']').
                replace('</a>', '[/URL]');
        }

        return html;
    }

    document.getElementById('result8').innerHTML = replaceTag(input);
}

//Problem 9. Extract e-mails
//
//Write a function for extracting all email addresses from given text.
//    All sub-strings that match the format @… should be recognized as emails.
//    Return the emails as array of strings.

function problem9() {
    var input = document.getElementById('input9').value,
        result;

    function extractEmails(text) {
        var i,
            len,
            arr = text.split(' '),
            possibleEmails = [],
            validEmails = [];

        for (i = 0, len = arr.length; i < len; i += 1) {
            if ((arr[i].indexOf('@') > 0) &&
                (arr[i].indexOf('@') < (arr[i].length - 1)) &&
                (arr[i].indexOf('@')) == arr[i].lastIndexOf('@')) {
                possibleEmails.push(arr[i]);
            }
        }

        for (i = 0, len = possibleEmails.length; i < len; i += 1) {
            if ((possibleEmails[i].indexOf('.', possibleEmails[i].indexOf('@')) >
                (possibleEmails[i].indexOf('@') + 1)) &&
                (possibleEmails[i].lastIndexOf('.') <
                (possibleEmails[i].length - 1))) {
                validEmails.push(possibleEmails[i]);
            }
        }

        return [possibleEmails.join(', '), validEmails.join(', ')];
    }

    result = extractEmails(input);

    document.getElementById('result9').innerHTML = 'Possible emails (only ...@... matched):<br />' + result[0] + '<br />Valid emails, meeting other criteria as well:<br />' + result[1];
}

//Problem 10. Find palindromes
//
//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

function problem10() {
    var input = document.getElementById('input10').value;

    document.getElementById('result10').innerHTML = findPalindromes(input);
}

function findPalindromes(text) {
    var i,
        len,
        result = [],
        arrOfWords = text.split(' ').map(function (item) {
            return item.trim('.,!?()"-');
        });

    for (i = 0, len = arrOfWords.length; i < len; i += 1) {
        if (arrOfWords[i].length > 1 &&
            arrOfWords[i].toLowerCase() === reverseWord(arrOfWords[i].toLowerCase())) {
            result.push(arrOfWords[i]);
        }
    }

    return result;
}

function reverseWord(word) {
    return word.split('')
        .reverse()
        .join('');
}

String.prototype.trimLeft = function (charlist) {
    if (charlist === undefined)
        charlist = "\s";

    return this.replace(new RegExp("^[" + charlist + "]+"), "");
};

String.prototype.trimRight = function (charlist) {
    if (charlist === undefined)
        charlist = "\s";

    return this.replace(new RegExp("[" + charlist + "]+$"), "");
};

String.prototype.trim = function (charlist) {
    return this.trimLeft(charlist).trimRight(charlist);
};

//Problem 11. String format
//
//Write a function that formats a string using placeholders.
//    The function should work with up to 30 placeholders and all types.
//    Examples:
//
//var str = stringFormat('Hello {0}!', 'Peter');
////str = 'Hello Peter!';
//
//var frmt = '{0}, {1}, {0} text {2}';
//var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
////str = '1, Pesho, 1 text Gosho'

function problem11() {
    var str1 = format('{0}, {1}!', 'Hello', 'World'),
        str2 = format("{0}, {1}, {0} text {2}", 1, "Pesho", "Gosho"),
        str3 = format("Array: {0}, Object: {1}, Boolean: {2}", [1, 2, 3], {
            a: 1,
            b: 2
        }, true);

    function format(str) {
        var newArguments = arguments;

        return str.replace(/{(\d+)}/g, function(match, p1) {
            return newArguments[+p1 + 1];
        });
    }

    document.getElementById('result11').innerHTML = 'Ex.1: ' + str1 + '<br />' + 'Ex.2: ' + str2 + '<br />' + 'Ex.3: ' + str3;
}

//Problem 12. Generate list
//
//Write a function that creates a HTML <ul> using a template for every HTML <li>.
//The source of the list should be an array of elements.
//    Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
//    Example: HTML:
//
//    <div data-type="template" id="list-item">
//    <strong>-{name}-</strong> <span>-{age}-</span>
///div>
//JavaScript:
//
//var people = [{name: 'Peter', age: 14},…];
//var tmpl = document.getElementById('list-item').innerHtml;
//var peopleList = generateList(people, template);
////peopleList = '<ul><li><strong>Peter</strong> <span>14</span></li><li>…</li>…</ul>'

function problem12() {
    var people = [{
            name: 'Pesho',
            age: 25
        }, {
            name: 'Gosho',
            age: 30
        }, {
            name: 'Vanko',
            age: 35
        }, {
            name: 'Doncho',
            age: 40
        }],
        divPeople = document.getElementById('list-item'),
        template = divPeople.innerHTML,
        peopleList = generateList(people, template);

    divPeople.innerHTML = peopleList;

    document.body.removeChild(document.getElementById('pr12'));
    document.body.removeChild(document.getElementById('pr12div'));
}

function generateList(people, template) {
    var prop,
        i,
        len,
        liContent,
        props = [],
        peopleList = [];

    peopleList.push('<ul><strong>-\{name\}-</strong><span>-\{age\}-</span >');

    for (prop in people[0]) {
        props.push(prop);
    }

    for (i = 0, len = people.length; i < len; i += 1) {
        peopleList.push('<li>');
        liContent = template;

        for (prop in people[0]) {
            liContent = liContent.replace(new RegExp(
                '\\-{' + prop + '\\}-', "g"), people[i][prop]);
        }

        peopleList.push(liContent);
        peopleList.push('</li>');
    }

    peopleList.push('</ul>');

    return peopleList.join('');
}