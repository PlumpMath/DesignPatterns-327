using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.SingltonPattern;


namespace DesignPatternsDemonstrationMVC_APP.Controllers
{
    public class SingltonController : Controller
    {
        // GET: Singlton
        public ActionResult Index()
        {


            President pr = President.Instance();
            pr.SetPresidentName("New prezident name");
            pr.SetPresidentAge(44);

            President pr2 = President.Instance();
            pr2.SetPresidentAge(23);

            return View();
        }
    }
}