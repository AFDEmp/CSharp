using System;

namespace const_vs_readonly_vs_staticreadonly
{
    class Keywords
    {
        /*
        1. const
        2. readonly
        3. static readonly
        These are very common keywords and are quite confusing.
        Let's find out the differences.
        */

        /*
        'const' is nothing but "constant", a variable of which the value is constant but at compile time. 
        And it's mandatory to assign a value to it. 
        By default a const is static and we cannot change the value of a const variable throughout the entire program.
         */
        public const string constName = "John";

        /*
        'readonly' is the keyword whose value we can change during runtime or we can assign it at run time but only through the non-static constructor. Not even a method.
        */
        public readonly string readonlyName = "John";

        /*
        A 'static readonly' type variable's value can be assigned at runtime or assigned at compile time and changed at runtime. In runtime, the variable's value can only be changed once in the static constructor.
        */
        public static readonly string staticReadonlyName = "John";

        // normal constructor
        public Keywords(string name) {
            // Changing 'const' is not allowed
            //constName = name;

            // Changing 'readonly' is allowed
            readonlyName = name;

            // Changing 'static readonly' is not allowed
            //staticReadonlyName = name;
        }

        // static constructor
        static Keywords() {
            // Changing 'const' is not allowed
            //constName = "Mary";

            // Changing 'readonly' is not allowed
            //readonlyName = "Mary";

            // Changing 'static readonly' is allowed
            staticReadonlyName = "Mary";
        }

        public void MyMethod() {
            // Changing 'const' is not allowed
            //constName = "Mary";

            // Changing 'readonly' is not allowed
            //readonlyName = "Mary";

            // Changing 'static readonly' is not allowed
            //staticReadonlyName = "Mary";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Keywords key_01 = new Keywords("Bill");
            Keywords key_02 = new Keywords("Nick");

            Console.WriteLine($"const: {Keywords.constName}\treadonly: {key_01.readonlyName}\tstatic readonly: {Keywords.staticReadonlyName}");

            Console.WriteLine($"const: {Keywords.constName}\treadonly: {key_02.readonlyName}\tstatic readonly: {Keywords.staticReadonlyName}");

            // Changing 'const' is not allowed
            //Keywords.constName = "Bo";

            // Changing 'readonly' is not allowed
            //key_01.readonlyName = "Bo";

            // Changing 'static readonly' is not allowed
            //Keywords.staticReadonlyName = "Mary";
        }
    }
}
