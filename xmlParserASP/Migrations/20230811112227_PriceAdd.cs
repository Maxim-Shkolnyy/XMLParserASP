using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations
{
    /// <inheritdoc />
    public partial class PriceAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "currency_node",
                table: "supplier_xml_settings",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "description_node",
                table: "supplier_xml_settings",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name_node",
                table: "supplier_xml_settings",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "price_node",
                table: "supplier_xml_settings",
                type: "longtext",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "currency_node",
                table: "supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "description_node",
                table: "supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "name_node",
                table: "supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "price_node",
                table: "supplier_xml_settings");
        }
    }
}
