jsConsole.writeLine('Open the console to see the results');

//Problem 1. Format with placeholders
//Write a function that formats a string. The function should have placeholders, as shown in the example
//Add the function to the String.prototype

console.log('Problem 1');

String.prototype.format = function (options) {
    var option,
        regex,
        formatted = this;

    for (option in options) {
        regex = new RegExp('#{' + option + '}', 'g');
        formatted = formatted.replace(regex, options[option]);
    }

    return formatted;
};

console.log('Hello, there! Are you #{name}?'.format({ name: 'John' }));
console.log('My name is #{name} and I am #{age}-years-old'.format({ name: 'John', age: 13 }));
console.log('');

//Problem 2. HTML binding
//Write a function that puts the value of an object into the content/attributes of HTML tags.
//Add the function to the String.prototype

console.log('Problem 2');

String.prototype.bind = function (output, parameters) {
    var regexContent,
        regexHref,
        regexClass,
        prop;

    output = this;

    for (prop in parameters) {
        regexContent = new RegExp('(<.*?data-bind-content="' + prop + '".*?>)(.*?)(<\\s*/.*?>)', 'g');
        regexHref = new RegExp('(<.*?data-bind-href="' + prop + '".*?)>', 'g');
        regexClass = new RegExp('(<.*?data-bind-class="(' + prop + ')".*?)>', 'g');

        output = output.replace(regexContent, function (element, openingTag, content, closingTag) {
            return openingTag + parameters[prop] + closingTag;
        });

        output = output.replace(regexHref, function (tag, contentBeforeClosing) {
            return contentBeforeClosing + ' href="' + parameters[prop] + '">';
        });

        output = output.replace(regexClass, function (tag, contentBeforeClosing) {
            return contentBeforeClosing + ' class="' + parameters[prop] + '">';
        });
    }

    return output;
};

console.log('<div data-bind-content="name"></div>'.bind('', { name: 'Steven' }));
console.log('<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></div>'.bind('', { name: 'Elena', link: 'http://telerikacademy.com' }));

