<?php
/**
 * The main template file
 *
 * @package WordPress
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
	<link rel="stylesheet" href="<?php echo $assets.'/assets/css/home' ?>.css">
	<?php wp_head(); ?>
</head>
<body>
<div id="header">
        <h1 id='title'><?php echo get_bloginfo('name') ?></h1>
</div>
<div id="categories">
    <?php
    $categories = get_categories();
    foreach( $categories as $category ) {
        $category_link = sprintf( 
            '<a href="%1$s" alt="%2$s">%3$s<img href=/></a>',
            esc_url( get_site_url().'/'.$category->slug ),
            esc_attr( sprintf( __( 'View all posts in %s', 'textdomain' ), $category->name ) ),
            esc_html( $category->name )
        );
        echo sprintf( esc_html__( '%s' ), $category_link );
    } 
    ?>
</div>
<div id="footer">
    <h2>nastenne malby</h2>
    <ul id="menuContainer">
        <li>blah blahh</li>
        <li>blah bla bl</li>
        <li>blah balh</li>
        <li>bjlakbab</li>
    </ul>
<?php
get_footer();
?>