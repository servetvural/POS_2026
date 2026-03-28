using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class entitytypeschanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EntityType",
                table: "Categories",
                newName: "CategoryType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryType",
                table: "Categories",
                newName: "EntityType");
        }
    }
}
