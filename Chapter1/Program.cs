using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
			var t = Task.Run(()=> 
				{
					for(int x =0; x<100;x++)
					{
						Console.Write('*');
					}
				}
			);
			t.Wait ();

        }
    }
}
