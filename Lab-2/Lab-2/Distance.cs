using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Distance
    {
        double dist1, dist2,dist3;
        public Distance(double d1,double d2) { 
            this.dist1 = d1;
            this.dist2 = d2;
        }
        public void calculateDistance()
        {
            dist3 = dist1 + dist2;
            Console.WriteLine("Total DIstance is : "+dist3);
        }
    }
}
