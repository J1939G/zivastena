using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using beta.Models;
using System.Web.Mvc;

namespace beta.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            Start Info = new Start() { Lang = 1 };
            return View("_Start", Info);
        }
        // GET: Children
        public ActionResult Children()
        {
            List<Image> images = new List<Image>() {
                new Image() { Title = "Airplanes", Abrev = "a", Length = "1 day" },
                new Image() { Title = "Under the Sea", Abrev = "bm", Length = "3 days" },
                new Image() { Title = "Monkeys", Abrev = "ch", Length = "2 days" },
                new Image() { Title = "Rabbits", Abrev = "cj", Length = "2 days" },
                new Image() { Title = "Fairy Tales", Abrev = "dm", Length = "2 days" },
                new Image() { Title = "Dinosaurs I", Abrev = "dsf", Length = "2½ days" },
                new Image() { Title = "Far Away Kingdom", Abrev = "euv", Length = "2 days" },
                new Image() { Title = "Extreme Speed", Abrev = "fu", Length = "1 day" },
                new Image() { Title = "Chicken", Abrev = "g", Length = "1½ day" },
                new Image() { Title = "Fairies, Stars and Flowers", Abrev = "hr", Length = "1 day" },
                new Image() { Title = "Jets", Abrev = "j", Length = "4 days" },
                new Image() { Title = "Japanese Garden", Abrev = "k", Length = "1½ day" },
                new Image() { Title = "Transportation", Abrev = "mdt", Length = "2 days" },
                new Image() { Title = "Tree and song", Abrev = "nd", Length = "2 days" },
                new Image() { Title = "Gorila", Abrev = "ga", Length = "2 days" },
                new Image() { Title = "Safari", Abrev = "sf", Length = "2 days" },
                new Image() { Title = "Starwars", Abrev = "sw", Length = "3½ days" },
                new Image() { Title = "Rapunzel", Abrev = "rz", Length = "1½ day" },
                new Image() { Title = "Dolphins", Abrev = "pd", Length = "1½ day" },
                new Image() { Title = "Solar System", Abrev = "ss", Length = "2½ days" },
                new Image() { Title = "Little Prince", Abrev = "p", Length = "1 day" },
                new Image() { Title = "Cars", Abrev = "tra", Length = "1½ day" },
                new Image() { Title = "Whinnie the Pooh", Abrev = "wp", Length = "2½ days" },
                new Image() { Title = "Sailboat", Abrev = "vel", Length = "2 days" },
                new Image() { Title = "Noahs Arch", Abrev = "an", Length = "3½ days" },
                new Image() { Title = "Flying in the Clouds", Abrev = "as", Length = "2 days" },
                new Image() { Title = "Sweet Girls", Abrev = "chm", Length = "3 days" },
                new Image() { Title = "Lighthouse", Abrev = "chp", Length = "3 days" },
                new Image() { Title = "Footballfever", Abrev = "soc", Length = "2 days" },
                new Image() { Title = "Dinosaurs", Abrev = "di", Length = "2 days" },
                new Image() { Title = "Castles", Abrev = "d", Length = "2 days" },
                new Image() { Title = "Small Adventurers", Abrev = "ds", Length = "3½ days" },
                new Image() { Title = "Flowers", Abrev = "fr", Length = "1 day" },
                new Image() { Title = "Cars", Abrev = "c", Length = "2 days" },
                new Image() { Title = "Fairies", Abrev = "h", Length = "1 day" },
                new Image() { Title = "Pink Fairies", Abrev = "hv", Length = "1½ day" },
                new Image() { Title = "Surrealist Garden", Abrev = "js", Length = "1 day" },
                new Image() { Title = "Children Safari", Abrev = "ly", Length = "2 days" },
                new Image() { Title = "Pirates", Abrev = "ps", Length = "2½ days" },
                new Image() { Title = "Teddie Bear", Abrev = "ot", Length = "1 days" },
                new Image() { Title = "Le petit prince", Abrev = "pf", Length = "1½ day" },
                new Image() { Title = "Little Prince", Abrev = "psf", Length = "1½ day" },
                new Image() { Title = "Pegasus and Unicorns", Abrev = "pu", Length = "2½ days" },
                new Image() { Title = "Marvel", Abrev = "mv", Length = "3 days" },
                new Image() { Title = "In the Jungle", Abrev = "s", Length = "4 days" },
                new Image() { Title = "Savanah", Abrev = "sv", Length = "2½ days" },
                new Image() { Title = "Animal Train", Abrev = "tda", Length = "3 days" }
            };
            return View("_Class", images);
        }
        // GET: Paintings
        public ActionResult Paintings()
        {
            string op = "Oil on canvass";
            string od = "Oil on wood";
            string u = "undefined";
            int s = 171717;
            List<Painting> Obrazky = new List<Painting>()
            {
                new Painting() { Title = "Bamboo", Technique = op, Availability = s, Abrev = "aa", Size = "150x150"},
                new Painting() { Title = "Bicycle", Technique = op, Availability = s, Abrev = "ab", Size = "150x125"},
                new Painting() { Title = "Coconuts", Technique = od, Availability = s, Abrev = "ac", Size = "80x60"},
                new Painting() { Title = "Green Tea", Technique = "Gold leaf and oil on wood", Availability = 4400, Abrev = "ad", Size = "31x42.7"},
                new Painting() { Title = "Firy Volcano", Technique = op, Availability = 13000, Abrev = "ae", Size = u},
                new Painting() { Title = "Ficus", Technique = "Oil on linen", Availability = s, Abrev = "af", Size = "60x80"},
                new Painting() { Title = "Red Heliconias", Technique = od, Availability = s, Abrev = "ag", Size = "120x40"},
                new Painting() { Title = "Red Flowers", Technique = op, Availability = 6000, Abrev = "ah", Size = u},
                new Painting() { Title = "6 Pepper", Technique = op, Availability = 6000, Abrev = "aj", Size = "42x155"},
                new Painting() { Title = "Gingko Biloba", Technique = op, Availability = 4500, Abrev = "ak", Size = "59.7x94"},
                new Painting() { Title = "Banana leafs", Technique = op, Availability = s, Abrev = "al", Size = "80x60"},
                new Painting() { Title = "Sea", Technique = op, Availability = s, Abrev = "am", Size = "130x55"},
                new Painting() { Title = "Chinese Lamps", Technique = "Pastels on cotton", Availability = 3800, Abrev = "an", Size = u},
                new Painting() { Title = "White Vase", Technique = "Oil on linen", Availability = 3100, Abrev = "ao", Size = u},
                new Painting() { Title = "Sails", Technique = op, Availability = 5200, Abrev = "ap", Size = "121x92"},
                new Painting() { Title = "We Recycle", Technique = op, Availability = 7500, Abrev = "aq", Size = "94x127"},
                new Painting() { Title = "Bread over Napkin", Technique = op, Availability = 3100, Abrev = "ar", Size = u},
                new Painting() { Title = "Bees to the Honey", Technique = "Acrilic on canvass", Availability = s, Abrev = "as", Size = "30x30"},
                new Painting() { Title = "Lilium", Technique = od, Availability = s, Abrev = "au", Size = "38x60"},
                new Painting() { Title = "Alcatraces", Technique = od, Availability = 2800, Abrev = "aw", Size = u},
                new Painting() { Title = "Tulip", Technique = od, Availability =3200, Abrev = "ax", Size = u},
                new Painting() { Title = "Lilium II", Technique = od, Availability = 2500, Abrev = "ay", Size = u},
                new Painting() { Title = "Flower", Technique = op, Availability = s, Abrev = "az", Size = "140x140"},
                new Painting() { Title = "Birds I", Technique = "Acrilic on canvass", Availability = s, Abrev = "av", Size = "20x21"},
                new Painting() { Title = "Bird II", Technique = "Acrilic on canvass", Availability = 600, Abrev = "at", Size = "24x21"},
                new Painting() { Title = "Key", Technique = "Oil over oak", Availability = s, Abrev = "bc", Size = "12x30"},
                new Painting() { Title = "Maguey", Technique = "Watercolor", Availability = 600, Abrev = "bd", Size = u},
                new Painting() { Title = "Heliconias", Technique = od, Availability = s, Abrev = "be", Size = "120x40 (2)"},
                new Painting() { Title = "Orange Heliconias", Technique = od, Availability = s, Abrev = "bf", Size = "120x40"},
                new Painting() { Title = "Wind Music", Technique = op, Availability = 5800, Abrev = "bg", Size = u},
                new Painting() { Title = "Oranges", Technique = op, Availability = s, Abrev = "bh", Size = "60x80"},
                new Painting() { Title = "Look", Technique = op, Availability = 1800, Abrev = "bi", Size = "68x27"},
                new Painting() { Title = "10 Peppers", Technique = op, Availability = s, Abrev = "bj", Size = "220x60"},
                new Painting() { Title = "Old Toys", Technique = od, Availability = s, Abrev = "bk", Size = "180x45"},
                new Painting() { Title = "Sea Stick", Technique = op, Availability = s, Abrev = "bl", Size = "25.4x63.5"},
                new Painting() { Title = "Death Nature", Technique = od, Availability = s, Abrev = "bm", Size = "60x22"},
                new Painting() { Title = "Alcatraz Stems", Technique = op, Availability = 4800, Abrev = "bn", Size = "67x90"},
                new Painting() { Title = "5 Zebras", Technique = "Acrilic on canvass", Availability = s, Abrev = "bo", Size = "180x145"},
                new Painting() { Title = "Climbing Plant", Technique = "Watercolor", Availability = 600, Abrev = "bp", Size = u},
                new Painting() { Title = "Bananas", Technique = od, Availability = s, Abrev = "bq", Size = "70x80"},
                new Painting() { Title = "Volcano in Summer", Technique = op, Availability = s, Abrev = "br", Size = "150x115"},
                new Painting() { Title = "Snowdrop", Technique = op, Availability = s, Abrev = "bs", Size = "60x25"},
                new Painting() { Title = "Banana Leafs", Technique = "Watercolor", Availability = 600, Abrev = "bu", Size = u},
                new Painting() { Title = "Pears", Technique = op, Availability = s, Abrev = "bw", Size = "30x30"},
                new Painting() { Title = "Jacket", Technique = op, Availability = s, Abrev = "bx", Size = "65x125"},
                new Painting() { Title = "Holding Hands", Technique = od, Availability = s, Abrev = "by", Size = "244x122"}
            };
            return View("_Paintings", Obrazky);
        }
        // GET: Interiors
        public ActionResult Interiors()
        {
            List<Image> image = new List<Image>()
            {
                new Image() { Title = "Gray Forest", Abrev = "bsg", Length = "1 day"},
                new Image() { Title = "Ingredients", Abrev = "rp", Length = "1 day"},
                new Image() { Title = "Dwarves", Abrev = "bg", Length = "½ day"},
                new Image() { Title = "Marine Kingdom", Abrev = "cp", Length = "8 days"},
                new Image() { Title = "Wooden Furniture", Abrev = "mdm", Length = "1 day"},
                new Image() { Title = "Palm", Abrev = "pt", Length = "1 day"},
                new Image() { Title = "Flamenco", Abrev = "f", Length = "2 days"},
                new Image() { Title = "Bamboo", Abrev = "boo", Length = "1 day"},
                new Image() { Title = "Orange Kitchen", Abrev = "ln", Length = "2 days"},
                new Image() { Title = "Three Welcoming", Abrev = "ap", Length = "1 day"},
                new Image() { Title = "Wooden Fridge", Abrev = "r", Length = "2 days"},
                new Image() { Title = "Woman with Red Sweater", Abrev = "sr", Length = "2 days"},
                new Image() { Title = "International Love", Abrev = "fr", Length = "1 day"},
                new Image() { Title = "BBQ", Abrev = "rv", Length = "1 day"},
                new Image() { Title = "Hot Terrace", Abrev = "pp", Length = "1 day"},
                new Image() { Title = "Woman Baking", Abrev = "mcb", Length = "2 days"},
                new Image() { Title = "Sailboat", Abrev = "vro", Length = "1 day"},
                new Image() { Title = "Holandese Terrace", Abrev = "h", Length = "1 day"},
                new Image() { Title = "Kitchen for a Great Chef", Abrev = "cco", Length = "1 day"},
            };
            return View("_Class", image);
        }
        // GET: Public
        public ActionResult Public()
        {
            List<Image> image = new List<Image>()
            {
                new Image() { Title = "Carolo", Abrev = "ca", Length = "7 days" },
                new Image() { Title = "Catamaran", Abrev = "fc", Length = "10 days" },
                new Image() { Title = "Dupuis", Abrev = "du", Length = "4 days" },
                new Image() { Title = "Fishmart Revolución", Abrev = "fr", Length = "4 days" },
                new Image() { Title = "Lamborghini", Abrev = "l", Length = "5 days" },
                new Image() { Title = "Fishmart Polanco", Abrev = "ec", Length = "5 days" },
                new Image() { Title = "La Vie En Rose", Abrev = "pa", Length = "7 days" },
                new Image() { Title = "Gourmet Icecream", Abrev = "hg", Length = "8 days" },
                new Image() { Title = "Kiwi", Abrev = "k", Length = "3 days" },
                new Image() { Title = "Fishmart Bar", Abrev = "fn", Length = "4 days" },
                new Image() { Title = "Kinder", Abrev = "lu", Length = "3 days" },
                new Image() { Title = "Relax", Abrev = "ma", Length = "3 days" },
                new Image() { Title = "Carolo Carso", Abrev = "cc", Length = "7 days" },
                new Image() { Title = "Villahermosa", Abrev = "ov", Length = "11 days" },
            };
            return View("_Class", image);
        }
        // GET: Grace
        public ActionResult Grace()
        {
            List<Image> image = new List<Image>()
            {
                new Image() { Title = "Painting for Children", Abrev = "act"},
                new Image() { Title = "Orphanage 'Joy'", Abrev = "cha" },
                new Image() { Title = "Orphanage in Colima", Abrev = "chc" },
                new Image() { Title = "Orphanage in Puebla I", Abrev = "chp" },
                new Image() { Title = "Orphanage in Puebla II", Abrev = "chpn" },
                new Image() { Title = "Lion", Abrev = "l" },
                new Image() { Title = "Bible School in Nottingham", Abrev = "ebn" },
            };
            return View("_Class", image);
        }
        // GET: Libuska. Order is : 0-Libuse, 1-Kontakt, 2-Ceny, 3-ChciMalbu, 4-Milost;
        public ActionResult Libuska()
        {
            Info Information = new Info() { Number = 0, Lang = 1, Text = "From my childhood I have always loved to paint. In the country I grew up (Mexico), it is uncommon to study art, so I studied design, then married and had children. Once we moved into a big, massive house. It was so big that I didn't have so many furniture to fill it up, and it looked really empty. My solution was to paint the walls. I started with my childrens room, and painted for them a colourfull jungle, with a lake, some threes, ducks, crocodiles, monkeys, jumping frogs and flying birds. They were really excited! They even took less time to get to learn the colors and the numbers. One day, a friend came to visit and entered to see the room. She saw the landscape and she loved it. 'Make me one, identical, for my childrens room' she said. To hers, since she had a girl, I also added some fairies and other flowers that she asked for. We were very good friends, and I gladfully painted for her :) Afterwards, a friend of hers (whom I had never met) went to her house. When she saw the mural, she decided she wanted one for her children also. My friend called and explained that her friend wanted a mural. From there on, calls started coming wishing for a mural, and, eventually, not only for their children, but for restaurants, offices and many other things. That was the simple beginning of 'paredviva' (in Spanish: 'Living - wall', in Czech: 'ZivaStena'). I transformed it into a established 'business', came with a name for it and made it its website, in Mexico, 15 years ago. Publicity came by itself, making itself from mouth to mouth. In 2014, while I was calmly talking with my husband, I received a call from the ambassy from the Czech Republic in Mexico, to inform me about a recent law which allows for the grandchildren of czech emigrants to make a petition to obtain czech citizenship. Such an interesting life for my family!!! To shorten the matter, my grandfather arrived to Mexico during the Second World War, where he married, had children, and one of his sons became my dear father :) (That explains why my name is so czech) And so, we applied for citizenship. To complete the process we came to live here last year, as czechs, but learning slowly the not very easy czech language. Now my children are young men, one goes to Gymnazium and the other one is about to enter an art school. We have been incredibly well received, which has helped us a lot to adapt to this completely new culture. The Czech Republic has facinated us in every sense! We love to walk alongside Vltava and to hike in the such well signalized czech mountains. To eat tocena zmrzlina, and parek v rohliku. We have been marveled by its change in seasons and its freezing winter. We have Enyojed learning a new language, and to suddenly find ourselves in the middle of this wonderful nation, with the simple possibility of spending the evening wandering in Prague. Now I'm starting to do with so much happiness and satisfaction what I have done for so many time: PAINTING" };
            return View("Info", Information);
        }
        // GET: Contact
        public ActionResult Contact()
        {
            Info Information = new Info() { Number = 1, Lang = 1, Text = "Libuska Smutna (English, Spanish... and some Czech, but still learning). If you're interested in a mural or a painting, contact me at:" };
            return View("Info", Information);
        }
        // GET: Pricing 
        public ActionResult Pricing()
        {
            Info Information = new Info() { Number = 2, Lang = 1, Text = "Pricing varies according to the time the painting takes. For childrens rooms and smaller proyects the price is 3,000 kč a day, with 8 work hours. For public places or larger proyects the price is 5,000 kč a day due to the time spent in planning the complete desing. For buildings or murals with more than a floor of height where using scaffolds is required I prefer to make a personal budget, because of the implied danger. I need to charge by time because I noticed that, once the design was approved and after providing the estimate, clients would like an extra detail, but they didn't feel comfortable asking for it, since it was out of the estimate, and I ended up taking more time then I had planned for. Charging by time has solved this issue completely." };
            return View("Info", Information);
        }
        // GET: Paint
        public ActionResult Paint()
        {
            Info Information = new Info() { Number = 3, Lang = 1, Text = "Murals are something extremely personal, not something done in series. My main objective is to perfectly understand the purpose of the mural, and by doing this, to achieve exactly what my clients want. It is not only painting, but also creating the enviroment, a space that gives joy, which people want to be in, in which people can rejoice and enyoj. Something like that can only happen from individual to individual. First, you can contact me by mail or by phone, tell me the theme, the size and of course, the adress. In this moment I'll give you an aproximated estimate. If it's in a house or a small proyect, I arrive with my painting box and, after carefully studying the theme and the space, I make a small sketch in paper and start covering and protecting furniture and floors. First I make the stroke and afterwards I color it. I paint with acrilic paint, which dries quickly and is very resistant. It doesn't smell at all, and the place can be used the whole time as usual. The paint can be applied over any wall. Murals in houses, for a childrens room, take usually about one to three days, depending on the proyect and the size of the room. To paint a restaurant or a bigger proyect the process is similar, except that it slows down a little bit. The biggest difference is that the process to provide a sketch or budget is more detailed, and I need be in the site with days in anticipation to study the place and take the exacte measures, apart from the time to plan the proyect. In this case, acrilic is also used. A public place also can be kept working as usual, and I've found out that people don't only not bother with my presence, but their attentions are drawn to seeing me work, although, of course, it is less complicated when the place is being built or remodeled." };
            return View("Info", Information);
        }
        // GET: Grace
        public ActionResult Gracea()
        {
            Info Information = new Info() { Number = 4, Lang = 1, Text = "There's a saying that says: 'What you have freely given, freely give'. That's exactly what painting has been for me: a gift. Even though it's my job, that I love to paint, and that I've taken (and given) many art courses, in the end art is, for me, a given talent. It's not something that requires exhausting work from me, or for me to struggle to attain something, but it is something I was born with, and I only discovered it on the way :) It is a talent which God gave me, gratuitely. And as a talent from him, I know it's not only for me, it's for the rest, to lift His name up. If you want a mural for some kind of social work (Hospital, Orphanage, Senior Houses, Refugees, Rehab...) or any other place or activity where the objective is to expand Gods Kingdom, I'd love to help and take part, and to give gracefully that grace which, so lovingly, has been given to me." };
            return View("Info", Information);
        }
    }
}