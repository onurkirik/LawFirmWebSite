using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebSite.DATA.Migrations
{
    public partial class contentDescription : Migration
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
                name: "ContentDescription",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8f7013ee-da4e-4940-b813-986416f4453d"),
                column: "ConcurrencyStamp",
                value: "f22a3023-6e46-4530-82e8-27c9203e4dc2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ed86dd8-29b5-49c9-98f8-c29216bd234b"),
                column: "ConcurrencyStamp",
                value: "aef2e3db-159b-4f72-9d55-3caf605ce058");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f9d4c7a6-e007-44ef-87fd-06ea56ac2dbf"),
                column: "ConcurrencyStamp",
                value: "5bd84060-2603-4313-b848-e36e01cb9d6d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6a57d34c-0669-4bc7-b941-354e27da91f6"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cfc59570-efe7-4176-a124-b2b4fd62403d", "av.nurselenayzengin@gmail.com", "av.nurselenayzengin@gmail.com", "av.nurselenayzengin@gmail.com", "AQAAAAEAACcQAAAAEJMoYrxhDatgowihi7UlYXpcloVBD5oHS+GF/G7d0lI8PfI0CFSCow1k1DBt14mT7Q==", "21e0aa5c-8185-4ce6-b64a-151d241d46ee", "av.nurselenayzengin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0311af2-1efc-4094-aa60-3145efa32d57"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53c503cd-c1bf-4e18-862a-b4135fba323d", "AQAAAAEAACcQAAAAECQ1EJDIEIfJNxPjNPk1XtmEH1UVJCQslVswvUViImtmwDo0O7GhWi0yp1iyHZW/UA==", "b8a1a0fb-7aba-4f1a-b1b7-d1422b71e74f" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: new Guid("7dd728b5-eb76-4624-bc94-25e3b9c1bde1"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 12, 49, 32, 403, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: new Guid("abb2a50c-f530-4b5e-8342-67bc682b126e"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 20, 12, 49, 32, 403, DateTimeKind.Local).AddTicks(2890));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentDescription",
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
