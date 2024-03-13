using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Box
    {
        public double Length;
        public double Breadth;


        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public static Box Add(Box b1, Box b2)
        
        {
            double newlen = b1.Length + b2.Length;
            double newbred = b1.Breadth + b2.Breadth;
            return new Box(newlen, newbred);
        }
    }

    class TestBox
    {
        static void Main()
        {
            Console.WriteLine("Enter len of box 1: ");
            double length1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter breadth of box 1: ");
            double breadth1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter len of box 2: ");
            double length2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter breadth of box 2: ");
            double breadth2 = Convert.ToDouble(Console.ReadLine());


            Box b1 = new Box(length1, breadth1);
            Box b2 = new Box(length2, breadth2);
            Box b3 = Box.Add(b1, b2);

            Console.WriteLine($"TOTAL SUM OF BOXES: Length = {b3.Length} and Breadth = {b3.Breadth}");
            Console.Read();


        }
    }
}
