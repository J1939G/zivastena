using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using beta.Models;
using System.Web.Mvc;

namespace beta.Controllers
{
    public class DomaController : Controller
    {
        // GET: Doma
        public ActionResult Doma()
        {
            Start Info = new Start() { Lang = 0 };
            return View("_Start", Info);
        }
        // GET: Deti
        public ActionResult Deti()
        {
            List<Image> images = new List<Image>() {
                new Image() { Title = "Letadla", Abrev = "a", Length = "1 den" },
                new Image() { Title = "V Moři", Abrev = "bm", Length = "3 dny" },
                new Image() { Title = "Opice", Abrev = "ch", Length = "2 dny" },
                new Image() { Title = "Zajíčci", Abrev = "cj", Length = "2 dny" },
                new Image() { Title = "Pohadkové Pohoj", Abrev = "dm", Length = "2 dny" },
                new Image() { Title = "Dinosauři I", Abrev = "dsf", Length = "2½ dny" },
                new Image() { Title = "Vzdalená Kraloství", Abrev = "euv", Length = "2 dny" },
                new Image() { Title = "Extremní Rychlost", Abrev = "fu", Length = "1 den" },
                new Image() { Title = "Kuřata", Abrev = "g", Length = "1½ den" },
                new Image() { Title = "Víla, Hvězdy a Květiny", Abrev = "hr", Length = "1 den" },
                new Image() { Title = "Trysky", Abrev = "j", Length = "4 dny" },
                new Image() { Title = "Japonská Zahrada", Abrev = "k", Length = "1½ den" },
                new Image() { Title = "Dopravní Prostředky", Abrev = "mdt", Length = "2 dny" },
                new Image() { Title = "Strom a Bazeň", Abrev = "nd", Length = "2 dny" },
                new Image() { Title = "Gorila", Abrev = "ga", Length = "2 dny" },
                new Image() { Title = "Safari", Abrev = "sf", Length = "2 dny" },
                new Image() { Title = "Hvězdné Války", Abrev = "sw", Length = "3½ dny" },
                new Image() { Title = "Johanka s dlouhými vlasy", Abrev = "rz", Length = "1½ den" },
                new Image() { Title = "Delfíni", Abrev = "pd", Length = "1½ den" },
                new Image() { Title = "Solární Soustava", Abrev = "ss", Length = "2½ dny" },
                new Image() { Title = "Maly Princ", Abrev = "p", Length = "1 den" },
                new Image() { Title = "Autičky", Abrev = "tra", Length = "1½ den" },
                new Image() { Title = "Whinnie the Pooh", Abrev = "wp", Length = "2½ dny" },
                new Image() { Title = "Plachetnice", Abrev = "vel", Length = "2 dny" },
                new Image() { Title = "Noemová Archa", Abrev = "an", Length = "3½ dny" },
                new Image() { Title = "Letání v Oblacích", Abrev = "as", Length = "2 dny" },
                new Image() { Title = "Mílé Dívky", Abrev = "chm", Length = "3 dny" },
                new Image() { Title = "Májak", Abrev = "chp", Length = "3 dny" },
                new Image() { Title = "Footballfever", Abrev = "soc", Length = "2 dny" },
                new Image() { Title = "Dinosaurus", Abrev = "di", Length = "2 dny" },
                new Image() { Title = "Hráci a Hrady", Abrev = "d", Length = "2 dny" },
                new Image() { Title = "Malí Průzkumníci", Abrev = "ds", Length = "3½ dny" },
                new Image() { Title = "Květiny", Abrev = "fr", Length = "1 den" },
                new Image() { Title = "Auta", Abrev = "c", Length = "2 dny" },
                new Image() { Title = "Víly s copankami", Abrev = "h", Length = "1 den" },
                new Image() { Title = "Růžové Víly", Abrev = "hv", Length = "1½ den" },
                new Image() { Title = "Surrealisticá Zahrada", Abrev = "js", Length = "1 den" },
                new Image() { Title = "Dětský Safari", Abrev = "ly", Length = "2 dny" },
                new Image() { Title = "Piraty", Abrev = "ps", Length = "2½ dny" },
                new Image() { Title = "Medvídek", Abrev = "ot", Length = "1 den" },
                new Image() { Title = "Le petit prince", Abrev = "pf", Length = "1½ den" },
                new Image() { Title = "Výkresy Malého Prince", Abrev = "psf", Length = "1½ den" },
                new Image() { Title = "Pegasi a Jednorožci", Abrev = "pu", Length = "2½ dny" },
                new Image() { Title = "Marvel", Abrev = "mv", Length = "3 dny" },
                new Image() { Title = "V Džungli", Abrev = "s", Length = "4 dny" },
                new Image() { Title = "Savana", Abrev = "sv", Length = "2½ dny" },
                new Image() { Title = "Zoologický vlak", Abrev = "tda", Length = "3 dny" }
            };
            return View("_Class", images);
        }
        // GET: Obrazy
        public ActionResult Obrazy()
        {
            string op = "Olej na platně";
            string od = "Olej na dřevě";
            string u = "undefined";
            int s = 171717;
            List<Painting> Painting = new List<Painting>()
            {
                new Painting() { Title = "Bambus", Technique = op, Availability = s, Abrev = "aa", Size = "150x150"},
                new Painting() { Title = "Kolo", Technique = op, Availability = s, Abrev = "ab", Size = "150x125"},
                new Painting() { Title = "Kokosy", Technique = od, Availability = s, Abrev = "ac", Size = "80x60"},
                new Painting() { Title = "Zelený Čaj", Technique = "Olej a platkové zlato na dřevě", Availability = 4400, Abrev = "ad", Size = "31x42.7"},
                new Painting() { Title = "Ohňová země", Technique = op, Availability = 13000, Abrev = "ae", Size = u},
                new Painting() { Title = "Fikus", Technique = "Olej na len", Availability = s, Abrev = "af", Size = "60x80"},
                new Painting() { Title = "Červený Helikónie", Technique = od, Availability = s, Abrev = "ag", Size = "120x40"},
                new Painting() { Title = "Červené Lilie", Technique = op, Availability = 6000, Abrev = "ah", Size = u},
                new Painting() { Title = "6 Papriků", Technique = op, Availability = 6000, Abrev = "aj", Size = "42x155"},
                new Painting() { Title = "Gingko Biloba", Technique = op, Availability = 4500, Abrev = "ak", Size = "59.7x94"},
                new Painting() { Title = "Banánoví listy", Technique = op, Availability = s, Abrev = "al", Size = "80x60"},
                new Painting() { Title = "Moře", Technique = op, Availability = s, Abrev = "am", Size = "130x55"},
                new Painting() { Title = "Činskí lampy", Technique = "Pastel na bavlnový papíře", Availability = 3800, Abrev = "an", Size = u},
                new Painting() { Title = "Bílé Sklenice", Technique = "Olej nad lenem", Availability = 3100, Abrev = "ao", Size = u},
                new Painting() { Title = "Plachety", Technique = op, Availability = 5200, Abrev = "ap", Size = "121x92"},
                new Painting() { Title = "We Recycle", Technique = op, Availability = 7500, Abrev = "aq", Size = "94x127"},
                new Painting() { Title = "Chléb na ubrousku", Technique = op, Availability = 3100, Abrev = "ar", Size = u},
                new Painting() { Title = "Včely do meďi", Technique = "Akryl na platně", Availability = s, Abrev = "as", Size = "30x30"},
                new Painting() { Title = "Lilium", Technique = od, Availability = s, Abrev = "au", Size = "38x60"},
                new Painting() { Title = "Arum I", Technique = od, Availability = 2800, Abrev = "aw", Size = u},
                new Painting() { Title = "Tulipány", Technique = od, Availability =3200, Abrev = "ax", Size = u},
                new Painting() { Title = "Arum II", Technique = od, Availability = 2500, Abrev = "ay", Size = u},
                new Painting() { Title = "Květina", Technique = op, Availability = s, Abrev = "az", Size = "140x140"},
                new Painting() { Title = "Ptáci I", Technique = "Akryl na platně", Availability = s, Abrev = "av", Size = "20x21"},
                new Painting() { Title = "Ptáci II", Technique = "Akryl na platně", Availability = 600, Abrev = "at", Size = "24x21"},
                new Painting() { Title = "Klíče", Technique = "Olej na dubu", Availability = s, Abrev = "bc", Size = "12x30"},
                new Painting() { Title = "Maguey", Technique = "Akvarely", Availability = 600, Abrev = "bd", Size = u},
                new Painting() { Title = "Helikónie", Technique = od, Availability = s, Abrev = "be", Size = "120x40 (2)"},
                new Painting() { Title = "Oranžoví Helikónie", Technique = od, Availability = s, Abrev = "bf", Size = "120x40"},
                new Painting() { Title = "Hudba Vzduchu", Technique = op, Availability = 5800, Abrev = "bg", Size = u},
                new Painting() { Title = "Pomeranče", Technique = op, Availability = s, Abrev = "bh", Size = "60x80"},
                new Painting() { Title = "Vzhled", Technique = op, Availability = 1800, Abrev = "bi", Size = "68x27"},
                new Painting() { Title = "10 Papriků", Technique = op, Availability = s, Abrev = "bj", Size = "220x60"},
                new Painting() { Title = "Staré Hračky", Technique = od, Availability = s, Abrev = "bk", Size = "180x45"},
                new Painting() { Title = "Mořský Klácek", Technique = op, Availability = s, Abrev = "bl", Size = "25.4x63.5"},
                new Painting() { Title = "Mrtvá Příroda", Technique = od, Availability = s, Abrev = "bm", Size = "60x22"},
                new Painting() { Title = "Arumové Stonky", Technique = op, Availability = 4800, Abrev = "bn", Size = "67x90"},
                new Painting() { Title = "Pět Zebry", Technique = "Akryl na platně", Availability = s, Abrev = "bo", Size = "180x145"},
                new Painting() { Title = "Popínavá Rostlina", Technique = "Akvarel", Availability = 600, Abrev = "bp", Size = u},
                new Painting() { Title = "Banány", Technique = od, Availability = s, Abrev = "bq", Size = "70x80"},
                new Painting() { Title = "Sopka na Jaře", Technique = op, Availability = s, Abrev = "br", Size = "150x115"},
                new Painting() { Title = "Galanthus", Technique = op, Availability = s, Abrev = "bs", Size = "60x25"},
                new Painting() { Title = "Banány", Technique = "Akvarely", Availability = 600, Abrev = "bu", Size = u},
                new Painting() { Title = "Hrušky", Technique = op, Availability = s, Abrev = "bw", Size = "30x30"},
                new Painting() { Title = "Bunda", Technique = op, Availability = s, Abrev = "bx", Size = "65x125"},
                new Painting() { Title = "Držicí Ruce", Technique = od, Availability = s, Abrev = "by", Size = "244x122"}
            };
            return View("_Paintings", Painting);
        }
        // GET: Interiery
        public ActionResult Interiery()
        {
            List<Image> image = new List<Image>()
            {
                new Image() { Title = "Šedý Les", Abrev = "bsg", Length = "1 den"},
                new Image() { Title = "Přísady", Abrev = "rp", Length = "1 den"},
                new Image() { Title = "Skřítci", Abrev = "bg", Length = "½ den"},
                new Image() { Title = "Mořská Krajina", Abrev = "cp", Length = "8 dnů"},
                new Image() { Title = "Malování Nabýtku", Abrev = "mdm", Length = "1 den"},
                new Image() { Title = "Palma", Abrev = "pt", Length = "1 den"},
                new Image() { Title = "Španělský Flamenco", Abrev = "f", Length = "2 dny"},
                new Image() { Title = "Bambus", Abrev = "boo", Length = "1 den"},
                new Image() { Title = "Oranžová Kuchyň", Abrev = "ln", Length = "2 dny"},
                new Image() { Title = "Vítaní Stromy", Abrev = "ap", Length = "1 den"},
                new Image() { Title = "Dřevěná Lednička", Abrev = "r", Length = "2 dny"},
                new Image() { Title = "Žena s Červeným Svetrem", Abrev = "sr", Length = "2 dny"},
                new Image() { Title = "Mezinárodní Laska", Abrev = "fr", Length = "1 den"},
                new Image() { Title = "BBQ", Abrev = "rv", Length = "1 den"},
                new Image() { Title = "Teplá Teraza", Abrev = "pp", Length = "1 den"},
                new Image() { Title = "V Pekárně", Abrev = "mcb", Length = "2 dny"},
                new Image() { Title = "Loď", Abrev = "vro", Length = "1 den"},
                new Image() { Title = "Nizozemská Teraza", Abrev = "h", Length = "1 den"},
                new Image() { Title = "Kuchyně pro Dobrého Kuchaře", Abrev = "cco", Length = "1 den"},
            };
            return View("_Class", image);
        }
        // GET: Verejnost
        public ActionResult Verejnost()
        {
            List<Image> image = new List<Image>()
            {
                new Image() { Title = "Carolo", Abrev = "ca", Length = "7 dnů" },
                new Image() { Title = "Katamaran", Abrev = "fc", Length = "10 dnů" },
                new Image() { Title = "Dupuis", Abrev = "du", Length = "4 dny" },
                new Image() { Title = "Fishmart Revolución", Abrev = "fr", Length = "4 dny" },
                new Image() { Title = "Lamborghini", Abrev = "l", Length = "5 dnů" },
                new Image() { Title = "Fishmart Polanco", Abrev = "ec", Length = "5 dnů" },
                new Image() { Title = "La Vie En Rose", Abrev = "pa", Length = "7 dnů" },
                new Image() { Title = "Zmrzlina Gourmet", Abrev = "hg", Length = "8 dnů" },
                new Image() { Title = "Kiwi", Abrev = "k", Length = "3 dny" },
                new Image() { Title = "Fishmart Bar", Abrev = "fn", Length = "4 dny" },
                new Image() { Title = "Školka", Abrev = "lu", Length = "3 dny" },
                new Image() { Title = "Relax", Abrev = "ma", Length = "3 dny" },
                new Image() { Title = "Carolo Carso", Abrev = "cc", Length = "7 dnů" },
                new Image() { Title = "Villahermosa", Abrev = "ov", Length = "11 dnů" },
            };
            return View("_Class", image);
        }
        // GET: Milost
        public ActionResult Milost()
        {
            List<Image> image = new List<Image>()
            {
                new Image() { Title = "Dětská Malba", Abrev = "act"},
                new Image() { Title = "Dětský Domov 'Radost'", Abrev = "cha" },
                new Image() { Title = "Dětský Domov 'Colima'", Abrev = "chc" },
                new Image() { Title = "Dětský Domov v Pueblě I", Abrev = "chp" },
                new Image() { Title = "Dětský Domov v Pueblě II", Abrev = "chpn" },
                new Image() { Title = "Lev", Abrev = "l" },
                new Image() { Title = "Biblická Škola v Nottinghamu", Abrev = "ebn" },
            };
            return View("_Class", image);
        }
        // GET: Libuska. Order is : 0-Libuse, 1-Kontakt, 2-Ceny, 3-ChciMalbu, 4-Milost;
        public ActionResult Libuse()
        {
            Info Information = new Info() { Number = 0, Lang = 0, Text = "Vždy mě bavilo malovat. Už od malička. V zemi, kde jsem vyrůstala, v Mexiku, není velkým zvykem studovat umění, proto jsem se nakonec rozhodla studovat design, po studiu jsem se vdala a měla děti. Když jsme se jednou přestěhovali do velkého domu, do opravdu ohromného domu, že jsme neměli dostatek nábytku, aby dům vypadal alespoň trochu útulně, vypadal strašně prázdně. A tak mě napadlo vymalovat stěny. Začala jsem v dětském pokoji, namalovala jsem barevný prales, s jezerem, stromy, kačkami, s krokodýly a opicemi a skákajícími žábami a poletujícími ptáčky. Děti byly ohromeny! Naučily se také mnohem rychleji čísla a barvičky než ostatní děti stejného věku. Jednoho dne moje kamarádka zavítala do dětského pokoje, spatřila namalovanou krajinu a strašně se ji líbila. Řekla mi: “Namaluj mi úplně stejnou stěnu, identickou, v pokoji s hračkami pro moje děti.” Na její zeď jsem namalovala ještě víly a kytičky, protože má ještě jednu dceru. Byly jsme velké kamarádky a jsem moc ráda, že jsem mohla namalovat stěnu právě ji. O něco později, jedna její kamarádka, kterou jsem já neznala, během návštěvy uviděla namalovanou stěnu a chtěla ji hned také pro své děti, tentokrát pro mne už placenou. Moje kamarádka mi ihned zavolala a domluvily jsme se na namalování stěny pro její kamarádku. Od té doby mi začali volat ze všech možných míst, už ne kvůli pokojíčkům pro děti, ale z restaurací, kanceláří apod. A tak jednoduše začala “živá stěna”. Proměnila jsem je ve vlastní “podnikání”, vymyslela jméno a založila internetovou stránku, v Mexiku, před 15 lety. Reklama přišla sama, vždy na doporučení přes známé. V roce 2014, když jsme jednou poklidně debatovali s manželem, jsem obdržela telefonát z Velvyslanectví České republiky v Mexiku, aby nás informovali, že byl schválen nový občanský zákoník, který dovoloval vnukům českých emigrantů získat české státní občanství. Vždycky je nějaké zajímavé překvapení u nás v rodině! Abych zkrátila rodinou historii, můj děda se přestěhoval do Mexika, kde se oženil, měl děti, a jeden z jeho synů je můj milovaný táta  To vysvětluje moje typicky české jméno. Zažádali jsme tedy o české občanství a minulý rok jsme se sem přestěhovali, už jako čeští občané a pomalu ale jistě se učíme tak složitý jazyk. Teď jsou naši synové ještě mladí, jeden studuje Gymnázium a druhý brzy začne studovat umění. Byli jsme zde přijati neuvěřitelně vřele, což nám moc pomohlo rychleji si zvyknout a poznat tuto naprosto odlišnou a pro nás úplně novou kulturu. Česká republika nás fascinuje! Milujeme procházky podél Vltavy a chodit po horách, kde jsou tak skvěle označené stezky, jist svíčkovou a párek v rohlíku. Ohromilo nás střídání čtyř ročních období a chladné zimy. Užíváme si učit se novou řeč a být tak snadno a rychle v centru tak nádherné země, často trávíme odpoledne v krásné Praze. Nyní se vracím k tomu, co mě vždy bavilo a uspokojovalo takovou dobu: MALOVÁNÍ." };
            return View("_Info" , Information);
        }
        // GET: Kontakt
        public ActionResult Kontakt()
        {
            Info Information = new Info() { Number = 1, Lang = 0, Text = "Libuše Smutná (Mluvím anglicky, španělsky, a česky se ještě učím). Pokud máš zájem o nástěnnou malbu nebo obraz, kontaktuj mě na:" };
            return View("_Info", Information);
        }
        // GET: Ceny 
        public ActionResult Ceny()
        {
            Info Information = new Info() { Number = 2, Lang = 0, Text = "Cena záleží na čase malby. Pro dětské pokoje a menší projekty je cena 3 000,- Kč za den, tedy za 8 hodin práce. Pro veřejné prostory a vetší projekty je cena 5 000 Kč za den, za 8 hodin práce, a to z toho důvodu, že započítávám čas, který musím věnovat vypracování plánu, návrhu. Pro budovy nebo místa se stěnami vyššími, než je druhé patro upřednostňuji udělat osobní návrh ceny, kvůli vyhodnocení bezpečnosti při malbě z důvodu velké výšky. Cena je od hodiny, protože se často stávalo, že po odsouhlaseni plánu malby stěny a rozpočtu si zadavatel přál nějaký detail navíc, něco dokreslit, ale nechtěli se ptát, protože to nebylo zahrnuto v plánu a ceně a já jsem nakonec končila malby později, než bylo plánované. Cena za hodinu tento problém úplně vyřešila." };
            return View("_Info", Information);
        }
        // GET: ChciMalbu
        public ActionResult ChciMalbu()
        {
            Info Information = new Info() { Number = 3, Lang = 0, Text = "Malované stěny jsou velmi osobní záležitostí, nejedná se o sériovou výrobu. Mou náplní práce je perfektně porozumět všem detailům a smyslu malované stěny tak, abych dokázala uspokojit, o co mě zájemce o stěnu žádá. Není to jenom o malování, ale o vytvoření prostředí, vytvoření nového prostou, který motivuje, který Vás bude lákat být tam, který si užijete. Toho lze ale dosáhnout jen s osobním přístupem. Můžete mě kontaktovat nejdříve telefonicky, říct, jaké téma malované stěny si přejete, velikost a samozřejmě také adresu. Na základě těchto informací Vám budu moci sdělit předběžnou cenu malby. Pokud se jedná o malbu v domě nebo o malý projekt, přijedu s kufříkem s barvami a po prostudování prostoru začnu s náčrtem na papír a také s pokládáním ochrany na nábytek a pokrývat podlahy. Nejprve nakreslím linie a poté začnu malovat barvami. Používám akrylové barvy, které rychle schnou a jsou velmi odolné. Nezapáchají a místnost lze nadále normálně používat. Barvy lze použít na jakýkoliv povrch zdi. Malování živé stěny v domě, v případě dětských pokojů obvykle trvá 1–3 dny, podle projektu a velikosti místnosti. V případě restaurace nebo jiného většího projektu je to podobné, jen je to o něco pomalejší. Kromě času, který trvá samotné naplánování většího projektu, je náčrt a návrh malby mnohem detailnější a je potřeba navštívit místo několik dní před samotnou malbou za účelem nastudování prostoru a získání přesných rozměrů. I v tomto případě používám akrylové barvy. Veřejné místo může být také dále používané skoro stejně jako během běžného provozu. Ze zkušenosti vím, že malování návštěvníkům nevadí, naopak malování poutá jejich pozornost, i když je samozřejmě jednodušší, když malování stěn probíhá při stavbě, rekonstrukci prostoru." };
            return View("_Info", Information);
        }
        // GET: Milosti
        public ActionResult Milosti()
        {
            Info Information = new Info() { Number = 4, Lang = 0, Text = "Jedno mexické přísloví říká: 'Co jste přijali zadarmo, zadarmo darujte'. To je přesně to, co pro mne znamená malování: dar. Navzdory tomu, že se jedná o mou práci, která mě fascinuje a že jsem se účastnila několika seminářů o umění, je pro mne umění darovaným talentem. Není to něco, co by vyžadovalo výjimečné úsilí nebo něco s čím bojuji, abych dosáhla výsledku, je to něco, s čím jsem se narodila, já osobně jsem umění pouze objevila na své cestě. Je to darem od Boha, zadarmo. A tak by samotný talent neměl být jen pro mě, měl by být sdílen se všemi, znásoben a vyzdvihnout jméno boží. Pokud máte zájem o živou stěnu v rámci nějakého dobročinného projektu (nemocnice, dětský domov, domov důchodců, uprchlíci, rehabilitační zařízení atd.) nebo jakéhokoliv dalšího zařízení nebo aktivity, která pomáhá rozšířit Boží království, moc ráda jej podpořím a budu jeho součástí a daruji tak dar, který mi byl s takovou láskou dán." };
            return View("_Info", Information);
        }
    }
}