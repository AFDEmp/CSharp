using System;

namespace Exercise_Tuition {
    public class Student {
        public int Age { get; set; }
        public string Name { get; set; }
        public decimal TuitionFee { get; set; }
        public DateTime StartingDate { get; set; }
        public string Telephone { get; set; }

        public Student() {
            StartingDate = new DateTime(2018, 1, 1);
        }

        public Student(int age, string name, decimal tuitionFee, DateTime startingDate, string telephone) {
            Age = age;
            this.Name = name;
            TuitionFee = tuitionFee;
            StartingDate = startingDate;
            Telephone = telephone;
        }

        public void RaiseTuitionFeeByPercentage(double percentage) {
            TuitionFee *= (decimal) (1.0 + percentage / 100.0);
            // The following line does the same
            //TuitionFee = TuitionFee * (decimal) (1.0 + percentage / 100.0);
        }
    }

}