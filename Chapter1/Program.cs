using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            int[] n = { 0 };

            var up = Task.Run(() =>
            {
                for (var i = 0; i < 1000000; i++)
                    Interlocked.Increment(ref n[0]);

            });

            for (var i = 0; i < 1000000; i++)
                Interlocked.Increment(ref n[0]);

            up.Wait();
            Console.WriteLine(n[0]);
            Console.ReadKey();
        }
    }
}
