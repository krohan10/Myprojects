using System;


namespace Constructor
{
    public class Customer
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string GetUserName()
        {
            return FirstName + "_" + LastName;
        }
        public Customer()
        {
            Console.WriteLine("Before: " + Id);
            Id++;
        }
    }
}
