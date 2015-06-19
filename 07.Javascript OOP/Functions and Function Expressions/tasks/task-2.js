/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(from, to) {
	
	if(arguments.lenght <= 1){
		throw new Error('Missing arguments');
	}

	if(isNaN(from) || isNaN(to)){
		throw new Error('Invalid arguments');
	}

	function isPrime(x){
    	var i,
    		maxDivisor = Math.sqrt(x);
    	
    	if(x===0 || x===1){
    		return false;
    	}

    	for(i=2; i <= maxDivisor; i+=1){
    		if(!(x%i)){
    			return false;
    		}
    	}
    	return true;
    }

	var result = [],
        i;

    from = from*1;
    to = to*1;
    
    for(i=from; i<=to; i+=1){
    	if(i===1){
    		continue;
    	}
    	if(isPrime(i)){
    		result.push(i);
    	}
    }

    return result;
}

module.exports = findPrimes;
