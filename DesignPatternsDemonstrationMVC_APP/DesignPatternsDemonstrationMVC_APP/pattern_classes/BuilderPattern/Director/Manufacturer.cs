using DesignPatternsDemonstrationMVC_APP.pattern_classes.BuilderPattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.BuilderPattern.Director
{
    public class Manufacturer
    {
        public void Construct(IBikeBuilder bikeBuilder) 
        {
            bikeBuilder.BuildEngine();
            bikeBuilder.Buildbody();
        }
    }
}