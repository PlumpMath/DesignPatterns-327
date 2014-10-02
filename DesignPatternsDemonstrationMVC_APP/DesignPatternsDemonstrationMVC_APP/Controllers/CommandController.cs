using DesignPatternsDemonstrationMVC_APP.pattern_classes.CommandP.ConcreteCommand;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.CommandP.Invoker;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.CommandP.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignPatternsDemonstrationMVC_APP.Controllers
{
    public class CommandController : Controller
    {
        // GET: Command
        public ActionResult Index()
        {

            

            //Remote remote = new Remote();
            
            Window w1 = new Window();
            Window w2 = new Window();
            Window w3 = new Window();

            
            OpenWindow ow = new OpenWindow(w1);



            Remote.InsertOnCommand(ow);

            Remote.InsertOffCommand(CloseGate.Instance());

            Remote.InsertOffCommand(CloseGate.Instance());

            Remote.PressButtonOn(0);

            return View();
        }
    }
}