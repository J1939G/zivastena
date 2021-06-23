<?php

the_post();
$assets = get_stylesheet_directory_uri();

?>
<!doctype html>
<html <?php language_attributes(); ?>>
<head>
	<meta charset="<?php bloginfo('charset'); ?>" />
	<meta name="viewport" content="width=device-width, initial-scale=1" />
    <title><?php the_title(); ?></title>
    <?php wp_head(); ?>
</head>
<body>
    <h1><?php the_title(); ?></h1>
    <div class="content">
        <?php
            the_content("", false);
            get_footer();
        ?>