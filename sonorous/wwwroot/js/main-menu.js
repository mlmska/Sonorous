$('#menu .nav > li > .dropdown-menu').each(function() {
    var menu = $('#menu').offset();
    var dropdown = $(this).parent().offset();

    var i = (dropdown.left + $(this).outerWidth()) - (menu.left + $('#menu').outerWidth());

    if (i > 0) {
        $(this).css('margin-left', '-' + (i + 5) + 'px');
    }
});

var $screensize = $(window).width();
$('#menu .nav > li, #header .links > ul > li').on("mouseover", function() {

    if ($screensize > 991) {
        $(this).find('> .dropdown-menu').stop(true, true).slideDown('fast');
    }
    $(this).bind('mouseleave', function() {

        if ($screensize > 991) {
            $(this).find('> .dropdown-menu').stop(true, true).css('display', 'none');
        }
    });
});
$('#menu .nav > li div > ul > li').on("mouseover", function() {
    if ($screensize > 991) {
        $(this).find('> div').css('display', 'block');
    }
    $(this).bind('mouseleave', function() {
        if ($screensize > 991) {
            $(this).find('> div').css('display', 'none');
        }
    });
});
$('#menu .nav > li > .dropdown-menu').closest("li").addClass('sub');

// Clearfix for sub Menu column
$(document).ready(function() {
    $screensize = $(window).width();
    if ($screensize > 1199) {
        $('#menu .nav > li.mega-menu > div > .column:nth-child(6n)').after('<div class="clearfix visible-lg-block"></div>');
    }
    if ($screensize < 1199) {
        $('#menu .nav > li.mega-menu > div > .column:nth-child(4n)').after('<div class="clearfix visible-lg-block visible-md-block"></div>');
    }
});
$(window).resize(function() {
    $screensize = $(window).width();
    if ($screensize > 1199) {
        $("#menu .nav > li.mega-menu > div .clearfix.visible-lg-block").remove();
        $('#menu .nav > li.mega-menu > div > .column:nth-child(6n)').after('<div class="clearfix visible-lg-block"></div>');
    }
    if ($screensize < 1199) {
        $("#menu .nav > li.mega-menu > div .clearfix.visible-lg-block").remove();
        $('#menu .nav > li.mega-menu > div > .column:nth-child(4n)').after('<div class="clearfix visible-lg-block visible-md-block"></div>');
    }
});