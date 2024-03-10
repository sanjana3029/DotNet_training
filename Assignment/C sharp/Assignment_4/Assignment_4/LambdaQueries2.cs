using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class LambdaQueries2
    {
        static void Main()
        {
            List<string> words = new List<string> { "atom", "bloom", "fire", "adam", "amsterdam" };

            var wd = words.Where(word => word.StartsWith("a", StringComparison.OrdinalIgnoreCase)
            && word.EndsWith("m", StringComparison.OrdinalIgnoreCase))
                .ToList();

            Console.WriteLine("words start with 'a' n end with 'm' : ");

            foreach (var word in wd)
            {
                Console.WriteLine(word);

            }

            Console.Read();

        }

    }
}
