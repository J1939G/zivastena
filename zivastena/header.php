<nav class='main'>
	<button class='menu-toggle'>
		<span class="top"></span>
		<span class="bottom"></span>
	</button>
	<h1 class="title-wrapper"><a href='/' class='title'><?php echo get_bloginfo('name') ?></a></h1>
	<?php wp_nav_menu(array('theme_location' => 'main','container_class'=>'links')); ?>
</nav>
