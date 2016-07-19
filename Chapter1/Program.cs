using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            var longRunning = Task.Run(() => { Thread.Sleep(10000); });
            var index = Task.WaitAny(new[] {longRunning}, 1000);
            if (index == -1)
            {
                Console.WriteLine("Task Timed Out");
            }
        }
    }
}
