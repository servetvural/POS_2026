using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class removedbaseorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XorderItems_Orders_OrderIID",
                table: "XorderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_XorderItems_Xorders_XOrderIID",
                table: "XorderItems");

            migrationBuilder.DropIndex(
                name: "IX_XorderItems_XOrderIID",
                table: "XorderItems");

            migrationBuilder.DropColumn(
                name: "XOrderIID",
                table: "XorderItems");

            migrationBuilder.AddForeignKey(
                name: "FK_XorderItems_Xorders_OrderIID",
                table: "XorderItems",
                column: "OrderIID",
                principalTable: "Xorders",
                principalColumn: "IID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XorderItems_Xorders_OrderIID",
                table: "XorderItems");

            migrationBuilder.AddColumn<string>(
                name: "XOrderIID",
                table: "XorderItems",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_XorderItems_XOrderIID",
                table: "XorderItems",
                column: "XOrderIID");

            migrationBuilder.AddForeignKey(
                name: "FK_XorderItems_Orders_OrderIID",
                table: "XorderItems",
                column: "OrderIID",
                principalTable: "Orders",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_XorderItems_Xorders_XOrderIID",
                table: "XorderItems",
                column: "XOrderIID",
                principalTable: "Xorders",
                principalColumn: "IID");
        }
    }
}
