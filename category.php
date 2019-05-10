<?php
/**
 * @subpackage Zivastena
 */

$assets = get_stylesheet_directory_uri();

?>
<!doctype html>
<html <?php language_attributes(); ?>>
<head>
	<meta charset="<?php bloginfo( 'charset' ); ?>" />
	<meta name="viewport" content="width=device-width, initial-scale=1" />
	<script src="<?php echo $assets.'/assets/scripts/live.js' ?>"></script>
	<link rel="stylesheet" href="<?php echo $assets.'/assets/css/category' ?>.css">
</head>
<body>

<?php
    require 'modules.php';
    get_header(); 

    $category = get_category( get_query_var( 'cat' ) );
    $cat_name = $category->name;
?>

<h1 id="title"><?php echo $cat_name ?></h1>
<div id="content" class="site-content">

<?php
    $query = new WP_Query( array( 'category_name' => get_the_category()[0]->name ) );
    if( $query->have_posts() ):
        while (have_posts()): the_post();
            $tiempo = get_post_meta($post->ID, 'Tiempo', true);
?>
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
        endwhile;
    endif;

    
?>