$(function () {

	$('.js-open-login').on('click', function(e){
		$('.overlay').fadeIn(300);
		$('.login-popup').fadeIn(200).addClass('opened');
		e.preventDefault();
	});

	$('.overlay').on('click', function(){
		$('.modal.opened').removeClass('opened').fadeOut(300, function(){
			$('.overlay').fadeOut(200);
		});
	});

	$(document).keyup(function(e) {
		if (e.keyCode == 27) {
			$('.modal.opened').removeClass('opened').fadeOut(300, function(){
				$('.overlay').fadeOut(200);
			});
		}
	});

});

$(window).on('load', function () {



});

$(window).resize(function () {



});