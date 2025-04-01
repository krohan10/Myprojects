using System;

namespace ContructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            Console.WriteLine("After:" + c1.Id);

            Customer c2 = new Customer();
            Console.WriteLine("After:" + c1.Id);

            Customer c3 = new Customer();
            Console.WriteLine("After:" + c1.Id);

            Customer c4 = new Customer();
            Console.WriteLine(c4.Id);
        }

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
                Console.WriteLine("Before:" + Id);
                Id++;

            }
        }
    }
}