using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class linking3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XorderItems_Xorders_OrderIID",
                table: "XorderItems");

            migrationBuilder.DropColumn(
                name: "TableName",
                table: "Xorders");

            migrationBuilder.DropColumn(
                name: "Waiter",
                table: "Xorders");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Xorders",
                newName: "LastModified");

            migrationBuilder.AlterColumn<string>(
                name: "TableIID",
                table: "Xorders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SessionIID",
                table: "Xorders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserIID",
                table: "Xorders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XOrderIID",
                table: "OrderItems",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Xorders_SessionIID",
                table: "Xorders",
                column: "SessionIID");

            migrationBuilder.CreateIndex(
                name: "IX_Xorders_TableIID",
                table: "Xorders",
                column: "TableIID");

            migrationBuilder.CreateIndex(
                name: "IX_Xorders_UserIID",
                table: "Xorders",
                column: "UserIID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_XOrderIID",
                table: "OrderItems",
                column: "XOrderIID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Xorders_XOrderIID",
                table: "OrderItems",
                column: "XOrderIID",
                principalTable: "Xorders",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_XorderItems_Orders_OrderIID",
                table: "XorderItems",
                column: "OrderIID",
                principalTable: "Orders",
                principalColumn: "IID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Xorders_Sessions_SessionIID",
                table: "Xorders",
                column: "SessionIID",
                principalTable: "Sessions",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_Xorders_Tables_TableIID",
                table: "Xorders",
                column: "TableIID",
                principalTable: "Tables",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_Xorders_Users_UserIID",
                table: "Xorders",
                column: "UserIID",
                principalTable: "Users",
                principalColumn: "IID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Xorders_XOrderIID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_XorderItems_Orders_OrderIID",
                table: "XorderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Xorders_Sessions_SessionIID",
                table: "Xorders");

            migrationBuilder.DropForeignKey(
                name: "FK_Xorders_Tables_TableIID",
                table: "Xorders");

            migrationBuilder.DropForeignKey(
                name: "FK_Xorders_Users_UserIID",
                table: "Xorders");

            migrationBuilder.DropIndex(
                name: "IX_Xorders_SessionIID",
                table: "Xorders");

            migrationBuilder.DropIndex(
                name: "IX_Xorders_TableIID",
                table: "Xorders");

            migrationBuilder.DropIndex(
                name: "IX_Xorders_UserIID",
                table: "Xorders");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_XOrderIID",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "UserIID",
                table: "Xorders");

            migrationBuilder.DropColumn(
                name: "XOrderIID",
                table: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "LastModified",
                table: "Xorders",
                newName: "OrderDate");

            migrationBuilder.AlterColumn<string>(
                name: "TableIID",
                table: "Xorders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SessionIID",
                table: "Xorders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TableName",
                table: "Xorders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Waiter",
                table: "Xorders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_XorderItems_Xorders_OrderIID",
                table: "XorderItems",
                column: "OrderIID",
                principalTable: "Xorders",
                principalColumn: "IID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
