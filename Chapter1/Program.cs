using System;
using System.Collections.Concurrent;

namespace Chapter1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            var dict = new ConcurrentDictionary<string, int>();
            if(dict.TryAdd("k1", 42))
                Console.WriteLine("Added");
            if (dict.TryUpdate("k1", 21, 42))
                Console.WriteLine("42 updated to 21");
            dict["k1"] = 42;
            int r1 = dict.AddOrUpdate("k1", 3, (s,i)=>i*2);
            int r2 = dict.GetOrAdd("k2", 3);
            Console.WriteLine(r1);
            Console.WriteLine(r2);

            Console.ReadKey();

        }


    }
}
