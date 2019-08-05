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
	<?php wp_head(); ?>
</head>
<body>