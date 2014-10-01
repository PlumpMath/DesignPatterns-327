using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.TemplatePattern
{
    public abstract class Pizza
    {
        
        public abstract void MakePizza();

        protected void AddKetchup()
        {
            Console.WriteLine("Ketchup is added on the pizza");
        }

        protected void AddChease() 
        {
            Console.WriteLine("Adding cheese on the pizza");
        }

        protected abstract void AddToping();
    }
}