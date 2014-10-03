using DesignPatternsDemonstrationMVC_APP.pattern_classes.BuilderPattern.Builder;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.BuilderPattern.ConcreteBuilder
{
    // Concrete class extends bike interface.
    // This class must have methods declared in interface whitch class implements
    public class ScooterBuilder : IBikeBuilder
    {
        private Bike _bike;

        public ScooterBuilder() 
        {
            _bike = new Bike("Scooter");
        }

        public void BuildEngine() 
        {
            _bike.Engine = "Some dummy engine";
        }

        public void Buildbody() 
        {
            _bike.Body = "Some dummy body";
        }

        public Bike GetBike() 
        {
            return _bike;
        }
    }
}