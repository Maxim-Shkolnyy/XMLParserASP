using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations
{
    /// <inheritdoc />
    public partial class ExchangeRateAndMarkup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "exchange_rate",
                table: "mm_supplier_xml_settings",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "markup",
                table: "mm_supplier_xml_settings",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "exchange_rate",
                table: "mm_supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "markup",
                table: "mm_supplier_xml_settings");
        }
    }
}
