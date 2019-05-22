<?php 
function wpit_resources() {
    wp_enqueue_style('style', get_stylesheet_uri());
}
add_action('wp_enqueue_scripts', 'wpit_resources');

add_theme_support( 'post-thumbnails' ); 
add_theme_support( 'html5', array( 'gallery', 'caption' ) );

register_nav_menus(array(
    'general' => __( 'General Menu'),
    'pages'=> __('Information Menu')
));

add_filter('show_admin_bar', '__return_false');
?>
