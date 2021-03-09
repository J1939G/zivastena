<?php 
function wpit_resources()
{
    wp_enqueue_style('style', get_stylesheet_uri());
}
add_action('wp_enqueue_scripts', 'wpit_resources');

add_theme_support( 'post-thumbnails' ); 
add_theme_support( 'html5', array( 'gallery', 'caption' ) );

register_nav_menus(array(
    'categories' => __( 'Categories Menu'),
    'pages'=> __('Information Menu'),
    'pages-home'=> __('Pages Menu')
));

// replace https://www.facebook.com/zivastena.eu @zivastena.eu
// replace https://www.instagram.com/ziva_stena/ ziva_stena
add_filter('the_content', function ($content) {
    $fb_link = 'https://www.facebook.com/zivastena.eu';
    $ig_link = 'https://www.instagram.com/ziva_stena/';
    $open = ' <a href="';
    $close = ' target="_blank">$1</a>';

    $fb_regex = '/ (fb|facebook(u|em))/i';
    $fb_replace = "$open$fb_link\" class=\"fb-link ext-link\"$close";

    $ig_regex = '/ (ig|instagram(u|em))/i';
    $ig_replace = "$open$ig_link\" class=\"ig-link ext-link\"$close";

    return preg_replace(
        [$fb_regex, $ig_regex], 
        [$fb_replace, $ig_replace], 
        $content);
});


add_action( 'wp_enqueue_scripts', 'styles' );
add_action( 'wp_enqueue_scripts', 'live_js');

function styles(){
    if ( is_front_page() || is_home()) {
        wp_enqueue_style( 'home', get_stylesheet_directory_uri() . '/assets/css/home.min.css' );
    }
    if ( is_page_template("category-challenge.php" )){
        wp_enqueue_style('challenge', get_stylesheet_directory_uri() . '/assets/css/challenge.min.css' ); 
    }

    if( is_404() ){
        wp_enqueue_style( '404', get_stylesheet_directory_uri() . '/assets/css/404.min.css');
    }

}

function live_js(){
    wp_enqueue_script( 'live', get_stylesheet_directory_uri() . '/assets/scripts/live.js' );
}

add_filter('show_admin_bar', '__return_false');
