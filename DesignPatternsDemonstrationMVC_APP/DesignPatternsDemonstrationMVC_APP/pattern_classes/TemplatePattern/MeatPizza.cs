using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.TemplatePattern
{
    public class MeatPizza : Pizza
    {

        public override void MakePizza()
        {
            base.AddKetchup();
            base.AddChease();
            AddToping();
            base.AddKetchup();
            base.AddChease();
        }

        protected override void AddToping()
        {
            Console.WriteLine("Add meat to pizza");
        }

    }
}