using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyWebSite.DATA.Context;
using MyWebSite.Entity.Entities;
using MyWebSite.Service.Services.Abstractions;

namespace MyWebSite.Web.ViewComponents
{
    public class SuggestArticleViewComponent : ViewComponent
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _db;
        private int listLength;

        public SuggestArticleViewComponent(IArticleService articleService, ICategoryService categoryService, IMapper mapper, ApplicationDbContext db)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _mapper = mapper;
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(Guid articleId)
        {
            var articles = _db.Articles.OrderByDescending(a => a.CreatedDate).Where(a => a.ID != articleId).ToList();
            listLength = articles.Count();
            articles = articles.Take(listLength / 2).ToList();

            return View(articles);
        }
    }
}
