using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_API.Migrations
{
    public partial class renamebookauthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Author_Authors_Authorid",
                table: "Author");

            migrationBuilder.DropForeignKey(
                name: "FK_Author_Books_Bookid",
                table: "Author");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Author_books");

            migrationBuilder.RenameIndex(
                name: "IX_Author_Bookid",
                table: "Author_books",
                newName: "IX_Author_books_Bookid");

            migrationBuilder.RenameIndex(
                name: "IX_Author_Authorid",
                table: "Author_books",
                newName: "IX_Author_books_Authorid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author_books",
                table: "Author_books",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Author_books_Authors_Authorid",
                table: "Author_books",
                column: "Authorid",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Author_books_Books_Bookid",
                table: "Author_books",
                column: "Bookid",
                principalTable: "Books",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Author_books_Authors_Authorid",
                table: "Author_books");

            migrationBuilder.DropForeignKey(
                name: "FK_Author_books_Books_Bookid",
                table: "Author_books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author_books",
                table: "Author_books");

            migrationBuilder.RenameTable(
                name: "Author_books",
                newName: "Author");

            migrationBuilder.RenameIndex(
                name: "IX_Author_books_Bookid",
                table: "Author",
                newName: "IX_Author_Bookid");

            migrationBuilder.RenameIndex(
                name: "IX_Author_books_Authorid",
                table: "Author",
                newName: "IX_Author_Authorid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Author_Authors_Authorid",
                table: "Author",
                column: "Authorid",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Author_Books_Bookid",
                table: "Author",
                column: "Bookid",
                principalTable: "Books",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
