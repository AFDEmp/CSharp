using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVsInstance
{
    delegate void Del();

    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sc = new SampleClass();

            // Map the delegate to the instance method:
            Del d = sc.InstanceMethod;
            d();

            // Map to the static method:
            d = SampleClass.StaticMethod;
            d();
        }
    }
}
