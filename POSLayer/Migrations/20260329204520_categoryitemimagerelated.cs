using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class categoryitemimagerelated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImagePosition",
                table: "CategoryItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemStyle",
                table: "CategoryItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePosition",
                table: "CategoryItems");

            migrationBuilder.DropColumn(
                name: "ItemStyle",
                table: "CategoryItems");
        }
    }
}
