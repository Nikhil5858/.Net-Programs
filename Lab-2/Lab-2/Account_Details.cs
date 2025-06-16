using System;

namespace Lab_2
{
    public class Account_Details
    {
        protected double Balance; 
        public void GetDetails()
        {
            Console.Write("Enter Balance: ");
            Balance = double.Parse(Console.ReadLine());
        }
    }

    class Interest : Account_Details
    {
        public void CalculateInterest()
        {
            double interest = Balance * 0.05;
            Console.WriteLine("Interest 5% : " + interest);
        }
    }
}
