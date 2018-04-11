using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionsExample
{
    class Program
    {
        public delegate void Print(int val);

        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            Print prnt = ConsolePrint;
            prnt(10);

            // Multiple ways to initialize an Action
            // .::-- First way --::.
            //Action<int> printActionDel = ConsolePrint;
            //printActionDel(10);

            // .::-- Second way --::.
            //Action<int> printActionDel = new Action<int>(ConsolePrint);
            //printActionDel(10);

            // .::-- Third way --::.
            //Action<int> printActionDel = delegate (int i)
            //{
            //    Console.WriteLine(i);
            //};
            //printActionDel(10);

            //Action<int> printActionDel = i => Console.WriteLine(i);
            //printActionDel(10);
        }
    }
}
