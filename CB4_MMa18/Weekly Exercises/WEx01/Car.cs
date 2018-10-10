using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    public class Car
    {
        // Private readonly variables (we don't want to change brand & model after initialization)
        private readonly string _brand;
        private readonly string _model;
        // Private variable
        private int _speed;
        // Private const (remember const is static)
        private const int MAX_SPEED = 120;

        // Exposed Properties for _brand, _model plus Color and Engine
        public Color Color { get; set; }
        public string Brand { get { return _brand; } }
        public string Model { get { return _model; } }
        public Engine Engine { get; set; }

        public Car(string brand, string model, Color color, Engine engine)
        {
            _brand = brand;
            _model = model;
            Color = color;
            Engine = engine;
            _speed = 0;
        }

        public void Accelerate(float speed)
        {
            // If wanted speed is lower than current speed or current speed is already
            // at its maximum value, then just return
            if (speed <= _speed || _speed == MAX_SPEED)
            {
                return;
            }
            // If wanted speed is greater than maximum value, then set it to maximum value
            if (speed > MAX_SPEED) 
            {
                speed = MAX_SPEED;
            }
            // loop until wanted speed is reached
            while (_speed < speed)
            {
                Console.WriteLine($"{_brand} {_model} runs at {++_speed}");
            }
        }

        public void Stop()
        {
            // if car is moving, stop it!
            if (_speed > 0)
            {
                _speed = 0;
                Console.WriteLine("Car stopped!");
            }
        }
    }
}
