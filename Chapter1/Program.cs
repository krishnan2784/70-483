using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            bool x = true;
            bool y = false;
            bool result = x || y;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
