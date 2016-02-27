using System;
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

				var taskFactory = new TaskFactory (TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);
				taskFactory.StartNew (() => results [0] = 0);
				taskFactory.StartNew (() => results [1] = 1);
				taskFactory.StartNew (() => results [2] = 2);
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
