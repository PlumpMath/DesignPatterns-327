using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.strategy
{
    // change strategy in run time

    public interface Ilunch
    {
        string GetFoodName();
    }

    public class Cheese : Ilunch
    {

        string foodName = "Cheese";

        public string GetFoodName()
        {
            return foodName;
        }

    }

    public class Pizza : Ilunch
    {
        string foodName = "Pizza";

        public string GetFoodName()
        {
            return foodName;
        }
    }

    public class Person
    {
        public Ilunch lunch = new Pizza();

        public void ChangeLunch(Ilunch newLunch)
        {
            lunch = newLunch;
        }
    }

    /////////////////////////////////////////////////////////////////////////
    // run time console aplication
    // this is not real console app, just demonstration of main, how run time work with strategy pattern.
    public class ConsoleApp
    {
        public static void Main(string[] args)
        {
            Person person = new Person();

            Ilunch lunch = null;

            var date = new DateTime();

            switch (date.DayOfWeek.ToString())
            {
                case "Monday":
                    lunch = new Cheese();
                    break;
                default:
                    lunch = new Pizza();
                    break;
            }

            person.ChangeLunch(lunch);
        }
    }
    // run time console aplication
    /////////////////////////////////////////////////////////////////////////
}