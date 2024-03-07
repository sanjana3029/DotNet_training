using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class String
    {
     static void Main()
        {

            
            Console.WriteLine("enter a string Firstname: ");
            string FirstName = Console.ReadLine();
       
            Console.WriteLine("enter a string Secondname: ");
            string SecondName = Console.ReadLine();

            string upperFirstName = FirstName.ToUpper();
            string upperSecondName = SecondName.ToUpper();


            Console.WriteLine($"Firstname: {upperFirstName}");
            Console.WriteLine($"Secondname: {upperSecondName}");
            Console.Read();
        }




    }
}
