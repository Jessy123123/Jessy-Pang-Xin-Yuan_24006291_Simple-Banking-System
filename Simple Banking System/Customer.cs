using System;

namespace Simple_Banking_System
{
    internal class Customer
    {
        private int customerID;
        private string customerName;
        private int phoneNumber;

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public void displayCustomerInfo()
        {
            Console.WriteLine("Customer ID: {0}", customerID);
            Console.WriteLine("Customer Name: {0}", customerName);
            Console.WriteLine("Phone Number: {0}", phoneNumber);
        }
    }
}
