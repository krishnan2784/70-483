using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Chapter1
{
	public static class Program
	{
        public static void Main(string[] args)
        {
            var col = new BlockingCollection<string>();
            var read = Task.Run(() =>
            {
                while (true)
                {
                    Console.WriteLine(col.Take());
                }
            });

            var write = Task.Run(() =>
            {
                while (true)
                {
                    var s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;
                    col.Add(s);
                }
            });
            write.Wait();
        }
    }
}
