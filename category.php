<?php
/**
 * @subpackage Zivastena
 */

    $assets = get_stylesheet_directory_uri();
    require 'modules.php';
    get_header(); 

    $category = get_category( get_query_var( 'cat' ) );
    $cat_name = $category->name;
?>
<!doctype html>
<html <?php language_attributes(); ?>>
<head>
	<meta charset="<?php bloginfo( 'charset' ); ?>" />
	<meta name="viewport" content="width=device-width, initial-scale=1" />
	<script src="<?php echo $assets.'/assets/scripts/live.js' ?>"></script>
	<link rel="stylesheet" href="<?php echo $assets.'/assets/css/category' ?>.css">
    <title><?php echo $cat_name ?></title>
</head>
<body>
    <h1 id="title"><?php echo $cat_name ?></h1>
    <div id="content" class="site-content">
    <?php
        $randomPosts = get_posts( array(
            'category_name' => get_the_category()[0]->name,
            'orderby' => 'rand',
            'numberposts' => 100,
        ));
        foreach($randomPosts as $post){
            $tiempo = get_post_meta($post->ID, 'Tiempo', true);?>
            <div class="protection">
                <figure class="post">
                        <a href="<?php the_permalink(); ?>">
                            <?php the_post_thumbnail('large'); ?>
                            <figcaption><?php the_title(); ?></figcaption>
                            <p><?php echo date_humanize( $tiempo, get_bloginfo("language") ); ?></p>
                        </a>
                </figure>
            </div>
    <?php
        }
        get_footer();
    ?>