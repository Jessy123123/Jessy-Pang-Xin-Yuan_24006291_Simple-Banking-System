using System;

namespace Simple_Banking_System
{
    public class BankAccount
    {
        public int accountNumber;
        public string accountHolderName;
        public string accountType;
        public double balance;

        public BankAccount(int accountNumber, string accountHolderName, string accountType, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.accountType = accountType;
            this.balance = balance;
        }

        public void displayAccountInfo()
        {
            Console.WriteLine("Account Number: {0}", accountNumber);
            Console.WriteLine("Account Holder Name: {0}", accountHolderName);
            Console.WriteLine("Account Type: {0}", accountType);
            Console.WriteLine("Account Balance: RM {0}", balance);
        }
    }
}
