using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
     abstract class Student_Grade
    {

        protected string Name;
        protected int StudentId;
        protected double Grade;

        public Student_Grade(string name, int stId, double grade)
        {
            Name = name;
            StudentId = stId;
            Grade = grade;
        }

        public abstract bool IsPassed(double grade);
    }

    class Undergraduate: Student_Grade
    {
        public Undergraduate(string name, int stId, double grade) : base(name, stId, grade)
        {
        }
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }
    class Graduate : Student_Grade
    {
        public Graduate(string name, int stId, double grade) : base(name, stId, grade)
        {}
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }
}
