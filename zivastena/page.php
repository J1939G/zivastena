<?php the_post() ?>
<!doctype html>
<html <?php language_attributes(); ?>>
<head>
    <title><?php the_title(); ?></title>
    <?php wp_head() ?>
</head>
<body>
    <?php get_header() ?>
    <div class="content">
        <h1><?php the_title(); ?></h1>
        <?php the_content("", false) ?>
    </div>
    <?php get_footer() ?>
</body>
</html>
