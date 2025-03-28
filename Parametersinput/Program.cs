using System;


namespace Myprojects
{
    class Parametersinput
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.GetuserName1();

            string userName2 = customer.GetuserName2();

            Console.WriteLine(userName2);

            string fname = Console.ReadLine();

            string lname = Console.ReadLine();

            customer.GetuserName3(fname, lname);

            Console.ReadLine();
        }
        class Customer
        {
            public void GetuserName1()
            {
                string fname = Console.ReadLine();
                string lname = Console.ReadLine();
                string userName = fname + "_" + lname;
                Console.WriteLine(userName);

            }
            public string GetuserName2()
            {
                string fname = Console.ReadLine();
                string lname = Console.ReadLine();
                string userName = fname + "_" + lname;
                return userName;

            }
            public void GetuserName3(string fname, string lname)
            {
                string userName = fname + "_" + lname;
                Console.WriteLine(userName);
            }

        }
    }
}

