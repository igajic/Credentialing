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

	$('input[type="file"]').on('change', function(){
		var path = $(this).val();
		var fileName = path.replace(/^.*\\/, "");
		$(this).siblings('.temp-filename').text(fileName);
	});

	$('.js-toggle-steps').on('click', function(){
		$('.steps-progress').stop().slideToggle(400);
		$(this).toggleClass('opened');
	});

});

$(window).on('load', function () {



});

$(window).resize(function () {



});