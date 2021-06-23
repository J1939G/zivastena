<?php
/**
 *
 * Template Name: Obrazy
 *
 * @subpackage Zivastena
 */

$assets = get_stylesheet_directory_uri();
require 'modules.php';
$category = get_category(get_query_var('cat'));
$cat_name = $category->name;
?>
<!doctype html>
<html <?php language_attributes(); ?>>
<head>
    <?php wp_head() ?>
	<meta name="viewport" content="width=device-width, initial-scale=1" />
    <title><?php echo $cat_name ?></title>
</head>
<body>
    <?php get_header() ?>
    <div class="content" class="site-content">
        <h1 class="categroy-title"><?php echo $cat_name ?></h1>
        <div class="posts-container">
            <?php
                $randomPosts = get_posts(array(
                    'category_name' => get_the_category()[0]->name,
                    'orderby' => 'date',
                    'numberposts' => 100,
                ));
                foreach ($randomPosts as $post) {
                    $technique = get_post_meta($post->ID, 'Technique', true);
                    $price = get_post_meta($post->ID, 'Price', true);
                    $size = get_post_meta($post->ID, 'Size', true); ?>
                    <div class="protection">
                        <div class="post">
                            <?php the_post_thumbnail('large'); ?>
                            <h3 class="title"><?php the_title(); ?></h3>
                            <p><?php echo technique($technique, get_bloginfo("language")); ?><br>
                            <?php echo humanize_price($price, get_bloginfo("language")); ?>
                            <?php echo humanize_size($size); ?></p>
                        </div>
                    </div>
                <?php
                } ?>
        </div>
    <?php get_footer();?>