using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations.Gamma
{
    /// <inheritdoc />
    public partial class noKey4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_products_manual_set_quanitys",
                table: "products_manual_set_quanitys");

            migrationBuilder.AlterColumn<string>(
                name: "sku",
                table: "products_manual_set_quanitys",
                type: "varchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(16)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "sku",
                table: "products_manual_set_quanitys",
                type: "varchar(16)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AddPrimaryKey(
                name: "pk_products_manual_set_quanitys",
                table: "products_manual_set_quanitys",
                column: "sku");
        }
    }
}
