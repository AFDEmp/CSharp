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
            Console.WriteLine(list1.GetString());

            Console.WriteLine("-- Generic linked list with integers");
            LinkedListGeneric<int> list2 = new LinkedListGeneric<int>();
            list2.Add(10);
            list2.Add(2);
            list2.Add(100);
            Console.WriteLine(list2.GetString());

            Console.WriteLine("-- Generic linked list with booleans");
            LinkedListGeneric<bool> list3 = new LinkedListGeneric<bool>();
            list3.Add(false);
            list3.Add(false);
            list3.Add(true);
            Console.WriteLine(list3.GetString());

            Console.ReadKey();
        }
    }
}
