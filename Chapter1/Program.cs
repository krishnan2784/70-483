﻿using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Linq;

namespace Chapter1
{
	public static class Program
	{
		public static void Main (string[] args)
		{
			var number = Enumerable.Range (0, 20);
			var parallelResult = number.AsParallel ().AsOrdered().Where (i => i % 2 == 0).AsSequential();
			foreach (var i in parallelResult.Take(5))
				Console.WriteLine (i);
		}

	    
	}
}
