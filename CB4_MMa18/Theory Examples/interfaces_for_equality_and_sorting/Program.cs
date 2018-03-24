using System;
using System.Collections.Generic;

namespace interfaces_for_equality_and_sorting
{
    public interface IWalkable
    {
        void Walk(int meters);
    }

    public interface ISpeakable {
        void Speak(string voice);
    }

    public class Human : IWalkable, ISpeakable, IComparable, IEquatable<Human>, IEquatable<int> {
        public int Age { get; set; }

        public Human(int age) {
            Age = age;
        }

        // This implements IComparable interface
        public int CompareTo(object obj) {
            Human other = obj as Human;
            if (this.Age < other.Age) {
                return 1;
            }
            else if (this.Age > other.Age) {
                return -1;
            }
            else {
                return 0;
            }
        }

        // This is overriden from base class object
        public override bool Equals(object obj) {
            Human otherHuman = obj as Human;
            if (this.Age == otherHuman.Age) {
                return true;
            }
            return false;
        }

        // When we override Equals, we must also override GetHashCode and vice versa
        public override int GetHashCode() {
            return Age.GetHashCode();
        }

        // This implements IEquetable<Human> interface
        public bool Equals(Human otherHuman) {
            if (this.Age == otherHuman.Age) {
                return true;
            }
            return false;
        }

        // This implements IEquetable<int> interface
        public bool Equals(int otherAge) {
            if (this.Age == otherAge) {
                return true;
            }
            return false;
        }

        // This implements IWalkable interface
        public void Walk(int meters) {
            Console.WriteLine($"Human walked {meters} meters");
        }

        // This implements ISpeakable interface
        public void Speak(string voice) {
            Console.WriteLine(voice);
        }

        // This implements == operator
        // We can now compare two Humans, h1 == h2
        public static bool operator ==(Human h1, Human h2) {
            return h1.Equals(h2);
        }
        
        // When we implement == operator, we must also implement != operator
        public static bool operator !=(Human h1, Human h2) {
            return !h1.Equals(h2);
        }
    }

    public class Dog : IWalkable {
        // This implements IWalkable interface
        public void Walk(int meters) {
            Console.WriteLine($"Dog walked {meters} meters");
        } 
    }

    class Program
    {
        // We declare the parameter as IWalkable, 
        // so any object that implements IWalkable can be passed in
        static void WalkInMeters(IWalkable o, int meters) {
            o.Walk(meters);
        }

        static void Main(string[] args)
        {
            Human human1 = new Human(5);
            Dog dog1 = new Dog();
            WalkInMeters(human1, 10);
            WalkInMeters(dog1, 30);

            List<Human> humans = new List<Human>();
            humans.Add(new Human(25));
            humans.Add(new Human(10));
            humans.Add(new Human(29));
            humans.Add(new Human(75));
            humans.Add(new Human(40));
            humans.Add(new Human(2));
            humans.Add(new Human(47));

            Console.Write("Before sorting: ");
            for (int i = 0; i < humans.Count; i++) {
                Console.Write($"{humans[i].Age}, ");
            }
            Console.WriteLine();

            // This works correctly because we have implemented IComparable interface
            humans.Sort();
            
            Console.Write("After sorting: ");
            for (int i = 0; i < humans.Count; i++) {
                Console.Write($"{humans[i].Age}, ");
            }
            Console.WriteLine();

            Human h1 = new Human(5);
            Human h2 = new Human(5);
            bool areEqual = h1.Equals(h2);
            Console.WriteLine($"h1.Equals(h2) gives {areEqual}.");

            bool areEqual2 = h1.Equals(35);
            Console.WriteLine($"h1.Equals(35) gives {areEqual2}.");

            if (h1 == h2) {
                Console.WriteLine("h1 == h2 gives True.");
            }
            
            //Console.WriteLine(h1.GetHashCode());
        }


    }
}
