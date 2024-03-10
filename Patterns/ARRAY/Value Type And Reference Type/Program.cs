using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Type_And_Reference_Type
{
    //struct Employee
    class Employee
    {
        public int Salary;
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.Salary = 50000;

            emp.Age = 18;

            Employee e1 = emp;
            Employee e2 = emp;

            emp.Age = 19;

            Console.WriteLine(e1.Age);
            Console.WriteLine(e2.Age);

            Console.ReadLine();


        }
    }
}
