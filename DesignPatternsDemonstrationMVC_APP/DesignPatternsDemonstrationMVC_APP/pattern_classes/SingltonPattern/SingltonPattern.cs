using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.SingltonPattern
{


    public class President
    {
        public string name;
        public int age;

        private static President president = null;



        private President(){}

        public static President Instance()
        {
            if (president == null) 
            {
                president = new President();
            }
            return president;
        }

        public void SetPresidentName(string newName) 
        {
            president.name = newName;
        }

        public void SetPresidentAge(int newAge) 
        {
            president.age = newAge;
        }

        public string GetPresidentName() 
        {
            return president.name;
        }

    }


}