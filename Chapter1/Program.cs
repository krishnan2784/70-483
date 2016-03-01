using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var bag = new ConcurrentBag<int> {42, 21};
            int result;
            if (bag.TryTake(out result))
                Console.WriteLine(result);
            if(bag.TryPeek(out result))
                Console.WriteLine("There is a next item: {0}", result);

        }
    }
}
