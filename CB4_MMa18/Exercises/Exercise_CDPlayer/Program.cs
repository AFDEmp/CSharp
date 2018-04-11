using System;

namespace Exercise_CDPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Track track_01 = new Track("Unfaithful", 138);
            Track track_02 = new Track("Unforgiven", 245);

            CD best_of = new CD("Best of 1980", track_01, track_02, new Track("Untold", 190));

            Console.WriteLine(best_of);
        }
    }
}
