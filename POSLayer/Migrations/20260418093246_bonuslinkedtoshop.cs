using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class bonuslinkedtoshop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bonus_Shops_ShopIID",
                table: "Bonus");

            migrationBuilder.DropIndex(
                name: "IX_Bonus_ShopIID",
                table: "Bonus");

            migrationBuilder.DropColumn(
                name: "ShopIID",
                table: "Bonus");

            migrationBuilder.AddColumn<string>(
                name: "BonusIID",
                table: "Shops",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shops_BonusIID",
                table: "Shops",
                column: "BonusIID");

            migrationBuilder.AddForeignKey(
                name: "FK_Shops_Bonus_BonusIID",
                table: "Shops",
                column: "BonusIID",
                principalTable: "Bonus",
                principalColumn: "IID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shops_Bonus_BonusIID",
                table: "Shops");

            migrationBuilder.DropIndex(
                name: "IX_Shops_BonusIID",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "BonusIID",
                table: "Shops");

            migrationBuilder.AddColumn<string>(
                name: "ShopIID",
                table: "Bonus",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bonus_ShopIID",
                table: "Bonus",
                column: "ShopIID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bonus_Shops_ShopIID",
                table: "Bonus",
                column: "ShopIID",
                principalTable: "Shops",
                principalColumn: "IID");
        }
    }
}
