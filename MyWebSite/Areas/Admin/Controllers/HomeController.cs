using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebSite.Service.Services.Abstractions;
using MyWebSite.Service.Services.Concrete;
using System.Diagnostics;

namespace MyWebSite.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService _articleService;

        public HomeController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public async Task<IActionResult> Index()
        {
            var article = await _articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            return View(article);
        }
    }
}
