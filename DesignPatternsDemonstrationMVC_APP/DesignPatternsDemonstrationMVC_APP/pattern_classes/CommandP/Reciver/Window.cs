using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.CommandP.Reciver
{
    public class Window
    {
        public bool open = false;

        public void OpenWindow() 
        {
            Console.WriteLine("Open window");
        }

        public void CloseWindow()
        {
            Console.WriteLine("Close window");
        }

        public void OpenHalfWindow() 
        {
            Console.WriteLine("Half window is open");
        }
    }
}