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
                int r = 42;
                b = false;
            }

            Console.ReadLine();
        }


    }
}
