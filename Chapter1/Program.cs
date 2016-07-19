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
            var t1 = Task.Run(() =>
            {
                if (_value != 1) return;
                Thread.Sleep(1000);
                _value = 2;
            });
            var t2 = Task.Run(() =>
            {
                _value = 3;
            });
            Task.WaitAll(t1, t2);
            Console.WriteLine(_value);
            
            Console.ReadKey();
        }
    }
}
