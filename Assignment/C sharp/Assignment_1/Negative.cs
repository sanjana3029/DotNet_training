using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_test
{
    class Negative
    {
        public void Check()
        {
            int num1;
            Console.WriteLine("enter a value: ");
            num1 = int.Parse(Console.ReadLine());
            if (num1 < 0)
            {
                Console.WriteLine("negavite");

            }
            else
            {
                Console.WriteLine("positive");
            }
            Console.ReadLine();

        }
    }
}
