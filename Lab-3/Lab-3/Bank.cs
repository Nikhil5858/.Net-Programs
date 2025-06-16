using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
        public class Bank
        {
                public virtual double calculateInterest()
                {
                    return 5;
                }
        }
        public class HDFC : Bank
        {
            public override double calculateInterest()
            {
                return 5.5;
            }
        }
        public class SBI : Bank
        {
            public override double calculateInterest()
            {
                return 10.4;
            }
        }
        public class ICICI : Bank
        {
            public override double calculateInterest()
            {
                return 9.8;
            }
        }
}
