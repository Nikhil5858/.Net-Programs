using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class AreaOfRectangel
    {
        double L,B;
        public AreaOfRectangel(double l, double b)
        {
            this.L = l;
            this.B = b;
        }
        public void CalculateArea()
        {
            Console.WriteLine("Area of Rectangel is : "+(L*B));
        }
    }
}
