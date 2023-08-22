using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CayoteRoadRunners.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatingapplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "USerCategory",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_USerCategory_UserId",
                table: "USerCategory",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_USerCategory_AspNetUsers_UserId",
                table: "USerCategory",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_USerCategory_AspNetUsers_UserId",
                table: "USerCategory");

            migrationBuilder.DropIndex(
                name: "IX_USerCategory_UserId",
                table: "USerCategory");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "USerCategory",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
