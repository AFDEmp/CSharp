using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace SimpleEventHandler
{
    class Program
    {
        private static int _remainingTime;

        static void Main(string[] args)
        {
            Console.Write("Insert time (in seconds): ");
            _remainingTime = int.Parse(Console.ReadLine());

            Timer t = new Timer
            {
                Interval = 1000,
                Enabled = true
            };

            t.Elapsed += ElapsedTime;
            t.Start();

            Console.ReadKey();
        }

        static void ElapsedTime(object sender, ElapsedEventArgs e)
        {
            if (_remainingTime == 0)
            {
                ((Timer)sender).Stop();
                return;
            }

            Console.Write($"\rRemaining time: {--_remainingTime}");
        }
    }
}
