using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class addedimagesize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ImageSizeinKB",
                table: "Images",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageSizeinKB",
                table: "Images");
        }
    }
}
