using DesignPatternsDemonstrationMVC_APP.pattern_classes.CommandP.AbastractComand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.CommandP.Invoker
{
    public class Remote
    {
        private static IList<ICommand> turnOnComands = new List<ICommand>();
        private static IList<ICommand> turnOffComands = new List<ICommand>();

        public static void InsertOnCommand(ICommand command) 
        {
            turnOnComands.Add(command);
        }


        public static void InsertOffCommand(ICommand command)
        {
            turnOffComands.Add(command);
        }


        public static void PressButtonOn(int buttonNumber) 
        {
            turnOnComands[buttonNumber].Execute();
        }

        public static void PressButtonOff(int buttonNumber) 
        {
            turnOffComands[buttonNumber].Execute();
        }

    }
}