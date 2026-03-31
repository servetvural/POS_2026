using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class recipe1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StockItemIID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CategoryItemIID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    QuantityType = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    MenuIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.IID);
                    table.ForeignKey(
                        name: "FK_Recipes_CategoryItems_CategoryItemIID",
                        column: x => x.CategoryItemIID,
                        principalTable: "CategoryItems",
                        principalColumn: "IID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Recipes_StockItems_StockItemIID",
                        column: x => x.StockItemIID,
                        principalTable: "StockItems",
                        principalColumn: "IID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryItemIID",
                table: "Recipes",
                column: "CategoryItemIID");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_StockItemIID",
                table: "Recipes",
                column: "StockItemIID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
