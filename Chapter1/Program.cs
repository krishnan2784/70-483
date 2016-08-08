using System;

namespace Chapter1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var b = false;
            var c = true;
            if (b)
            {
               Console.WriteLine("b is true");
            }
            else if (c)
            {
                Console.WriteLine("c is true");
            }
            else
            {
                Console.WriteLine("both b and c are false");
            }

            Console.ReadLine();
        }
    }
}
