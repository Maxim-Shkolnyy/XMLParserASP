using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace xmlParserASP.Migrations.Gamma
{
    /// <inheritdoc />
    public partial class Prduct112 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "product_limit_quantity");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "product_limit_quantity");

            migrationBuilder.AddColumn<int>(
                name: "product_id",
                table: "product_limit_quantity",
                type: "int(11)",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "product_limit_quantity",
                column: "product_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "product_limit_quantity");

            migrationBuilder.DropColumn(
                name: "product_id",
                table: "product_limit_quantity");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "product_limit_quantity",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "product_limit_quantity",
                column: "ProductId");
        }
    }
}
