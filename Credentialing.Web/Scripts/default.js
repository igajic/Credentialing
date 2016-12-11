$(function () {

	$('.menu-toggle').on('click', function() {
		if(!$(this).hasClass('opened')){
			$(this).addClass('opened');
			$('.header').find('.mobile-menu').addClass('opened');
		} else {
			$(this).removeClass('opened');
			$('.header').find('.mobile-menu').removeClass('opened');
		}
	});

	/* Documentation @ http://lcdsantos.github.io/jQuery-Selectric/ */
	if($('select').length){
		$('select').selectric({
			disableOnMobile: false,
			arrowButtonMarkup: '<span class="arrow"><img src="/img/svg/arrow-down-blue.svg" width="14" alt="" /></span>'
		});
	}

	$('.js-open-login').on('click', function (e) {
		$('.overlay').fadeIn(300);
		$('.login-popup').fadeIn(200).addClass('opened');
		e.preventDefault();
	});

	$('.js-open-register').on('click', function (e) {
		$('.login-popup').fadeOut(200);
		$('.overlay').fadeIn(300);
		$('.register-popup').fadeIn(200).addClass('opened');
		e.preventDefault();
	});

	$('.overlay').on('click', function () {
		$('.modal.opened').removeClass('opened').fadeOut(300, function () {
			$('.overlay').fadeOut(200);
		});
	});

	$(document).keyup(function (e) {
		if (e.keyCode == 27) {
			$('.modal.opened').removeClass('opened').fadeOut(300, function () {
				$('.overlay').fadeOut(200);
			});
		}
	});

	$('input[type="file"]').on('change', function () {
		var path = $(this).val();
		var fileName = path.replace(/^.*\\/, "");
		$(this).siblings('.temp-filename').text(fileName);
	});

	$('.js-toggle-steps').on('click', function () {
		$('.steps-progress').stop().slideToggle(400);
		$(this).toggleClass('opened');
	});

	if ($('.datepicker-default').length) {
	    $('.datepicker-default').each(function(idx, element) {
	        new Pikaday({
	            field: element,
	            format: moment().format('MM/DD/YYYY'),
	            firstDay: 1,
	            onSelect: function (date) {
	                this._o.field.value = moment(date).format('MM/DD/YYYY');
	            },
	            onOpen: function () {
	                if (parseInt(this.el.style.top, 10) < $(this.el).offset().top) {
	                    this.el.style.marginTop = '1px';
	                }
	            },
	            onClose: function () {
	                this.el.style.marginTop = '';
	            }
	        });
	    });
	}

	if ($('.datepicker-monthly').length) {
		$('.datepicker-monthly').each(function (idx, element) {
			new Pikaday({
				field: element,
				format: 'MM/YY',
				firstDay: 1,
				onOpen: function () {
					if (parseInt(this.el.style.top, 10) < $(this.el).offset().top) {
						this.el.style.marginTop = '1px';
					}
					this.el.className += " pika-monthly";
				},
				onDraw: function (e) {
					this.field.value = ('00' + (e.calendars[0].month + 1)).slice(-2) + '/' + ('' + e.calendars[0].year).slice(-2);
				},
				onClose: function () {
					this.el.style.marginTop = '';
					this.el.className = this.el.className.replace('pika-monthly', '');
				}
			});

		});
	}
});

$(window).on('load', function () {


});

$(window).resize(function () {


});