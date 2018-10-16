using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchEnumsTM
{
    class Program
    {
        enum Color
        {
            Red,
            Yellow,
            Black,
            Orange
        }

        static void Main(string[] args)
        {
            Console.Write("Pick a number between 1 and 6");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 6:
                case 5:
                    Console.WriteLine("You picked 5");
                    break;
                case 4:
                    Console.WriteLine("You picked 4");
                    break;
                case 3:
                    Console.WriteLine("You picked 3");
                    break;
                case 2:
                    Console.WriteLine("You picked 2");
                    break;
                case 1:
                    Console.WriteLine("You picked 1");
                    break;
                default:
                    Console.WriteLine("You Picked Wrong Number!");
                    break;
            }

            Color favourite = Color.Yellow;

            switch (favourite)
            {
                case Color.Red:
                    Console.WriteLine("You Chosed Red");
                    break;
                case Color.Black:
                    Console.WriteLine("You Chosed Black");
                    break;
                case Color.Orange:
                    Console.WriteLine("You Chosed Orange");
                    break;
                case Color.Yellow:
                    Console.WriteLine("You Chosed Yellow");
                    break;
                default:
                    Console.WriteLine("Wrong Color");
                    break;
            }
        }
    }
}
