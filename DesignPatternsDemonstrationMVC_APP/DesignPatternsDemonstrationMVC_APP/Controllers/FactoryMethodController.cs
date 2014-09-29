using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.FactoryMethod;

namespace DesignPatternsDemonstrationMVC_APP.Controllers
{
    public class FactoryMethodController : Controller
    {
        // GET: FactoryMethod
        public ActionResult Index()
        {
            // creates instance of Mac laptop
            Laptop macLaptop = Laptopfactory.CreateLaptop(LaptopType.MAC);

            // create instance of lenovo laptop
            Laptop LeneovoLaptop = Laptopfactory.CreateLaptop(LaptopType.LENOVO);

            return View();
        }
    }
}