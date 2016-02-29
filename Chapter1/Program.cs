﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

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

	}
}
