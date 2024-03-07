using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Letter
    {
        static void Main()
        {
            Console.WriteLine("enter a string: ");
            string String = Console.ReadLine();

            Console.WriteLine("enter a letter tp count: ");
            char letter = Console.ReadKey().KeyChar;
            Console.WriteLine();


            int occ = CountOcc(String, letter);
            Console.WriteLine($"Letter : {letter}");
            Console.WriteLine($"LetterCount: {occ}");
            Console.Read();



        }

        public static int CountOcc(string String, char  letter)
        {
            int count = 0;
            foreach(char s in String)
            {
                if (s == letter)
                    count++;
            }

            return count;
        }
    }
}
