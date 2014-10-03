using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.BuilderPattern.Product
{
    public class Bike
    {
        private string _name;
        private string _engine;
        private string _body;

        public Bike(string name)
        {
            _name = name;
        }

        public string GetBikeName
        {
            get { return _name; }
        }

        public string Engine 
        {
            get { return _engine; }
            set { _engine = value; }
        }

        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }

    }
}