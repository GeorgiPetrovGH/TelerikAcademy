// Problem 1:
function problem1() {
    var a = document.getElementById('first-number').value,
        b = document.getElementById('second-number').value,
        temp;
    document.getElementById("pr1answer").style.color = "#FF0000";   
    
    if (!isNaN(a) && !isNaN(b) && a !== '' && b !== '') {
        if (a > b) {
            temp = a;
            a = b;
            b = temp;
        }

        document.getElementById('pr1answer').innerHTML = a + ' ' + b;
        console.log('Problem 1: ' + a + ' ' + b);
    } else {
        document.getElementById('pr1answer').innerHTML = 'Incorrect input. Enter two numbers.';
    }
    //clear input
    document.getElementById('first-number').value = '';
    document.getElementById('second-number').value = '';
}

//Problem 2:
function problem2() {
    var a = document.getElementById('first-number2').value,
        b = document.getElementById('second-number2').value,
        c = document.getElementById('third-number2').value,
        result;
    document.getElementById("pr2answer").style.color = "#FF0000";
        
    if(!isNaN(a) && !isNaN(b) && !isNaN(c) && a!=='' && b!=='' && c!=='') {            
        if(a * 1 === 0 || b * 1 === 0 || c * 1 === 0) {
            result = '0';
        } else {
            if(a > 0) {
            if(b > 0) {
                if(c > 0) { result = '+'; }                   
                else { result = '-'; }
            } else {
                if(c > 0) { result = '-'; }                    
                else { result = '+'; }
            }
        } else {
            if(b > 0) {
                if(c > 0) { result = '-'; }                    
                else { result = '+'; }
            } else {
                if(c > 0) { result = '+'; }                    
                else { result = '-'; }
            }
        }
        } 
            
        document.getElementById('pr2answer').innerHTML = 'Product is: ' + result;
        console.log('Problem 2: Product is ' + result);

    } else {
        document.getElementById('pr2answer').innerHTML = 'Incorrect input. Enter three numbers.';
    }

    //clear input
    document.getElementById('first-number2').value = '';
    document.getElementById('second-number2').value = '';
    document.getElementById('third-number2').value = '';
}

//Problem 3:
function problem3() {
    var a = document.getElementById('first-number3').value,
        b = document.getElementById('second-number3').value,
        c = document.getElementById('third-number3').value,
        array = [a,b,c],
        result,
        len,
        index;
    document.getElementById("pr3answer").style.color = "#FF0000";

    if(!isNaN(a) && !isNaN(b) && !isNaN(c) && a !=='' && b!=='' && c!=='') {
        array[0] = a * 1; 
        array[1] = b * 1;
        array[2] = c * 1;
        result = array[0];
        for (index = 1, len = array.length; index < len; index+=1) {
            if(array[index] >= result) {
                result = array[index];
            }
        };
            
        document.getElementById('pr3answer').innerHTML = result;
        console.log('Problem 4: ' + result);
        
    } else {
        document.getElementById('pr3answer').innerHTML = 'Incorrect input. Enter three numbers.';
    }

    //clear input
    document.getElementById('first-number3').value = '';
    document.getElementById('second-number3').value = '';
    document.getElementById('third-number3').value = '';
}

//Problem 4:
function problem4 () {
    var a = document.getElementById('first-number4').value,
        b = document.getElementById('second-number4').value,
        c = document.getElementById('third-number4').value,
        result;     
    document.getElementById("pr4answer").style.color = "#FF0000";  

    if(!isNaN(a) && !isNaN(b) && !isNaN(c) && a !== '' && b !== '' && c !== '') {
        a *= 1; 
        b *= 1;
        c *= 1;
        if(a>=b) {
            if(b>=c) { result = a + ' ' + b + ' ' + c; } 
            else {
                if(c>a) { result = c + ' ' + a + ' ' + b; }
                else { result = a + ' ' + c + ' ' + b;}
            }            
        } else {
            if(a>=c) { result = b + ' ' + a + ' ' + c; }
            else {
                if(c>=b) { result = c + ' ' + b + ' ' + a; }
                else {result = b + ' ' + c + ' ' + a;}
            }
        }
        
        document.getElementById('pr4answer').innerHTML = result;
        console.log('Problem 4: ' + result);
    } else {
        document.getElementById('pr4answer').innerHTML = 'Incorrect input. Enter three numbers.';
    } 

    //clear input
    document.getElementById('first-number4').value = '';
    document.getElementById('second-number4').value = '';
    document.getElementById('third-number4').value = ''; 
}
//Problem 5: 
function problem5() {
    var digit = document.getElementById('first-number5').value,
        result = 'not a digit';
    document.getElementById("pr5answer").style.color = "#FF0000";
    
    switch (digit) {
        case '0': result = "Zero"; break;
        case '1': result = "One"; break;
        case '2': result = "Two"; break;
        case '3': result = "Three"; break;
        case '4': result = "Four"; break;
        case '5': result = "Five"; break;
        case '6': result = "Six"; break;
        case '7': result = "Seven"; break;
        case '8': result = "Eight"; break;
        case '9': result = "Nine"; break;        
    }

    document.getElementById('pr5answer').innerHTML = result;
    console.log('Problem 5: ' + result);

    //clear input
    document.getElementById('first-number5').value = '';
}

