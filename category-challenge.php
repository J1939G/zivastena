<?php
/**
 * 
 * Template Name: Challenge
 * 
 * @subpackage Zivastena
 */

require 'modules.php';

if( $lang == "cs" ){
    $home_url = "/";
} else if( $lang == "es"){
    $home_url = "/es/";
} else {
    $home_url = "/en/";
}

global $post;
$home = get_post_meta( $post->ID, 'home', true);
$bases = get_post_meta( $post->ID, 'bases', true);
$registrate = get_post_meta( $post->ID, 'registrate', true);
$artists = get_post_meta( $post->ID, 'artist', true);
$top_text = get_post_meta( $post->ID, 'top_text', true);

?>
<!doctype html>
<html <?php language_attributes(); ?>>
<head>
    <?php wp_head(); ?>
    <meta charset="<?php bloginfo('charset'); ?>" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title><?php the_title(); ?></title>
</head>
<body onload="Listen()">
        <p class="top-text"><?php  echo get_post_meta($post->ID, 'top_text', true) ?></p>
    <header class="header">
        <h1>#zivachallenge</h1>
        <nav>
            <a href="<?php echo $home_url ?>"><?php echo $home ?></a>
            <a href="#bases"><?php echo $bases ?></a>
            <a href="#registration"><?php echo $registrate ?></a>
            <a href="#artists"><?php echo $artists ?></a>
        </nav>
    </header>
    <div class="content">
        <div class="images">
            <div></div>
            <div></div>
        </div>
    <?php the_content() ?>
    </div>
    <?php wp_nav_menu(array('theme_location' => 'pages-home','container_class'=>'footer')); ?>
</body>
</html>