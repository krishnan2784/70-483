using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
	public static class Program
	{
		public static void Main (string[] args)
		{
			var result = Parallel.For (0, 1000, (int i, ParallelLoopState loopState) => 
				{
					if(i==500)
					{
						Console.WriteLine("Breaking Loop");
						loopState.Break();
					}
					return;
			});
			
		}
	}
}
