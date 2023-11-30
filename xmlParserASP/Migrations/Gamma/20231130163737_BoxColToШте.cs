using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations.Gamma
{
    /// <inheritdoc />
    public partial class BoxColToШте : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "qty_in_box_column",
                table: "mm_supplier_xml_settings");

            migrationBuilder.AddColumn<int>(
                name: "qty_in_box_column_number",
                table: "mm_supplier_xml_settings",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "qty_in_box_column_number",
                table: "mm_supplier_xml_settings");

            migrationBuilder.AddColumn<string>(
                name: "qty_in_box_column",
                table: "mm_supplier_xml_settings",
                type: "longtext",
                nullable: true);
        }
    }
}
