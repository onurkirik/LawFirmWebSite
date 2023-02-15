using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebSite.DATA.Migrations
{
    public partial class DataSeedCompleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("38321b2d-2af8-4b6e-9d05-4cc56c4f7695"), "Admin Test", new DateTime(2023, 2, 15, 0, 49, 47, 578, DateTimeKind.Local).AddTicks(9208), null, null, false, null, null, "Visual Studio" },
                    { new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"), "Admin Test", new DateTime(2023, 2, 15, 0, 49, 47, 578, DateTimeKind.Local).AddTicks(9180), null, null, false, null, null, "ASP .NET CORE" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"), "Admin Test", new DateTime(2023, 2, 15, 0, 49, 47, 578, DateTimeKind.Local).AddTicks(9778), null, null, "images/testimage", "jpg", false, null, null },
                    { new Guid("abb2a50c-f530-4b5e-8342-67bc682b126e"), "Admin Test", new DateTime(2023, 2, 15, 0, 49, 47, 578, DateTimeKind.Local).AddTicks(9787), null, null, "images/testimage", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ID", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("4f8f2607-dbf0-4b0a-b885-96138c2f3051"), new Guid("38321b2d-2af8-4b6e-9d05-4cc56c4f7695"), "lorem ipsum dolor hello world deneme makale içeriği data seed aşamasındali denemeler.", "Admin Test", new DateTime(2023, 2, 15, 0, 49, 47, 578, DateTimeKind.Local).AddTicks(8469), null, null, new Guid("abb2a50c-f530-4b5e-8342-67bc682b126e"), false, null, null, "Hello World", 25 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ID", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("71b9fadb-7249-44d0-8f66-61aead4054e9"), new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"), "lorem ipsum dolor hello world deneme makale içeriği data seed aşamasındali denemeler.", "Admin Test", new DateTime(2023, 2, 15, 0, 49, 47, 578, DateTimeKind.Local).AddTicks(8452), null, null, new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"), false, null, null, "Asp .NET Core Deneme Makalesi", 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: new Guid("4f8f2607-dbf0-4b0a-b885-96138c2f3051"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: new Guid("71b9fadb-7249-44d0-8f66-61aead4054e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("38321b2d-2af8-4b6e-9d05-4cc56c4f7695"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ID",
                keyValue: new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ID",
                keyValue: new Guid("abb2a50c-f530-4b5e-8342-67bc682b126e"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
