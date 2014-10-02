using DesignPatternsDemonstrationMVC_APP.pattern_classes.AbstractFactoryPattern.AbastractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.AbstractFactoryPattern.AbastractFactory
{
    public abstract class BookFactory
    {
        public abstract PhpBook MakePhpBook();
        public abstract MySqlBook MakeMySqlBook();
    }
}