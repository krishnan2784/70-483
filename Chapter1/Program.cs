using System;
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
			var number = Enumerable.Range (0, 10);
			var parallelResult = number.AsParallel ().AsOrdered().Where (i => i % 2 == 0).ToArray ();
			foreach (var i in parallelResult)
				Console.WriteLine (i);
		}

	    
	}
}
