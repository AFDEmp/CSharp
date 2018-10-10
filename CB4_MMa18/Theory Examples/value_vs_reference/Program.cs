using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace value_vs_reference
{
    class Program
    {
        // reference type
        class TheClass
        {
            public string willIChange;
        }

        // value type
        struct TheStruct
        {
            public string willIChange;
        }

        class TestClassAndStruct
        {
            static void ClassTaker(TheClass c)
            {
                c.willIChange = "Changed";
                Console.WriteLine($"Class field inside method: {c.willIChange}");
            }

            static void StructTaker(TheStruct s)
            {
                s.willIChange = "Changed";
                Console.WriteLine($"Struct field inside method: {s.willIChange}");
            }

            static void StringTaker(string s) 
            {
                s = "Changed";
                Console.WriteLine($"String inside method: {s}");
            }


            // If we want to pass and a value-type by reference
            // then we use the keyword 'ref'
            static void intTaker(ref int i)
            {
                i = 1;
                Console.WriteLine($"Integer inside method: {i}");
            }

            static void Main()
            {
                TheClass testClass = new TheClass();        //reference type
                TheStruct testStruct = new TheStruct();     //value type
                string testString;                          //value type
                int testInteger;                            //value type

                testClass.willIChange = "Initial";
                testStruct.willIChange = "Initial";
                testString = "Initial";
                testInteger = 0;

                Console.WriteLine($"Class field before method: {testClass.willIChange}");
                Console.WriteLine($"Struct field before method: {testStruct.willIChange}");
                Console.WriteLine($"String before method: {testString}");
                Console.WriteLine($"Integer before method: {testInteger}");
                Console.WriteLine();

                ClassTaker(testClass);
                StructTaker(testStruct);
                StringTaker(testString);
                // we need to use 'ref' here too!
                intTaker(ref testInteger);
                
                Console.WriteLine();
                Console.WriteLine($"Class field after method: {testClass.willIChange}");
                Console.WriteLine($"Struct field after method: {testStruct.willIChange}");
                Console.WriteLine($"String after method: {testString}");
                Console.WriteLine($"Integer after method: {testInteger}");
                Console.WriteLine();

                // Keep the console window open in debug mode.
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
        /* Output:
            Class field before method: Initial
            Struct field before method: Initial
            String before method: Initial
            Integer before method: 0

            Class field inside method: Changed
            Struct field inside method: Changed
            String inside method: Changed
            Integer inside method: 1

            Class field after method: Changed
            Struct field after method: Initial
            String after method: Initial
            Integer after method: 1
        */
    }
}
