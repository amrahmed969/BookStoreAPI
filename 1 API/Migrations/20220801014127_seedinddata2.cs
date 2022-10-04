using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_API.Migrations
{
    public partial class seedinddata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateRead" },
                values: new object[] { new DateTime(2022, 8, 2, 3, 41, 26, 901, DateTimeKind.Local).AddTicks(2429), new DateTime(2022, 8, 1, 3, 41, 26, 901, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "CoverUrl", "DateAdded", "DateRead", "Description", "Genre", "IsRead", "Rate", "Title" },
                values: new object[] { 2, "https...", new DateTime(2022, 8, 2, 3, 41, 26, 901, DateTimeKind.Local).AddTicks(2448), new DateTime(2022, 8, 1, 3, 41, 26, 901, DateTimeKind.Local).AddTicks(2449), "firstdiscription", "comedy", true, 6, "secondbook" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateRead" },
                values: new object[] { new DateTime(2022, 8, 2, 3, 36, 30, 23, DateTimeKind.Local).AddTicks(8348), new DateTime(2022, 8, 1, 3, 36, 30, 23, DateTimeKind.Local).AddTicks(8395) });
        }
    }
}
