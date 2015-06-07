// Problem 1:
function problem1() {
    document.getElementById("pr1answer").style.color = "#FF0000";

    var input = document.getElementById('number1').value;
    if (input !== '' && !isNaN(input) && input % 1 === 0) {
        var result,
            digit = input[input.length - 1];

        switch (digit) {
            case '0': result = 'Zero'; break;
            case '1': result = 'One'; break;
            case '2': result = 'Two'; break;
            case '3': result = 'Three'; break;
            case '4': result = 'Four'; break;
            case '5': result = 'Five'; break;
            case '6': result = 'Six'; break;
            case '7': result = 'Seven'; break;
            case '8': result = 'Eight'; break;
            case '9': result = 'Nine'; break;
        }
        document.getElementById('pr1answer').innerHTML = 'Number: ' + input + ' Last digit: ' + result;
        console.log('Problem 1: ' + result);
    } else {
        document.getElementById('pr1answer').innerHTML = 'Invalid input. Enter an integer.';
    }    

    //clear input
    document.getElementById('number1').value = '';
} 

// Problem 2:
function problem2() {
    document.getElementById("pr2answer").style.color = "#FF0000";

    var input = document.getElementById('number2').value,
        result = '',
        i;

    if (input !== '' && !isNaN(input)) {
        if (input < 0) {
            input = (-input).toString();
            result += '-';
        }
        for (i = input.length - 1; i >= 0; i -= 1) {
            result += input[i];
        }
        document.getElementById('pr2answer').innerHTML = 'Initial number: ' + input + ' Reversed number: ' + result;
        console.log('Problem 2: ' + result);
    } else {
        document.getElementById('pr2answer').innerHTML = 'Invalid input. Enter a number.';
    }

    //clear input
    document.getElementById('number2').value = '';
}

// Problem 3:
function problem3() {
    document.getElementById("pr3answer").style.color = "#FF0000";
    
    var check = document.getElementById('check').checked,
        word = document.getElementById('word').value,
        text = document.getElementById('text').innerHTML,
        result = 0;

    if (word !== '') {
        if (check) {            
            result = searchWord(text, word, true);  
        } else {
            result = searchWord(text, word, false);                      
        }       
        document.getElementById('pr3answer').innerHTML = 'Word: ' + word + ' Occurrence: ' + result;
    } else {        
        document.getElementById('pr3answer').innerHTML = 'Please enter a word to search for:';
    }

    //clear input
    document.getElementById('check').checked = false;
    document.getElementById('word').value = '';
}

function searchWord(text, word, isCaseSensitive){
    var regexString = '\\b' + word + '\\b',
        modifier = isCaseSensitive ? 'g' : 'gi',
        regex = new RegExp(regexString, modifier);
        if(text.match(regex)){
            return text.match(regex).length;
        } else {
            return 0;
        }    
}

// Problem 4:
function problem4() {
    document.getElementById("pr4answer").style.color = "#FF0000";
    
    var count = document.getElementsByTagName('div').length;
    document.getElementById('pr4answer').innerHTML = 'There are ' + count + ' Div-s in this HTML.';
    console.log('Problem 4: There are ' + count + ' Div-s.');
}

// Problem 5:
function problem5() {
    document.getElementById("pr5answer").style.color = "#FF0000";

    var input = document.getElementById('array5').value,
        validInput = validateInput(input),
        number = document.getElementById('number5').value,
        arr,
        i,
        result;

    if (validInput && number !== '' && !isNaN(number)) {
        arr = input.split(', ').map(Number);
        number *= 1;
        result = count(number, arr);
        
        document.getElementById('pr5answer').innerHTML = 'Array: ' + arr + ' Number: ' + number + ' Count: ' + result;
        console.log('Problem 5: ' + 'Number: ' + number + ' Count: ' + result);
    } else {
        document.getElementById('pr5answer').innerHTML = 'Invalid input';
    }
    
    //clear input (save array)
    document.getElementById('array5').value = '1, 4, 4, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 1';
    document.getElementById('number5').value = '';
}

