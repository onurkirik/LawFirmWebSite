using AutoMapper;
using MyWebSite.DATA.UnitOfWorks;
using MyWebSite.Entity.DTOS.Articles;
using MyWebSite.Entity.Entities;
using MyWebSite.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
        {
            var userId = Guid.Parse("6A57D34C-0669-4BC7-B941-354E27DA91F6");

            var article = new Article
            {
                Title = articleAddDto.Title,
                Content = articleAddDto.Content,
                CategoryId = articleAddDto.CategoryID,
                UserId = userId
            };

            await _unitOfWork.GetRepository<Article>().AddAsync(article);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync(a => !a.IsDeleted, a => a.Category);
            var map = _mapper.Map<List<ArticleDto>>(articles);
            return map;
        }

        public async Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetAsync(a => !a.IsDeleted && a.ID == articleId, a => a.Category);
            var map = _mapper.Map<ArticleDto>(article);
            return map;
        }

        public async Task UpdateArticleAsync(ArticleUpdateDto articleUpdatedto)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetAsync(a => !a.IsDeleted && a.ID == articleUpdatedto.ID, a => a.Category);

            article.Title = articleUpdatedto.Title;
            article.Content = articleUpdatedto.Content;

            await _unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await _unitOfWork.SaveAsync();
        }

        public async Task SafeDeleteArticleAsync(Guid articleId)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetbyguidAsync(articleId);

            
            await _unitOfWork.GetRepository<Article>().DeleteAsync(article);
            await _unitOfWork.SaveAsync();
        }
    }
}
