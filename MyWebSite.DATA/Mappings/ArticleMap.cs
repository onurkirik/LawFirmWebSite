using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.DATA.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(
                new Article
                {
                    ID = Guid.NewGuid(),
                    Title = "Asp .NET Core Deneme Makalesi",
                    Content = "lorem ipsum dolor hello world deneme makale içeriği data seed aşamasındali denemeler.",
                    ViewCount = 15,
                    CategoryId = Guid.Parse("7DD728B5-EB76-4624-BC94-25E3B9C1BDE1"),
                    ImageId = Guid.Parse("7DD728B5-EB76-4624-BC94-25E3B9C1BDE1"),
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    UserId = Guid.Parse("6A57D34C-0669-4BC7-B941-354E27DA91F6")
                },
                new Article
                {
                    ID = Guid.NewGuid(),
                    Title = "Hello World",
                    Content = "lorem ipsum dolor hello world deneme makale içeriği data seed aşamasındali denemeler.",
                    ViewCount = 25,
                    CategoryId = Guid.Parse("38321B2D-2AF8-4B6E-9D05-4CC56C4F7695"),
                    ImageId = Guid.Parse("ABB2A50C-F530-4B5E-8342-67BC682B126E"),
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    UserId = Guid.Parse("B0311AF2-1EFC-4094-AA60-3145EFA32D57")
                });
        }
    }
}
