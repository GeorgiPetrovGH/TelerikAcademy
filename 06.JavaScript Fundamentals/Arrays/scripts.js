// Problem 1:
function problem1() {
    document.getElementById("pr1answer").style.color = "#FF0000";

    var arr = [],
        index;

    for (index = 0; index < 20; index += 1) {
        arr[index] = index * 5;
    }

    document.getElementById('pr1answer').innerHTML = arr.join(', ');
    console.log('Problem 1: ' + arr.join(', '));
} 

//Problem 2:
function problem2() {
    document.getElementById("pr2answer").style.color = "#FF0000";

    var string1 = document.getElementById('first-string2').value,
        string2 = document.getElementById('second-string2').value,
        len1,
        len2,
        index,
        result = '';

    if (string1 !== '' && string2 !== '') {
        len1 = string1.length;
        len2 = string2.length;

        for (index = 0; index < Math.min(len1, len2); index += 1) {
            if (string1[index] < string2[index]) {
                result = '" ' + string1 + '"' + ' is lexicographically smaller than ' + '" ' + string2 + '"';
                break;
            }
            if (string1[index] > string2[index]) {
                result = '" ' + string2 + '"' + ' is lexicographically smaller than ' + '" ' + string1 + '"';
                break;
            }
        }

        if (result === '') {
            if (len1 < len2) {
                result = '" ' + string1 + '"' + ' is lexicographically smaller than ' + '" ' + string2 + '"';
            } else if (string1len > string2len) {
                result = '" ' + string2 + '"' + ' is lexicographically smaller than ' + '" ' + string1 + '"';
            } else {
                result = string1 + ' = ' + string2;
            }
        }

        document.getElementById('pr2answer').innerHTML = result;
        console.log('Problem 2: ' + result);

    } else {
        document.getElementById('pr2answer').innerHTML =
            'Please enter two strings';
    }

    //clear input
    document.getElementById('first-string2').value = '';
    document.getElementById('second-string2').value = '';
}


// Problem 3:
function problem3() {
    document.getElementById("pr3answer").style.color = "#FF0000";
    
    var input = document.getElementById('array3').value,
        validInput = validateInput(input),
        max = 1,
        currentMax = 1,
        maxEndIndex = 0,
        arr,
        i,
        len,
        maxSequence;

    if (validInput) {
        arr = input.split(', ').map(Number);

        for (i = 1, len = arr.length; i < len; i += 1) {
            if (arr[i] === arr[i - 1]) {
                currentMax += 1;
                if (currentMax > max) {
                    max = currentMax;
                    maxEndIndex = i;
                }
            } else {
                currentMax = 1;
            }
        }
        maxSequence = arr.splice(maxEndIndex - max + 1, max).join(', ');
        document.getElementById('pr3answer').innerHTML = 'Maximal sequence of equal elements: ' + maxSequence;
        console.log('Problem 3: Maximal sequence of equal elements: ' + maxSequence);

    } else {
        document.getElementById('pr3answer').innerHTML = 'Invalid input';
    } 

    //clear input(Actually writting the innitial sequence)
    document.getElementById('array3').value = '2, 1, 1, 2, 3, 3, 2, 2, 2, 1';    
}

