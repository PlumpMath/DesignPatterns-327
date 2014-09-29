using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.PrototypePattern;

namespace DesignPatternsDemonstrationMVC_APP.Controllers
{
    public class PrototypeController : Controller
    {
        // GET: Prototype
        public ActionResult Index()
        {

            Laptop laptop = new MacLaptop();

            // laptop2 is a clone of laptop, it become a new object and it got it's own place in memory.
            Laptop laptop2 = laptop.GetCopy();


            return View();
        }
    }
}