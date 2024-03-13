using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Employees
    {
        public int Empid;
        public string Empname;
        public float Salary;

        public Employees(int id, string name, float salary)
        {
            Empid = id;
            Empname = name;
            Salary = salary;
        }
            
    }
    class ParttimeEmployee : Employees
    {
        public double wages { get; set; }

        public ParttimeEmployee(int id,string name, float salary, double wage)
           : base(id,name,salary)
        {
            wages = wage;
            Console.WriteLine($"Wages: {wages}");
        }
        

    }
    class Employee
    {
        static void Main()
        {
            Console.WriteLine("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary: ");
            float salary = float.Parse(Console.ReadLine());
            Console.WriteLine("Employee wages:");
            double wages = Convert.ToDouble(Console.ReadLine());

            ParttimeEmployee pt = new ParttimeEmployee(id,name,salary,wages);
            Console.WriteLine($"Employee Id: {pt.Empid}, Employee Name: {pt.Empname}, Employee Salary: {pt.Salary}, Employee Wages: {pt.wages}");
            Console.Read();


        }
    }
}
