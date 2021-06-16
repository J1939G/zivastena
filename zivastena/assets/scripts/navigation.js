jQuery(document).ready(function() {
    jQuery('.menu-toggle').click(function(e) {
        jQuery('nav.main').toggleClass('full-height');
        jQuery('body').toggleClass('block-scroll');
        e.preventDefault();
    });
});