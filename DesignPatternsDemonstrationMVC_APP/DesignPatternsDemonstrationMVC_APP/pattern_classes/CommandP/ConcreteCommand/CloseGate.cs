using DesignPatternsDemonstrationMVC_APP.pattern_classes.CommandP.AbastractComand;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.CommandP.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.CommandP.ConcreteCommand
{
    public class CloseGate : ICommand
    {
        private static CloseGate _closeGate = null;

        private Gate _gate = Gate.Instance();

        private CloseGate() { }

        public static CloseGate Instance() 
        {
            if (_closeGate == null) 
            {
                _closeGate = new CloseGate();
            }

            return _closeGate;
        }

        public void Execute() 
        {
            if (IsOpen()) 
            {
                _gate.CloseGate();
            }
        }


        private bool IsOpen()
        {
            return _gate.open;
        }

    }
}