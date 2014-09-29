using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.FactoryMethod
{
    public interface Laptop
    {
        string GetName();
    }

    public class LenovoLaptop : Laptop 
    {
        public string name = "Lenovo";

        public string GetName() 
        {
            return name;
        }
    }

    public class MacLaptop : Laptop 
    {
        public string name = "Mac";

        public string GetName()
        {
            return name;
        }
    }

    public enum LaptopType
    {
        LENOVO,
        MAC
    }

    public class Laptopfactory 
    {
        public static Laptop CreateLaptop(LaptopType type)
        {
            Laptop laptop = null;

            switch(type)
            {
                case LaptopType.MAC :
                    laptop = new MacLaptop();
                    break;
                case LaptopType.LENOVO:
                    laptop = new LenovoLaptop();
                    break;
                default:
                    break;
            }

            return laptop;
        }
    }

    
}

