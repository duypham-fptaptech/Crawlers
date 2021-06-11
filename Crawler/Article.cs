using System;

namespace Crawler.vnExpressCrawler
{
    public class Article
    {
        public String Url { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public String Image { get; set; }

        public override string ToString()
        {
            return $"Url: {Url}, Title: {Title}, Content: {Content}, Image: {Image}";
        }
    }
}