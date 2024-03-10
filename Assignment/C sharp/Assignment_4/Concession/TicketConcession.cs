using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class TicketConcession
    
       
        {
            private const int Totalfare = 500;

            public void ConcessionCal(int age, string name)
            {

                if (age <= 5)
                {
                    Console.WriteLine($"Free tciket for Chotta Bachha--- Name: {name} and Age: {age}");
                }
                else if (age > 60)
                {
                    double con_amount = 0.3 * Totalfare;
                    double discount = Totalfare - con_amount;

                    Console.WriteLine($" Senior Citizen Fare with {name}: and {age}:  {discount}");
                }
                else
                {
                    Console.WriteLine($"Ticket Booked Fare for {name}: and  {age} : {Totalfare}");
                }

            }
        }
    }

