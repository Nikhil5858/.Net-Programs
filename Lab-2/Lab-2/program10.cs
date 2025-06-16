using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    interface Gross
    {
        void Gross_sal();
    }

    public class Salary2
    {
        public double HRA = 3000, TA = 2000, DA = 1500;

        public void Disp_sal()
        {
            Console.WriteLine($"HRA: {HRA}, TA: {TA}, DA: {DA}");
        }
    }

    public class Employee:Salary2,Gross
    {
        string Name;

        public void getEmployees()
        {
            Console.WriteLine("Enter Name : ");
            Name = Console.ReadLine();
        }

        public void Gross_sal()
        {
            double total = HRA + TA + DA;
            Console.WriteLine($"Employee Name is : {Name}\n Total is {total}");
        }
    }


}
