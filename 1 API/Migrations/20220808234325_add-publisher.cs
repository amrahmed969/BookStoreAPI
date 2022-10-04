using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_API.Migrations
{
    public partial class addpublisher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateRead" },
                values: new object[] { new DateTime(2022, 8, 10, 1, 43, 24, 172, DateTimeKind.Local).AddTicks(6104), new DateTime(2022, 8, 9, 1, 43, 24, 172, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateRead" },
                values: new object[] { new DateTime(2022, 8, 10, 1, 43, 24, 172, DateTimeKind.Local).AddTicks(6125), new DateTime(2022, 8, 9, 1, 43, 24, 172, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateRead" },
                values: new object[] { new DateTime(2022, 8, 10, 1, 43, 24, 172, DateTimeKind.Local).AddTicks(6130), new DateTime(2022, 8, 9, 1, 43, 24, 172, DateTimeKind.Local).AddTicks(6131) });

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publisher_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publisher_PublisherId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropIndex(
                name: "IX_Books_PublisherId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Books");

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

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateRead" },
                values: new object[] { new DateTime(2022, 8, 2, 5, 27, 26, 608, DateTimeKind.Local).AddTicks(1302), new DateTime(2022, 8, 1, 5, 27, 26, 608, DateTimeKind.Local).AddTicks(1303) });
        }
    }
}
