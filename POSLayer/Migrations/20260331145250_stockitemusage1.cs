using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class stockitemusage1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockItemUsages",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StockItemIID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CategoryItemIID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SessionQuantity = table.Column<double>(type: "float", nullable: false),
                    XSessionQuantity = table.Column<double>(type: "float", nullable: false),
                    PreviousQuantity = table.Column<double>(type: "float", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockItemUsages", x => x.IID);
                    table.ForeignKey(
                        name: "FK_StockItemUsages_CategoryItems_CategoryItemIID",
                        column: x => x.CategoryItemIID,
                        principalTable: "CategoryItems",
                        principalColumn: "IID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_StockItemUsages_StockItems_StockItemIID",
                        column: x => x.StockItemIID,
                        principalTable: "StockItems",
                        principalColumn: "IID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockItemUsages_CategoryItemIID",
                table: "StockItemUsages",
                column: "CategoryItemIID");

            migrationBuilder.CreateIndex(
                name: "IX_StockItemUsages_StockItemIID",
                table: "StockItemUsages",
                column: "StockItemIID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockItemUsages");
        }
    }
}
