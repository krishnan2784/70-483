using System;
using System.Collections.Concurrent;

namespace Chapter1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            var queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);

            int result;
            if(queue.TryDequeue(out result))
                    Console.WriteLine("Dequeued: {0}", result );

            Console.ReadKey();
        }


    }
}
