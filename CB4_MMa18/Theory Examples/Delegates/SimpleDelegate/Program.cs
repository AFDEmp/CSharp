using System;

namespace SimpleDelegate
{
    class Program
    {
        // Declare a delegate
        public delegate int PerformCalculation(int x, int y);

        // Declare a delegate
        delegate void MyDelegate(string message);

        static void Main(string[] args)
        {
            // Instantiating a delegate (two ways)
            // MyDelegate myDelegate = new MyDelegate(MyMethod);
            MyDelegate myDelegate = MyMethod;
            myDelegate("Hello world!");

            // Instantiating a delegate (two ways)
            PerformCalculation calculation = new PerformCalculation(Sum);
            //PerformCalculation calculation = Sum;

            Console.WriteLine(calculation(1, 3));

            Console.ReadKey();
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }

        static void MyMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}
