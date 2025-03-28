using System;
using System.Runtime.InteropServices;


namespace Outputparameters
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingRefOutDemo obj = new UsingRefOutDemo();

            int result1 = 0;

            Console.WriteLine(" before addition result:" + result1);

            obj.Addition(20, 30, ref result1);

            Console.WriteLine("after addition result:" + result1);

            int result2;

            obj.Subtraction(30, 20, out result2);

            Console.WriteLine("after subtraction result:" + result2);

            Console.ReadLine();
        }
    }
        class UsingRefOutDemo
        {
            public void Addition(int x, int y, ref int z)
            {
                z = x + y;
            }

            public void Subtraction(int x, int y, out int z)
            {
                z = x - y;
            }
        } 
   
}
