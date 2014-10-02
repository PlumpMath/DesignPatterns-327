using DesignPatternsDemonstrationMVC_APP.pattern_classes.AbstractFactoryPattern.AbastractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.AbstractFactoryPattern.ConcreteProduct
{
    public class SamsPhpBook : PhpBook
    {
        public SamsPhpBook()
        {
            base.author = "Autor sams php knjige.";
            base.title = "Naslov sams php knjige.";
        }

        public override string GetAuthor() 
        {
            return base.author;
        }

        public override string GetTitle()
        {
            return base.title;
        }
    }
}