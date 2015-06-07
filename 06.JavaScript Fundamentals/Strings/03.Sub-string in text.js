//Problem 3. Sub-string in text
//Write a JavaScript function that finds how many times a substring is contained in a given text 
//(perform case insensitive search).


function countSubstring(text, string) {
    var i,
        count = 0,
        textlen = text.length,
        strlen = string.length;
    if (textlen < strlen) {
        return 0;
    }
    text = text.toLowerCase();
    string = string.toLowerCase();
    for (i = 0; i < textlen - strlen; i += 1) {
        if (text.substr(i, strlen) === string) {
            count += 1;
        }
    }
    return count;
}

var text = 'We are living in an yellow submarine. We don\'t have anything else. ' +
            'Inside the submarine is very tight. So we are drinking all the day. ' +
            'We will move out of it in 5 days.';

console.log('Count: ' + countSubstring(text, 'in'))
