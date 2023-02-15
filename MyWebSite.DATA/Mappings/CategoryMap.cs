using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.DATA.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    ID = Guid.Parse("7DD728B5-EB76-4624-BC94-25E3B9C1BDE1"),
                    Name = "ASP .NET CORE",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    ID = Guid.Parse("38321B2D-2AF8-4B6E-9D05-4CC56C4F7695"),
                    Name = "Visual Studio",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                });
        }
    }
}
