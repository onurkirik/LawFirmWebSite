using AutoMapper;
using MyWebSite.DATA.UnitOfWorks;
using MyWebSite.Entity.DTOS.Articles;
using MyWebSite.Entity.DTOS.Categories;
using MyWebSite.Entity.Entities;
using MyWebSite.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.Service.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateCategoryAsync(CategoryAddDto categoryAddDto)
        {
            var userId = Guid.Parse("6A57D34C-0669-4BC7-B941-354E27DA91F6");

            var category = new Category
            {
                Name = categoryAddDto.Name,
                CreatedBy = "Nurselenay ZENGİN",
                CreatedDate = DateTime.Now    
            };

            await _unitOfWork.GetRepository<Category>().AddAsync(category);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<CategoryDto>> GetAllCategoriesNonDeleted()
        {
            var categories = await _unitOfWork.GetRepository<Category>().GetAllAsync(x => !x.IsDeleted);
            var map = _mapper.Map<List<CategoryDto>>(categories);

            return map;
        }
        public async Task<CategoryDto> GetCategory(Guid categoryId)
        {
            var category = await _unitOfWork.GetRepository<Category>().GetAsync(a => a.ID == categoryId);
            var map = _mapper.Map<CategoryDto>(category);
            return map;
        }
        public async Task UpdateCategoryAsync(CategoryUpdateDto categoryUpdatedto)
        {
            var category = await _unitOfWork.GetRepository<Category>().GetAsync(a => !a.IsDeleted && a.ID == categoryUpdatedto.ID);

            category.Name = categoryUpdatedto.Name;

            await _unitOfWork.GetRepository<Category>().UpdateAsync(category);
            await _unitOfWork.SaveAsync();
        }
    }
}
