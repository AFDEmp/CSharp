using System;
using System.Collections.Generic;

namespace exceptions
{
    // We can creat our own exceptions by inheriting from base class Exception
    // or any other exception class
    public class MyException : Exception {
        public string CustomMessage { get; set; }

        public MyException() : base(){

        }
    }

    public class Human {
        public int Age { get; private set;}

        // This method throws and ArgumentException if age < 0
        // We can provide a custom message to the exception object
        public void SetAge(int age) {
            if (age < 0) {
                throw new ArgumentException("Age cannot be negative!");
            }
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() {
                1, 2, 3, 4, 5
            };

            try 
            {
                // This will throw an exception
                Console.WriteLine(myList[10]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException caught");
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("ArgumentOutOfRangeException caught");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Exception caught");
            }
            finally {
                Console.WriteLine("finally block will always run");
            }

            Console.WriteLine("This is outside of try-catch");

            Human h1 = new Human();
            try {
                // this will throw an exception
                h1.SetAge(-10);
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }

            // If an exception is unhandled our program will stop
            // h1.SetAge(-10);
        }
    }
}
