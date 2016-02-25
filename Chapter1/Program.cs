using System;
using System.Threading;

namespace Chapter1
{
	public static class Program
	{
		public static void ThreadMethod()
		{
			for (int i = 0; i < 10; i++) {
				Console.WriteLine ("ThreadProc: {0}", i);
				Thread.Sleep(0);
			}
		}
		public static void Main (string[] args)
		{
			var t = new Thread (new ThreadStart (ThreadMethod));
			t.Start ();
			for (int i = 0; i < 4; i++) {
				Console.WriteLine ("Main Thread: Do some work");
				Thread.Sleep (0);
			}
			t.Join ();
		}
	}
}
