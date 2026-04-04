using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class bigchange1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderIID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Xorders_XOrderIID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_StockItemUsages_CategoryItems_CategoryItemIID",
                table: "StockItemUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_StockItemUsages_StockItems_StockItemIID",
                table: "StockItemUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_XorderItems_Orders_OrderIID",
                table: "XorderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockItemUsages",
                table: "StockItemUsages");

            migrationBuilder.DropColumn(
                name: "EntityButtonIID",
                table: "XorderItems");

            migrationBuilder.DropColumn(
                name: "EntityIID",
                table: "XorderItems");

            migrationBuilder.DropColumn(
                name: "EntityName",
                table: "XorderItems");

            migrationBuilder.DropColumn(
                name: "EntityButtonIID",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "EntityIID",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "EntityName",
                table: "OrderItems");

            migrationBuilder.RenameTable(
                name: "StockItemUsages",
                newName: "StockItemUsage");

            migrationBuilder.RenameColumn(
                name: "EntityDisplayOrder",
                table: "XorderItems",
                newName: "CategoryDisplayOrder");

            migrationBuilder.RenameColumn(
                name: "X3total",
                table: "Sessions",
                newName: "X3Total");

            migrationBuilder.RenameColumn(
                name: "X2total",
                table: "Sessions",
                newName: "X2Total");

            migrationBuilder.RenameColumn(
                name: "X1total",
                table: "Sessions",
                newName: "X1Total");

            migrationBuilder.RenameColumn(
                name: "XOrderIID",
                table: "OrderItems",
                newName: "CategoryItemIID");

            migrationBuilder.RenameColumn(
                name: "EntityDisplayOrder",
                table: "OrderItems",
                newName: "CategoryDisplayOrder");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_XOrderIID",
                table: "OrderItems",
                newName: "IX_OrderItems_CategoryItemIID");

            migrationBuilder.RenameColumn(
                name: "EntityButtonIID",
                table: "KitchenOrderItems",
                newName: "CategoryItemIID");

            migrationBuilder.RenameIndex(
                name: "IX_StockItemUsages_StockItemIID",
                table: "StockItemUsage",
                newName: "IX_StockItemUsage_StockItemIID");

            migrationBuilder.RenameIndex(
                name: "IX_StockItemUsages_CategoryItemIID",
                table: "StockItemUsage",
                newName: "IX_StockItemUsage_CategoryItemIID");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "Xorders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "OrderIID",
                table: "XorderItems",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "DistributionIID",
                table: "XorderItems",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryItemIID",
                table: "XorderItems",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XOrderIID",
                table: "XorderItems",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "OrderIID",
                table: "OrderItems",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "DistributionIID",
                table: "OrderItems",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockItemUsage",
                table: "StockItemUsage",
                column: "IID");

            migrationBuilder.CreateIndex(
                name: "IX_XorderItems_CategoryItemIID",
                table: "XorderItems",
                column: "CategoryItemIID");

            migrationBuilder.CreateIndex(
                name: "IX_XorderItems_DistributionIID",
                table: "XorderItems",
                column: "DistributionIID");

            migrationBuilder.CreateIndex(
                name: "IX_XorderItems_XOrderIID",
                table: "XorderItems",
                column: "XOrderIID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_DistributionIID",
                table: "OrderItems",
                column: "DistributionIID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_CategoryItems_CategoryItemIID",
                table: "OrderItems",
                column: "CategoryItemIID",
                principalTable: "CategoryItems",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Distributions_DistributionIID",
                table: "OrderItems",
                column: "DistributionIID",
                principalTable: "Distributions",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderIID",
                table: "OrderItems",
                column: "OrderIID",
                principalTable: "Orders",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_StockItemUsage_CategoryItems_CategoryItemIID",
                table: "StockItemUsage",
                column: "CategoryItemIID",
                principalTable: "CategoryItems",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_StockItemUsage_StockItems_StockItemIID",
                table: "StockItemUsage",
                column: "StockItemIID",
                principalTable: "StockItems",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_XorderItems_CategoryItems_CategoryItemIID",
                table: "XorderItems",
                column: "CategoryItemIID",
                principalTable: "CategoryItems",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_XorderItems_Distributions_DistributionIID",
                table: "XorderItems",
                column: "DistributionIID",
                principalTable: "Distributions",
                principalColumn: "IID");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_CategoryItems_CategoryItemIID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Distributions_DistributionIID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderIID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_StockItemUsage_CategoryItems_CategoryItemIID",
                table: "StockItemUsage");

            migrationBuilder.DropForeignKey(
                name: "FK_StockItemUsage_StockItems_StockItemIID",
                table: "StockItemUsage");

            migrationBuilder.DropForeignKey(
                name: "FK_XorderItems_CategoryItems_CategoryItemIID",
                table: "XorderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_XorderItems_Distributions_DistributionIID",
                table: "XorderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_XorderItems_Orders_OrderIID",
                table: "XorderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_XorderItems_Xorders_XOrderIID",
                table: "XorderItems");

            migrationBuilder.DropIndex(
                name: "IX_XorderItems_CategoryItemIID",
                table: "XorderItems");

            migrationBuilder.DropIndex(
                name: "IX_XorderItems_DistributionIID",
                table: "XorderItems");

            migrationBuilder.DropIndex(
                name: "IX_XorderItems_XOrderIID",
                table: "XorderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_DistributionIID",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockItemUsage",
                table: "StockItemUsage");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "Xorders");

            migrationBuilder.DropColumn(
                name: "CategoryItemIID",
                table: "XorderItems");

            migrationBuilder.DropColumn(
                name: "XOrderIID",
                table: "XorderItems");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "StockItemUsage",
                newName: "StockItemUsages");

            migrationBuilder.RenameColumn(
                name: "CategoryDisplayOrder",
                table: "XorderItems",
                newName: "EntityDisplayOrder");

            migrationBuilder.RenameColumn(
                name: "X3Total",
                table: "Sessions",
                newName: "X3total");

            migrationBuilder.RenameColumn(
                name: "X2Total",
                table: "Sessions",
                newName: "X2total");

            migrationBuilder.RenameColumn(
                name: "X1Total",
                table: "Sessions",
                newName: "X1total");

            migrationBuilder.RenameColumn(
                name: "CategoryItemIID",
                table: "OrderItems",
                newName: "XOrderIID");

            migrationBuilder.RenameColumn(
                name: "CategoryDisplayOrder",
                table: "OrderItems",
                newName: "EntityDisplayOrder");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_CategoryItemIID",
                table: "OrderItems",
                newName: "IX_OrderItems_XOrderIID");

            migrationBuilder.RenameColumn(
                name: "CategoryItemIID",
                table: "KitchenOrderItems",
                newName: "EntityButtonIID");

            migrationBuilder.RenameIndex(
                name: "IX_StockItemUsage_StockItemIID",
                table: "StockItemUsages",
                newName: "IX_StockItemUsages_StockItemIID");

            migrationBuilder.RenameIndex(
                name: "IX_StockItemUsage_CategoryItemIID",
                table: "StockItemUsages",
                newName: "IX_StockItemUsages_CategoryItemIID");

            migrationBuilder.AlterColumn<string>(
                name: "OrderIID",
                table: "XorderItems",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DistributionIID",
                table: "XorderItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityButtonIID",
                table: "XorderItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityIID",
                table: "XorderItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EntityName",
                table: "XorderItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OrderIID",
                table: "OrderItems",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DistributionIID",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityButtonIID",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntityIID",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EntityName",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockItemUsages",
                table: "StockItemUsages",
                column: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderIID",
                table: "OrderItems",
                column: "OrderIID",
                principalTable: "Orders",
                principalColumn: "IID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Xorders_XOrderIID",
                table: "OrderItems",
                column: "XOrderIID",
                principalTable: "Xorders",
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

            migrationBuilder.AddForeignKey(
                name: "FK_XorderItems_Orders_OrderIID",
                table: "XorderItems",
                column: "OrderIID",
                principalTable: "Orders",
                principalColumn: "IID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
