using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class sessionorderstructurestarted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TableName",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "TableIID",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SessionIID",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SessionIID",
                table: "Orders",
                column: "SessionIID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableIID",
                table: "Orders",
                column: "TableIID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Sessions_SessionIID",
                table: "Orders",
                column: "SessionIID",
                principalTable: "Sessions",
                principalColumn: "IID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_TableIID",
                table: "Orders",
                column: "TableIID",
                principalTable: "Tables",
                principalColumn: "IID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Sessions_SessionIID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_TableIID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_SessionIID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TableIID",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "TableIID",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SessionIID",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TableName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
