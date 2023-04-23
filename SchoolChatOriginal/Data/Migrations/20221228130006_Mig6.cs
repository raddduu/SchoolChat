using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolChatOriginal.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Categories_CategoryIdCategory",
                table: "Groups");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryIdCategory",
                table: "Groups",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Categories_CategoryIdCategory",
                table: "Groups",
                column: "CategoryIdCategory",
                principalTable: "Categories",
                principalColumn: "IdCategory");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Categories_CategoryIdCategory",
                table: "Groups");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryIdCategory",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Categories_CategoryIdCategory",
                table: "Groups",
                column: "CategoryIdCategory",
                principalTable: "Categories",
                principalColumn: "IdCategory",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
