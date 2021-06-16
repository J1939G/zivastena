<nav class='footer'>
    <?php wp_nav_menu(array('theme_location' => 'footer','container_class'=>'links')); ?>
    <div class="bottom-links">
        <div class='languages'>Language: <?php pll_the_languages( array( 'dropdown' => 1, 'hide-current' => 1 ) ); ?></div>
        <div class='copyright'>&copy; <?php echo date('Y'); ?> Libuska Smutna</div>
    </div>
</nav>