function clone(obj){
    if (typeof obj !== 'object') {
        return obj;
    }

    var cloned = {};
    for (var prop in obj) {
        cloned[prop] = clone(obj[prop]);
    }

    return cloned;
}

console.log(clone(5));
console.log(clone({name: 'Ninja', color: 'Black'}));
