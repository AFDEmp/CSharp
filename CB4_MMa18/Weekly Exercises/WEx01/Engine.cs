namespace Exercise_01
{
    public class Engine 
    {
        // private static variable
        private static int counter;

        // private readonly variable (we do not want to change it after initialization)
        private readonly int _engineNumber;

        // Exposed Propety which allows only reading _engineNumber (get)
        public int EngineNumber { get { return _engineNumber; } }

        // normal constructor
        public Engine() 
        {
            _engineNumber = ++counter;
        }

        // static constructor (called once and only once, when the first object of this class is created)
        static Engine() 
        {
            counter = 0;
        }    
    }
}
