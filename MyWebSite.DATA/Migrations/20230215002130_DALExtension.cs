using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebSite.DATA.Migrations
{
    public partial class DALExtension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: new Guid("4f8f2607-dbf0-4b0a-b885-96138c2f3051"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: new Guid("71b9fadb-7249-44d0-8f66-61aead4054e9"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ID", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("3b5dc384-ca1e-4bd9-9192-a167ca8b7072"), new Guid("38321b2d-2af8-4b6e-9d05-4cc56c4f7695"), "lorem ipsum dolor hello world deneme makale içeriği data seed aşamasındali denemeler.", "Admin Test", new DateTime(2023, 2, 15, 3, 21, 30, 202, DateTimeKind.Local).AddTicks(9274), null, null, new Guid("abb2a50c-f530-4b5e-8342-67bc682b126e"), false, null, null, "Hello World", 25 },
                    { new Guid("72fa7a61-d195-4e38-955c-c285f989d108"), new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"), "lorem ipsum dolor hello world deneme makale içeriği data seed aşamasındali denemeler.", "Admin Test", new DateTime(2023, 2, 15, 3, 21, 30, 202, DateTimeKind.Local).AddTicks(9263), null, null, new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"), false, null, null, "Asp .NET Core Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("38321b2d-2af8-4b6e-9d05-4cc56c4f7695"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 15, 3, 21, 30, 202, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 15, 3, 21, 30, 202, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 15, 3, 21, 30, 203, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: new Guid("abb2a50c-f530-4b5e-8342-67bc682b126e"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 15, 3, 21, 30, 203, DateTimeKind.Local).AddTicks(80));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: new Guid("3b5dc384-ca1e-4bd9-9192-a167ca8b7072"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: new Guid("72fa7a61-d195-4e38-955c-c285f989d108"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ID", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("4f8f2607-dbf0-4b0a-b885-96138c2f3051"), new Guid("38321b2d-2af8-4b6e-9d05-4cc56c4f7695"), "lorem ipsum dolor hello world deneme makale içeriği data seed aşamasındali denemeler.", "Admin Test", new DateTime(2023, 2, 15, 0, 49, 47, 578, DateTimeKind.Local).AddTicks(8469), null, null, new Guid("abb2a50c-f530-4b5e-8342-67bc682b126e"), false, null, null, "Hello World", 25 },
                    { new Guid("71b9fadb-7249-44d0-8f66-61aead4054e9"), new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"), "lorem ipsum dolor hello world deneme makale içeriği data seed aşamasındali denemeler.", "Admin Test", new DateTime(2023, 2, 15, 0, 49, 47, 578, DateTimeKind.Local).AddTicks(8452), null, null, new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"), false, null, null, "Asp .NET Core Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("38321b2d-2af8-4b6e-9d05-4cc56c4f7695"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 15, 0, 49, 47, 578, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 15, 0, 49, 47, 578, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 15, 0, 49, 47, 578, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: new Guid("abb2a50c-f530-4b5e-8342-67bc682b126e"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 15, 0, 49, 47, 578, DateTimeKind.Local).AddTicks(9787));
        }
    }
}
