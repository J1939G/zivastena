<?php
/**
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
                    'category_name' => $cat_name,
                    'orderby' => 'date',
                    'numberposts' => 100,
                ));
                foreach ($randomPosts as $post) {
                    $tiempo = get_post_meta($post->ID, 'Tiempo', true); ?>
                    <div class="protection">
                        <a class="post" href="<?php the_permalink(); ?>">
                            <?php the_post_thumbnail('large'); ?>
                            <h3 class="title"><?php the_title(); ?></h3>
                            <p class="metadata time"><?php echo date_humanize($tiempo, get_bloginfo("language")); ?></p>
                        </a>
                    </div>
                <?php
                } ?>
        </div>
    <?php get_footer();?>