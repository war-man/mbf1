																					$(window).ready(function () {
																					    $('.navigation_mobile_1 .arrow_1').click(function () {
																					        if ($(this).attr('class') == 'arrow_1 class_test') {
																					            $('.navigation_mobile_1 .arrow_1').removeClass('class_test');
																					            $('.navigation_mobile_1').removeClass('active');
																					            $('.navigation_mobile_1').find('.menu-mobile-container_1').hide("slow");
																					        } else {
																					            $('.navigation_mobile_1 .arrow_1').addClass('class_test');
																					            $('.navigation_mobile_1').addClass('active');
																					            $('.navigation_mobile_1').find('.menu-mobile-container_1').show("slow");
																					        }
																					    });
																					});