using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.strategy;

namespace DesignPatternsDemonstrationMVC_APP.Controllers
{
    public class StrategyController : Controller
    {
        // GET: Strategy
        public ActionResult Index()
        {

            Person person = new Person();

            Ilunch lunch = null;

            var date = new DateTime();

            switch (date.DayOfWeek.ToString())
            {
                case "Monday":
                    lunch = new Cheese();
                    break;
                default:
                    lunch = new Pizza();
                    break;
            }


            // person will have pizza or cheese for lunch depends of the day in week.
            // person eat pizza every day but Monday.
            person.ChangeLunch(lunch);
        

            return View();
        }
    }
}