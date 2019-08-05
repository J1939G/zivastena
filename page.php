<?php 

the_post();
$assets = get_stylesheet_directory_uri();

?>
<!doctype html>
<html <?php language_attributes(); ?>>
<head>
	<meta charset="<?php bloginfo( 'charset' ); ?>" />
	<meta name="viewport" content="width=device-width, initial-scale=1" />
    <title><?php the_title(); ?></title>
    <link rel="stylesheet" href="<?php echo $assets.'/assets/css/page' ?>.css">
</head>
<body>
    <h1><?php the_title(); ?></h1>
    <div id="content">
        <?php 
            the_content("", FALSE);
        ?>
    </div>
    <?php wp_nav_menu(array('theme_location' => 'pages-home','container_id'=>'footer')); ?>
</body>
</html>
