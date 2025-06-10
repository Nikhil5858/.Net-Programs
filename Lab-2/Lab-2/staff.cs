using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_2
{
    internal class staff
    {
        String name, department, designation;
        int experiance, salary;

        public void GetStaffDetails()
        {
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Department : ");
            department = Console.ReadLine();
            Console.WriteLine("Enter Designation : ");
            designation = Console.ReadLine();
            Console.WriteLine("Enter Experiance : ");
            experiance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Salary : ");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public void Displayhod()
        {
            if (designation== "hod")
            {
                Console.WriteLine($"Name: {name}, Salary: {salary}");
            }
        }
        public void DisplayCandidateDetails()
        {
            Console.WriteLine($"Name : {name}, Department : {department},Designation : {designation}, Experiance : {experiance}, Salary : {salary}");
        }
    }
}
