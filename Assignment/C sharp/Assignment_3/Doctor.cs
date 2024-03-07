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

        public void Doctorinfo (int regno, string name, double feescharged)
        {
            Regno = regno;
            Name = name;
            Feescharged = feescharged;
         }

        public void Displayinfo()
        {
            Console.WriteLine($"enter regno: {Regno}");
            Console.WriteLine($"enter name:  { Name}");
            Console.WriteLine($"enter feescharged: { Feescharged}");
        }



    }
}
