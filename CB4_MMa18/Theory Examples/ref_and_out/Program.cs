using System;

namespace ref_and_out
{
    class Program
    {
        // parameter x is passed by value
        static void Increase(int x) {
            x++;
            Console.WriteLine($"Inside Increae: {x}");
        }

        // parameter x is passed by reference
        static void IncreaseByRef(ref int x) {
            x++;
            Console.WriteLine($"Inside IncreaseByRef: {x}");
        }

        // parameter isOver100 is declared as output
        // the method must provide its value
        static int Add(int x, int y, out bool isOver100) {
            int result = x + y;
            if (result >= 100) {
                isOver100 = true;
            }
            else {
                isOver100 = false;
            }
            // The following line does the same as the above if-else
            //isOver100 = result >= 100 ? true : false;
            return result;
        }

        static void Main(string[] args)
        {
            // Pass by value
            int myNumber = 0;
            Console.WriteLine($"Before Increase: {myNumber}");
            Increase(myNumber);
            Console.WriteLine($"After Increase: {myNumber}");

            // Pass by reference
            int myRefNumber = 0;
            Console.WriteLine($"Before IncreaseByRef: {myRefNumber}");
            IncreaseByRef(ref myRefNumber);
            Console.WriteLine($"After IncreaseByRef: {myRefNumber}");

            // Copy by value
            int originalByValue = 0;
            int copyByValue = originalByValue;
            originalByValue += 1;
            Console.WriteLine($"Original value: {originalByValue}");
            Console.WriteLine($"CopyByReference value: {copyByValue}");

            // Copy by reference
            int originalByReference = 0;
            ref int copyByReference = ref originalByReference;
            originalByReference += 1;
            Console.WriteLine($"Original value: {originalByReference}");
            Console.WriteLine($"CopyByReference value: {copyByReference}");

            // Call method with out parameter
            int x = 50;
            int y = 55;
            bool isOver100;
            int result = Add(x, y, out isOver100);
            Console.WriteLine($"{x} + {y} = {result}, isOver100 = {isOver100}");
        }
    }
}
