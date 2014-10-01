using DesignPatternsDemonstrationMVC_APP.pattern_classes.FacadePattern.facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignPatternsDemonstrationMVC_APP.Controllers
{
    public class FacadeController : Controller
    {
        // GET: Facade
        public ActionResult Index()
        {

            FacadeClass facade = new FacadeClass();

            facade.Tasks1();
            facade.Tasks3();

            return View();
        }
    }
}