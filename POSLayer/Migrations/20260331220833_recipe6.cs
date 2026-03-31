using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class recipe6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_CategoryItems_CategoryItemIID",
                table: "Recipes");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_CategoryItems_CategoryItemIID",
                table: "Recipes",
                column: "CategoryItemIID",
                principalTable: "CategoryItems",
                principalColumn: "IID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_CategoryItems_CategoryItemIID",
                table: "Recipes");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_CategoryItems_CategoryItemIID",
                table: "Recipes",
                column: "CategoryItemIID",
                principalTable: "CategoryItems",
                principalColumn: "IID",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
