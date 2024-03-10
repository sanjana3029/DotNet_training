using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class LambdaQueries1
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int> { 4, 5, 7, 8, 9, 6 };
            //Console.WriteLine("Sq of list is greater than 20: ");

            var sq = li.Select(n => (num: n, Square: n * n))
                .Where(s => s.Square > 20)
                .ToList();

            Console.WriteLine("sq of numbers greater than 20 : ");
            foreach (var s in sq)
            {
                Console.WriteLine($"{s.num} -Square: {s.Square}");
            }
            Console.WriteLine();
            Console.Read();
        }

    }
}
