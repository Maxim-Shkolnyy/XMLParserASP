using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations.Gamma
{
    /// <inheritdoc />
    public partial class _33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image_name_in_cat_img",
                table: "mm_supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "start_gamma_id_from",
                table: "mm_supplier_xml_settings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image_name_in_cat_img",
                table: "mm_supplier_xml_settings",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "start_gamma_id_from",
                table: "mm_supplier_xml_settings",
                type: "int",
                nullable: true);
        }
    }
}
