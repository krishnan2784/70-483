using System;
using System.Threading;

namespace Chapter1
{
	public static class Program
	{
		public static void ThreadMethod(object o)
		{
			for (int i = 0; i < (int)o; i++) {
				Console.WriteLine ("ThreadProc: {0}", i);
				Thread.Sleep(1000);
			}
		}
		public static void Main (string[] args)
		{
			var t = new Thread (new ParameterizedThreadStart (ThreadMethod));

			t.Start (5);
			/*
			for (int i = 0; i < 4; i++) {
				Console.WriteLine ("Main Thread: Do some work");
				Thread.Sleep (0);
			}

			*/
			t.Join ();}
	}
}
