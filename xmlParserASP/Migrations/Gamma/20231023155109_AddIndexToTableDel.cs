using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace xmlParserASP.Migrations.Gamma
{
    /// <inheritdoc />
    public partial class AddIndexToTableDel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products_manual_set_quanitys");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products_manual_set_quanitys",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    date_end = table.Column<DateOnly>(type: "date", nullable: true),
                    date_start = table.Column<DateOnly>(type: "date", nullable: true),
                    set_in_stock_qty = table.Column<int>(type: "int", nullable: false),
                    sku = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_products_manual_set_quanitys", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "ix_products_manual_set_quanitys_sku",
                table: "products_manual_set_quanitys",
                column: "sku",
                unique: true);
        }
    }
}
