//Problem 11. String format
//Write a function that formats a string using placeholders.
//The function should work with up to 30 placeholders and all types.

function format(str) {
    var newArguments = arguments;
    return str.replace(/{(\d+)}/g, function(match, p1) {
        return newArguments[+p1 + 1];
    });
}

var str1 = format('{0}, {1}!', 'Hello', 'World'),
    str2 = format("{0}, {1}, {0} text {2}", 1, "Pesho", "Gosho");  

console.log(str1);
console.log(str2);

