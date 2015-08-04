function solve(){
  return function(selector){
    var container = $('<div />').addClass('dropdown-list'),
    optionsContainer = $('<div class="options-container" style="position: absolute; display: none;"></div>'),
    len = $(selector).find('option').length,
    options = $(selector).find('option');

	$(selector).css('display', 'none').appendTo(container);
	$('<div class="current" data-value="">Option 1</div>').appendTo(container);
	
	for(var i = 0; i < len; i += 1){
		var item = $('<div/>').html('Option ' + (i+1))
                    	.addClass('dropdown-item')
                    	.attr('data-value', $(options[i]).val())
                    	.attr('data-index', i);  

        optionsContainer.append(item);
	}
	
	optionsContainer.appendTo(container);

	$(document.body).append(container);

	$('.current').on('click', function(){
		optionsContainer.css('display', 'block');
		$(this).html('Select a value');
	});

	optionsContainer.on('click', '.dropdown-item', function(){
		optionsContainer.css('display', 'none');
		$(selector).val($(this).attr('data-value'));
		$('.current').html($(this).html());
	});

	return this;
  };
}

module.exports = solve;