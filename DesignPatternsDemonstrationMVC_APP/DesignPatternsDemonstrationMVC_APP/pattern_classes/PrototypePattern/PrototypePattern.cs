using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.PrototypePattern
{

    public interface Laptop
    {
        Laptop GetCopy();
        string GetName();
    }

    public class LenovoLaptop : Laptop
    {
        public string name = "Lenovo";

        public string GetName()
        {
            return name;
        }

        public Laptop GetCopy() 
        {
            return (Laptop)this.MemberwiseClone();
        } 
    }

    public class MacLaptop : Laptop
    {
        public string name = "Mac";

        public string GetName()
        {
            return name;
        }

        public Laptop GetCopy()
        {
            return (Laptop)this.MemberwiseClone();
        }

    }
}