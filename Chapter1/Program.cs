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
            if (args == null) throw new ArgumentNullException(nameof(args));
            var stack = new ConcurrentStack<int>();
            stack.Push(42);
            int result;
            if(stack.TryPop(out result))
                Console.WriteLine("Popped: {0}", result);
            stack.PushRange(new[] {1, 2, 3, 4});

            var values = new int[2];
            stack.TryPopRange(values);
            foreach (var i in values)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
