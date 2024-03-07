using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Schlorship
    {
        public double Merit(double marks, double fees)
        {
            double schlorAmount = 0;

            if (marks >= 70 && marks <= 80)
            {
                schlorAmount = 0.2 * fees;
            }

            else if (marks > 80 && marks <= 90)
            {
                schlorAmount = 0.3 * fees;
            }
            else if (marks > 90)
            {
                schlorAmount = 0.5 * fees;
            }

            return schlorAmount;

        }
        static void Main(string[] args)
        {

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

