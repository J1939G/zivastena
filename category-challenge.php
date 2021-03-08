<?php
/**
 * 
 * Template Name: Challenge
 * 
 * @subpackage Zivastena
 */

require 'modules.php';

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
        <p class="top-text"><?php global $post; echo get_post_meta($post->ID, 'top_text', true) ?></p>
    <header class="header">
        <h1>#zivachallenge</h1>
        <nav>
            <a href="/zivastena/">Home</a>
            <a href="#bases">Bases</a>
            <a href="#registration">Registro</a>
            <a href="#artists">Artists</a>
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