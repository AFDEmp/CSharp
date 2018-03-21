using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Linked list of integers");
            LinkedList myList = new LinkedList();
            Console.WriteLine(myList.GetString());
            myList.Add(5);
            Console.WriteLine(myList.GetString());
            myList.Add(10);
            Console.WriteLine(myList.GetString());
            myList.Add(20);
            Console.WriteLine(myList.GetString());

            Console.WriteLine($"Count= {myList.Count}");

            Console.WriteLine("-- Generic linked list with strings");
            LinkedListGeneric<string> list1;
            list1 = new LinkedListGeneric<string>();
            list1.Add("Hello world!");
            list1.Add("My name is");
            list1.Add("John");
            // Because we overrided ToString()
            Console.WriteLine(list1);
            // Get value at index = 1
            Console.WriteLine($"list1[1] = {list1.Get(1)}");
            // Remove first item
            list1.RemoveAt(0);
            Console.WriteLine($"After RemoveAt[0] -> {list1}");
            // The following line will throw an IndexOutOfRangeException
            //list1.RemoveAt(5);
            // We can bulletproof our code with try-catch 
            // and run alternative code if exception is thrown
            try 
            {
                list1.RemoveAt(8);
            }
            catch 
            {
                Console.WriteLine("Exception was thrown!");
            }

            Console.WriteLine("-- Generic linked list with integers");
            LinkedListGeneric<int> list2 = new LinkedListGeneric<int>();
            list2.Add(10);
            list2.Add(2);
            list2.Add(100);
            // Because we overrided ToString()
            Console.WriteLine(list2);

            Console.WriteLine("-- Generic linked list with booleans");
            LinkedListGeneric<bool> list3 = new LinkedListGeneric<bool>();
            list3.Add(false);
            list3.Add(false);
            list3.Add(true);
            // Because we overrided ToString()
            Console.WriteLine(list3);

            Console.ReadKey();
        }
    }
}
