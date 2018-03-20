$(function() {
	// Product View image click
	

	// Add new Product
	$('.add-new-product').click(function() {
		// Get root template template
		var $template = $('.root-template').html();
		var $element = '<div>' + $template + '</div>';
		$('.additional').append($element);
	});


});