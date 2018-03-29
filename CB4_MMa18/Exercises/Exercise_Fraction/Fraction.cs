using System;

namespace Exercise_Fraction 
{
    public class Fraction : IComparable<Fraction>
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        // Property Decimal has only getter. We dont want to be able to assign a value!
        public decimal Decimal
        {
            get 
            { 
                return (decimal) Numerator / (decimal) Denominator; 
            }
        }

        // constructor with two parameters
        public Fraction(int numerator, int denominator) {
            Numerator = numerator;
            Denominator = denominator;
        }

        // constructor with one parameter
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

        // Fraction * Fraction
        public static Fraction operator * (Fraction fraction1, Fraction fraction2)
        {
            int numerator = fraction1.Numerator * fraction2.Numerator;
            int denominator = fraction1.Denominator * fraction2.Denominator;
            return new Fraction(numerator, denominator);
        }

        // Fraction * int
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

        // int * Fraction
        public static Fraction operator * (int i, Fraction fraction1) {
            return fraction1 * i;
        }

        // Create a Fraction from string
        public static Fraction Parse(string str) {
            string[] splitted = str.Split('/');
            if (splitted.Length != 2) {
                throw new ArgumentException("str must be of format 1/3");
            }
            int numerator;
            if (!int.TryParse(splitted[0], out numerator)) {
                throw new ArgumentException("str must be of format 'x/y' where x and y are integers");
            }
            int denominator;
            if (!int.TryParse(splitted[1], out denominator)) {
                throw new ArgumentException("str must be of format 'x/y' where x and y are integers");
            }
            return new Fraction(numerator, denominator);
        }

        // Cancel the Fraction: 5/15 becomes 1/3
        public void Cancel()
        {
            int min = Math.Min(this.Numerator, this.Denominator);
            for (int i = min; i >= 2; i--) {
                if ((this.Numerator % i) == 0 && (this.Denominator % i) == 0) {
                    this.Numerator /= i;
                    this.Denominator /= i;
                }
            }
        }

        // Implement CompareTo method of IComparable<Fraction> interface
        public int CompareTo(Fraction other)
        {
            return this.Decimal.CompareTo(other.Decimal);
        }
    }
}