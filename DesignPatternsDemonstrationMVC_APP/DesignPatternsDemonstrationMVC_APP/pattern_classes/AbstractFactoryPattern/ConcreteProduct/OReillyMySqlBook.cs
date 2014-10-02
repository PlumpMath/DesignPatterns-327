using DesignPatternsDemonstrationMVC_APP.pattern_classes.AbstractFactoryPattern.AbastractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.AbstractFactoryPattern.ConcreteProduct
{
    public class OReillyMySqlBook : MySqlBook
    {
        public OReillyMySqlBook() 
        {
            base.author = "OReillyMySqlBook";
            base.title = "OReillyMSqlBook";
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