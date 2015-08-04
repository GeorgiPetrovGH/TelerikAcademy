/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  

*/

function solve(){
  return function (selector) {  	
  	if(typeof selector !== 'string' &&
  		!(selector instanceof HTMLElement)){
  		throw new Error('Invalid selector type');
  	}

  	if(document.getElementById(selector) === null) {
  		throw new Error('Not found such element');
  	}

  	var buttons = document.getElementsByClassName('button'),
  		content = document.getElementsByClassName('content'),
  		i, len;

  	for(i = 0, len = buttons.length; i < len; i +=1) {
  		buttons[i].innerHTML = 'hide';
  		buttons[i].addEventListener('click', clickButton);
  	}

  	function clickButton(ev){
  		var clickedButton = ev.target;
  		var nextSibling = clickedButton.nextElementSibling;
  		var contentElement;
  		var changeVisibility;

  		while(nextSibling) {
  			if(nextSibling.className === 'content') {
  				contentElement = nextSibling;
  				nextSibling = nextSibling.nextElementSibling;

  				while(nextSibling) {
  					if(nextSibling.className == 'button') {
  						changeVisibility = true;
  						break;
  					}

  					nextSibling = nextSibling.nextElementSibling;
  				}
  				break;
  			} else {
  				nextSibling = nextSibling.nextElementSibling;
  			}
  		}

  		if(changeVisibility) {
  			if(contentElement.style.display === 'none') {
  				contentElement.style.display = '';
  				clickedButton.innerHTML = 'hide';
  			} else {
  				contentElement.style.display = 'none';
  				clickedButton.innerHTML = 'show';
  			}
  		}
  	}
  	
  };
};

module.exports = solve;