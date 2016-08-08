using System;

namespace Chapter1
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            var b = true;
            if (b)
            {
                Console.WriteLine("Both theses lines");
                Console.WriteLine("Will be executed");
            }

            Console.ReadLine();
        }


    }
}
