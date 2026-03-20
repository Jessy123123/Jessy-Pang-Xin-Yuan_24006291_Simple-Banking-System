using System;

namespace Simple_Banking_System
{
    public class Customer
    {
        private int customerID;
        private string customerName;
        private string phoneNumber;

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

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public void displayCustomerInfo()
        {
            Console.WriteLine("Customer ID: {0}", CustomerID);
            Console.WriteLine("Customer Name: {0}", CustomerName);
            Console.WriteLine("Phone Number: {0}", PhoneNumber);
        }
    }
}
