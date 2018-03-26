using System;

namespace Exercise_Fraction 
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        // constructor with parameters
        public Fraction(int numerator, int denominator) {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction(int numerator) {
            Numerator = numerator;
            Denominator = 1;
        }

        // constructor with no parameters
        public Fraction() {
            Numerator = 0;
            Denominator = 1;
        }

        public override string ToString() {
            string result = "";
            if (Numerator * Denominator < 0) {
                result += "-";
            }
            result += Math.Abs(Numerator);
            result += "/";
            result += Math.Abs(Denominator);
            return result;

            // This is a very simple implementation
            //return $"{Numerator}/{Denominator}";
        }

        public static Fraction operator * (Fraction fraction1, Fraction fraction2)
        {
            int numerator = fraction1.Numerator * fraction2.Numerator;
            int denominator = fraction1.Denominator * fraction2.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator * (Fraction fraction1, int i) 
        {
            return fraction1 * new Fraction(i);

            // If i didn't have Fraction(int numerator)
            // or if optimization was a big issue
            //
            //int numerator = fraction1.Numerator * i;
            //int denominator = fraction1.Denominator;
            //return new Fraction(numerator, denominator);
        }

        public static Fraction operator * (int i, Fraction fraction1) {
            return fraction1 * i;
        }

        public static Fraction Parse(string str) {
            string[] splitted = str.Split('/');
            if (splitted.Length != 2) {
                throw new ArgumentException("str must be of format 1/3");
            }
            int numerator = int.Parse(splitted[0]);
            int denominator = int.Parse(splitted[1]);
            return new Fraction(numerator, denominator);
        }
    }
}