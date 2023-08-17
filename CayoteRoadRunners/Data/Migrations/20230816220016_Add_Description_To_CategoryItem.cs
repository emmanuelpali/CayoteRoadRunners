using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CayoteRoadRunners.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_Description_To_CategoryItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CategoryItem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CategoryItem");
        }
    }
}
