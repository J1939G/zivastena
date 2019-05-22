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
            '<div><a href="%1$s" alt="%2$s"><img href=/><p>%3$s</p></a></div>',
            esc_url( get_site_url().'/'.$category->slug ),
            esc_attr( sprintf( __( 'View all posts in %s', 'textdomain' ), $category->name ) ),
            esc_html( $category->name )
        );
        echo sprintf( esc_html__( '%s' ), $category_link );
    } 
    ?>
    <h2>nastěnné <br id="mobileBreak">malby</h2>
</div>
<?php wp_nav_menu(array('theme_location' => 'pages','container_id'=>'footer')); ?>
</body>
</html>