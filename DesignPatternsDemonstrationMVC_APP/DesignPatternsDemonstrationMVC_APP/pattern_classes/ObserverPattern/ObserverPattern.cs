using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.ObserverPattern
{
    
    public interface IEmployee
    {
        void Notify();
    }

    public class DepartmentManager : IEmployee
    {
       
        public void Notify()
        {
            Console.WriteLine("Department manager is informed about change");
        }


    }

    public class Developer : IEmployee 
    {
        public void Notify()
        {
            Console.WriteLine("Developer is informed about change");
        }
    }



    public class Company 
    {
        private List<IEmployee> employeeList = new List<IEmployee>();

        public void AddEmploy(IEmployee emp) 
        {
            employeeList.Add(emp);
        }

        public void RemoveEmploye(IEmployee emp) 
        {
            employeeList.Remove(emp);
        }

        public void NotifyManagers() 
        {
            foreach(var employee in employeeList)
            {
                if(employee.GetType() == typeof(DepartmentManager))
                {
                    employee.Notify();
                }
            }
        }

        public void NotifyDevelopers()
        {
            foreach (var employee in employeeList)
            {
                if (employee.GetType() == typeof(Developer))
                {
                    employee.Notify();
                }
            }
        }

        public void NotifyAll()
        {
            foreach (var employee in employeeList)
            {
                 employee.Notify();
            }
        }


    }


}