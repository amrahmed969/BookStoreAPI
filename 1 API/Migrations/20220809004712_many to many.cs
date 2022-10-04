using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_API.Migrations
{
    public partial class manytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publisher_PublisherId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publisher",
                table: "Publisher");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "Publisher",
                newName: "publishers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_publishers",
                table: "publishers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bookid = table.Column<int>(type: "int", nullable: false),
                    Authorid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Author_Authors_Authorid",
                        column: x => x.Authorid,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Author_Books_Bookid",
                        column: x => x.Bookid,
                        principalTable: "Books",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Author_Authorid",
                table: "Author",
                column: "Authorid");

            migrationBuilder.CreateIndex(
                name: "IX_Author_Bookid",
                table: "Author",
                column: "Bookid");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_publishers_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_publishers_PublisherId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_publishers",
                table: "publishers");

            migrationBuilder.RenameTable(
                name: "publishers",
                newName: "Publisher");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publisher",
                table: "Publisher",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "CoverUrl", "DateAdded", "DateRead", "Description", "Genre", "IsRead", "PublisherId", "Rate", "Title" },
                values: new object[] { 1, "https...", new DateTime(2022, 8, 10, 1, 43, 24, 172, DateTimeKind.Local).AddTicks(6104), new DateTime(2022, 8, 9, 1, 43, 24, 172, DateTimeKind.Local).AddTicks(6119), "firstdiscription", "comedy", true, 0, 6, "firstbook" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "CoverUrl", "DateAdded", "DateRead", "Description", "Genre", "IsRead", "PublisherId", "Rate", "Title" },
                values: new object[] { 2, "https...", new DateTime(2022, 8, 10, 1, 43, 24, 172, DateTimeKind.Local).AddTicks(6125), new DateTime(2022, 8, 9, 1, 43, 24, 172, DateTimeKind.Local).AddTicks(6126), "firstdiscription", "comedy", true, 0, 6, "secondbook" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "CoverUrl", "DateAdded", "DateRead", "Description", "Genre", "IsRead", "PublisherId", "Rate", "Title" },
                values: new object[] { 3, "https...", new DateTime(2022, 8, 10, 1, 43, 24, 172, DateTimeKind.Local).AddTicks(6130), new DateTime(2022, 8, 9, 1, 43, 24, 172, DateTimeKind.Local).AddTicks(6131), "Thirdiscription", "action", true, 0, 4, "Thirdbook" });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publisher_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
