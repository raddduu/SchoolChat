using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolChatOriginal.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mgr2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Groups_GroupIdGroup",
                table: "Messages");

            migrationBuilder.AlterColumn<int>(
                name: "GroupIdGroup",
                table: "Messages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Groups_GroupIdGroup",
                table: "Messages",
                column: "GroupIdGroup",
                principalTable: "Groups",
                principalColumn: "IdGroup");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Groups_GroupIdGroup",
                table: "Messages");

            migrationBuilder.AlterColumn<int>(
                name: "GroupIdGroup",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Groups_GroupIdGroup",
                table: "Messages",
                column: "GroupIdGroup",
                principalTable: "Groups",
                principalColumn: "IdGroup",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
