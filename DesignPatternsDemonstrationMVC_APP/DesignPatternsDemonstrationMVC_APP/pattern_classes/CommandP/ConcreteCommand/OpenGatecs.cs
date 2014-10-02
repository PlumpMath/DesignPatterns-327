using DesignPatternsDemonstrationMVC_APP.pattern_classes.CommandP.AbastractComand;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.CommandP.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.CommandP.ConcreteCommand
{
    public class OpenGatecs : ICommand
    {
        private Gate _gate = Gate.Instance();

        public void Execute() 
        {
            if (!_gate.open) 
            {
                _gate.OpenGate();
            }
        }
    }
}