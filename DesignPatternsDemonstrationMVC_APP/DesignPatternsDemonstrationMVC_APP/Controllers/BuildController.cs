using DesignPatternsDemonstrationMVC_APP.pattern_classes.BuilderPattern.ConcreteBuilder;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.BuilderPattern.Director;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignPatternsDemonstrationMVC_APP.Controllers
{
    public class BuildController : Controller
    {
        // GET: Build
        public ActionResult Index()
        {

            // create manufacturer
            Manufacturer manufacturer = new Manufacturer();

            // create builder
            ScooterBuilder scb = new ScooterBuilder();

            // creating bike by passing reference of scooter builder
            manufacturer.Construct(scb);

            // Geting the instance of bike, created by Construct method of manufacturer object.
            var b = scb.GetBike();

            return View();
        }
    }
}