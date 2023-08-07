using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations
{
    /// <inheritdoc />
    public partial class Max4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "param_attribute",
                table: "supplier_xml_settings",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "path",
                table: "supplier_xml_settings",
                type: "longtext",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "param_attribute",
                table: "supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "path",
                table: "supplier_xml_settings");
        }
    }
}
