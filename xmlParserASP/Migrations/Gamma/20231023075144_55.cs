using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations.Gamma;

/// <inheritdoc />
public partial class _55 : Migration
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
                    sku = table.Column<string>(type: "varchar(255)", nullable: false),
                    date_end = table.Column<DateOnly>(type: "date", nullable: true),
                    date_start = table.Column<DateOnly>(type: "date", nullable: true),
                    set_in_stock_qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_products_manual_set_quanitys", x => x.sku);
                })
            .Annotation("MySQL:Charset", "utf8mb4");
    }
}