using DesignPatternsDemonstrationMVC_APP.pattern_classes.DecorationPatt;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.DecorationPatt.ConcreteComponent;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.DecorationPatt.ConcreteDecoratorB;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.DecorationPattern.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignPatternsDemonstrationMVC_APP.Controllers
{
    public class DecorationController : Controller
    {
        // GET: Decoration
        public ActionResult Index()
        {

            
            Pancake pancake = new DesertPanCake();

            pancake = new CherryCream(pancake);

            var cost2 = pancake.Cost();

            LunchPanCake pancake2 = new LunchPanCake();

            pancake2 = new Onion(pancake2);

            var cost3 = pancake2.Cost();


            
            return View();
        }
    }
}