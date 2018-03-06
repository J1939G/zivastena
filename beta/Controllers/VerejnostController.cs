using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using beta.Models;
using System.Web.Mvc;

namespace beta.Controllers
{
    public class VerejnostController : Controller
    {
        // GET: Ca
        public ActionResult Ca()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "ca", Family = 3 };
            return View("_SubClass", SubClass);
        }
        // GET: Cc
        public ActionResult Cc()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "cc", Family = 3 };
            return View("_SubClass", SubClass);
        }
        // GET: Du
        public ActionResult Du()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 2, Abrev = "du", Family = 3 };
            return View("_SubClass", SubClass);
        }
        // GET: Ec
        public ActionResult Ec()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "ec", Family = 3 };
            return View("_SubClass", SubClass);
        }
        // GET: Fc
        public ActionResult Fc()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "fc", Family = 3 };
            return View("_SubClass", SubClass);
        }
        // GET: Fr
        public ActionResult Fr()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 3, Abrev = "fr", Family = 3 };
            return View("_SubClass", SubClass);
        }
        // GET: Hg
        public ActionResult Hg()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 2, Abrev = "hg", Family = 3 };
            return View("_SubClass", SubClass);
        }
        // GET: K
        public ActionResult K()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 3, Abrev = "k", Family = 3 };
            return View("_SubClass", SubClass);
        }
        // GET: L
        public ActionResult L()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 3, Abrev = "l", Family = 3 };
            return View("_SubClass", SubClass);
        }
        // GET: Lu
        public ActionResult Lu()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 8, Abrev = "lu", Family = 3 };
            return View("_SubClass", SubClass);
        }
        // GET: Ma
        public ActionResult Ma()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 2, Abrev = "ma", Family = 3 };
            return View("_SubClass", SubClass);
        }
        // GET: Mm
        public ActionResult Mm()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 1, Abrev = "mm", Family = 3 };
            return View("_SubClass", SubClass);
        }
        // GET: Ov
        public ActionResult Ov()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "ov", Family = 3 };
            return View("_SubClass", SubClass);
        }
        // GET: Pa
        public ActionResult Pa()
        {
            SubClass SubClass = new SubClass() { Lang = 0, Count = 4, Abrev = "pa", Family = 3 };
            return View("_SubClass", SubClass);
        }
    }
}