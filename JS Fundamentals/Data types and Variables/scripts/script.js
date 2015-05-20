/* global jsConsole */
// Problem 1. JavaScript literals
// Assign all the possible JavaScript literals to different variables.

var int = 5;
jsConsole.writeLine("int: " + int);

var float = 3.14;
jsConsole.writeLine("float: " + float);

var bool = true;
jsConsole.writeLine("bool: " + bool);

var str = "Gosho";
jsConsole.writeLine("string: " + str);

var object = {};
jsConsole.writeLine("object: " + object);

var array = [1, 2, 3];
jsConsole.writeLine("array: " + array);

jsConsole.writeLine("");

//Problem 2. Quoted text
//Create a string variable with quoted text in it.
//For example: `'How you doin'?', Joey said'.

var example = '"How you doin?", Joey said.';
jsConsole.writeLine(example);

jsConsole.writeLine("");

//Problem 3. Typeof variables
//Try typeof on all variables you created.

jsConsole.writeLine(typeof(int));
jsConsole.writeLine(typeof(float));
jsConsole.writeLine(typeof(bool));
jsConsole.writeLine(typeof(str));
jsConsole.writeLine(typeof(object));
jsConsole.writeLine(typeof(array));

jsConsole.writeLine("");

//Problem 4. Typeof null
//Create null, undefined variables and try typeof on them.

var nullVar = null;
var undefinedVar = undefined;

jsConsole.writeLine(typeof(nullVar));
jsConsole.writeLine(typeof(undefinedVar));