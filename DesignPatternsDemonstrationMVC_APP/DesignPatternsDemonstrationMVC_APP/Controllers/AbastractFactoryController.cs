using DesignPatternsDemonstrationMVC_APP.pattern_classes.AbstractFactoryPattern.AbastractFactory;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.AbstractFactoryPattern.AbastractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignPatternsDemonstrationMVC_APP.Controllers
{
    public class AbastractFactoryController : Controller
    {
        // GET: AbastractFactory
        public ActionResult Index()
        {

            BookFactory bookFaktory = new OreillyBookFactory();
            BookFactory bookFaktory2 = new SamsBookFactory();
            
            var a = bookFaktory.MakeMySqlBook();

            var b = bookFaktory2.MakePhpBook();

            string title = a.GetTitle();


            return View();
        }
    }
}