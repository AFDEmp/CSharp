using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Do The Simplest Thing That Could Possibly Work.";
            string s2 = "Do The Simplest Thing That Could Possibly Work.";

            bool areEqual = ReferenceEquals(s1, s2);
            //Output: True

            string s3 = string.Copy(s1);

            bool s1s3AreEqual = ReferenceEquals(s1, s3);
            bool s2s3AreEqual = ReferenceEquals(s2, s3);
            Console.WriteLine(s2s3AreEqual);
            Console.ReadKey();
            //Output: False
            //        False

        }
    }
}
