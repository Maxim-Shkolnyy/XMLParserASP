using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations.Gamma;

/// <inheritdoc />
public partial class DEl : Migration
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
                    date_end = table.Column<DateOnly>(type: "date", nullable: true),
                    date_start = table.Column<DateOnly>(type: "date", nullable: true),
                    set_in_stock_qty = table.Column<int>(type: "int", nullable: false),
                    sku = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                })
            .Annotation("MySQL:Charset", "utf8mb4");
    }
}