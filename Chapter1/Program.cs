using System;
using System.Threading;

namespace Chapter1
{
    public static class Program
    {
        private static ThreadLocal<int> _field = new ThreadLocal<int>(() => Thread.CurrentThread.ManagedThreadId);

        public static void Main(string[] args)
        {
             new Thread(() =>
            {
                for (var x = 0; x< _field.Value; x++)
                {
                    Console.WriteLine("Thread A: {0}", x);

                }
            }).Start();

            new Thread(() =>
            {
                for (var x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread B: {0}", x);

                }
            }).Start();
            Console.ReadKey();
        }
    }
}
