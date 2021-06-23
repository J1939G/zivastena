let img = null
let img_width = 0;
let img_height = 0;
let img_pos = 0;
let img_src = 0;

jQuery(document).ready(function() {
    jQuery('body').append('<div class="zoombox fxbox"><div>');
    jQuery('body').append('<div class="blurbox fxbox"><div>');

    jQuery('div.fxbox').click(function() {
        if (jQuery('.zoombox').hasClass('zoomed')) {
            jQuery('.zoombox').css({
                top: img.offset().top - jQuery(window).scrollTop(),
                left: img.offset().left,
                width: img.width(),
                height: img.height()
            });

            jQuery('.blurbox').css({ backdropFilter: 'blur(0)', backgroundColor: 'transparent' });


            setTimeout(function() {
                //jQuery('body').toggleClass('noscroll');
                img.removeClass('zoomed');
                setTimeout(function() {
                    jQuery('.zoombox').removeClass('zoomed');
                    jQuery('.blurbox').removeClass('zoomed');
                }, 1);
            }, 750);

        }
    })

    jQuery('img').click(function() {

        //jQuery('body').toggleClass('noscroll');
        img = jQuery(this)

        img_width = jQuery(this).width();
        img_height = jQuery(this).height();
        img_pos = jQuery(this).offset();
        img_src = jQuery(this).attr('src');

        let w_height = jQuery(window).height();
        let w_width = jQuery(window).width();
        let vp_ratio = w_width / w_height;
        let img_ratio = img.width() / img.height();
        let is_wide = vp_ratio < img_ratio; // true if the images width extended makes whole image visible, false otherwhise

        jQuery('.zoombox').css({
            backgroundImage: 'url(' + img.attr('src') + ')',
            top: img_pos.top - jQuery(window).scrollTop(),
            left: img_pos.left,
            width: img.width(),
            height: img.height()
        });

        jQuery('.blurbox').toggleClass('zoomed').css({ backdropFilter: 'blur(0.5em)', backgroundColor: 'rgba(0, 0, 0, 0.2)' });

        let new_width = 0;
        let new_height = 0;
        let new_top = 0;
        let new_left = 0;

        if (is_wide) {
            new_width = 'calc(' + w_width + 'px - 5vw)';
            new_height = 'calc(' + (w_width / img_ratio) + 'px)';
            new_top = 'calc((' + w_height + 'px - (' + (w_width / img_ratio) + 'px)) / 2)';
            new_left = '2.5vw';
        } else {
            new_height = 'calc(' + w_height + 'px - 5vw)';
            new_width = 'calc( (' + w_height + 'px - 5vw) * ' + img_ratio + ')';
            new_top = '2.5vw';
            new_left = 'calc((' + w_width + 'px - ((' + w_height + 'px - 5vw) *' + img_ratio + ')) / 2)';
        }


        setTimeout(
            function() {
                jQuery('.zoombox').toggleClass('zoomed')
                img.toggleClass('zoomed');
                jQuery('.zoombox').css({
                    top: new_top,
                    left: new_left,
                    width: new_width,
                    height: new_height
                });
            }, 0);
    });
});