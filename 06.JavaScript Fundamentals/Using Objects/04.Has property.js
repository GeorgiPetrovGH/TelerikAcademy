function hasProperty(obj, prop){
    return obj.hasOwnProperty(prop);
}

var ninja = {
    name: 'Ninja',
    age: Infinity,
    occupation: 'Ninja stuff'
};

console.log(ninja);
console.log('has occupation: ' + hasProperty(ninja, 'occupation'));
console.log('has gender: ' + hasProperty(ninja, 'gender'));
ninja.gender = 'unknown';
console.log(ninja);
console.log('has gender: ' + hasProperty(ninja, 'gender'));