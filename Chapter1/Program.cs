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
            var gate = new object();
            var lockTaken = false;
            try
            {
                Monitor.Enter(gate, ref lockTaken);
            }
            finally
            {
                if(lockTaken)
                    Monitor.Exit(gate);
            }
            Console.ReadKey();
        }
    }
}
