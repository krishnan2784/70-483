using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;
            var task = Task.Run(() =>
                {
                    while (!token.IsCancellationRequested)
                    {
                        Console.WriteLine("*");
                        Thread.Sleep(1000);
                    }
                    token.ThrowIfCancellationRequested();
                }, token);


            try
            {
                Console.WriteLine("Press enter to stop the task");
                Console.ReadLine();
                cancellationTokenSource.Cancel();


            }
            catch (AggregateException exception)
            {
                Console.WriteLine(exception.InnerExceptions[0].Message);
            }

            Console.WriteLine("Press enter to end the application");
            Console.ReadLine();
        }
    }
}
