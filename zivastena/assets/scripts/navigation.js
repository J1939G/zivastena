function toggle_menu(e) {
    jQuery('nav.main').toggleClass('full-height');
    jQuery('body').toggleClass('block-scroll');
    if (e)
        e.preventDefault();
}

jQuery(document).ready(function() {
    jQuery('.menu-toggle').click(function(e) {
        toggle_menu(e)
    });

    jQuery(document).keyup(function(e) {
        if (jQuery('nav.main').hasClass('full-height') && e.keyCode == 27) { // escape key
            toggle_menu();
        }
    });
});