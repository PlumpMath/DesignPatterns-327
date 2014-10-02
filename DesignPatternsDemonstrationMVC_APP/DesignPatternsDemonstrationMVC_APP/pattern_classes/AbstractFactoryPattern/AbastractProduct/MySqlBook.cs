using DesignPatternsDemonstrationMVC_APP.pattern_classes.AbstractFactoryPattern.book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.AbstractFactoryPattern.AbastractProduct
{
    public abstract class MySqlBook : Book
    {
        private string subject = "MySql";
    }
}