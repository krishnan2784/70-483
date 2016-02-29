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
			try
			{
				var parallelResult = numbers.AsParallel().Where(i=>IsEven(i));
				parallelResult.ForAll(d=> Console.WriteLine(d));
			}
			catch(AggregateException e) 
			{
				Console.WriteLine ("There were {0} exceptions", e.InnerExceptions.Count);
			}
		}

		public static bool IsEven(int i)
		{
			if (i % 10 == 0)
				throw new ArgumentException ("i");
			return i % 2 == 0;
		}
	    
	}
}
