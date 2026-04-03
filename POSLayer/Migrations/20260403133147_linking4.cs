using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class linking4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Distributions_DistributionIID",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Menus_MenuIID",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryItems_Distributions_DistributionIID",
                table: "CategoryItems");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeItems_CategoryItems_CategoryItemIID",
                table: "RecipeItems");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeItems_StockItems_StockItemIID",
                table: "RecipeItems");

            migrationBuilder.DropForeignKey(
                name: "FK_StockItemUsages_CategoryItems_CategoryItemIID",
                table: "StockItemUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_StockItemUsages_StockItems_StockItemIID",
                table: "StockItemUsages");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Distributions_DistributionIID",
                table: "Categories",
                column: "DistributionIID",
                principalTable: "Distributions",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Menus_MenuIID",
                table: "Categories",
                column: "MenuIID",
                principalTable: "Menus",
                principalColumn: "IID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryItems_Distributions_DistributionIID",
                table: "CategoryItems",
                column: "DistributionIID",
                principalTable: "Distributions",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeItems_CategoryItems_CategoryItemIID",
                table: "RecipeItems",
                column: "CategoryItemIID",
                principalTable: "CategoryItems",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeItems_StockItems_StockItemIID",
                table: "RecipeItems",
                column: "StockItemIID",
                principalTable: "StockItems",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_StockItemUsages_CategoryItems_CategoryItemIID",
                table: "StockItemUsages",
                column: "CategoryItemIID",
                principalTable: "CategoryItems",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_StockItemUsages_StockItems_StockItemIID",
                table: "StockItemUsages",
                column: "StockItemIID",
                principalTable: "StockItems",
                principalColumn: "IID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Distributions_DistributionIID",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Menus_MenuIID",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryItems_Distributions_DistributionIID",
                table: "CategoryItems");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeItems_CategoryItems_CategoryItemIID",
                table: "RecipeItems");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeItems_StockItems_StockItemIID",
                table: "RecipeItems");

            migrationBuilder.DropForeignKey(
                name: "FK_StockItemUsages_CategoryItems_CategoryItemIID",
                table: "StockItemUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_StockItemUsages_StockItems_StockItemIID",
                table: "StockItemUsages");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Distributions_DistributionIID",
                table: "Categories",
                column: "DistributionIID",
                principalTable: "Distributions",
                principalColumn: "IID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Menus_MenuIID",
                table: "Categories",
                column: "MenuIID",
                principalTable: "Menus",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryItems_Distributions_DistributionIID",
                table: "CategoryItems",
                column: "DistributionIID",
                principalTable: "Distributions",
                principalColumn: "IID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeItems_CategoryItems_CategoryItemIID",
                table: "RecipeItems",
                column: "CategoryItemIID",
                principalTable: "CategoryItems",
                principalColumn: "IID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeItems_StockItems_StockItemIID",
                table: "RecipeItems",
                column: "StockItemIID",
                principalTable: "StockItems",
                principalColumn: "IID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_StockItemUsages_CategoryItems_CategoryItemIID",
                table: "StockItemUsages",
                column: "CategoryItemIID",
                principalTable: "CategoryItems",
                principalColumn: "IID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_StockItemUsages_StockItems_StockItemIID",
                table: "StockItemUsages",
                column: "StockItemIID",
                principalTable: "StockItems",
                principalColumn: "IID",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
