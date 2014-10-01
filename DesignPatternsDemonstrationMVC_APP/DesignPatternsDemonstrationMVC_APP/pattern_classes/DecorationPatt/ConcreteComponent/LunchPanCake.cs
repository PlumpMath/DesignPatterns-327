using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.DecorationPatt.ConcreteComponent
{
    public class LunchPanCake : Pancake
    {
        public override double Cost()
        {
            return 2.20;
        }
    }
}