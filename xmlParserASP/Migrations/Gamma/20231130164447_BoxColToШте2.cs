using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations.Gamma
{
    /// <inheritdoc />
    public partial class BoxColToШте2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "qty_in_box_column_number",
                table: "mm_supplier_xml_settings",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "qty_in_box_column_number",
                table: "mm_supplier_xml_settings",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);
        }
    }
}
