using System;

namespace Simple_Banking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            BankAccount bankAccount = new BankAccount(123456, "Jessy Pang Xin Yuan", "Savings", 78900);

            Console.WriteLine("Welcome to the Simple Banking System!");
            Console.Write("Please enter your ID: ");
            customer.CustomerID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your name: ");
            customer.CustomerName = Console.ReadLine();
            Console.Write("Please enter your phone number: ");
            customer.PhoneNumber = Console.ReadLine();

            Console.WriteLine();

            Transaction transaction = new Transaction(123456, "Deposit", 0, 0);
            Console.Write("Enter the amount to deposit: ");
            transaction.amount = Convert.ToDouble(Console.ReadLine());
            bankAccount.balance = transaction.deposit(transaction.amount, bankAccount.balance);

            Console.WriteLine("Your current balance is: " + bankAccount.balance);
            Console.WriteLine();

            Console.Write("Enter the amount to withdraw: ");
            transaction.amount = Convert.ToDouble(Console.ReadLine());
            bankAccount.balance = transaction.withdraw(transaction.amount, bankAccount.balance);

            Console.WriteLine("Your current balance is: " + bankAccount.balance);
            Console.WriteLine();

            Console.WriteLine("Customer Information: ");
            customer.displayCustomerInfo();
            Console.WriteLine();

            Console.WriteLine("Account Information:");
            bankAccount.displayAccountInfo();
            Console.WriteLine();

            Console.WriteLine("Transaction Details:");
            transaction.displayTransactionInfo();
        }
    }
}
