<?php

$lang = substr(get_locale(), 0, 2);
if ($lang == "cs") {
    $title = "vyzva";
} elseif ($lang == "es") {
    $title = "vyzva";
} else {
    $challenge_url = "challenge";
}

?>

<div class="contact-form">
    <?php echo do_shortcode('[contact-form-7 id="1736" title="Contact_en"]'); ?>
</div>