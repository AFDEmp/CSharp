using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsTM
{
    class Program
    {
        static void Main(string[] args)
        {
            // When we have the logic divert based on Conditions
            // We can have control over the flow of our program
            Console.Write("What is your age? ");
            var myAge = Console.ReadLine();

            // Convert a string to integer
            int age = int.Parse(myAge);

            // Special Note : = is used for assingment (int x = 9;), == is used for equality (7 + 2 == 9), != is used for inequality (5 + 1 != 4)

            // Create a block of code consist of one or more statements
            if (age > 70)
            {
                Console.WriteLine("You can't Vote. You can't Drive");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You Can Drive.");
            }
            // this usually handles all other cases
            else
            {
                Console.WriteLine("You are NOT an Adult");
            }

            // Conditionals with operators
            int johnAge = 23;
            int MariaAge = 19;

            int johnHoursOfSleep = 8;
            int mariaHoursOfSleep = 5;

            if (johnAge >= 18 && johnHoursOfSleep >= 8)
            {
                Console.WriteLine("John can Drive");
            }
            else if (MariaAge >= 18 && mariaHoursOfSleep >= 8)
            {
                Console.WriteLine("Maria can Drive");
            }

        }
    }
}
