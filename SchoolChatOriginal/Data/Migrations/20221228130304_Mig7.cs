using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolChatOriginal.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Categories_CategoryIdCategory",
                table: "Groups");

            migrationBuilder.RenameColumn(
                name: "CategoryIdCategory",
                table: "Groups",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_CategoryIdCategory",
                table: "Groups",
                newName: "IX_Groups_CategoryId");

            migrationBuilder.RenameColumn(
                name: "IdCategory",
                table: "Categories",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Categories_CategoryId",
                table: "Groups",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Categories_CategoryId",
                table: "Groups");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Groups",
                newName: "CategoryIdCategory");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_CategoryId",
                table: "Groups",
                newName: "IX_Groups_CategoryIdCategory");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "IdCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Categories_CategoryIdCategory",
                table: "Groups",
                column: "CategoryIdCategory",
                principalTable: "Categories",
                principalColumn: "IdCategory");
        }
    }
}
