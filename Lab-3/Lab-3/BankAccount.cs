using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class BankAccount
    {
        int initialBalance;
        String accountHolderName;
        public BankAccount(int bal,String name) {
            initialBalance = bal; 
            accountHolderName = name;
        }
        public void deposit(int amt)
        {
            initialBalance += amt;
            Console.WriteLine($"{amt} Amount was Added to your account.");
            Console.WriteLine($"Your Current balance is {initialBalance}");
        }

        public void deposit(int amt , String chequename)
        {
            initialBalance += amt;
            Console.WriteLine($"{amt} Amount was Added by Cheque {chequename} to your account.");
            Console.WriteLine($"Your Current balance is {initialBalance}");
        }

        public void withdraw(int amt)
        {
            if (amt <= initialBalance)
            {
                initialBalance -= amt;
                Console.WriteLine($"Withdrew {amt}. New balance: {initialBalance}");
            }
            else
            {
                Console.WriteLine("Insufficent balance");
            }
        }
        public void withdraw(int amt,String chequename)
        {
            if (amt <= initialBalance)
            {
                initialBalance -= amt;
                Console.WriteLine($"Withdrew {amt} with cheque name {chequename} . New balance: {initialBalance}");
            }
            else
            {
                Console.WriteLine("Insufficent balance");
            }
        }
    }
}
