using DesignPatternsDemonstrationMVC_APP.pattern_classes.AbstractFactoryPattern.AbastractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.AbstractFactoryPattern.ConcreteProduct
{
    public class OReillyPhpBook : PhpBook
    {
        public OReillyPhpBook() 
        {
            base.author = "OReilly Php book autor";
            base.title = "OReilly php autor";
        }

        public override string GetAuthor()
        {
            return author;
        }

        public override string GetTitle()
        {
            return title;
        }
    }
}