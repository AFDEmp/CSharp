using System;
using System.Net;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demo 1
            Console.WriteLine(" Demo 1: Awaiting call to long operation:");
            Task withAwaitAtCallTask = WithAwaitAtCallAsync();
            withAwaitAtCallTask.Wait();

            // Demo 2
            Console.WriteLine(" Demo 2: NOT awaiting call to long operation:");

            Task withoutAwaitAtCallTask = WithoutAwaitAtCallAsync();
            withoutAwaitAtCallTask.Wait();

            Console.ReadKey();
        }

        private static async Task WithAwaitAtCallAsync()
        {
            Console.WriteLine(" WithAwaitAtCallAsync() entered.");
            Console.WriteLine(" Awaiting when I call LongOperation().");
            await LongOperation();
            Console.WriteLine(" Pretending to do other work in WithAwaitAtCallAsync().");
        }

        private static async Task WithoutAwaitAtCallAsync()
        {
            Console.WriteLine(" WithoutAwaitAtCallAsync() entered.");
            Console.WriteLine(" Call made to LongOperation() with NO await.");
            Task task = LongOperation();
            Console.WriteLine(" Do some other work in WithoutAwaitAtCallAsync() after calling LongOperation().");
            await task;
        }

        private static async Task LongOperation()
        {
            Console.WriteLine(" LongOperation() entered.");
            Console.WriteLine(" Starting the long (3 second) process in LongOperation()...");
            await Task.Delay(4000);
            Console.WriteLine(" Completed the long (3 second) process in LongOperation()...");
        }
    }
}
