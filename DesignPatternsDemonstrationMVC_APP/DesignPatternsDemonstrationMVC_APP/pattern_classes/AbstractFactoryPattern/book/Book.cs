using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.AbstractFactoryPattern.book
{
    public abstract class Book
    {
        protected string author;
        protected string title;

        public abstract string GetAuthor();
        public abstract string GetTitle();
    }
}