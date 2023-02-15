using Microsoft.EntityFrameworkCore;
using MyWebSite.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.DATA.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
                new Image
                {
                    ID = Guid.Parse("7DD728B5-EB76-4624-BC94-25E3B9C1BDE1"),
                    FileName = "images/testimage",
                    FileType = "jpg",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Image
                {
                    ID = Guid.Parse("ABB2A50C-F530-4B5E-8342-67BC682B126E"),
                    FileName = "images/testimage",
                    FileType = "jpg",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                });
        }
    }
}
