using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations
{
    /// <inheritdoc />
    public partial class Str : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SupplierName",
                table: "Suppliers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "status",
                table: "Products",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "model",
                table: "Products",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SupplierName",
                table: "Suppliers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "Products",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "model",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");
        }
    }
}
