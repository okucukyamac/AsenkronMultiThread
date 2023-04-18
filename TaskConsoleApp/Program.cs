using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TaskConsoleApp
{
    internal class Program
    {
        private async static Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var mytask = new HttpClient().GetStringAsync("https://www.google.com");

            Console.WriteLine("Arada yapılacak işler.");

            var data = await mytask;

            Console.WriteLine(data.Length.ToString());


            //Console.WriteLine("Hello World!");

            //var mytask = new HttpClient().GetStringAsync("https://www.google.com").ContinueWith((data) =>
            //{
            //    Console.WriteLine(data.Result.Length);
            //});

            //Console.WriteLine("Arada yapılacak işler.");

            //await mytask;

        }
    }
}
