using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class linking1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShopIID",
                table: "Sessions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShopIID",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShopIID",
                table: "Bonus",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_ShopIID",
                table: "Sessions",
                column: "ShopIID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ShopIID",
                table: "Employees",
                column: "ShopIID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Shops_ShopIID",
                table: "Employees",
                column: "ShopIID",
                principalTable: "Shops",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Shops_ShopIID",
                table: "Sessions",
                column: "ShopIID",
                principalTable: "Shops",
                principalColumn: "IID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bonus_Shops_ShopIID",
                table: "Bonus");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Shops_ShopIID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Shops_ShopIID",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_ShopIID",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ShopIID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Bonus_ShopIID",
                table: "Bonus");

            migrationBuilder.DropColumn(
                name: "ShopIID",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "ShopIID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ShopIID",
                table: "Bonus");
        }
    }
}
