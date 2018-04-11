using System;
using System.Collections.Generic;

namespace Exercise_Fraction
{
    class Program
    {
        static void Main(string[] args)
        {   
            // test constructors
            Fraction fraction0 = new Fraction();
            Fraction fraction1 = new Fraction(2);
            Fraction fraction2 = new Fraction(1, -4);
            Console.WriteLine($"new Fraction() -> {fraction0}");
            Console.WriteLine($"new Fraction(2) -> {fraction1}");
            Console.WriteLine($"new Fraction(1, 4) -> {fraction2}");

            // test multiplications
            Fraction fraction3 = fraction1 * 5;
            Console.WriteLine($"{fraction1} * 5 -> {fraction3}");

            Fraction fraction4 = 5 * fraction1;
            Console.WriteLine($"5 * {fraction1} -> {fraction4}");

            Fraction fraction5 = 5 * fraction1 * fraction2 * 40;
            Console.WriteLine($"mixed multiplication supported -> {fraction5}");

            // test Parse(string) and
            // try to catch exception
            try {
                Fraction parsed_fraction = Fraction.Parse("9");
                Console.WriteLine("Fraction created by Parse() -> {parsed_fraction}");
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            
            // test Cancel()
            Fraction fraction6 = new Fraction(5, 15);
            Console.WriteLine($"Before canceling: {fraction6}");
            fraction6.Cancel();
            Console.WriteLine($"After canceling: {fraction6}");

            // create list of fractions and test IComperable<Fraction>
            List<Fraction> list_of_fractions = new List<Fraction>();
            list_of_fractions.Add(fraction0);
            list_of_fractions.Add(fraction1); 
            list_of_fractions.Add(fraction2); 
            list_of_fractions.Add(fraction3); 
            list_of_fractions.Add(fraction4); 
            list_of_fractions.Add(fraction5); 
            list_of_fractions.Add(fraction6); 

            Console.WriteLine("List before sorting");
            for (int i = 0; i < list_of_fractions.Count; i++) {
                Console.WriteLine($"{list_of_fractions[i]}");
            }

            list_of_fractions.Sort();

            Console.WriteLine("List after sorting");
            for (int i = 0; i < list_of_fractions.Count; i++) {
                Console.WriteLine($"{list_of_fractions[i]}");
            }
        }
    }
}
