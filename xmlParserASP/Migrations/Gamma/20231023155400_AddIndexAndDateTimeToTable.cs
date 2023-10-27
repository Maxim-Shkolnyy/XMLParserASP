using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace xmlParserASP.Migrations.Gamma;

/// <inheritdoc />
public partial class AddIndexAndDateTimeToTable : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
                name: "products_manual_set_quanitys",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sku = table.Column<string>(type: "varchar(255)", nullable: false),
                    set_in_stock_qty = table.Column<int>(type: "int", nullable: false),
                    date_start = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    date_end = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "products_manual_set_quanitys");
    }
}