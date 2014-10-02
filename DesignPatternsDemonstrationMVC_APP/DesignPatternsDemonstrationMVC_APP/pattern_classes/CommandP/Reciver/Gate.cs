using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.CommandP.Reciver
{
    public class Gate
    {
        public bool open = false;

        private static Gate _gate = null;


        private Gate() { }



        public static Gate Instance()
        {
            if (_gate == null)
            {
                _gate = new Gate();
            }

            return _gate;
        }

        public void OpenGate() 
        {
            Console.WriteLine("Gate is open");
        }

        public void CloseGate() 
        {
            Console.WriteLine("Gate is closed");
        }
    }
}