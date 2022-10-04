using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_API.Migrations
{
    public partial class seedinddata3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateRead" },
                values: new object[] { new DateTime(2022, 8, 2, 5, 27, 26, 608, DateTimeKind.Local).AddTicks(1279), new DateTime(2022, 8, 1, 5, 27, 26, 608, DateTimeKind.Local).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateRead" },
                values: new object[] { new DateTime(2022, 8, 2, 5, 27, 26, 608, DateTimeKind.Local).AddTicks(1300), new DateTime(2022, 8, 1, 5, 27, 26, 608, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "CoverUrl", "DateAdded", "DateRead", "Description", "Genre", "IsRead", "Rate", "Title" },
                values: new object[] { 3, "https...", new DateTime(2022, 8, 2, 5, 27, 26, 608, DateTimeKind.Local).AddTicks(1302), new DateTime(2022, 8, 1, 5, 27, 26, 608, DateTimeKind.Local).AddTicks(1303), "Thirdiscription", "action", true, 4, "Thirdbook" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateRead" },
                values: new object[] { new DateTime(2022, 8, 2, 3, 41, 26, 901, DateTimeKind.Local).AddTicks(2429), new DateTime(2022, 8, 1, 3, 41, 26, 901, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateRead" },
                values: new object[] { new DateTime(2022, 8, 2, 3, 41, 26, 901, DateTimeKind.Local).AddTicks(2448), new DateTime(2022, 8, 1, 3, 41, 26, 901, DateTimeKind.Local).AddTicks(2449) });
        }
    }
}
