using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
            },
            new Employee
            {
                Id = 2,
            }
        };

        public void AddEmp(Employee emp)
        {
            employees.Add(emp);
        }

        public void RemoveEmp (int id)
        {
            Employee deletedEmployee = employees.FirstOrDefault(x => x.Id == id);
            if (deletedEmployee == null)
            {
                Console.WriteLine("Employee not found.");
                return;
            }
            employees.Remove(deletedEmployee);
            Console.WriteLine($"Employee with id {id} deleted from list.");
        }

        public void GetAll()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.Id);
            }
        }
    }
}
