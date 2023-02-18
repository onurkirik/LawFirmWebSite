using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebSite.DATA.Context;
using MyWebSite.Entity.DTOS.Articles;
using MyWebSite.Entity.DTOS.Categories;
using MyWebSite.Entity.Entities;
using MyWebSite.Service.Services.Abstractions;
using MyWebSite.Service.Services.Concrete;

namespace MyWebSite.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper, ApplicationDbContext db)
        {
            _db = db;
            _categoryService = categoryService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllCategoriesNonDeleted();
            return View(categories);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            await _categoryService.CreateCategoryAsync(categoryAddDto);

            return RedirectToAction("Index", "Category", new { Area = "Admin" });
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid categoryId)
        {
            var category = await _categoryService.GetCategory(categoryId);

            var categoryUpdateDto = _mapper.Map<CategoryUpdateDto>(category);

            return View(categoryUpdateDto);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
        {
            await _categoryService.UpdateCategoryAsync(categoryUpdateDto);

            return RedirectToAction("Index", "Categories", new { Area = "Admin" });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid categoryId)
        {
            var deleteCategory = await _db.Categories.FindAsync(categoryId);
            if (deleteCategory == null)
                return NotFound();
            else
            {
                _db.Categories.Remove(deleteCategory);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index", "Category", new { Area = "Admin" });
            }
        }
    }
}
