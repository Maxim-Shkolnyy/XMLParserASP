using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations
{
    /// <inheritdoc />
    public partial class Max : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_supplier_xml_settings_supplier_id",
                table: "supplier_xml_settings");

            migrationBuilder.CreateIndex(
                name: "ix_supplier_xml_settings_supplier_id",
                table: "supplier_xml_settings",
                column: "supplier_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_supplier_xml_settings_supplier_id",
                table: "supplier_xml_settings");

            migrationBuilder.CreateIndex(
                name: "ix_supplier_xml_settings_supplier_id",
                table: "supplier_xml_settings",
                column: "supplier_id",
                unique: true);
        }
    }
}
