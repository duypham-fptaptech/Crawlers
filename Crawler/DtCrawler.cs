using System;
using System.Collections.Generic;
using System.Linq;
using Crawler.vnExpressCrawler;
using HtmlAgilityPack;

namespace Crawler
{
    public class DtCrawler
    {
        public Article CrawlDetail(string url)
        {
            try
            {
                var htmlWeb = new HtmlWeb();
                var htmlDocument = htmlWeb.Load(url);
                var titleNode = htmlDocument.DocumentNode.SelectSingleNode("//h1[contains(@class, 'dt-news__title')]");
                var title = titleNode.InnerText;
                var contentNode = htmlDocument.DocumentNode.SelectSingleNode("//article[contains(@class, 'dt-news__detail')]");
                var content = contentNode.InnerHtml;
                var imageNode = htmlDocument.DocumentNode.SelectSingleNode("//figure/img");
                var image = imageNode.Attributes["src"].Value;
                var article = new Article
                {
                    Title = title,
                    Content = content,
                    Image = image,
                    Url = url
                };
                return article;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public List<string> GetlistLink(string urlToGetListLink)
        {
            var listLink = new List<string>();
            var htmlWeb = new HtmlWeb();
            var htmlDocument = htmlWeb.Load(urlToGetListLink);
            var listNodeA = htmlDocument.DocumentNode.SelectNodes("//h2[contains(@class, 'news-item__related-item')]/a");
            for (var i = 0; i < listNodeA.Count; i++)
            {
                var link = listNodeA.ElementAt(i).Attributes["href"].Value;
                listLink.Add(link);
            }
            return listLink;
        }
    }
}