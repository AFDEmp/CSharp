using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsTM
{
    class Program
    {
        enum Ages
        {
            kindergarten = 5,
            highSchool = 12,
            university = 18
        }

        static void Main(string[] args)
        {
            const int age = 15;

            if (age < (int)Ages.kindergarten)
            {
                Console.WriteLine("You are very very young");
            }
            else if (age < (int)Ages.highSchool)
            {
                Console.WriteLine("You are going to primary School");
            }
            else if (age < (int)Ages.university)
            {
                Console.WriteLine("You are going to High School");
            }
            else
            {
                Console.WriteLine("You are going to University");
            }
        }
    }
}
