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
            if (args == null)
                throw new ArgumentNullException(nameof(args));


            private static volatile int _flag = 0;
        private static int _value = 0;
            public static void Thread1()
            {
                _value = 5;
                _flag = 1;
            }
            public static void Thread2()
            {
                    if (_flag == 1)
                        Console.WriteLine(_value);
            }
        }
    }
}
