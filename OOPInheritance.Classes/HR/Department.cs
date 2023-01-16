using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Classes.HR
{
   public class Department
    {
        // Aggregation - the employees are part of the department
        // However they will not cease to exist if they are removed from the department
        private List<Employee> _employees = new List<Employee>(); 
        public string Name { get; private set; }

        public Department(string name)
        {
            this.Name = name;
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            _employees.Remove(employee);
        }

    }
}
