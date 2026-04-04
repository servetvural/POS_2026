using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class linking7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TableGroups");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TableIID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CurrentOrderIID",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "ParentTableIID",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "Shape",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "TableType",
                table: "Tables");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableIID",
                table: "Orders",
                column: "TableIID",
                unique: true,
                filter: "[TableIID] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orders_TableIID",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "CurrentOrderIID",
                table: "Tables",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ParentTableIID",
                table: "Tables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Shape",
                table: "Tables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TableType",
                table: "Tables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TableGroups",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DOrder = table.Column<int>(type: "int", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableGroups", x => x.IID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableIID",
                table: "Orders",
                column: "TableIID");
        }
    }
}
