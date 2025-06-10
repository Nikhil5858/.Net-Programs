using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Salary
    {
            double Basic, TA, DA, HRA;

            public Salary(double basic, double ta, double da = 1000, double hra = 2000)
            {
                Basic = basic;
                TA = ta;
                DA = da;
                HRA = hra;
            }

            public void CalculateTotalSalary()
            {
                double total = Basic + TA + DA + HRA;
                Console.WriteLine("Total Salary: " + total);
            }

        }
}
