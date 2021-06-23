<?php
function wpit_resources()
{
    wp_enqueue_style('style', get_stylesheet_uri());
}
add_action('wp_enqueue_scripts', 'wpit_resources');

add_theme_support('post-thumbnails');
add_theme_support('html5', array( 'gallery', 'caption' ));

register_nav_menus(array(
    'main' => __('Main navigation')
));


function enqueue_style($filename)
{
    wp_enqueue_style($filename, get_stylesheet_directory_uri() . '/assets/css/' . $filename . '.min.css');
}

function styles()
{
    if (is_front_page() || is_home()) {
        enqueue_style('home');
    }
    if (is_404()) {
        enqueue_style('404');
    }
    if (is_category()) {
        enqueue_style('category');
    }
    if (isChild()) {
        enqueue_style('category-paintings');
    }
    if (is_single()) {
        enqueue_style('single');
    }
    if (is_page()) {
        enqueue_style('page');
    }
}

add_action('wp_enqueue_scripts', 'styles');
add_action('wp_enqueue_scripts', 'scripts');
//add_action('wp_enqueue_scripts', 'live_js');


function mobile_theme_color()
{
    echo '<meta name="theme-color" content="#404040" />';
    echo '<meta charset="<?php bloginfo( \'charset\' ); ?>" />';
    echo '<meta name="viewport" content="width=device-width, initial-scale=1" />';
}

add_action('wp_head', 'mobile_theme_color');


function scripts()
{
    wp_enqueue_script('navigation', get_stylesheet_directory_uri(). '/assets/scripts/navigation.js', array('jquery'));

    if (is_single() || isChild()) {
        wp_enqueue_script('zoom', get_stylesheet_directory_uri().'/assets/scripts/zoom.js', array('jquery'));
    }
}

function live_js()
{
    wp_enqueue_script('live', get_stylesheet_directory_uri() . '/assets/scripts/live.js', null, true);
}

add_filter('show_admin_bar', '__return_false');

// template selection for categories

function isChild()
{
    return cat_is_ancestor_of(get_cat_id('paintings'), get_query_var('cat')) ||
    cat_is_ancestor_of(get_cat_id('obrazy'), get_query_var('cat')) ||
    cat_is_ancestor_of(get_cat_id('cuadros'), get_query_var('cat'));
}

function myTemplateSelect()
{
    if (is_category() && !is_feed()) {
        if (isChild()) {
            load_template(TEMPLATEPATH . '/category-paintings.php');
            exit;
        }
    }
}

add_action('template_redirect', 'myTemplateSelect');

// clean wp_head ------------------------------------------------------------

// Removes the wlwmanifest link
remove_action('wp_head', 'wlwmanifest_link');
// Removes the RSD link
remove_action('wp_head', 'rsd_link');
// Removes the WP shortlink
remove_action('wp_head', 'wp_shortlink_wp_head', 10, 0);
// Removes the canonical links
remove_action('wp_head', 'rel_canonical');
// Removes the links to the extra feeds such as category feeds
remove_action('wp_head', 'feed_links_extra', 3);
// Removes links to the general feeds: Post and Comment Feed
remove_action('wp_head', 'feed_links', 2);
// Removes the index link
remove_action('wp_head', 'index_rel_link');
// Removes the prev link
remove_action('wp_head', 'parent_post_rel_link');
// Removes the start link
remove_action('wp_head', 'start_post_rel_link');
// Removes the relational links for the posts adjacent to the current post
//remove_action( 'wp_head', 'adjacent_posts_rel_link' );
//remove_action( 'wp_head', 'adjacent_posts_rel_link_wp_head' );

// Removes the WordPress version i.e. -
remove_action('wp_head', 'wp_generator');

// remove emojis
remove_action('wp_head', 'print_emoji_detection_script', 7);
remove_action('admin_print_scripts', 'print_emoji_detection_script');
remove_action('wp_print_styles', 'print_emoji_styles');
remove_action('admin_print_styles', 'print_emoji_styles');
