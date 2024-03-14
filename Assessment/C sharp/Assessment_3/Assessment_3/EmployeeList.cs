using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    class EmployeeList
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public string Titles;
        public DateTime DOB;
        public DateTime DOJ;
        public string City;

        public EmployeeList(int EID, string fName, string lName, string title, DateTime dob, DateTime doj, string city)
        {
            EmployeeID = EID;
            FirstName = fName;
            LastName = lName;
            Titles = title;
            DOB = dob;
            DOJ = doj;
            City = city;
        }
        public void Display()
        {
            Console.WriteLine($"EmployeeID: {EmployeeID}, Name: {FirstName} {LastName}, Title: {Titles}, DOB: {DOB.ToString("dd/MM/yyyy")}, DOJ: {DOJ.ToString("dd/MM/yyyy")}, City: {City}");
        }

    }


    class GenericList

    {
        static void Main()
        {
            List<EmployeeList> emplist = new List<EmployeeList>
            {
            new EmployeeList(1001, "Malcolm", "Daruwalla", "Manager", new DateTime(1984, 11, 16), new DateTime(2011, 6, 8), "Mumbai"),
            new EmployeeList(1002, "Asdin", "Dhalla", "AsstManager", new DateTime(1984, 8, 20), new DateTime(2012, 7, 7), "Mumbai"),
            new EmployeeList(1003, "Madhavi", "Oza", "Consultant", new DateTime(1987, 11, 14), new DateTime(2015, 4, 12), "Pune"),
            new EmployeeList(1004, "Saba", "Shaikh", "SE", new DateTime(1990, 6, 3), new DateTime(2016, 2, 2), "Pune"),
            new EmployeeList(1005, "Nazia", "Shaikh", "SE", new DateTime(1991, 3, 8), new DateTime(2016, 2, 2), "Mumbai"),
            new EmployeeList(1006, "Amit", "Pathak", "Consultant", new DateTime(1989, 11, 7), new DateTime(2014, 8, 8), "Chennai"),
             new EmployeeList(1007, "Vijay", "Natrajan", "Consultant", new DateTime(1989, 12, 2), new DateTime(2015, 6, 1), "Mumbai"),
            new EmployeeList(1008, "Rahul", "Dubey", "Associate", new DateTime(1993, 11, 11), new DateTime(2014, 11, 6), "Chennai"),
            new EmployeeList(1009, "Suresh", "Mistry", "Associate", new DateTime(1992, 8, 12), new DateTime(2014, 12, 3), "Chennai"),
            new EmployeeList(1010, "Sumit", "Shah", "Manager", new DateTime(1991, 4, 12), new DateTime(2016, 1, 2), "Pune")
            };

            //a.

            Console.WriteLine("Details of all employees: ");
            foreach (var emp in emplist)
            {
                emp.Display();
            }
            Console.WriteLine();

            //b.


            var mumbai = emplist.Where(emp => emp.City != "Mumbai");
            Console.WriteLine("Details of all employees whose location is not mumbai:");
            foreach (var emp in mumbai)
            {
                emp.Display();
            }
            Console.WriteLine();

            //c.

            var asst = emplist.Where(emp => emp.Titles == "AsstManager");
            Console.WriteLine("Details of all employees whose title is Asstmanager:");
            foreach (var emp in asst)
            {
                emp.Display();
            }
            Console.WriteLine();


            //d.

            var lname_s = emplist.Where(emp => emp.LastName.StartsWith("S"));
            Console.WriteLine("Details of all employees whose last name starts with S:");
            foreach (var emp in lname_s)
            {
                emp.Display();
            }
            Console.WriteLine();

            Console.Read();
        
        }
    }
}
