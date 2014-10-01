using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.AdapterPattern.adapter;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.AdapterPattern.adaptee;

namespace DesignPatternsDemonstrationMVC_APP.Controllers
{
    public class AdapterController : Controller
    {
        // GET: Adapter
        public ActionResult Index()
        {

            ArrayCollAdaptee<string> array = new ArrayCollAdaptee<string>();
            array.AddItemtoCollection("Item 1");
            array.AddItemtoCollection("Item 2");



            ConverterAdapter<string> convertor = new ConverterAdapter<string>(array);

            List<string> listOfStrings = convertor.Convert();

            return View();
        }
    }
}