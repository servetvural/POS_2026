using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class sessionorderstructurestarted2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerIID",
                table: "Orders");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerIID",
                table: "Orders",
                column: "CustomerIID",
                principalTable: "Customers",
                principalColumn: "IID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerIID",
                table: "Orders");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerIID",
                table: "Orders",
                column: "CustomerIID",
                principalTable: "Customers",
                principalColumn: "IID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
