using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class orders2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Waiter",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "LastModified");

            migrationBuilder.AddColumn<string>(
                name: "UserIID",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserIID",
                table: "Orders",
                column: "UserIID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserIID",
                table: "Orders",
                column: "UserIID",
                principalTable: "Users",
                principalColumn: "IID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserIID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserIID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserIID",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "LastModified",
                table: "Orders",
                newName: "OrderDate");

            migrationBuilder.AddColumn<string>(
                name: "Waiter",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
