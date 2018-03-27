using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            bool bothEven = ((n1 % 2 == 0) && (n2 % 2 == 0)) ? true : false;
            Console.WriteLine(bothEven ? "Both even!" : "There's a number odd!");
            Console.ReadKey();
        }
    }
}
