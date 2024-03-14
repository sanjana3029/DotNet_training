using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment_3
{
    class Append
    {
        static void Main()
        {
            string fileName = "Blog.txt";
            string textToAppend = "Megan the Vegan Mom Megan, the founder of “Megan the Vegan Mom”, blogs about her daily life as a vegan mom.";

            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
                    sw.WriteLine(textToAppend);
                }

                Console.WriteLine("text  append in blog successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.Read();
        }
    }
}   