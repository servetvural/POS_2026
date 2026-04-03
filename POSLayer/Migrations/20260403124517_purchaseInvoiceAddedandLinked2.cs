using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class purchaseInvoiceAddedandLinked2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoice_Suppliers_SupplierIID",
                table: "PurchaseInvoice");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoiceItem_PurchaseInvoice_PurchaseInvoiceIID",
                table: "PurchaseInvoiceItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseInvoice",
                table: "PurchaseInvoice");

            migrationBuilder.RenameTable(
                name: "PurchaseInvoice",
                newName: "PurchaseInvoices");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseInvoice_SupplierIID",
                table: "PurchaseInvoices",
                newName: "IX_PurchaseInvoices_SupplierIID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseInvoices",
                table: "PurchaseInvoices",
                column: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoiceItem_PurchaseInvoices_PurchaseInvoiceIID",
                table: "PurchaseInvoiceItem",
                column: "PurchaseInvoiceIID",
                principalTable: "PurchaseInvoices",
                principalColumn: "IID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoices_Suppliers_SupplierIID",
                table: "PurchaseInvoices",
                column: "SupplierIID",
                principalTable: "Suppliers",
                principalColumn: "IID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoiceItem_PurchaseInvoices_PurchaseInvoiceIID",
                table: "PurchaseInvoiceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoices_Suppliers_SupplierIID",
                table: "PurchaseInvoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseInvoices",
                table: "PurchaseInvoices");

            migrationBuilder.RenameTable(
                name: "PurchaseInvoices",
                newName: "PurchaseInvoice");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseInvoices_SupplierIID",
                table: "PurchaseInvoice",
                newName: "IX_PurchaseInvoice_SupplierIID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseInvoice",
                table: "PurchaseInvoice",
                column: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoice_Suppliers_SupplierIID",
                table: "PurchaseInvoice",
                column: "SupplierIID",
                principalTable: "Suppliers",
                principalColumn: "IID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoiceItem_PurchaseInvoice_PurchaseInvoiceIID",
                table: "PurchaseInvoiceItem",
                column: "PurchaseInvoiceIID",
                principalTable: "PurchaseInvoice",
                principalColumn: "IID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
