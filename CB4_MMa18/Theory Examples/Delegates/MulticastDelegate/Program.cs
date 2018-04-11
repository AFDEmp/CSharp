using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class Program
    {
        delegate void MulticastDelegate(string message);

        static void Hello(string message)
        {
            Console.WriteLine($"Hello, { message }!");
        }

        static void Goodbye(string message)
        {
            Console.WriteLine($"Goodbye, { message }!");
        }

        static void Main(string[] args)
        {
            // Declare instances of the custom delegate.
            MulticastDelegate hiDelegate, byeDelegate, multiDelegate, multiMinusHiDelegate;

            // In this example, you can omit the custom delegate if you 
            // want to and use Action<string> instead.
            //Action<string> hiDel, byeDel, multiDel, multiMinusHiDel;

            // Create the delegate object hiDel that references the
            // method Hello.
            hiDelegate = Hello;

            // Create the delegate object byeDel that references the
            // method Goodbye.
            byeDelegate = Goodbye;

            // The two delegates, hiDel and byeDel, are combined to 
            // form multiDel. 
            multiDelegate = hiDelegate + byeDelegate;

            // Remove hiDel from the multicast delegate, leaving byeDel,
            // which calls only the method Goodbye.
            multiMinusHiDelegate = multiDelegate - hiDelegate;

            Console.WriteLine("Invoking delegate hiDel:");

            hiDelegate("A");

            Console.WriteLine("Invoking delegate byeDel:");

            byeDelegate("B");

            Console.WriteLine("Invoking delegate multiDel:");

            multiDelegate("C");

            Console.WriteLine("Invoking delegate multiMinusHiDel:");

            multiMinusHiDelegate("D");

            Console.ReadKey();
        }
    }
}
