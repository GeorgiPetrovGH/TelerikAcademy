/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	
*/

function sum(arr) {	
		var result = 0,
			i,
			len;	

		if(!arr.length){
			return null;
		}	

		if(arr === undefined){
			throw new Error('The array is undefined')
		}

		for(i=0, len=arr.length; i<len; i+=1){		
			if(isNaN(arr[i]*1)){
				throw new Error('Array element is not a number');
			} 
			result+=arr[i]*1;		
		}
		return result;			
}

module.exports = sum;