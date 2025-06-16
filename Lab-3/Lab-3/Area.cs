using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Area
    {
        public int CalculateArea(int s) { 
            return s * s;
        }
        public double CalculateArea(double l,double b)
        {
            return l*b;
        }
        public double CalculateArea(double c)
        {
            return 3.14 * c * c;
        }
    }
}
