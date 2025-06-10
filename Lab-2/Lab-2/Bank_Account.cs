using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Bank_Account
    {
        int account_no, Account_Balance;
        string email,user_name, Account_Type;

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account No : ");
            account_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter User Name : ");
            user_name = Console.ReadLine();
            Console.WriteLine("Enter Account Balance : ");
            Account_Balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email : ");
            email = Console.ReadLine();
            Console.WriteLine("Enter Account Type : ");
            Account_Type = Console.ReadLine();
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"IdAccount No : {account_no}, User Name : {user_name}, Account Balance : {Account_Balance}, Email : {email}, Account_Type : {Account_Type}");
        }
    }
}
