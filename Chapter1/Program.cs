using System;
using System.Threading;

namespace Chapter1
{
    public static class Program
    {
        [ThreadStatic]
        public static int _field;

        public static void Main(string[] args)
        {
             new Thread(() =>
            {
                for (int i = 0; i<10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);

                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);

                }
            }).Start();
            Console.ReadKey();
        }
    }
}
