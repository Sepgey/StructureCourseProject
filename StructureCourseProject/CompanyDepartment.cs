using System.Collections;
using System.Collections.Generic;

namespace StructureCourseProject
{
    public class CompanyDepartment : IEnumerable<Employee>
    {
        public LinkedList<Employee> employees;

        public CompanyDepartment()
        {
            employees = new LinkedList<Employee>();
        }

        public void AddEmployee(Employee s)
        {
            employees.Add(s);
        }

        public void RemoveEmployee(int id)
        {
            employees.Remove(id);
        }
       
        public bool IsEmptyDepartment()
        {
            return employees.IsEmptyList();
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return employees.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void ShowDepartment()
        {
            foreach (var item in employees)
            {
                item.ShowInfo();
            }
        }
    }
}
