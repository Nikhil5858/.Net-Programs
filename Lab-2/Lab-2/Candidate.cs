using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Candidate
    {
        int id, age, weight, height;
        string name;

        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter Id : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight : ");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height : ");
            height = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayCandidateDetails()
        {
            Console.WriteLine($"Id : {id}, Name : {name}, Age : {age}, Weight : {weight}, Height : {height}");
        }
    }
}
