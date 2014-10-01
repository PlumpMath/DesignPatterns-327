using DesignPatternsDemonstrationMVC_APP.pattern_classes.DecorationPatt.ConcreteComponent;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.DecorationPatt.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.DecorationPatt.ConcreteDecoratorB
{
    public class Onion : Extras
    {
        public Onion(LunchPanCake pancake)
        {
            _pancake = pancake;
        }

        public override double Cost()
        {
            return base.Cost() + 0.15;
        }
    }
}