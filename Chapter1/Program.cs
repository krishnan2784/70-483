using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Chapter1
{
	public static class Program
	{
		public static void Main (string[] args)
		{
		    var result = DownloadContent().Result;
            Console.WriteLine(result);
		}

	    public static async Task<string> DownloadContent()
	    {
	        using (HttpClient client = new HttpClient())
	        {
	            var result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
	        }
	    }

	    public static Task SleepAsyncA(int milliSecondsTimeout)
	    {
	        return Task.Run(() => Thread.Sleep(milliSecondsTimeout));
	    }

        public static Task SleepAsyncB(int milliSecondsTimeout)
        {
            TaskCompletionSource<bool> taskCompletionSource = null;
            var t = new Timer(delegate { taskCompletionSource.TrySetResult(true); }, null, -1, -1);
            taskCompletionSource= new TaskCompletionSource<bool>(t);
            t.Change(milliSecondsTimeout, -1);
            return taskCompletionSource.Task;
        }

	    /*private static async void Button_Click(object sender, RoutedEventArgs e)
	    {
            var httpClient = new HttpClient();
	        var content = await httpClient.GetStringAsync("http://www.microsoft.com").ConfigureAwait(false);
            using (var sourceStream = new FileStream("temp.html", FileMode.Create, FileAccess.Write, FileShare.None, 4096, useAsync:true))
	        {
	            var encodedText = Encoding.Unicode.GetByteCount(content);
	        }

	    }*/
	}
}
