using System;
using System.Threading;
using System.Threading.Tasks;

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
        }

        private static bool GetY()
        {
            Console.Write("This Method doesn't get called");
            return true;
        }
    }
}
