<?php 

$lang = substr(get_locale(), 0, 2);


if( $lang == "cs" ){
    $title = "Jejda";
    $content = "Zdá se, že tato stránka neexistuje.</p><p>Pokud by existovat měla, napiš prosím na <a href='mailto:admin@zivastena.eu'>admin@zivastena.eu</a></p><p>V každem případě by tyto odkazy už měli fungovat v pořádku:";
} 
else if( $lang == "es"){
    $title = "404? En serio?";
    $content = "Parece que esta página no existe.</p><p>Si crees que no debería ser así,contáctanos en <a href='mailto:admin@zivastena.eu'>admin@zivastena.eu</a></p><p>De cualquier manera, aquí hay un par de links que deberían funcionar:";
} 
else {
    $title = "Whoopsie daisy!";
    $content = "It seems that the page you're looking for isn't here.</p><p>If you think it should, please drop a message to <a href='mailto:admin@zivastena.eu'>admin@zivastena.eu</a></p><p>In any case, these links should work OK:";
}


?>


<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <?php wp_head(); ?>
    <title><?php echo $title; ?></title>
</head>
<body>
    <h1><?php echo $title; ?></h1>
    <p class="content"><?php echo $content ?></p>
    <?php wp_nav_menu(array('theme_location' => 'pages-home','container_id'=>'footer')); ?>
</body>
</html>