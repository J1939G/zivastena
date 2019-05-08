<% Response.StatusCode = 404 %>
<!DOCTYPE html>

<html>
<head>
    <meta charset="utf-8" />
    <link rel="shortcut icon" href="/IMG/Start/Icons/abc.ico?" type="image/x-icon" />
    <title>: (</title>
    <style type="text/css">
        @font-face {
            font-family: "mfont";
            src: url(../Fonts/roboto.ttf);
        }

        body {
            font-family: "Segoe UI", mfont, sans-serif;
            margin: 0px;
            padding: 0px;
            border: none;
        }

        #bottom {
            display: block;
            width: 100%;
            position: relative;
            text-align: center;
            margin-left: auto;
            margin-right: auto;
        }

            #bottom a {
                text-decoration: none;
                display: inline-block;
                margin: 0;
                font-size: 1.8em;
                width: 22%;
                border: 0;
                padding: 0;
                color: rgba(92, 92, 92, 1);
            }

                #bottom a p {
                    padding: 0;
                    margin: 0.5em 0em;
                }

        .Item {
            height: auto;
            margin: 5em;
            vertical-align: middle;
            overflow: visible;
            margin-right: 3em;
        }

        .ImageLang {
            display: inline-block;
            height: auto;
            width: auto;
            vertical-align: top;
            margin-right: 2%;
        }

        .Text {
            display: inline-block;
            width: 100%;
            position: relative;
            text-align: center;
        }

        .Description {
            font-size: 2em;
            font-weight: 300;
            margin: 0px;
        }

        .coverUp {
            width: 88%;
            height: 0px;
            overflow: hidden;
            transition: 0.9s all;
            display: inline-block;
        }
    </style>
    <link type="text/css" rel="stylesheet" href="/Styles/ErrorSheet.css" />

    <script type="text/javascript">
        function Focus(Item) {
            var names = ["a", "b", "c"];
            var Dnames = ["aa", "bb", "cc"];
            var currentItem = Item;
            for (var detect = 0; detect < names.length; detect++) {
                if (names[detect] == Item) {
                    currentItem = detect;
                }
            }
            for (var elementName = 0; elementName < names.length; elementName++) {
                var element = document.getElementById(Dnames[elementName]);
                var textElement = document.getElementById(names[elementName]);
                if (elementName == currentItem) {
                    if (element.offsetHeight == 0) {
                        element.style.height = textElement.offsetHeight + "px";
                    }
                    else {
                        element.style.height = "0px";
                    }
                    continue;
                }
                else {
                    element.style.height = "0px"
                }
            }
        }
    </script>
</head>
<body onload='Focus("a")'>
    <div class="Item" onclick='Focus("a")'>
        <img class="ImageLang" src="/IMG/Start/Langs/CZ.png" />
        <div id="aa" class="coverUp">
            <div class="Text" id="a">
                <p class="Description">Omlouv&#225;me se. Str&#225;nku, kterou hled&#225;te, nelze naj&#237;t.</p>
                <div id="bottom">
                    <a class="link" href="/Doma/Doma"><p>Doma</p></a>
                    <a class="link" href="/Doma/Deti"><p>Děti</p></a>
                    <a class="link" href="/Doma/Interiery"><p>Interi&#233;ry</p></a>
                    <a class="link" href="/Doma/Obrazy"><p>Obrazy</p></a>
                    <a class="link" href="/Doma/Verejnost"><p>Veřejnost</p></a>
                    <a class="link" href="/Doma/Milost"><p>Milost</p></a>
                </div>
            </div>
        </div>
    </div>
    <div class="Item" onclick='Focus("b")'>
        <img class="ImageLang" src="/IMG/Start/Langs/EN.png" />
        <div id="bb" class="coverUp">
            <div class="Text" id="b">
                <p class="Description">We are sorry, but the page you requested cannot be found</p>
                <div id="bottom">
                    <a class="link" href="/Home/Home"><p>Home</p></a>
                    <a class="link" href="/Home/Children"><p>Children</p></a>
                    <a class="link" href="/Home/Interiors"><p>Interiors</p></a>
                    <a class="link" href="/Home/Paintings"><p>Paintings</p></a>
                    <a class="link" href="/Home/Public"><p>Public</p></a>
                    <a class="link" href="/Home/Grace"><p>Grace</p></a>
                </div>
            </div>
        </div>
    </div>
    <div class="Item" onclick='Focus("c")'>
        <img class="ImageLang" src="/IMG/Start/Langs/ES.png" />
        <div id="cc" class="coverUp">
            <div class="Text" id="c">
                <p class="Description">Lo sentimos, pero la p&#225;gina que buscas no fue encontrada</p>
                <div id="bottom">
                    <a class="link" href="/Inicio/Inicio"><p>Inicio</p></a>
                    <a class="link" href="/Inicio/Ninos"><p>Ni&#241;os</p></a>
                    <a class="link" href="/Inicio/Interiores"><p>Interiores</p></a>
                    <a class="link" href="/Inicio/Cuadros"><p>Cuadros</p></a>
                    <a class="link" href="/Inicio/Publico"><p>P&#250;blico</p></a>
                    <a class="link" href="/Inicio/Gracia"><p>Gracia</p></a>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
