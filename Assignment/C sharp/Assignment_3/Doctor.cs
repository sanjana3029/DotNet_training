using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Doctor
    {
        private int Regno;
        private string Name;
        private double Feescharged;

        public void Doctorinfo(int regno, string name, double feescharged)
        {
            Regno = regno;
            Name = name;
            Feescharged = feescharged;
        }

        public void Displayinfo()
        {
            Console.WriteLine($"Registration No is: {Regno}");
            Console.WriteLine($"Name is:  { Name}");
            Console.WriteLine($"Feescharged is: { Feescharged}");
        }
        static void Main(string[] args)
        {

            Doctor d = new Doctor();
            Console.WriteLine($"Enter Regno: ");
            int regno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Feecharged: ");
            double feecharged = double.Parse(Console.ReadLine());


        
            d.Doctorinfo(regno, name, feecharged);
            d.Displayinfo();
            Console.Read();
        }
    }
}
