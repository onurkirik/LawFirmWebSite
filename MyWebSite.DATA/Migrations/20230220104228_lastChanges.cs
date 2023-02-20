using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebSite.DATA.Migrations
{
    public partial class lastChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: new Guid("bcf81871-cfa7-4f9d-945f-524c2b81b080"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: new Guid("e3e11dc4-d8da-44f7-9be4-e4143f376c38"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("38321b2d-2af8-4b6e-9d05-4cc56c4f7695"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8f7013ee-da4e-4940-b813-986416f4453d"),
                column: "ConcurrencyStamp",
                value: "b3af2735-2a13-42a1-98ca-ee7e4c92fabe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ed86dd8-29b5-49c9-98f8-c29216bd234b"),
                column: "ConcurrencyStamp",
                value: "872dc66f-60a7-4d87-abf9-63d5cdc4963c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f9d4c7a6-e007-44ef-87fd-06ea56ac2dbf"),
                column: "ConcurrencyStamp",
                value: "f6e5935c-1b3d-4f86-9425-bf1c0675c0f9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6a57d34c-0669-4bc7-b941-354e27da91f6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b6bbec62-c048-4e34-9746-76baa8cc3283", "av.nurselenayzengin@gmail.com", "av.nurselenayzengin@gmail.com", "av.nurselenayzengin@gmail.com", "AQAAAAEAACcQAAAAECbf77MBIgUABjG9rq8DOxZ4VzUkZDPeXQBFhyYgyFucXUbTsluR36uPbSm4bQqgEQ==", "56c70792-a008-4491-8b48-f5d026645138", "av.nurselenayzengin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0311af2-1efc-4094-aa60-3145efa32d57"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce516b2c-36e5-4231-b9f1-2aaba76957ab", "AQAAAAEAACcQAAAAEFhalmrz2lye45DWhPtXW6P2x2LvsbUnhnjPDUjCeTAUGK6HnXNv2Sfe78jJTZ0w3Q==", "edbb46ae-5225-4872-9dce-d27e6d87ffdf" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 13, 42, 26, 992, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: new Guid("abb2a50c-f530-4b5e-8342-67bc682b126e"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 13, 42, 26, 992, DateTimeKind.Local).AddTicks(9892));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Articles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8f7013ee-da4e-4940-b813-986416f4453d"),
                column: "ConcurrencyStamp",
                value: "266a94f3-fd50-4757-87e9-21b283b782c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ed86dd8-29b5-49c9-98f8-c29216bd234b"),
                column: "ConcurrencyStamp",
                value: "a7d1c9fc-c603-49da-9d33-7fe8a22c107e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f9d4c7a6-e007-44ef-87fd-06ea56ac2dbf"),
                column: "ConcurrencyStamp",
                value: "8505c1e2-bea7-4793-b16d-6b1bc084d932");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6a57d34c-0669-4bc7-b941-354e27da91f6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cd7e649a-e188-47a5-86ad-ddc55262b6bd", "superadmin@gmail.com", "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAECj6XLv4Pz7KOSV8pcDtbox+HC16bh6Op64Oh4+uFUFg/0beYGEWHB/TZPGR3lsgBA==", "70da4128-b842-4c39-8428-6e366ab4fde5", "superadmin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0311af2-1efc-4094-aa60-3145efa32d57"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39c626d6-62a1-41c4-92e6-9a8e3040df5a", "AQAAAAEAACcQAAAAEAb1zpwOCLgWKod6oN/WE3DXOSnaZG/usBP1Ita6izAjRvRDvUcU7qkc3E9lfUjfKg==", "c058da3b-a779-437a-a978-77603bdfc457" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("38321b2d-2af8-4b6e-9d05-4cc56c4f7695"), "Admin Test", new DateTime(2023, 2, 16, 16, 54, 22, 5, DateTimeKind.Local).AddTicks(7122), null, null, false, null, null, "Visual Studio" },
                    { new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"), "Admin Test", new DateTime(2023, 2, 16, 16, 54, 22, 5, DateTimeKind.Local).AddTicks(7114), null, null, false, null, null, "ASP .NET CORE" }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 16, 16, 54, 22, 5, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: new Guid("abb2a50c-f530-4b5e-8342-67bc682b126e"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 16, 16, 54, 22, 5, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ID", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[] { new Guid("bcf81871-cfa7-4f9d-945f-524c2b81b080"), new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"), "lorem ipsum dolor hello world deneme makale içeriği data seed aşamasındali denemeler.", "Admin Test", new DateTime(2023, 2, 16, 16, 54, 22, 5, DateTimeKind.Local).AddTicks(6599), null, null, new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"), false, null, null, "Asp .NET Core Deneme Makalesi", new Guid("6a57d34c-0669-4bc7-b941-354e27da91f6"), 15 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ID", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[] { new Guid("e3e11dc4-d8da-44f7-9be4-e4143f376c38"), new Guid("38321b2d-2af8-4b6e-9d05-4cc56c4f7695"), "lorem ipsum dolor hello world deneme makale içeriği data seed aşamasındali denemeler.", "Admin Test", new DateTime(2023, 2, 16, 16, 54, 22, 5, DateTimeKind.Local).AddTicks(6634), null, null, new Guid("abb2a50c-f530-4b5e-8342-67bc682b126e"), false, null, null, "Hello World", new Guid("b0311af2-1efc-4094-aa60-3145efa32d57"), 25 });
        }
    }
}
