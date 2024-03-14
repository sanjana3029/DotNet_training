using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    class Delegates
    {
        delegate int Calculator(int p, int q);

        class Program
        {
            static int Addition(int p, int q)
            {
                return p + q;
            }

            static int Subtraction(int p, int q)
            {
                return p - q;
            }

            static int Multiplication(int p, int q)
            {
                return p * q;
            }

            static void Main()
            {
                Calculator add = Addition;
                Calculator sub = Subtraction;
                Calculator mul = Multiplication;

                Console.Write("Enter 1st integer: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("Enter 2nd integer: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Addition: {n1} + {n2} = {add(n1, n2)}");
                Console.WriteLine($"Subtraction: {n1} - {n2} = {sub(n1, n2)}");
                Console.WriteLine($"Multiplication: {n1} * {n2} = {mul(n1, n2)}");

                Console.Read();
            }
        }
    }
}
