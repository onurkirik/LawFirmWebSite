using MyWebSite.Entity.DTOS.Articles;
using MyWebSite.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();

        Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId);
        Task CreateArticleAsync(ArticleAddDto asticleAddDto);
        Task UpdateArticleAsync(ArticleUpdateDto articleUpdatedto);
        Task SafeDeleteArticleAsync(Guid articleId);
    }
}