function test() {
    document.getElementById("pr5test").style.color = "#FF0000";

    var arrTest = [1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5];
    var number1 = 1,
        number2 = 2,
        number3 = 3, 
        number4 = 4,
        number5 = 5,
        test1 = count(number1, arrTest),
        test2 = count(number2, arrTest),
        test3 = count(number3, arrTest),
        test4 = count(number4, arrTest),
        test5 = count(number5, arrTest),
        test1Exp = 1,
        test2Exp = 2,
        test3Exp = 3,
        test4Exp = 4,
        test5Exp = 5;
    document.getElementById('pr5test').innerHTML = 'Here comes the tests:' + 
        '<br />Test array--> [ ' + arrTest.join(', ') + ' ]' + 
        '<br />Test1--> Number: '+ number1 +' Expected result: ' + test1Exp + ' Result: ' + test1 + ' --> ' + (test1 === test1Exp) +
        '<br />Test2--> Number: '+ number2 +' Expected result: ' + test2Exp + ' Result: ' + test2 + ' --> ' + (test2 === test2Exp) +
        '<br />Test3--> Number: '+ number3 +' Expected result: ' + test3Exp + ' Result: ' + test3 + ' --> ' + (test3 === test3Exp) +
        '<br />Test4--> Number: '+ number4 +' Expected result: ' + test4Exp + ' Result: ' + test4 + ' --> ' + (test4 === test4Exp) +
        '<br />Test5--> Number: '+ number5 +' Expected result: ' + test5Exp + ' Result: ' + test5 + ' --> ' + (test5 === test5Exp);
}

function count(number, array) {
    var counter = 0;
    for (var i in array) {
        if (array[i] == number) {
            counter++;
        }
    }
    return counter;
}

function validateInput(input) {
    var validInput = true,
        arr;
    if (input === '') {
        validInput = false;
    } else {
        arr = input.split(', ').map(Number);
        for (i = 0, len = arr.length; i < len; i += 1) {
            if (isNaN(arr[i])) {
                validInput = false;
                break;
            }
        }
    }
    return validInput;
}

// Problem 6:
function problem6() {
    document.getElementById("pr6answer").style.color = "#FF0000";

    var input = document.getElementById('array6').value,
        validInput = validateInput(input),
        number = document.getElementById('number6').value,
        arr,
        i,
        result;

    if (validInput && number !== '' && !isNaN(number) && (number % 1 === 0)) {
        arr = input.split(', ').map(Number);
        number *= 1;

        if (number >= 0 && number < arr.length) {
            if (number > 0 && number < arr.length - 1) {
                result = checkLargerThanNeighbours(arr, number);
            } else {
                result = 'This element has only 1 neighbour';
            }
        } else {
            result = 'Index must be >= 0 and < ' + arr.length;
        }
    
        document.getElementById('pr6answer').innerHTML = 'Array: ' + arr + ' Index: ' + number + ' Bigger than it\'s neighbours: ' + result;
        console.log('Problem 6: Index ' + number + ' Bigger than it\'s neighbours: ' + result);
    } else {
        document.getElementById('pr6answer').innerHTML = 'Invalid input';
    }

    //clear input (save array)
    document.getElementById('array6').value = '11, 2, -1, 3, 1, 7, 4, 1, -2, 13, 7, 5';
    document.getElementById('number6').value = '';
}

function checkLargerThanNeighbours(array, number) {
    if (array[number] > array[number - 1] && array[number] > array[number + 1]) {
        return true;
    }
    return false;
}

// Problem 7:
function problem7() {
    document.getElementById("pr7answer").style.color = "#FF0000";

    var input = document.getElementById('array7').value,
        validInput = validateInput(input),        
        arr,
        i,
        len,
        result = -1;

    if (validInput) {
        arr = input.split(', ').map(Number);
        for (i = 0, len = arr.length; i < len; i += 1) {
            if (checkLargerThanNeighbours(arr, i)) {
                result = i;
                break;
            }
        }
        document.getElementById('pr7answer').innerHTML = 'Index (-1 if none): ' + result;
        console.log('Problem 7: Index (-1 if none): ' + result);
    } else {
        document.getElementById('pr7answer').innerHTML = 'Invalid input';
    }
}


