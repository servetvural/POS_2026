using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class purchaseInvoiceAddedandLinked : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PurchaseInvoice",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SupplierIID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoice", x => x.IID);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoice_Suppliers_SupplierIID",
                        column: x => x.SupplierIID,
                        principalTable: "Suppliers",
                        principalColumn: "IID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseInvoiceItem",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PurchaseInvoiceIID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StockItemIID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoiceItem", x => x.IID);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceItem_PurchaseInvoice_PurchaseInvoiceIID",
                        column: x => x.PurchaseInvoiceIID,
                        principalTable: "PurchaseInvoice",
                        principalColumn: "IID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceItem_StockItems_StockItemIID",
                        column: x => x.StockItemIID,
                        principalTable: "StockItems",
                        principalColumn: "IID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoice_SupplierIID",
                table: "PurchaseInvoice",
                column: "SupplierIID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceItem_PurchaseInvoiceIID",
                table: "PurchaseInvoiceItem",
                column: "PurchaseInvoiceIID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceItem_StockItemIID",
                table: "PurchaseInvoiceItem",
                column: "StockItemIID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseInvoiceItem");

            migrationBuilder.DropTable(
                name: "PurchaseInvoice");
        }
    }
}
