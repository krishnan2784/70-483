using System;
using System.Threading;

namespace Chapter1
{
	public static class Program
	{
		public static void Main (string[] args)
		{
			var stopped = false;
			var t = new Thread (new ThreadStart (() => {
				while (!stopped) {
					Console.WriteLine ("Running ...");
					Thread.Sleep (1000);
				}
			}));

			t.Start ();
			Console.WriteLine ("Press any key to exit");
			Console.ReadKey ();

			stopped = true;
			t.Join ();
		}
	}
}
