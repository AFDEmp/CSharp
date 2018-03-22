using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string columns = "Column 1\tColumn 2\tColumn 3";
            Console.WriteLine(columns);
            //Output: Column 1        Column 2        Column 3


            string rows = "Row 1\r\nRow 2\r\nRow 3";
            Console.WriteLine(rows);
            /* Output:
              Row 1
              Row 2
              Row 3
            */

            string title = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge";
            Console.WriteLine(title);
            //Output: "The Æolean Harp", by Samuel Taylor Coleridge

            string filePath = @"C:\Users\Michalis Nikolaidis\Documents\";
            Console.WriteLine(filePath);
            //Output: C:\Users\scoleridge\Documents\

            string text = @"My pensive SARA ! thy soft cheek reclined
Thus on mine arm, most soothing sweet it is
To sit beside our Cot,...";
            Console.WriteLine(text);
            /* Output:
            My pensive SARA ! thy soft cheek reclined
               Thus on mine arm, most soothing sweet it is
               To sit beside our Cot,... 
            */

            string quote = @"Her name was ""Sara.""";
            Console.WriteLine(quote);
            //Output: Her name was "Sara."

            Console.Read();
        }
    }
}
