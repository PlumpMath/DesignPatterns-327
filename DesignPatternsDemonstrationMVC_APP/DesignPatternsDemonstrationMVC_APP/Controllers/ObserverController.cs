using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.ObserverPattern;

namespace DesignPatternsDemonstrationMVC_APP.Controllers
{
    public class ObserverController : Controller
    {
        // GET: Observer
        public ActionResult Index()
        {

            Company company = new Company();

            DepartmentManager dm1 = new DepartmentManager();
            DepartmentManager dm2 = new DepartmentManager();

            Developer dev1 = new Developer();
            Developer dev2 = new Developer();

            company.AddEmploy(dm1);
            company.AddEmploy(dm2);
            company.AddEmploy(dev1);
            company.AddEmploy(dev2);

            company.NotifyManagers();




            return View();
        }
    }
}