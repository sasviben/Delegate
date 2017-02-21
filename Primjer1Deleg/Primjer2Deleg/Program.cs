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
            //lambda izraz
           Employee.PromotedEmployee(empList,emp => emp.Experinece >= 5);
        }
        //logika za IsEligibleToPromote u if izrazu unutar klase Employee
       
    }
    //odnosi se na if uvijet
    delegate bool IsPromotable(Employee empl);

    //TODO promjena hardkodirane logike u if uvijetu u prilagodnjivu logiku pomocu delegata
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experinece { get; set; }

        public static void PromotedEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)//funkcija prima listu i funkciju kao parametre, tj pokazivac 
        {
            foreach(Employee emp in employeeList)
            {
                //IsEligibleToPromote vraća bool izraz, treba napraviti logiku od IsEligibleToPromote->user ju implementira
                if (IsEligibleToPromote(emp))//delegate IsPromotable
                {
                    Console.WriteLine(emp.Name + " promoted");
                }
            }
        }
    }
}
