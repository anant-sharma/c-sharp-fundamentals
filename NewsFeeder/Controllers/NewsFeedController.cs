using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Toolkit.Parsers.Rss;

namespace NewsFeeder.Controllers
{
    [ApiController]
    [Route("news-feed")]
    public class NewsFeedController: ControllerBase
    {
        private readonly ILogger<NewsFeedController> _logger;
        private readonly HttpClient httpClient;

        public NewsFeedController(ILogger<NewsFeedController> logger)
        {
            _logger = logger;
            httpClient = new HttpClient();
        }

        [HttpGet]
        public async Task<IOrderedEnumerable<RssSchema>> Get()
        {
            var newsFeed = await this.GetNewsFeed();
            var sorted = from nf in newsFeed orderby nf.PublishDate descending select nf;
            return sorted;
        }

        private async Task<List<RssSchema>> GetNewsFeed()
        {
            string[] urls = new string[4]
            {
                "https://ir.tesla.com/rss/news-releases.xml",
                "https://ir.tesla.com/rss/sec-filings.xml",
                "https://ir.tesla.com/rss/sec-filings.xml?items=15&sub_group=4",
                "https://medium.com/feed/invironment/tagged/tesla"
            };

            List<Task<List<RssSchema>>> l = new List<Task<List<RssSchema>>>();

            foreach(var url in urls)
            {
                l.Add(GetNewsFeedFromUri(url));
            }

            var tasks = await Task.WhenAll(l);

            List<RssSchema> feed = new List<RssSchema>();
            foreach(var t in tasks)
            {
                feed.AddRange(t);
            }

            return feed;
        }

        private async Task<List<RssSchema>> GetNewsFeedFromUri(string uri)
        {
            string response = await httpClient.GetStringAsync(uri);
            List<RssSchema> newsFeed = new List<RssSchema>();

            if (response != null)
            {
                var parser = new RssParser();
                var rss = parser.Parse(response);

                foreach (var element in rss)
                {
                    newsFeed.Add(element);
                }
            }

            return newsFeed;
        }
    }
}
