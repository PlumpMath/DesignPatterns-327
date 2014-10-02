using DesignPatternsDemonstrationMVC_APP.pattern_classes.AbstractFactoryPattern.AbastractFactory;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.AbstractFactoryPattern.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.AbstractFactoryPattern.AbastractProduct
{
    public class OreillyBookFactory : BookFactory
    {
        public override PhpBook MakePhpBook()
        {
            return new OReillyPhpBook();
        }

        public override MySqlBook MakeMySqlBook()
        {
            return new OReillyMySqlBook();
        }
    }
}