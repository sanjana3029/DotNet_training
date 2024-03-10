using System;
using Concession;

namespace Assignment_4
{
    class Program
    {
        public static void Main(string[] args)
        {

            TicketConcession tf = new TicketConcession();
            Console.WriteLine("Passenger Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Passenger Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            tf.ConcessionCal(age, name);

            Console.ReadLine();

           
            
            
        }
    }
}
