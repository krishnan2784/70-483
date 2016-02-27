﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
	public static class Program
	{
		public static void Main (string[] args)
		{
			var parent = Task.Run (() => {
				var results = new Int32[3];
				new Task (() => results [0] = 0, TaskCreationOptions.AttachedToParent).Start();
				new Task (() => results [1] = 1, TaskCreationOptions.AttachedToParent).Start();
				new Task (() => results [2] = 2, TaskCreationOptions.AttachedToParent).Start();
				return results;
			});
			var finalTask = parent.ContinueWith (parentTask => {
				foreach (var i in parent.Result)
					Console.WriteLine (i);
			});
			finalTask.Wait ();
		}
	}
}
