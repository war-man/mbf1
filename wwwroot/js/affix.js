				function addaffix(scr) {
				    if ($(window).innerWidth() >= 992) {
				        if (scr > 170) {
				            if (!$('#top').hasClass('affix')) {
				                $('#top').addClass('affix').addClass('fadeInDown animated');
				            }
				        } else {
				            if ($('#top').hasClass('affix')) {
				                $('#top').prev().remove();
				                $('#top').removeClass('affix').removeClass('fadeInDown animated');
				            }
				        }
				    } else $('#top').removeClass('affix');
				}
				$(window).scroll(function () {
				    var scrollTop = $(this).scrollTop();
				    addaffix(scrollTop);
				});
				$(window).resize(function () {
				    var scrollTop = $(this).scrollTop();
				    addaffix(scrollTop);
				});