using System;

namespace Exercise_Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(1, -4);
            Fraction fraction2 = new Fraction(2, 3);
            Console.WriteLine(fraction1);

            Fraction fraction3 = fraction1 * 5;
            Console.WriteLine(fraction3);

            Fraction fraction4 = 5 * fraction1;
            Console.WriteLine(fraction4);

            Fraction fraction5 = 5 * fraction1 * fraction2 * 40;
            Console.WriteLine(fraction5);

            // try to catch exception
            try {
                Fraction fraction6 = Fraction.Parse("9");
                Console.WriteLine(fraction6);
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
