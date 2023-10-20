using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations.Gamma
{
    /// <inheritdoc />
    public partial class toInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "sku",
                table: "products_manual_set_quanitys",
                type: "varchar(16)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "sku",
                table: "products_manual_set_quanitys",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(16)");
        }
    }
}
