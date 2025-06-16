using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Hospital
    {
        public virtual void HospitalDetails()
        {
            Console.WriteLine("Hospital Parent class Was Called!");
        }
    }
    public class Apollo : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Apollo Class Was Called");
        }
    }

    public class Wockhardt : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Woodkhardt Class Was Called");
        }
    }

    public class Gokul_Superspeciality : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Gokul_Superspeciality Class Was Called");
        }
    }
}
