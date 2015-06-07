// Problem 1
console.log('Problem 1:');
console.log('-------------------------------------------------------');

function Person(firstname, lastname, age, gender) {
    if (isNaN(age) || !isFinite(age)) {
        throw new Error('age must be a number');
    }

    if (!(this instanceof  Person)) {
        return new Person(firstname, lastname, age, gender);
    }

    this.firstname = firstname;
    this.lastname = lastname;
    this.age = age;
    this.gender = gender;
}

Person.prototype.toString = function(){    
    return 'first name: ' + this.firstname + ', last name: ' + this.lastname + ', age: ' + this.age + ', gender: ' + ((this.gender) ? "female" : "male");
};

function People() {
	var len = 10,
		arr = [],
		index;

	for(index = 0; index < len; index += 1){
		arr[index] = new Person(stringGen(),stringGen(),Math.floor(Math.random() * 70),(index % 2));
	}
	return arr;
}

function stringGen()
{
    var text = '',
    	len = 7;

    var charSmall = "abcdefghijklmnopqrstuvwxyz",
    	charCapitol = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    text += charCapitol.charAt(Math.floor(Math.random() * charCapitol.length));
    for( var i=1; i < len; i++ )
        text += charSmall.charAt(Math.floor(Math.random() * charSmall.length));

    return text;
}

var people = People();
people.forEach(function (person){ console.log(person.toString())});

console.log('-------------------------------------------------------');


// Problem 2
console.log('Problem 2:');
console.log('-------------------------------------------------------');

console.log('All people are 18 or more years old --> ' + people.every(function(person){return person.age >= 18;}));

console.log('-------------------------------------------------------');


// Problem 3
console.log('Problem 3:');
console.log('-------------------------------------------------------');

people.filter(function(person){return person.age < 18;}).forEach(function (person) {console.log(person.toString());});

console.log('-------------------------------------------------------');


// Problem 4
console.log('Problem 4:');
console.log('-------------------------------------------------------');


var females = people.filter(function(person) {return person.gender;}),
    sum = females.reduce(function (sum, person) {return sum + person.age;}, 0),
    avg = sum / females.length;

console.log('Females: ');
females.forEach(function (person) {console.log(person.toString());});
console.log('Average age --> ' + avg);

console.log('-------------------------------------------------------');


// Problem 5
console.log('Problem 5:');
console.log('-------------------------------------------------------');

// polyfill by MDN
if (!Array.prototype.find) {
    Array.prototype.find = function(predicate) {
        if (this == null) {
            throw new TypeError('Array.prototype.find called on null or undefined');
        }
        if (typeof predicate !== 'function') {
            throw new TypeError('predicate must be a function');
        }
        var list = Object(this);
        var length = list.length >>> 0;
        var thisArg = arguments[1];
        var value;

        for (var i = 0; i < length; i++) {
            value = list[i];
            if (predicate.call(thisArg, value, i, list)) {
                return value;
            }
        }
        return undefined;
    };
}

function getYoungestMale (people) {
    var youngestMale =  people.sort(function (a, b) {return a.age - b.age;})
        .find(function(person) {return !person.gender;});

    return youngestMale.toString();
}
console.log('Youngest male: ');
console.log(getYoungestMale (people));

console.log('-------------------------------------------------------');


// Problem 
console.log('Problem 6:');
console.log('-------------------------------------------------------');

var result = people.reduce(function(obj, item) {
    if (obj[item.firstname[0]]) {
        obj[item.firstname[0]].push(item);
    } else {
        obj[item.firstname[0]] = [item];
    }
    return obj;
}, {});

console.log(result);

console.log('-------------------------------------------------------');