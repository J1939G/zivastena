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
	<?php wp_head(); ?>
	<meta name="google-site-verification" content="O6L-vbgL6zpRpPI-rJ6PTvMxAJXfmRw9jtaBuk9DZRY" />
    <title><?php echo get_bloginfo('name') ?></title>
</head>
<body onscroll="scroller()">
<div id="header">
        <h1 id='title'><?php echo get_bloginfo('name') ?></h1>
        <a class='challenge' href="zivachallenge">#zivachallenge</a>
</div>
<div id="categories">
    <?php
    $categories = get_categories( array('orderby' => 'description', 'order' => 'ASC'));
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
    <h2 id="subTitle"><?php echo get_bloginfo('description')?></h2>
</div>
<?php wp_nav_menu(array('theme_location' => 'pages','container_id'=>'footer')); ?>
</body>
</html>