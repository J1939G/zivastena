using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using beta.Models;
using System.Web.Mvc;

namespace beta.Controllers
{
    public class InterioresController : Controller
    {
        // GET: Ln
        public ActionResult Ln()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 3, Abrev = "ln", Family = 1 };
            return View("_SubClass", SubClass);
        }
        // GET: Cco
        public ActionResult Cco()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 3, Abrev = "cco", Family = 1 };
            return View("_SubClass", SubClass);
        }
        // GET: Mcb
        public ActionResult Mcb()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 3, Abrev = "mcb", Family = 1 };
            return View("_SubClass", SubClass);
        }
        /*// GET: Rv !SURE
        public ActionResult Rv()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = Sure ? , Abrev = "rv", Family = 1 };
            return View("_SubClass", SubClass);
        }*/
        // GET: Mdm
        public ActionResult Mdm()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 3, Abrev = "mdm", Family = 1 };
            return View("_SubClass", SubClass);
        }
        // GET: Rp
        public ActionResult Rp()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 4, Abrev = "rp", Family = 1 };
            return View("_SubClass", SubClass);
        }
        // GET: R
        public ActionResult R()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 2, Abrev = "r", Family = 1 };
            return View("_SubClass", SubClass);
        }
        // GET: Bsg
        public ActionResult Bsg()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 3, Abrev = "bsg", Family = 1 };
            return View("_SubClass", SubClass);
        }
        // GET: Sr
        public ActionResult Sr()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 2, Abrev = "sr", Family = 1 };
            return View("_SubClass", SubClass);
        }
        // GET: Ap
        public ActionResult Ap()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 3, Abrev = "ap", Family = 1 };
            return View("_SubClass", SubClass);
        }
        // GET: H
        public ActionResult H()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 4, Abrev = "h", Family = 1 };
            return View("_SubClass", SubClass);
        }
        // GET: Pp
        public ActionResult Pp()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 2, Abrev = "pp", Family = 1 };
            return View("_SubClass", SubClass);
        }
        // GET: Pt
        public ActionResult Pt()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 4, Abrev = "pt", Family = 1 };
            return View("_SubClass", SubClass);
        }
        // GET: Bg
        public ActionResult Bg()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 3, Abrev = "bg", Family = 1 };
            return View("_SubClass", SubClass);
        }
        // GET: Boo
        public ActionResult Boo()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 3, Abrev = "boo", Family = 1 };
            return View("_SubClass", SubClass);
        }
        // GET: Vro
        public ActionResult Vro()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 3, Abrev = "vro", Family = 1 };
            return View("_SubClass", SubClass);
        }
        // GET: Fr
        public ActionResult Fr()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 3, Abrev = "fr", Family = 1 };
            return View("_SubClass", SubClass);
        }
        // GET: Cp
        public ActionResult Cp()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 5, Abrev = "cp", Family = 1 };
            return View("_SubClass", SubClass);
        }
        // GET: F
        public ActionResult F()
        {
            SubClass SubClass = new SubClass() { Lang = 2, Count = 3, Abrev = "f", Family = 1 };
            return View("_SubClass", SubClass);
        }
    }
}