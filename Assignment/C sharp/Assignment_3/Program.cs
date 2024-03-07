using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Doctor d = new Doctor();
            //d.Doctorinfo(123, "Simran", 500.50);
            //d.Displayinfo();

            Schlorship sch = new Schlorship();

            Console.Write("Enter the Marks: ");
            double marks = double.Parse(Console.ReadLine());

            Console.Write("Enter the Fees: ");
            double fees = double.Parse(Console.ReadLine());

            double amount = sch.Merit(marks, fees);
            Console.WriteLine($"schlorship amount: {amount}");
            Console.Read();

        }
    }
}
