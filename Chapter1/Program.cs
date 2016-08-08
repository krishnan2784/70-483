using System;

namespace Chapter1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var x = true;
            var y = false;
            if (x)
            {
                if (y)
                {
                    F();
                }
                else
                {
                    G();
                }
            }

            Console.ReadLine();
        }

        private static void F()
        {
            Console.WriteLine("Both x and y are true.");
        }

        private static void G()
        {
            Console.WriteLine("x is true and y is false");
        }
    }
}
