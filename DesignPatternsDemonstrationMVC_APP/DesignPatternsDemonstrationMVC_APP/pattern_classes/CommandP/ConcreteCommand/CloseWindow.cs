using DesignPatternsDemonstrationMVC_APP.pattern_classes.CommandP.AbastractComand;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.CommandP.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.CommandP.ConcreteCommand
{
    public class CloseWindow : ICommand
    {

        private Window _window;

        public CloseWindow(Window window) 
        {
            _window = window;
        }

        public void Execute()
        {
            
        }
    }
}