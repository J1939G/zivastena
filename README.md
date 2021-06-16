# Wordpress art portfolio theme

Custom theme containing multiple art categories and additional pages. 

## Installation and development

The `zivastena` folder can be copied to any WP installation under `wp-content/themes/`, and the theme selected from `/wp-admin`.

For ease of development, install docker, docker-compose and run:

1. `git clone` this repo 
2. `cd zivastena`
3. `docker-compose up -d` 
4. Access site on `localhost:9000`

Additionally, `adminer` is available on `localhost:9090` (user, password and database: `wordpress`).

`uploads.ini` contains limits for file uploads.

After installing Wordpress, follow this steps:
- Install required plugins:
  - Polylang (with czech, spanish and english)
  - Category images (by Muhammad El Zahlan)
  - Category Order and Taxonomy Terms Order (by Nsp-Code)
- Download test database and import everything
- Select pages for menus (for each language)

## To do:
- [ ] finish initial version
- [ ] add testing database