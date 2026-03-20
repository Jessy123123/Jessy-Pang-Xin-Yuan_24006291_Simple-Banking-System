using System;

namespace Simple_Banking_System
{
    public class Transaction
    {
        public int accountNumber;
        public string transactionType;
        public double amount;
        public double newBalance;

        public Transaction(int accountNumber, string transactionType, double amount, double newBalance)
        {
            this.accountNumber = accountNumber;
            this.transactionType = transactionType;
            this.amount = amount;
            this.newBalance = newBalance;
        }

        public double deposit(double amount, double balance)
        {
            transactionType = "Deposit";
            newBalance = amount + balance;
            return newBalance;
        }

        public double withdraw(double amount, double balance)
        {
            transactionType = "Withdrawal";

            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds. Withdrawal failed.");
                return balance;
            }
            else
            {
                newBalance = balance - amount;
                return newBalance;
            }
        }

        public void displayTransactionInfo()
        {
            Console.WriteLine("Account Number: {0}", accountNumber);
            Console.WriteLine("Transaction Type: {0}", transactionType);
            Console.WriteLine("Amount: RM {0}", amount);
            Console.WriteLine("New Balance: RM {0}", newBalance);
        }

    }
}
