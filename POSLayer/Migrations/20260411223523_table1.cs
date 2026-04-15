using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class table1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orders_TableIID",
                table: "Orders");

            migrationBuilder.AddColumn<DateTime>(
                name: "LockedUntil",
                table: "Tables",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableIID",
                table: "Orders",
                column: "TableIID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orders_TableIID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LockedUntil",
                table: "Tables");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableIID",
                table: "Orders",
                column: "TableIID",
                unique: true,
                filter: "[TableIID] IS NOT NULL");
        }
    }
}
