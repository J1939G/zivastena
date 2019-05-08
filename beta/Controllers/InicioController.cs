using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using beta.Models;
using System.Web.Mvc;

namespace beta.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        public ActionResult Inicio()
        {
            Start Info = new Start() { Lang = 2 };
            return View( "_Start" , Info);
        }
        // GET: Niños
        public ActionResult Ninos()
        {
            ViewBag.Title = "Ninos";
            List<Image> images = new List<Image>() {
                new Image() { Title = "Aviones",                Abrev = "a",   Length = "1 día" },
                new Image() { Title = "Bajo el Mar",            Abrev = "bm",  Length = "3 días" },
                new Image() { Title = "Changos",                Abrev = "ch",  Length = "2 días" },
                new Image() { Title = "Conejos",                Abrev = "cj",  Length = "2 días" },
                new Image() { Title = "Cuarto de Hadas",        Abrev = "dm",  Length = "2 días" },
                new Image() { Title = "Dinosaurios I",          Abrev = "dsf", Length = "2½ días" },
                new Image() { Title = "Reinado Lejano",         Abrev = "euv", Length = "2 días" },
                new Image() { Title = "Velocidad Extrema",      Abrev = "fu",  Length = "1 día" },
                new Image() { Title = "Gallinas",               Abrev = "g",   Length = "1½ día" },
                new Image() { Title = "Hadas, Estrellas y Flores",Abrev = "hr",Length = "1 día" },
                new Image() { Title = "Trysky",                 Abrev = "j",   Length = "4 días" },
                new Image() { Title = "Jardin Japones",         Abrev = "k",   Length = "1½ día" },
                new Image() { Title = "Medios de transporte",   Abrev = "mdt", Length = "2 días" },
                new Image() { Title = "Arbol y Cancion",        Abrev = "nd",  Length = "2 días" },
                new Image() { Title = "Gorila",                 Abrev = "ga",  Length = "2 días" },
                new Image() { Title = "Safari",                 Abrev = "sf",  Length = "2 días" },
                new Image() { Title = "Guerra de las Galaxias", Abrev = "sw",  Length = "3½ días" },
                new Image() { Title = "Rapunzel",               Abrev = "rz",  Length = "1½ día" },
                new Image() { Title = "Delfines",               Abrev = "pd",  Length = "1½ día" },
                new Image() { Title = "Sistema Solar",          Abrev = "ss",  Length = "2½ días" },
                new Image() { Title = "El Principito",          Abrev = "p",   Length = "1 día" },
                new Image() { Title = "Cochecitos",             Abrev = "tra", Length = "1½ día" },
                new Image() { Title = "Whinnie the Pooh",       Abrev = "wp",  Length = "2½ días" },
                new Image() { Title = "Velero",                 Abrev = "vel", Length = "2 días" },
                new Image() { Title = "Arca de Noe",            Abrev = "an",  Length = "3½ días" },
                new Image() { Title = "Volando en las nubes",   Abrev = "as",  Length = "2 días" },
                new Image() { Title = "Niñas tiernas",          Abrev = "chm", Length = "3 días" },
                new Image() { Title = "Faro",                   Abrev = "chp", Length = "3 días" },
                new Image() { Title = "Footballfever",          Abrev = "soc", Length = "2 días" },
                new Image() { Title = "Dinosaurios",            Abrev = "di",  Length = "2 días" },
                new Image() { Title = "Castillos",              Abrev = "d",   Length = "2 días" },
                new Image() { Title = "Pequeños aventureros",   Abrev = "ds",  Length = "3½ días" },
                new Image() { Title = "Flores",                 Abrev = "fr",  Length = "1 día" },
                new Image() { Title = "Autos",                  Abrev = "c",   Length = "2 días" },
                new Image() { Title = "Hadas",                  Abrev = "h",   Length = "1 día" },
                new Image() { Title = "Hadas Rosas",            Abrev = "hv",  Length = "1½ día" },
                new Image() { Title = "Jarin Surrealista",      Abrev = "js",  Length = "1 día" },
                new Image() { Title = "Safari de Niños",        Abrev = "ly",  Length = "2 días" },
                new Image() { Title = "Piratas",                Abrev = "ps",  Length = "2½ días" },
                new Image() { Title = "Osito",                  Abrev = "ot",  Length = "1 días" },
                new Image() { Title = "Le petit prince",        Abrev = "pf",  Length = "1½ día" },
                new Image() { Title = "El Principito",          Abrev = "psf", Length = "1½ día" },
                new Image() { Title = "Pegasos y Unicornios",   Abrev = "pu",  Length = "2½ días" },
                new Image() { Title = "Marvel",                 Abrev = "mv",  Length = "3 días" },
                new Image() { Title = "En la Jungla",           Abrev = "s",   Length = "4 días" },
                new Image() { Title = "Savana",                 Abrev = "sv",  Length = "2½ días" },
                new Image() { Title = "Tren de Animales",       Abrev = "tda", Length = "3 días" }
            };
            return View("_Class", images);
        }
        // GET: Cuadros
        public ActionResult Cuadros()
        {
            string op = "Óleo sobre tela";
            string od = "Óleo sobre madera";
            string u = "undefined";
            int s = 171717;
            List<Painting> Obrazky = new List<Painting>()
            {
                new Painting() { Title = "Bamboo", Technique = op, Availability = s, Abrev = "aa", Size = "150x150"},
                new Painting() { Title = "Bicicleta", Technique = op, Availability = s, Abrev = "ab", Size = "150x125"},
                new Painting() { Title = "Cocos", Technique = od, Availability = s, Abrev = "ac", Size = "80x60"},
                new Painting() { Title = "Té Verde", Technique = "Óleo y oro sobre madera", Availability = 4400, Abrev = "ad", Size = "31x42.7"},
                new Painting() { Title = "Volcán de Fuego", Technique = op, Availability = 13000, Abrev = "ae", Size = u},
                new Painting() { Title = "Ficus", Technique = "Óleo sobre lino", Availability = s, Abrev = "af", Size = "60x80"},
                new Painting() { Title = "Heliconias Rojas", Technique = od, Availability = s, Abrev = "ag", Size = "120x40"},
                new Painting() { Title = "Azucenas Rojas", Technique = op, Availability = 6000, Abrev = "ah", Size = u},
                new Painting() { Title = "6 Pimientos", Technique = op, Availability = 6000, Abrev = "aj", Size = "42x155"},
                new Painting() { Title = "Gingko Biloba", Technique = op, Availability = 4500, Abrev = "ak", Size = "59.7x94"},
                new Painting() { Title = "Hojas de Plátano", Technique = op, Availability = s, Abrev = "al", Size = "80x60"},
                new Painting() { Title = "Mar", Technique = op, Availability = s, Abrev = "am", Size = "130x55"},
                new Painting() { Title = "Lámparas Chinas", Technique = "Pasteles sobre algodón", Availability = 3800, Abrev = "an", Size = u},
                new Painting() { Title = "Vaso Blanco", Technique = "Óleo sobre lino", Availability = 3100, Abrev = "ao", Size = u},
                new Painting() { Title = "Velas", Technique = op, Availability = 5200, Abrev = "ap", Size = "121x92"},
                new Painting() { Title = "We Recycle", Technique = op, Availability = 7500, Abrev = "aq", Size = "94x127"},
                new Painting() { Title = "Pan sobre Servilleta", Technique = op, Availability = 3100, Abrev = "ar", Size = u},
                new Painting() { Title = "Abejas a la Miel", Technique = "Acrílico sobre tela", Availability = s, Abrev = "as", Size = "30x30"},
                new Painting() { Title = "Lili", Technique = od, Availability = s, Abrev = "au", Size = "38x60"},
                new Painting() { Title = "Alcatraces", Technique = od, Availability = 2800, Abrev = "aw", Size = u},
                new Painting() { Title = "Tulipanes", Technique = od, Availability =3200, Abrev = "ax", Size = u},
                new Painting() { Title = "Lili II", Technique = od, Availability = 2500, Abrev = "ay", Size = u},
                new Painting() { Title = "Flor", Technique = op, Availability = s, Abrev = "az", Size = "140x140"},
                new Painting() { Title = "Pájaros I", Technique = "Acrílico sobre tela", Availability = s, Abrev = "av", Size = "20x21"},
                new Painting() { Title = "Pájaro II", Technique = "Acrílico sobre tela", Availability = 600, Abrev = "at", Size = "24x21"},
                new Painting() { Title = "Llave", Technique = "Óleo sobre roble", Availability = s, Abrev = "bc", Size = "12x30"},
                new Painting() { Title = "Maguey", Technique = "Acuarela", Availability = 600, Abrev = "bd", Size = u},
                new Painting() { Title = "Heliconias", Technique = od, Availability = s, Abrev = "be", Size = "120x40 (2)"},
                new Painting() { Title = "Heliconias Naranjas", Technique = od, Availability = s, Abrev = "bf", Size = "120x40"},
                new Painting() { Title = "Música del Viento", Technique = op, Availability = 5800, Abrev = "bg", Size = u},
                new Painting() { Title = "Naranjas", Technique = op, Availability = s, Abrev = "bh", Size = "60x80"},
                new Painting() { Title = "Mirada", Technique = op, Availability = 1800, Abrev = "bi", Size = "68x27"},
                new Painting() { Title = "10 Pimientos", Technique = op, Availability = s, Abrev = "bj", Size = "220x60"},
                new Painting() { Title = "Juguetes Viejos", Technique = od, Availability = s, Abrev = "bk", Size = "180x45"},
                new Painting() { Title = "Palo de Mar", Technique = op, Availability = s, Abrev = "bl", Size = "25.4x63.5"},
                new Painting() { Title = "Naturaleza Muerta", Technique = od, Availability = s, Abrev = "bm", Size = "60x22"},
                new Painting() { Title = "Tallos de Alcatraz", Technique = op, Availability = 4800, Abrev = "bn", Size = "67x90"},
                new Painting() { Title = "5 Cebras", Technique = "Acrílico sobre tela", Availability = s, Abrev = "bo", Size = "180x145"},
                new Painting() { Title = "Enredadera", Technique = "Acuarela", Availability = 600, Abrev = "bp", Size = u},
                new Painting() { Title = "Plátanos", Technique = od, Availability = s, Abrev = "bq", Size = "70x80"},
                new Painting() { Title = "Volcán en Primavera", Technique = op, Availability = s, Abrev = "br", Size = "150x115"},
                new Painting() { Title = "Snowdrop", Technique = op, Availability = s, Abrev = "bs", Size = "60x25"},
                new Painting() { Title = "Hojas de Plátano", Technique = "Acuarela", Availability = 600, Abrev = "bu", Size = u},
                new Painting() { Title = "Peras", Technique = op, Availability = s, Abrev = "bw", Size = "30x30"},
                new Painting() { Title = "Chamarra", Technique = op, Availability = s, Abrev = "bx", Size = "65x125"},
                new Painting() { Title = "Manos que Sostienen", Technique = od, Availability = s, Abrev = "by", Size = "244x122"}
            };
            return View("_Paintings", Obrazky);
        }
        // GET: Interiores
        public ActionResult Interiores()
        {
            List<Image> imag = new List<Image>()
            {
                new Image() { Title = "Bosque Gris", Abrev = "bsg", Length = "1 día"},
                new Image() { Title = "Ingredientes", Abrev = "rp", Length = "1 día"},
                new Image() { Title = "Enanos", Abrev = "bg", Length = "½ día"},
                new Image() { Title = "Reino Marino", Abrev = "cp", Length = "8 días"},
                new Image() { Title = "Muebles de Madera", Abrev = "mdm", Length = "1 día"},
                new Image() { Title = "Palma", Abrev = "pt", Length = "1 día"},
                new Image() { Title = "Flamenco Español", Abrev = "f", Length = "2 días"},
                new Image() { Title = "Bambu", Abrev = "boo", Length = "1 día"},
                new Image() { Title = "Cocina Naranja", Abrev = "ln", Length = "2 días"},
                new Image() { Title = "Árboles de Bienvenida", Abrev = "ap", Length = "1 día"},
                new Image() { Title = "Refrigerador de Madera", Abrev = "r", Length = "2 días"},
                new Image() { Title = "Mujer con Sueter Rojo", Abrev = "sr", Length = "2 días"},
                new Image() { Title = "Amor Internacional", Abrev = "fr", Length = "1 día"},
                new Image() { Title = "BBQ", Abrev = "rv", Length = "1 día"},
                new Image() { Title = "Terraza Caliente", Abrev = "pp", Length = "1 día"},
                new Image() { Title = "En la Panadería", Abrev = "mcb", Length = "2 días"},
                new Image() { Title = "Velero", Abrev = "vro", Length = "1 día"},
                new Image() { Title = "Terraza Holandesa", Abrev = "h", Length = "1 día"},
                new Image() { Title = "Cocina para un Buen Chef", Abrev = "cco", Length = "1 día"},
            };
            return View("_Class", imag);
        }
        // GET: Publico
        public ActionResult Publico()
        {
            List<Image> imge = new List<Image>()
            {
                new Image() { Title = "Carolo", Abrev = "ca", Length = "7 días" },
                new Image() { Title = "Catamarán", Abrev = "fc", Length = "10 días" },
                new Image() { Title = "Dupuis", Abrev = "du", Length = "4 días" },
                new Image() { Title = "Fishmart Revolución", Abrev = "fr", Length = "4 días" },
                new Image() { Title = "Lamborghini", Abrev = "l", Length = "5 días" },
                new Image() { Title = "Fishmart Polanco", Abrev = "ec", Length = "5 días" },
                new Image() { Title = "La Vie En Rose", Abrev = "pa", Length = "7 días" },
                new Image() { Title = "Helado Gourmet", Abrev = "hg", Length = "8 días" },
                new Image() { Title = "Kiwi", Abrev = "k", Length = "3 días" },
                new Image() { Title = "Fishmart Bar", Abrev = "fn", Length = "4 días" },
                new Image() { Title = "Kinder", Abrev = "lu", Length = "3 días" },
                new Image() { Title = "Relax", Abrev = "ma", Length = "3 días" },
                new Image() { Title = "Carolo Carso", Abrev = "cc", Length = "7 días" },
                new Image() { Title = "Villahermosa", Abrev = "ov", Length = "11 días" },
            };
            return View("_Class", imge);
        }
        // GET: Gracia
        public ActionResult Gracia()
        {
            List<Image> mages = new List<Image>()
            {
                new Image() { Title = "Pintura para niños", Abrev = "act"},
                new Image() { Title = "Casa Hogar Alegría", Abrev = "cha" },
                new Image() { Title = "Casa Hogar Colima", Abrev = "chc" },
                new Image() { Title = "Casa Hogar en Puebla I", Abrev = "chp" },
                new Image() { Title = "Casa Hogar en Puebla II", Abrev = "chpn" },
                new Image() { Title = "León", Abrev = "l" },
                new Image() { Title = "Escuela Bíblica en Nottingham", Abrev = "ebn" },
            };
            return View("_Class", mages);
        }
        // GET: Libuska. Order is : 0-Libuse, 1-Kontakt, 2-Ceny, 3-ChciMalbu, 4-Milost;
        public ActionResult Libuska()
        {
            Info Information = new Info() { Number = 0, Lang = 2, Text = "Siempre me gustó pintar. Desde niña. En el pais donde crecí (México) es raro estudiar arte, asi es que estudié diseño, despues me casé y tuve hijos. Una vez, nos cambiamos a una casa grande, muy grande. Tan grande que no tenía tantos muebles para llenarla, y la casa parecía muy vacía. Se me ocurrió pintar las paredes. Empecé por el cuarto de mis niños, les pinté una selva de muchos colores, con un lago, unos arboles y patos y cocodrilos y changos y ranas brincando y pájaros volando. Estaban fascinados!  Se aprendieron los números y los colores mucho mas rápido de lo normal!!  Un dia, una amiga que fue a visitarme y entró al cuarto, vió aquel paisaje y le encantó. 'Hazme uno igualito, idéntico, para el cuarto de juegos de mis niños' me dijo. Al suyo, ademas le puse unas hadas y otras flores que me pidió, porque tambien tenía una niña. Eramos muy amigas, y me dió muchísimo gusto pintarles :)  Despues, una amiga suya, que yo no conocía, fue a su casa, y vio el mural, y quiso uno para sus niños tambien. Me habló mi amiga y me explicó que su amiga quería tener un mural. A partir de ahi, me empezaron a llamar por muchas partes, ya no nadamas para cuartos de niños, sino para restaurantes, oficinas y demas. Asi fue el sencillo comienzo de 'paredviva'. Lo convertí en un 'negocio' establecido, le inventé un nombre y le hice su propia página web, en México, hace 15 años. La publicidad llegó solita, se fue haciendo de boca en boca. En 2014, mientras platicaba tranquilamente con mi esposo, recibí una llamada de la embajada de la República Checa en Mexico, para informarme que habían promulgado una nueva ley que permitía a los nietos de emigrantes checos, solicitar la ciudadanía checa. Toda una vida interesante la de mi familia!!! Para recortarles mucho la historia, mi abuelo llegó a México empezando la segunda guerra mundial, donde se casó, y tuvo hijos, y uno de sus hijos es mi querido papá  : )   (Eso explica mi nombre tan checo) Total, que solicitamos la nacionalidad. Y nos venimos a vivir aqui el año pasado, como checos, pero aprendiendo muy lentamente el nada fácil idioma checo.  Ahora mis hijos son jóvenes, uno va a gymnazium y el otro está por entrar a la escuela de arte. Hemos sido increíblemente bien recibidos, lo que nos ha ayudado mucho a adaptarnos a esta cultura completamente nueva para nosotros. Republica Checa nos ha fascinado! Nos encanta caminar por la orilla del Vltava y hacer hicking por sus montañas tan bien señalizadas. Comer tocena zmrzlina, y parek v rohliku. Nos ha maravillado su cambio de estaciones y su invierno tan frío. Hemos disfrutado el aprender una nueva lengua y encontrarnos de pronto en medio de esta bella nación, con la simple posibilidad de pasar la tarde en Praha. Ahora estoy retornando a lo que con tanto gusto y satisfacción he hecho por tanto tiempo: PINTAR" };
            return View("_Info", Information);
        }
        // GET: Contacto
        public ActionResult Contacto()
        {
            Info Information = new Info() { Number = 1, Lang = 2, Text = "Libuse Smutna   (inglés, español... y algo de checo, pero estoy aprendiendo). Si tienes interes en un moral o en un cuadro, contáctame en:" };
            return View("_Info", Information);
        }
        // GET: Precios 
        public ActionResult Precios()
        {
            Info Information = new Info() { Number = 2, Lang = 2, Text = "Los precios varían segun el tiempo que me toma hacerlos. Para cuartos de niños y proyectos chicos son 3,000 kč el dia, de 8 hrs de trabajo.  Para lugares públicos o proyectos grandes, son 5,000 kč el dia, de 8 hrs de trabajo, esto es porque estoy incluyendo el tiempo que me toma hacer el diseño completo.   Para edificios o lugares con mas de dos pisos de andamios prefiero hacer un presupuesto personal, esto por el peligro que implica. Necesito cobrar por tiempo, porque notaba que, una vez aprobado el diseño y entregado el presupuesto, algunas veces, querían algún detalle extra, pero para las personas era incómodo pedirlo, porque no estaba dentro del presupuesto y acababa tardándome mucho mas de lo planeado. Cobrar por tiempo resolvió completamente esa situación." };
            return View("_Info", Information);
        }
        // GET: QuieroUno
        public ActionResult QuieroUno()
        {
            Info Information = new Info() { Number = 3, Lang = 2, Text = "Los murales son algo tremendamente personal, no es algo hecho en serie. Mi trabajo principal se trata de procurar entender a la perfección la intención del mural, para poder lograr exactamente lo que la persona me pide. No es nada mas pintar, sino crear un ambiente, crear un espacio que anime, que den ganas de estar ahi, que se goce y se disfrute. Algo asi solo se puede lograr de persona a persona. Primero, puedes contactarme por correo o por telefono, decirme el tema, el tamaño y por supuesto, la dirección, en ese momento te daré un presupuesto aproximado. Si es en una casa, o un proyecto chico, llego con mi caja de pintura y, despues de estudiar el tema y el espacio con cuidado, hago un pequeño borrador en papel y empiezo cubriendo y protegiendo muebles y pisos. Primero hago el trazo y despues le pongo el color. Pinto con pintura acrílica, que seca muy rápido y es muy resistente. No huele a nada, y el lugar se puede seguir usando casi como de costumbre. Se puede pintar sobre cualquier textura de pared. Los murales en casa, para cuarto de niños, toman casi siempre entre uno y tres días, dependiendo del proyecto y del tamaño de la habitación. Para pintar un restaurante o algun proyecto grande es muy parecido, nadamas que un poco mas lento. Sobretodo para hacer el borrador o la propuesta, en este caso es mucho mas detallado y necesito ir días antes para estudiar el lugar y tomar las medidas exactas, ademas del tiempo que toma planear el proyecto. En este caso, igual pinto con pintura acrílicas. Un lugar público puede, tambien, seguir siendo habilitado casi como de costumbre y he encontrado que a la gente no nadamas no les molesta mi presencia, sino les llama la atención el verme pintar, aunque, por supuesto, es mucho mas sencillo mientras el lugar está en construcción." };
            return View("_Info", Information);
        }
        // GET: gracia
        public ActionResult Graciaa()
        {
            Info Information = new Info() { Number = 4, Lang = 2, Text = "Hay un dicho que dice: 'Lo que ustedes recibieron gratis, denlo gratuitamente'. Eso es justo lo que ha sido la pintura para mí: un regalo. A pesar de que es mi trabajo, de que me superfascina pintar, y que he tomado (y dado) varios cursos de arte, en realidad, el arte, para mi, es un talento dado. No es algo que me cuesta un trabajo excepcional, o que batalle para lograr algo, en realidad, es algo con lo que nací, yo nada más lo descubrí en el camino :) Es un talento que Dios me dio, gratuitamente. Y como talento suyo, sé que no es nada más para mí, es para los demás, para multiplicarlo y levantar Su nombre. Si quieres un mural para algún tipo de obra social (hospital, casa hogar para niños o ancianos, enfermos, refugiados, rehab, etc) o cualquier lugar o actividad donde se busque expandir el Reino de Dios, me encantaría apoyar y ser parte, y dar de gracia esa gracia que a mí, con tanto amor, me ha sido dada." };
            return View("_Info", Information);
        }
    }
}