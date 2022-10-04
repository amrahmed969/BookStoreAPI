using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_API.Migrations
{
    public partial class seedinddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "CoverUrl", "DateAdded", "DateRead", "Description", "Genre", "IsRead", "Rate", "Title" },
                values: new object[] { 1, "https...", new DateTime(2022, 8, 2, 3, 36, 30, 23, DateTimeKind.Local).AddTicks(8348), new DateTime(2022, 8, 1, 3, 36, 30, 23, DateTimeKind.Local).AddTicks(8395), "firstdiscription", "comedy", true, 6, "firstbook" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
