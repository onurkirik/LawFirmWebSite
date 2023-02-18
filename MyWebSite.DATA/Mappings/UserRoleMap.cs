using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebSite.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.DATA.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(
                new AppUserRole
                {
                    UserId = Guid.Parse("6A57D34C-0669-4BC7-B941-354E27DA91F6"),
                    RoleId = Guid.Parse("F9D4C7A6-E007-44EF-87FD-06EA56AC2DBF")
                },
                new AppUserRole
                {
                    UserId = Guid.Parse("B0311AF2-1EFC-4094-AA60-3145EFA32D57"),
                    RoleId = Guid.Parse("8F7013EE-DA4E-4940-B813-986416F4453D")
                });
        }
    }
}
