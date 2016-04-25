using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            var n = 0;
            var _lock = new object();

            var up = Task.Run(() =>
            {
                for (var i = 0; i < 1000000; i++)
                    lock (_lock)
                        n++;
            });

            for (var i = 0; i < 1000000; i++)
                lock (_lock)
                    n--;

            up.Wait();
            Console.WriteLine(n);
            Console.ReadKey();

        }


    }
}
