using System;

namespace Chapter1
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            var a = true;
            var b = false;

            Console.WriteLine(a ^ a); // False
            Console.WriteLine(a ^ b); // True
            Console.WriteLine(b ^ b); // False
            Console.ReadLine();
        }


    }
}
