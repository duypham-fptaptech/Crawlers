using System;
using System.Collections.Generic;

namespace Crawler.vnExpressCrawler
{
    public interface Crawler
    {
        Article CrawlDetail(String url);
        List<string> GetlistLink(string urlToGetListLink);
    }
}