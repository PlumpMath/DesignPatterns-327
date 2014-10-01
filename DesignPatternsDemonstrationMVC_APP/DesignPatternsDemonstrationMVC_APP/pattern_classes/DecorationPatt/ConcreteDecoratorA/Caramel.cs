using DesignPatternsDemonstrationMVC_APP.pattern_classes.DecorationPatt;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.DecorationPatt.ConcreteComponent;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.DecorationPatt.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.DecorationPattern.ConcreteDecorator
{
    public class Caramel : Toping
    {

        public Caramel(DesertPanCake pancake) 
        {
            _panCake = pancake;
        }

        public override double Cost()
        {
            return base.Cost() + 0.30;
        }
    }
}