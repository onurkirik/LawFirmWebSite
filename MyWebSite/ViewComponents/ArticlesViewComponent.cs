using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyWebSite.Entity.Entities;
using MyWebSite.Service.Services.Abstractions;

namespace MyWebSite.Web.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public ArticlesViewComponent(IArticleService articleService, ICategoryService categoryService, IMapper mapper)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var articles = await _articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            articles.OrderByDescending(a => a.CreatedDate);

            return View(articles);
        }
    }
}
