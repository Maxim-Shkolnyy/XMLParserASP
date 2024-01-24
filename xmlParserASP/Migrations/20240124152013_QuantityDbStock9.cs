using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations
{
    /// <inheritdoc />
    public partial class QuantityDbStock9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        { 
            migrationBuilder.AlterColumn<string>(
                name: "sku",
                table: "products_set_quantity_when_min",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "sku",
                table: "products_manual_set_prices",
                type: "varchar(7)",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AddColumn<string>(
                name: "quantity_db_stock6",
                table: "mm_supplier_xml_settings",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "quantity_db_stock7",
                table: "mm_supplier_xml_settings",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "quantity_db_stock8",
                table: "mm_supplier_xml_settings",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "quantity_db_stock9",
                table: "mm_supplier_xml_settings",
                type: "longtext",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_products_set_quantity_when_min_sku",
                table: "products_set_quantity_when_min",
                column: "sku",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_products_manual_set_prices_sku",
                table: "products_manual_set_prices",
                column: "sku",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_products_set_quantity_when_min_sku",
                table: "products_set_quantity_when_min");

            migrationBuilder.DropIndex(
                name: "ix_products_manual_set_prices_sku",
                table: "products_manual_set_prices");

            migrationBuilder.DropColumn(
                name: "quantity_db_stock6",
                table: "mm_supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "quantity_db_stock7",
                table: "mm_supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "quantity_db_stock8",
                table: "mm_supplier_xml_settings");

            migrationBuilder.DropColumn(
                name: "quantity_db_stock9",
                table: "mm_supplier_xml_settings");

            migrationBuilder.AlterColumn<string>(
                name: "sku",
                table: "products_set_quantity_when_min",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "sku",
                table: "products_manual_set_prices",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(7)",
                oldMaxLength: 7);
        }
    }
}
