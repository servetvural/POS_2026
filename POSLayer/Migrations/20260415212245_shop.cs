using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class shop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VoidText",
                table: "Shops",
                newName: "TaxNumber");

            migrationBuilder.RenameColumn(
                name: "Vat",
                table: "Shops",
                newName: "CashDrawerText");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaxNumber",
                table: "Shops",
                newName: "VoidText");

            migrationBuilder.RenameColumn(
                name: "CashDrawerText",
                table: "Shops",
                newName: "Vat");
        }
    }
}
