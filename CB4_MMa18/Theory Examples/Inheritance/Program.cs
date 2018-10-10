using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        // Parent class (or base or ancestor)
        // Because GetString() is abstract
        // the whole class must be abstract
        public abstract class Dice {
            // all children have this property
            public int Sides { get; }

            // base constructor
            public Dice(int sides) {
                Sides = sides;
            }

            // virtual method has implementation
            // but allowes children to re-implement it
            public virtual void Print() {
                Console.WriteLine("We are in Dice");
            }

            // abstract method does not have implementation
            // and forces children to implement it
            public abstract string GetString();

        }

        // child class
        public class DiceNumbers : Dice {
            // this property is DiceNumbers-specific
            public string Color {get ; set; }

            // child constructor
            // 1. first call base constructor
            // 2. and then set Color 
            public DiceNumbers(int sides) : base(sides) {
                Color = "red";
            }

            // another child constructor
            public DiceNumbers(int sides, string color) : base(sides) {
                Color = color;
            }

            // we override Print()
            // Note that we are allowed to call base.Print()
            public override void Print() {
                base.Print();
                Console.WriteLine("Special Method in DiceNumbers");
            }

            // Implementation of GetString()
            // This is obligatory!
            public override string GetString() {
                string result = "";
                for (int i = 1; i <= Sides; i++) {
                    result += $"{i} ";
                }
                return result;
            }
        }

        // another child class
        public class DiceLetters : Dice {
            public DiceLetters(int sides) : base(sides) {}

            public override string GetString() {
                string result = "";
                for (int i = 1; i <= Sides; i++) {
                    result += $"{((char)(64 + i)).ToString()} ";
                }
                return result;
            }
        }

        static void Main(string[] args)
        {
            DiceNumbers myDiceNumbers = new DiceNumbers(20);

            DiceLetters myDiceLetters = new DiceLetters(6);

            // We use generic List<T> provided by .NET Framework
            // We choose the parent class as the type in List
            List<Dice> list = new List<Dice>();
            // But we can add the children!!
            list.Add(myDiceNumbers);
            list.Add(myDiceLetters);
            for (int i = 0; i < list.Count; i++) {
                // So we can call the methods without worrying which class is what item
                // This is the power of inheritence (welcome to dark side)
                Console.WriteLine(list[i].GetString());
                list[i].Print();
            }
        }
    }
}
