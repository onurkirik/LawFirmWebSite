using AspNetCore.SEOHelper.Sitemap;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
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
        public async Task<IActionResult> Index()
        {

            var list = new List<SitemapNode>();
            list.Add(new SitemapNode
            {
                LastModified = DateTime.UtcNow,
                Priority = 1,
                Url = "https://nurselenayzengin.av.tr",
                Frequency = SitemapFrequency.Daily
            });
            list.Add(new SitemapNode
            {
                LastModified = DateTime.UtcNow,
                Priority = 0.9,
                Url = "https://nurselenayzengin.av.tr/#practiseArea",
                Frequency = SitemapFrequency.Daily
            });
            list.Add(new SitemapNode
            {
                LastModified = DateTime.UtcNow,
                Priority = 0.8,
                Url = "https://nurselenayzengin.av.tr/Article",
                Frequency = SitemapFrequency.Daily
            });

            var articles = await _articleService.GetAllArticlesWithCategoryNonDeletedAsync();

            foreach (var article in articles)
            {
                list.Add(new SitemapNode
                {
                    LastModified = DateTime.UtcNow,
                    Priority = 0.8,
                    Url = $"https://nurselenayzengin.av.tr/Article/ViewFullArticle?articleId={article.ID}",
                    Frequency = SitemapFrequency.Daily
                });
            }

            new SitemapDocument().CreateSitemapXML(list, _env.WebRootPath);

            var fileName = System.IO.Path.GetFileName($"{_env.WebRootPath}/sitemap.xml");
            var content = await System.IO.File.ReadAllBytesAsync($"{_env.WebRootPath}/sitemap.xml");
            new FileExtensionContentTypeProvider()
                .TryGetContentType(fileName, out string contentType);
            return File(content, contentType, fileName);

        }
    }
}
