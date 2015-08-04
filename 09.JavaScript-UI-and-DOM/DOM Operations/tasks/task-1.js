/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

  return function (element, contents) {
  	if(element === undefined || element === null) {
  		throw new Error('Element is undefined or null');
  	}

  	if(typeof element !== 'string' && !(element instanceof HTMLElement)){
  		throw new Error('Element is not valid input');
  	}

  	if(!Array.isArray(contents)){
  		throw new Error('Content is not an array');
  	}

  	for(var i = 0, len = contents.length; i<len; i+=1){
      var currentElement = contents[i];
      
      if(typeof currentElement !== 'string' && typeof currentElement !== 'number') {
        throw new Error("Invalid contents input");
      }
    }

    if(typeof element === 'string'){
      element = document.getElementById(element);
    }
    
    addDivsToElement(element, contents);

    function addDivsToElement(element, contents) {
      element.innerHTML = '';

      var div = document.createElement('div'),
          frag = document.createDocumentFragment();

      for(var i = 0, len = contents.length; i<len; i+=1) {
        var divToAdd = div.cloneNode(true);
        
        divToAdd.innerHTML = contents[i];
        frag.appendChild(divToAdd);
      }

      element.appendChild(frag);
    }

  };
};