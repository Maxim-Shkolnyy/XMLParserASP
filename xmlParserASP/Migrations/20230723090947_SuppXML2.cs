using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations
{
    /// <inheritdoc />
    public partial class SuppXML2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image_name_in_cat_img",
                table: "supplier_xml_settings",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "photo_folder",
                table: "supplier_xml_settings",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "start_gamma_id_from",
                table: "supplier_xml_settings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "xml_model_node",
                table: "supplier_xml_settings",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "xml_param_attr_node",
                table: "supplier_xml_settings",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "xml_param_node",
                table: "supplier_xml_settings",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "xml_picture_node",
                table: "supplier_xml_settings",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "xml_product_node",
                table: "supplier_xml_settings",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "xml_quantity_node",
                table: "supplier_xml_settings",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "xml_supplier_node",
                table: "supplier_xml_settings",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image_name_in_cat_img",
                table: "supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "photo_folder",
                table: "supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "start_gamma_id_from",
                table: "supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "xml_model_node",
                table: "supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "xml_param_attr_node",
                table: "supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "xml_param_node",
                table: "supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "xml_picture_node",
                table: "supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "xml_product_node",
                table: "supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "xml_quantity_node",
                table: "supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "xml_supplier_node",
                table: "supplier_xml_settings");
        }
    }
}
