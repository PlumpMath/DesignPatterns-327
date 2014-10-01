using DesignPatternsDemonstrationMVC_APP.pattern_classes.DecorationPatt.ConcreteComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.DecorationPatt.Decorator
{
    public class Extras : LunchPanCake
    {
        protected Pancake _pancake { get; set; }
    }
}