//Problem 6: 
function problem6() {
    var a = document.getElementById('first-number6').value,
        b = document.getElementById('second-number6').value,
        c = document.getElementById('third-number6').value,
        result,
        d,
        firstRoot,
        secondRoot;     
    document.getElementById("pr6answer").style.color = "#FF0000";


    if (!isNaN(a) && !isNaN(b) && !isNaN(c) && a !== '' && b !== '' && c !== '' && a * 1 !== 0) {
        a *= 1; 
        b *= 1;
        c *= 1;
        d = b * b - 4 * a * c;
        firstRoot = (-b - Math.sqrt(d)) / (2 * a);
        secondRoot = (-b + Math.sqrt(d)) / (2 * a);

        if(d<0) {
            result = 'no real roots';
        } else if(d===0) {
            result = 'first root = second root: ' + firstRoot;
        } else {
            result = ' first root: ' + firstRoot + ' secondRoot: ' + secondRoot;
        }   

        document.getElementById('pr6answer').innerHTML = result;
        console.log('Problem 6: ' + result);

    } else {
        document.getElementById('pr6answer').innerHTML = 'Incorrect input. Enter three numbers (a != 0)';
    }

    //clear input
    document.getElementById('first-number6').value = '';
    document.getElementById('second-number6').value = '';
    document.getElementById('third-number6').value = '';
}

//Problem 7: 
function problem7() {
    var a = document.getElementById('first-number7').value,
        b = document.getElementById('second-number7').value,
        c = document.getElementById('third-number7').value,
        d = document.getElementById('fourth-number7').value,
        e = document.getElementById('fifth-number7').value,        
        result;
    document.getElementById("pr7answer").style.color = "#FF0000";

    if (!isNaN(a) && !isNaN(b) && !isNaN(c) && !isNaN(d) && !isNaN(e) && a !== '' && b !== '' && c !== '' && d !== '' && e !== '') {
        a *= 1;
        b *= 1;
        c *= 1;
        d *= 1;
        e *= 1;
        result = a;
            
        if (b > result) { result = b; }
        if (c > result) { result = c; }
        if (d > result) { result = d; }
        if (e > result) { result = e; }

        document.getElementById('pr7answer').innerHTML = 'The greatest number is: ' + result;
        console.log('Problem 7: The greatest number is ' + result);

    } else {
            document.getElementById('pr7answer').innerHTML = 'Incorrect input. Enter five numbers.';
    }

    //clear input
    document.getElementById('first-number7').value = '';
    document.getElementById('second-number7').value = '';
    document.getElementById('third-number7').value = '';    
    document.getElementById('fourth-number7').value = '';
    document.getElementById('fifth-number7').value = '';
}

//Problem 8: 
function problem8() {
    var number = document.getElementById('first-number8').value,
        hundred = Math.floor(number / 100),
        ten = (Math.floor(number / 10)) % 10,
        one = (number % 10);
        result = '';
    document.getElementById("pr8answer").style.color = "#FF0000";

    if (!isNaN(number) && number !== '' && number * 1 >= 0 && number * 1 <= 999 && ((number * 1) % 1 === 0)) {
        number *= 1;
        switch (hundred)
            {
                case 1: result += 'one hundred and '; break;
                case 2: result += 'two hundred and '; break;
                case 3: result += 'three hundred and '; break;
                case 4: result += 'four hundred and '; break;
                case 5: result += 'five hundred and '; break;
                case 6: result += 'six hundred and '; break;
                case 7: result += 'seven hundred and '; break;
                case 8: result += 'eight hundred and '; break;
                case 9: result += 'nine hundred and '; break;
            }
        if (ten === 1) {
            switch (one) {
                case 0: result += 'ten'; break;
                case 1: result += 'eleven'; break;
                case 2: result += 'twelve'; break;
                case 3: result += 'thirteen'; break;
                case 4: result += 'fourtheen'; break;
                case 5: result += 'fifteen'; break;
                case 6: result += 'sixteen'; break;
                case 7: result += 'seventeen'; break;
                case 8: result += 'eighteen'; break;
                case 9: result += 'nineteen'; break;
            }
        } else {
            switch (ten) {
                case 2: result += 'twenty '; break;
                case 3: result += 'thirty '; break;
                case 4: result += 'fourty '; break;
                case 5: result += 'fifty '; break;
                case 6: result += 'sixty '; break;
                case 7: result += 'seventy '; break;
                case 8: result += 'eighty '; break;
                case 9: result += 'ninety '; break;
            }
            switch (one) {
                case 1: result += 'one'; break;
                case 2: result += 'two'; break;
                case 3: result += 'three'; break;
                case 4: result += 'four'; break;
                case 5: result += 'five'; break;
                case 6: result += 'six'; break;
                case 7: result += 'seven'; break;
                case 8: result += 'eight'; break;
                case 9: result += 'nine'; break;
            }
        }
        if (number === 0) { 
            result = 'zero';
        } 
        result = result.charAt(0).toUpperCase() + result.substring(1);
        document.getElementById('pr8answer').innerHTML = result;
        console.log('Problem 8: ' + result);           
    } else {
        document.getElementById('pr8answer').innerHTML = 'Enter an integer in the interval [0, 999]';
    }

    //clear input
    document.getElementById('first-number8').value = ''
}