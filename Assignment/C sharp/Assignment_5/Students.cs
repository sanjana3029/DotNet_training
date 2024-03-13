using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Students
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public Students(int StId, string name)
        {
            StudentId = StId;
            Name = name;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Student ID: {StudentId} and Name: {Name}");
        }
        
    }
    class Dayscholar: Students
    {
        public Dayscholar(int StId, string name): base(StId,name)
        {
            //Console.WriteLine($"Dayscholar Details: StudentId = {StudentId}, Name : {Name}");
        }
    }
    public class Resident : Students
    {

        public Resident(int StId, string name) : base(StId, name)
        {
            //Console.WriteLine($"Resident Details: StudentId : {StudentId}, Name : {Name}");
        }
    }

    class Student
    {
        static void Main()
        {
            
            Console.WriteLine("Enter ID: ");
            int dsId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name: ");
            string dsname = Console.ReadLine();
            Dayscholar ds = new Dayscholar(dsId, dsname);


            
            Console.WriteLine("Enter ID: ");
            int RsId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name: ");
             string Rsname =Console.ReadLine();
            Resident Rs = new Resident(RsId, Rsname);

            Console.WriteLine("\nStudent Details:");
            ds.ShowDetails();
            Rs.ShowDetails();
            Console.Read();

        }
    }

}
