using DesignPatternsDemonstrationMVC_APP.pattern_classes.BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.BuilderPattern.Builder
{
    // interface for bilding bikes
    // concrete builders must implement these method from interface.
    public interface IBikeBuilder
    {
        void BuildEngine();
        void Buildbody();
        Bike GetBike();
    }
}