using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using beta.Models;
using System.Web.Mvc;

namespace beta.Controllers
{
    public class DetiController : Controller
    {
        // GET: An
        public ActionResult An()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 7, Abrev = "an", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: A
        public ActionResult A()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 3, Abrev = "a", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Ss
        public ActionResult Ss()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 2, Abrev = "ss", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: D
        public ActionResult D()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 5, Abrev = "d", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Chm
        public ActionResult Chm()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "chm", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Ch
        public ActionResult Ch()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "ch", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Chp
        public ActionResult Chp()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 5, Abrev = "chp", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Cj
        public ActionResult Cj()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 6, Abrev = "cj", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: C
        public ActionResult C()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 3, Abrev = "c", Family = 0 };
            return View("_SubClass", SubClass);
        }
        /*// GET: Dfp
        public ActionResult Dfp()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = Df ? , Abrev = "dfp", Family = 0 };
            return View("_SubClass", SubClass);
        }*/
        // GET: Di
        public ActionResult Di()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 2, Abrev = "di", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Dm
        public ActionResult Dm()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 3, Abrev = "dm", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Bm
        public ActionResult Bm()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 6, Abrev = "bm", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Dsf
        public ActionResult Dsf()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 2, Abrev = "dsf", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Ds
        public ActionResult Ds()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "ds", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Euv
        public ActionResult Euv()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 6, Abrev = "euv", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Fr
        public ActionResult Fr()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 3, Abrev = "fr", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Fu
        public ActionResult Fu()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 3, Abrev = "fu", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Pd
        public ActionResult Pd()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 6, Abrev = "pd", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: G
        public ActionResult G()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 2, Abrev = "g", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: H
        public ActionResult H()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 3, Abrev = "h", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Hr
        public ActionResult Hr()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "hr", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Hv
        public ActionResult Hv()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 7, Abrev = "hv", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: J
        public ActionResult J()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 7, Abrev = "j", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Js
        public ActionResult Js()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "js", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: K
        public ActionResult K()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "k", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Ly
        public ActionResult Ly()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 3, Abrev = "ly", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Mdt
        public ActionResult Mdt()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 3, Abrev = "mdt", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Ps
        public ActionResult Ps()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 6, Abrev = "ps", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Nd
        public ActionResult Nd()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 3, Abrev = "nd", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Ot
        public ActionResult Ot()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 3, Abrev = "ot", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Ga
        public ActionResult Ga()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "ga", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: P
        public ActionResult P()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 3, Abrev = "p", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Pf
        public ActionResult Pf()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "pf", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Psf
        public ActionResult Psf()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "psf", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Mv
        public ActionResult Mv()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "mv", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Pu
        public ActionResult Pu()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 3, Abrev = "pu", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Rz
        public ActionResult Rz()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 6, Abrev = "rz", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Sw
        public ActionResult Sw()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 5, Abrev = "sw", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Soc
        public ActionResult Soc()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 2, Abrev = "soc", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: S
        public ActionResult S()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 6, Abrev = "s", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: As
        public ActionResult As()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 5, Abrev = "as", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Sv
        public ActionResult Sv()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 8, Abrev = "sv", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Sf
        public ActionResult Sf()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "sf", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Tda
        public ActionResult Tda()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 6, Abrev = "tda", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Tra
        public ActionResult Tra()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 5, Abrev = "tra", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Vel
        public ActionResult Vel()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "vel", Family = 0 };
            return View("_SubClass", SubClass);
        }
        // GET: Wp
        public ActionResult Wp()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 5, Abrev = "wp", Family = 0 };
            return View("_SubClass", SubClass);
        }
    }
}