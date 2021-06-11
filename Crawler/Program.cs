using System;
using Crawler.vnExpressCrawler;

namespace Crawler
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            VnexpressCrawler vnexpressCrawler = new VnexpressCrawler();
            var link = vnexpressCrawler.GetlistLink("https://vnexpress.net/giai-tri");
            for (int i = 0; i < link.Count; i++)
            {                 
                Console.WriteLine(link);
            }
        }
    }
}