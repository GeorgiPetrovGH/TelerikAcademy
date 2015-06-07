//Problem 5. nbsp
//Write a function that replaces non breaking white-spaces in a text with &nbsp;


function replaceAll (text, toReplace, replacement) {
    var regex = new RegExp(toReplace, 'gi');
    return text.replace(regex, replacement);
}

var text = 'We are living in an yellow submarine.    We don\'t have anything else.   ' +
            ' Inside the submarine is very tight.  So we are drinking all the day.    ' +
            ' We will move out of it in 5 days.     ';

text = replaceAll(text, ' ', '&nbsp;');
console.log(text);