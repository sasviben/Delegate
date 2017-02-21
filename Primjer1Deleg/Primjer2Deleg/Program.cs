using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjer2Deleg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Mark", Salary = 3000, Experinece = 3 });
            empList.Add(new Employee() { ID = 101, Name = "Sandro", Salary = 5000, Experinece = 5 });
            empList.Add(new Employee() { ID = 101, Name = "Filip", Salary = 4000, Experinece = 4 });
            empList.Add(new Employee() { ID = 101, Name = "Hrvoje", Salary = 7000, Experinece = 7 });

            Employee.PromotedEmployee(empList);
        }
    }
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experinece { get; set; }

        public static void PromotedEmployee(List<Employee> employeeList)
        {
            foreach(Employee emp in employeeList)
            {
                if(emp.Experinece >= 5)
                {
                    Console.WriteLine(emp.Name + " promoted");
                }
            }
        }
    }
}
