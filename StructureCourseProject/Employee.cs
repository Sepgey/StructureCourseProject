using System;
using System.Collections.Generic;
using System.Text;

namespace StructureCourseProject
{
   public class Employee
    {
        string Name { get; set; }
        string LastName { get; set; }
        int Age { get; set; }

        public Employee(string _Name, string _LastName, int _Age)
        {
            Name = _Name;
            LastName = _LastName;
            Age = _Age;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Name + " " + LastName + " " + Age );
        }
    }
}
