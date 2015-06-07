//Problem 2. Correct brackets
//Write a JavaScript function to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

function checkBrackets(expression) {
    var i,
        len = expression.length,
        leftBrackets = 0,
        rightBrackets = 0;
    for (i = 0; i < len; i += 1) {
        if (expression[i] === '(') {
            leftBrackets += 1;
        } else if (expression[i] === ')') {
            rightBrackets += 1;
        }

        if (leftBrackets < rightBrackets) {
            return false;
        }
    }
    if (leftBrackets === rightBrackets) {
        return true;
    }
    return false;
}

console.log('((a+b)/5-d) --> ' + checkBrackets('((a+b)/5-d)'));
console.log(')(a+b)) --> ' + checkBrackets(')(a+b))'));