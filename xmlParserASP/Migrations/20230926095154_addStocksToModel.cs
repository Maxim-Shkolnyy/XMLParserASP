using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations;

/// <inheritdoc />
public partial class addStocksToModel : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            name: "quantity_db_stock1",
            table: "supplier_xml_settings",
            type: "longtext",
            nullable: true);

        migrationBuilder.AddColumn<string>(
            name: "quantity_db_stock2",
            table: "supplier_xml_settings",
            type: "longtext",
            nullable: true);

        migrationBuilder.AddColumn<string>(
            name: "quantity_db_stock3",
            table: "supplier_xml_settings",
            type: "longtext",
            nullable: true);

        migrationBuilder.AddColumn<string>(
            name: "quantity_db_stock4",
            table: "supplier_xml_settings",
            type: "longtext",
            nullable: true);

        migrationBuilder.AddColumn<string>(
            name: "quantity_db_stock5",
            table: "supplier_xml_settings",
            type: "longtext",
            nullable: true);

        migrationBuilder.AlterColumn<float>(
            name: "quantity",
            table: "products",
            type: "float",
            nullable: true,
            oldClrType: typeof(int),
            oldType: "int",
            oldNullable: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "quantity_db_stock1",
            table: "supplier_xml_settings");

        migrationBuilder.DropColumn(
            name: "quantity_db_stock2",
            table: "supplier_xml_settings");

        migrationBuilder.DropColumn(
            name: "quantity_db_stock3",
            table: "supplier_xml_settings");

        migrationBuilder.DropColumn(
            name: "quantity_db_stock4",
            table: "supplier_xml_settings");

        migrationBuilder.DropColumn(
            name: "quantity_db_stock5",
            table: "supplier_xml_settings");

        migrationBuilder.AlterColumn<int>(
            name: "quantity",
            table: "products",
            type: "int",
            nullable: true,
            oldClrType: typeof(float),
            oldType: "float",
            oldNullable: true);
    }
}
