<?php the_post() ?>
<!doctype html>
<html <?php language_attributes(); ?>>
<head>
	<meta name="viewport" content="width=device-width, initial-scale=1" />
    <title><?php the_title(); ?></title>
    <?php wp_head() ?>
</head>
<body>
    <?php get_header() ?>
    <div class="content">
        <h1><?php the_title(); ?></h1>
        <?php the_content("", FALSE) ?>
    </div>
    <?php get_footer() ?>
</body>
</html>
