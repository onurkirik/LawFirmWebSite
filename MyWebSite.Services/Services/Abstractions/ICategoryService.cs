using MyWebSite.Entity.DTOS.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.Service.Services.Abstractions
{
    public interface ICategoryService
    {
        public Task<List<CategoryDto>> GetAllCategoriesNonDeleted();
        Task UpdateCategoryAsync(CategoryUpdateDto categoryUpdatedto);
        Task CreateCategoryAsync(CategoryAddDto categoryAddDto);
        Task<CategoryDto> GetCategory(Guid categoryId);
    }
}