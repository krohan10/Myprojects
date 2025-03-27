using System;


namespace Myprojects
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.MethodName();
            int result = obj.Sub(2, 6);
            Console.WriteLine(result);
            Console.WriteLine();
        }
        public void MethodName()
        {
            Console.WriteLine();
        }

        public int Sub(int a, int b)

        {
            int result = a - b;
            return result;
        }
    }
}
