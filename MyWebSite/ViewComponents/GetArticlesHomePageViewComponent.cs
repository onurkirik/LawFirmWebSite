using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebSite.DATA.Context;
using MyWebSite.Service.Services.Abstractions;
using MyWebSite.Service.Services.Concrete;

namespace MyWebSite.Web.ViewComponents
{
    public class GetArticlesHomePageViewComponent:ViewComponent
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _db;
        private int listLength;

        public GetArticlesHomePageViewComponent(IArticleService articleService, ICategoryService categoryService, IMapper mapper, ApplicationDbContext db)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _mapper = mapper;
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var articles = await _articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            var articles = _db.Articles.OrderByDescending(a => a.CreatedDate).ToList();
            listLength = articles.Count();
            articles = articles.Take(listLength / 2).ToList();

            return View(articles);
        }
    }
}
