using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolChatOriginal.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mgr3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Groups_GroupIdGroup",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_GroupIdGroup",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "GroupIdGroup",
                table: "Messages");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupIdGroup",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_GroupIdGroup",
                table: "Messages",
                column: "GroupIdGroup");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Groups_GroupIdGroup",
                table: "Messages",
                column: "GroupIdGroup",
                principalTable: "Groups",
                principalColumn: "IdGroup");
        }
    }
}
