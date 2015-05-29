//Task 1
var int = 17,
    float = 5.15,
    bool = true,
    string = 'Pesho',
    object = {
        name: 'Gosho',
        age: 25
    },
    array = [1, 2, 3],
    func = function(){
        alert('This is a function.');
    };

//Task 2
var quotedString = '"How you doin\'?", Joey said.',
    newDiv = document.createElement('div');

newDiv.innerHTML = quotedString;
document.getElementById('task2').appendChild(newDiv);
console.log('Task 2: \n');
console.log('Quoted string - ' + quotedString);

//Task 3
var array = [
    int,
    float,
    bool,
    string,
    object,
    array,
    func    
];

console.log('Task 3: \n');

for (var i = 0; i < array.length; i += 1) {
    getTypeOf(array[i], "task3");
    console.log('Type of ' + array[i] + ' is: ' + typeof(array[i]));
}

//Task 4
console.log('Task 4: \n');

var nullVar = null,
    undefinedVar; // undefined

console.log('Type of ' + nullVar + ' is: ' + typeof(nullVar));
console.log('Type of ' + undefinedVar + ' is: ' + typeof(undefinedVar));

getTypeOf(nullVar, "task4");
getTypeOf(undefinedVar, "task4");

//HTML
function getTypeOf(obj, taskNumberId) {
    var currDiv = document.createElement('div');
    var result = 'The type of ' + obj + ' is: ' + '<span style="color:blue">' + typeof(obj) + '</span>';
    currDiv.innerHTML = result + ' ';
    document.getElementById(taskNumberId).appendChild(currDiv);
}

//Styles
var divs = document.getElementsByTagName("div"),
    container = document.getElementById("container");

for (var i = 0; i < divs.length; i += 1) {    
    divs[i].style.padding = "4px";    
}

container.style.width = "500px";