using System;

namespace Exercise_Tuition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Populate Properties with assignment
            Student student1 = new Student();
            student1.Age = 25;
            student1.Name = "Bo";
            student1.TuitionFee = 10000;
            student1.StartingDate = DateTime.Now;
            student1.Telephone = "2102525250";

            // Populate Properties with constructor
            Student student2 = new Student(22, "Claire", 8500, new DateTime(2018, 2, 10), "2310788909");

            // Populate Properties with initialization
            Student student3 = new Student() {
                Age = 10,
                Name = "Mary"
            };
            
            Console.WriteLine($"{student1.Name} is {student1.Age} years old and pays {student1.TuitionFee}.");
            student1.RaiseTuitionFeeByPercentage(30);
            Console.WriteLine($"{student1.Name} is {student1.Age} years old and pays {student1.TuitionFee}.");
            Console.ReadKey();
        }
    }
}
