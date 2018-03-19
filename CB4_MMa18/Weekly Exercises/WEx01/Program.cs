using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Lada", "Niva", Color.NavyBlue, new Engine());
    
            car.Accelerate(100);
            car.Stop();
            car.Accelerate(50);
            car.Accelerate(110);
            car.Accelerate(150);
            car.Stop();

            // If we create another engine
            Engine upgraded_engine = new Engine();

            // We can set it as the engine of the car
            car.Engine = upgraded_engine;
            
            // but we cannot change the details of the engine (its number)
            //car.Engine.EngineNumber = 100;

            // and we cannot change the car's brand
            //car.Brand = "Toyota";

            Console.ReadKey();
        }
    }
}