//additional function
function validateInput(input) {
    var validInput = true;
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

// Problem 4:
function problem4() {
    document.getElementById("pr4answer").style.color = "#FF0000";

    var input = document.getElementById('array4').value,
        validInput = validateInput(input),
        max = 1,
        currentMax = 1,
        maxEndIndex = 0,
        arr,
        i,
        len,
        maxSequence;

    if (validInput) {
        arr = input.split(', ').map(Number);
        for (i = 1, len = arr.length; i < len; i += 1) {
            if (arr[i] > arr[i - 1]) {
                currentMax += 1;
                if (currentMax > max) {
                    max = currentMax;
                    maxEndIndex = i;
                }
            } else {
                currentMax = 1;
            }
        }
        maxSequence = arr.splice(maxEndIndex - max + 1, max).join(', ');
        document.getElementById('pr4answer').innerHTML =
            'Maximal sequence of equal elements: ' + maxSequence;
        console.log('Problem 4: Maximal sequence of equal elements: ' +
            maxSequence);
    } else {
        document.getElementById('pr4answer').innerHTML = 'Invalid input';
    }

    //Writting the innitial sequence
    document.getElementById('array4').value = '2, 1, 1, 2, 3, 3, 2, 2, 2, 1';
}

// Problem 5:
function problem5() {
    document.getElementById("pr5answer").style.color = "#FF0000";

    var input = document.getElementById('array5').value,
        validInput = validateInput(input),
        temp,
        arr,
        i,
        j,
        min,
        len,
        result;

    if (validInput) {
        arr = input.split(', ').map(Number);
        result = 'Initial array: ' + arr.join(', ');

        for (i = 0, len = arr.length; i < len; i += 1) {
            for (j = i + 1; j < len; j += 1) {
                if (arr[i] > arr[j]) {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }

        result += '<br>Sorted array: ' + arr.join(', ');
        document.getElementById('pr5answer').innerHTML = result;
        console.log('Problem 5: ' + result);

    } else {
        document.getElementById('pr5answer').innerHTML = 'Invalid input';
    }

    //Writting the innitial sequence
    document.getElementById('array5').value = '14, -2, 8, 3, 11, 0, 2, -4, 10, 1, 9';
}

// Problem 6:
function problem6() {
    document.getElementById("pr6answer").style.color = "#FF0000";

    var input = document.getElementById('array6').value,
        validInput = validateInput(input),
        mostFrequent,
        current,
        mostFrequentCount = 0,
        currentCount = 0,
        arr,
        i,
        j,
        len,
        result;

    if (validInput) {
        arr = input.split(', ').map(Number);
        for (i = 0, len = arr.length; i < len; i += 1) {
            current = arr[i];
            currentCount = 0;
            for (j = i; j < len; j += 1) {
                if (arr[j] === current) {
                    currentCount += 1;
                    if (currentCount > mostFrequentCount) {
                        mostFrequentCount = currentCount;
                        mostFrequent = current;
                    }
                }
            }
        }

        result = 'The most frequent number is: ' + mostFrequent + ' (' + mostFrequentCount + ' times)';
        document.getElementById('pr6answer').innerHTML = result;
        console.log('Problem 6: ' + result);

    } else {
        document.getElementById('pr6answer').innerHTML = 'Invalid input';
    }

    //Writting the innitial sequence
    document.getElementById('array6').value = '4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3';
}

// Problem 7:
function problem7() {
    document.getElementById("pr7answer").style.color = "#FF0000";

    var input = document.getElementById('array7').value,
        number = document.getElementById('number7').value,
        validInput = validateInput(input),
        arr,
        i,
        indexOf,
        num,
        len,
        result;

    if (validInput && number !== '' && !isNaN(number)) {
        arr = input.split(', ').map(Number);
        arr.sort(function(a, b) {
            return a - b;
        });
        number *= 1;
        indexOf = binSearch(arr, number, 0, arr.length - 1);
        result = 'The index of ' + number + ' is (-1 if not found): ' + indexOf;
        document.getElementById('pr7answer').innerHTML = result;
        console.log('Problem 7: ' + result);
    } else {
        document.getElementById('pr7answer').innerHTML = 'Invalid input';
    }

    //Writting the innitial sequence
    document.getElementById('array7').value = '-4, -2, 0, 1, 2, 3, 8, 9, 10, 11, 14';
    document.getElementById('number7').value = '3';

    function binSearch(array, number, start, end) {
        if (array[start] > number || number > array[end]) {
            return (-1);
        }
        var middle = ((end + start) / 2) | 0;
        if (array[middle] === number) {
            return middle;
        } else {
            if (array[middle] > number) {
                return binSearch(array, number, start, (middle - 1));
            } else {
                return binSearch(array, number, (middle + 1), end);
            }
        }
    }
}
