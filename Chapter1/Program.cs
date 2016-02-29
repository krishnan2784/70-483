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
			var numbers = Enumerable.Range (0, 20);

				var parallelResult = numbers.AsParallel().Where(i=>IsEven(i));
				parallelResult.ForAll(d=> Console.WriteLine(d));

		}

		public static bool IsEven(int i)
		{
			
			return i % 2 == 0;
		}
	    
	}
}
