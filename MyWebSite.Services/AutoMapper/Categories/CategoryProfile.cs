using AutoMapper;
using MyWebSite.Entity.DTOS.Articles;
using MyWebSite.Entity.DTOS.Categories;
using MyWebSite.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.Service.AutoMapper.Categories
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<CategoryUpdateDto, CategoryDto>().ReverseMap();

        }
    }
}
