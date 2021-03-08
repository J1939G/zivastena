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


add_action( 'wp_enqueue_scripts', 'front_page_style' );
add_action( 'wp_enqueue_scripts', 'live_js');

function front_page_style(){
    if ( is_front_page() || is_home()) {
        wp_enqueue_style( 'home', get_stylesheet_directory_uri() . '/assets/css/home.min.css' );
    }
    if ( is_page_template("category-challenge.php" )){
        wp_enqueue_style('challenge', get_stylesheet_directory_uri() . '/assets/css/challenge.min.css' ); 
    }
}

function live_js(){
    wp_enqueue_script( 'live', get_stylesheet_directory_uri() . '/assets/scripts/live.js' );
}

add_filter('show_admin_bar', '__return_false');
