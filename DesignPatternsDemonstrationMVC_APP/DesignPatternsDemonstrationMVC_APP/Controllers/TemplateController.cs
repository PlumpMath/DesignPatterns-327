using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.TemplatePattern;

namespace DesignPatternsDemonstrationMVC_APP.Controllers
{
    public class TemplateController : Controller
    {
        // GET: Template
        public ActionResult Index()
        {
            Pizza pz = new VegiePizza();

            pz.MakePizza();

            


            return View();
        }
    }
}