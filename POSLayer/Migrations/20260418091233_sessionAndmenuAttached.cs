using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class sessionAndmenuAttached : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MenuIID",
                table: "Sessions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_MenuIID",
                table: "Sessions",
                column: "MenuIID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Menus_MenuIID",
                table: "Sessions",
                column: "MenuIID",
                principalTable: "Menus",
                principalColumn: "IID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Menus_MenuIID",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_MenuIID",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "MenuIID",
                table: "Sessions");
        }
    }
}
