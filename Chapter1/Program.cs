using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            var x = 42;
            var y = 1;
            var z = 42;
            Console.WriteLine(x==y);
            Console.WriteLine(x==z);
            Console.ReadLine();
        }
    }
}
