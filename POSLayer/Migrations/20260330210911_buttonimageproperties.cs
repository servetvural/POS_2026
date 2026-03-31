using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class buttonimageproperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WithImage",
                table: "CategoryItems");

            migrationBuilder.RenameColumn(
                name: "ItemStyle",
                table: "CategoryItems",
                newName: "TextImageRelation");

            migrationBuilder.RenameColumn(
                name: "ImagePosition",
                table: "CategoryItems",
                newName: "TextAlign");

            migrationBuilder.AddColumn<int>(
                name: "ButtonDisplayStyle",
                table: "CategoryItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImageAlign",
                table: "CategoryItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ButtonDisplayStyle",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImageAlign",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TextAlign",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TextImageRelation",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ButtonDisplayStyle",
                table: "CategoryItems");

            migrationBuilder.DropColumn(
                name: "ImageAlign",
                table: "CategoryItems");

            migrationBuilder.DropColumn(
                name: "ButtonDisplayStyle",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ImageAlign",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "TextAlign",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "TextImageRelation",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "TextImageRelation",
                table: "CategoryItems",
                newName: "ItemStyle");

            migrationBuilder.RenameColumn(
                name: "TextAlign",
                table: "CategoryItems",
                newName: "ImagePosition");

            migrationBuilder.AddColumn<bool>(
                name: "WithImage",
                table: "CategoryItems",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
