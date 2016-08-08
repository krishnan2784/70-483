using System;

namespace Chapter1
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            OrShortCircuit();
            Console.ReadLine();
        }

        public static void OrShortCircuit()
        {
            bool x = true;
            bool result = x || GetY();
            Console.WriteLine(result.ToString());
        }

        private static bool GetY()
        {
            Console.Write("This method doesn't get called");
            return true;
        }

        public static void Process(string input)
        {
            bool result = (input != null) && input.StartsWith("v");

        }

    }
}
