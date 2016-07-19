using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {
        private static int _value = 1;

        public static void Main(string[] args)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;
            var taks = Task.Run(() =>
                {
                    while (!token.IsCancellationRequested)
                    {
                        Console.WriteLine("*");
                        Thread.Sleep(1000); 
                    }
                }, token);


            Console.WriteLine("Press enter to stop the task");
            Console.ReadLine();
            cancellationTokenSource.Cancel();

            Console.WriteLine("Press enter to end the application");
            Console.ReadLine();
        }
    }
}
