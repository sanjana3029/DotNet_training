using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Schlorship
    {
        public double Merit(double marks, double fees)
        {
            double schlorAmount = 0;

            if (marks >= 70 && marks <= 80) 
            {
                schlorAmount = 0.2 * fees;
            }

            else if(marks > 80 && marks <= 90)
            {
                schlorAmount = 0.3 * fees;
            }
            else if(marks >90)
            {
                schlorAmount = 0.5 * fees;
            }

            return schlorAmount;

        }
    }
}
