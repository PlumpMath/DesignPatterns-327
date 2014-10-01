using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.TemplatePattern
{
    public class VegiePizza : Pizza
    {
        public override void MakePizza()
        {
            base.AddChease();
            base.AddKetchup();
            AddToping();
            base.AddKetchup();
            base.AddChease();
        }

        protected override void AddToping()
        {
            Console.WriteLine("add veggies to pizza to pizza");
        }
    }
}