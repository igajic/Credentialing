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

	if($('.datepicker-default').length) {
		var field = $('.datepicker-default')[0];
		var picker = new Pikaday({
			field: field,
			format: moment().format('MM/DD/YYYY'),
			firstDay: 1,
			onSelect: function() {
				field.value = this.getMoment().format('MM/DD/YYYY');
			},
			onOpen: function() {
				if(parseInt(this.el.style.top, 10) < $(field).offset().top) {
					this.el.style.marginTop = '1px';
				}
			},
			onClose: function() {
				this.el.style.marginTop = '';
			}
		});
	}

	if($('.datepicker-monthly').length) {
		var fieldMon = $('.datepicker-monthly')[0];
		var pickerMon = new Pikaday({
			field: fieldMon,
			format: moment().format('MM/YY'),
			firstDay: 1,
			onOpen: function() {
				if(parseInt(this.el.style.top, 10) < $(fieldMon).offset().top) {
					this.el.style.marginTop = '1px';
				}
				this.el.className += " pika-monthly";
			},
			/*onDraw: function() {
				fieldMon.value = pickerMon.getMoment().format('MM/YY');
			},*/
			onClose: function() {
				fieldMon.value = this.getMoment().format('MM/YY');
				this.el.style.marginTop = '';
				this.el.className = this.el.className.replace('pika-monthly', '');
			}
		});
	}

});

$(window).on('load', function () {



});

$(window).resize(function () {



});