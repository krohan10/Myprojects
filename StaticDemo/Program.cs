using System;


namespace StaticDemo
{
    class Program
    {
        public static int x = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Before modification static  x:" + StaticDemo.x);
            StaticDemo.x = 20;
            Console.WriteLine("After  modification static x:" + StaticDemo.x);


            StaticDemo obj1 = new StaticDemo();
            Console.WriteLine("Before modification instance1 y:" + obj1.y);
            obj1.y = 30;
            Console.WriteLine("After modification instance1 y:" + obj1.y);


            Console.WriteLine("Before modification static  x:" + StaticDemo.x);
            StaticDemo.x= 150;
            Console.WriteLine("After modification static x:" + StaticDemo.x);

            StaticDemo obj2 = new StaticDemo();
            Console.WriteLine("Before modification instance2  y:" + obj2.y);
            obj2.y= 200;
            Console.WriteLine("After modification instance2 y:" + obj2.y);

        }
        public class StaticDemo
        {
            public static int x;
            public int y;
            static StaticDemo()
            {
                x = 50;
            }
            public StaticDemo()
            {
                y = 500;
            }
        }
    }
}
