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
	<script src="<?php echo $assets.'/assets/scripts/live.js' ?>"></script>
	<link rel="stylesheet" href="<?php echo $assets.'/assets/css/category' ?>.css">
</head>
<body>
    <h1><?php the_title(); ?></h1>
    <div id="content" data-featherlight=".lbox">
        <?php 
            the_content("", FALSE);
            get_footer();
        ?>