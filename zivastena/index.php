<?php
/**
 * The main template file
 *
 * @package WordPress
 * @subpackage Zivastena
 */

$assets = get_stylesheet_directory_uri();
$lang = substr(get_locale(), 0, 2);
if( $lang == "cs" ){
    $challenge_url = "vyzva";
    $view_more = "Vidět víc";
} else if( $lang == "es"){
    $challenge_url = "reto";
    $view_more = "Ver mas";
} else {
    $challenge_url = "challenge";
    $view_more = "See more";
}

function get_pll_cat($id){ return get_category(pll_get_term($id)); }

function print_cat_by_id($id, $class){
    $category = get_pll_cat($id);
    printf( 
        '<div class="category $class"><a href="%1$s"><h2>%2$s</h2><p>%3$s</p><div class="img-container"><img src="%4$s" alt="%5$s"></div></a></div>',
        esc_url( get_site_url().'/'.$category->slug ),
        esc_html( $category->name ),
        esc_html( $category->description),
        esc_html( z_taxonomy_image_url($category->term_id)),
        esc_attr( sprintf( __( 'View all posts in %s', 'textdomain' ), $category->name ) ),
    );
}



?>
<!doctype html>
<html <?php language_attributes(); ?>>
<head>
	<meta charset="<?php bloginfo( 'charset' ); ?>" />
	<meta name="viewport" content="width=device-width, initial-scale=1" />
	<?php wp_head(); ?>
	<meta name="google-site-verification" content="O6L-vbgL6zpRpPI-rJ6PTvMxAJXfmRw9jtaBuk9DZRY" />
    <title><?php echo get_bloginfo('name') ?></title>
</head>
<body>
    <?php include 'header.php' ?>
    <div class="content">
        <p class="text">¿Si las paredes hablaran?</br>
            ¡LAS PAREDES HABLAN!</br>
            ¡LAS PAREDES VIVEN!</br>
            ¡VÍVELAS!</br>

            Las paredes han llevado una vida latente pintadas de blanco, de plano y parejo.</br>
            Se van haciendo frías y se convierten en los muros que nos encierran.</br>

            ¡DESPIÉRTALAS!</br>

            ¡HAZLAS PROYECTAR TODA LA VIDA!</br>

            Dales fuerza, dales calma, dales movimiento, dales mares, dales historias y cuentos, ventanas al cielo y al campo, pájaros volando...</br>
            Dales lo real o lo abstracto</br>

            No vivas encerrado entre paredes</br>
            Vive las paredes </br>

            Dales todo cuanto quieras en tu vida y</br>
            tenlo siempre presente,</br>
            ¡TU PARED VIVE!
        </p>
        <div class='category-container'>
            <?php foreach( get_categories(['hide_empty' => 0]) as $category ){ 
                $cat_link = get_site_url() . '/' . $category->slug;
                $img_link = z_taxonomy_image_url($category->term_id);
            ?>
            <a href="<?php echo $cat_link ?>"  class="category <?php echo $category->slug ?>">
                <h2><?php echo $category->name ?></h2>
                <div class="img-container" style="background-image:url('<?php echo $img_link ?>')"></div>
                <p><?php echo $category->description ?></p>
                <p class="see-more"><?php echo esc_html($view_more) ?></p>
            </a>
            <?php  } ?>
        </div>
    </div>
    <?php include 'footer.php' ?>
</body>
</html>