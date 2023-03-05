using AspNetCore.SEOHelper.Sitemap;
using Microsoft.AspNetCore.Mvc;
using MyWebSite.Service.Services.Abstractions;
using static System.Net.WebRequestMethods;

namespace MyWebSite.Web.Controllers
{
    public class SiteMapController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IArticleService _articleService;
        public SiteMapController(IWebHostEnvironment env, IArticleService articleService)
        {
            _env = env;
            _articleService = articleService;
        }

        [HttpGet]
        public async Task<IActionResult> Generate()
        {

            var list = new List<SitemapNode>();
            list.Add(new SitemapNode
            {
                LastModified = DateTime.UtcNow,
                Priority = 1,
                Url = "https://av-nurselenay.azurewebsites.net",
                Frequency = SitemapFrequency.Daily
            });
            list.Add(new SitemapNode
            {
                LastModified = DateTime.UtcNow,
                Priority = 0.9,
                Url = "https://av-nurselenay.azurewebsites.net/#practiseArea",
                Frequency = SitemapFrequency.Daily
            });
            list.Add(new SitemapNode
            {
                LastModified = DateTime.UtcNow,
                Priority = 0.8,
                Url = "https://av-nurselenay.azurewebsites.net/Article",
                Frequency = SitemapFrequency.Daily
            });

            var articles = await _articleService.GetAllArticlesWithCategoryNonDeletedAsync();

            foreach (var article in articles)
            {
                list.Add(new SitemapNode
                {
                    LastModified = DateTime.UtcNow,
                    Priority = 0.8,
                    Url = $"https://av-nurselenay.azurewebsites.net/Article/ViewFullArticle?articleId={article.ID}",
                    Frequency = SitemapFrequency.Daily
                });
            }

            new SitemapDocument().CreateSitemapXML(list, _env.WebRootPath);

            return Ok();
        }
    }
}
