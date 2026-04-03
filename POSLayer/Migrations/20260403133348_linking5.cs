using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class linking5 : Migration
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
        }
    }
}
