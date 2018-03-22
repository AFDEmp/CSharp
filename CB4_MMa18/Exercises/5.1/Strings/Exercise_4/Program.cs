using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleClass sc = new SimpleClass
            {
                Integer = 1,
                Float = 4.5f,
                Double = 6.9,
                Long = 9223372036854775803
            };

            Console.WriteLine(sc);
            Console.ReadKey();
        }
    }
}
