using System;

namespace Chapter1
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            var value = 42;
            var result = (0 < value) && (value < 100);
            Console.Write(result.ToString());
            Console.ReadLine();
        }


    }
}
