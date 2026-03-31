using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class stockitem1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupplierName",
                table: "StockItems");

            migrationBuilder.AlterColumn<string>(
                name: "SupplierIID",
                table: "StockItems",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_StockItems_SupplierIID",
                table: "StockItems",
                column: "SupplierIID");

            migrationBuilder.AddForeignKey(
                name: "FK_StockItems_Suppliers_SupplierIID",
                table: "StockItems",
                column: "SupplierIID",
                principalTable: "Suppliers",
                principalColumn: "IID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockItems_Suppliers_SupplierIID",
                table: "StockItems");

            migrationBuilder.DropIndex(
                name: "IX_StockItems_SupplierIID",
                table: "StockItems");

            migrationBuilder.AlterColumn<string>(
                name: "SupplierIID",
                table: "StockItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupplierName",
                table: "StockItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
