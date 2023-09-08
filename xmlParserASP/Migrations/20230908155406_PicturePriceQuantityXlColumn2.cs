using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations
{
    /// <inheritdoc />
    public partial class PicturePriceQuantityXlColumn2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "picture_xl_column",
                table: "supplier_xml_settings",
                newName: "picture_price_quantity_xl_column");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "picture_price_quantity_xl_column",
                table: "supplier_xml_settings",
                newName: "picture_xl_column");
        }
    }
}
