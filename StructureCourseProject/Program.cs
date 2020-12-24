using System;

namespace StructureCourseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var department = new CompanyDepartment();


            department.AddEmployee(new Employee("Bob", "Franklin", 24));
            department.AddEmployee(new Employee("Mickael", "Jackson", 25));
            department.AddEmployee(new Employee("Steve", "Vashington", 26));
            department.AddEmployee(new Employee("Pol", "MacCartny", 27));
            department.AddEmployee(new Employee("Steve", "Ckoks", 28));

            department.ShowDepartment();
            department.RemoveEmployee(3);
            Console.WriteLine("\n");
            department.ShowDepartment();
        }
    }
}