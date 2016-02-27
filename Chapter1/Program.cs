﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
			var t = Task.Run(()=> 
				{
					return 42;
				}
			).ContinueWith((i)=> {return i.Result *2;});
			Console.WriteLine (t.Result);

        }
    }
}
