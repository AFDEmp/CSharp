namespace StaticVsInstance
{
    class SampleClass
    {
        public void InstanceMethod()
        {
            System.Console.WriteLine("A message from the instance method.");
        }

        static public void StaticMethod()
        {
            System.Console.WriteLine("A message from the static method.");
        }
    }
}
