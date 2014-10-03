using DesignPatternsDemonstrationMVC_APP.pattern_classes.BuilderPattern.Builder;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.BuilderPattern.ConcreteBuilder
{
    public class SuperMotoBuilder : IBikeBuilder
    {
        private Bike _bike;
 
        public SuperMotoBuilder() 
        {
            _bike = new Bike("Scooter");
        }

        public void BuildEngine() 
        {
            _bike.Engine = "Some dummy engine for super moto bike";
        }

        public void Buildbody() 
        {
            _bike.Body = "Some dummy body for super moto bike.";
        }

        public Bike GetBike() 
        {
            return _bike;
        }
    }
}