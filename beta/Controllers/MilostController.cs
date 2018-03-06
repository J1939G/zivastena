using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using beta.Models;
using System.Web.Mvc;

namespace beta.Controllers
{
    public class MilostController : Controller
    {
        // GET: Act
        public ActionResult Act()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 15, Abrev = "act", Family = 4 };
            return View("_SubClass", SubClass);
        }
        // GET: Cha
        public ActionResult Cha()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 10, Abrev = "cha", Family = 4 };
            return View("_SubClass", SubClass);
        }
        // GET: Chc
        public ActionResult Chc()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 5, Abrev = "chc", Family = 4 };
            return View("_SubClass", SubClass);
        }
        // GET: Chp
        public ActionResult Chp()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 5, Abrev = "chp", Family = 4 };
            return View("_SubClass", SubClass);
        }
        // GET: Chpn
        public ActionResult Chpn()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 3, Abrev = "chpn", Family = 4 };
            return View("_SubClass", SubClass);
        }
        // GET: L
        public ActionResult L()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 6, Abrev = "l", Family = 4 };
            return View("_SubClass", SubClass);
        }
        // GET: Ebn
        public ActionResult Ebn()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 10, Abrev = "ebn", Family = 4 };
            return View("_SubClass", SubClass);
        }
    }
}