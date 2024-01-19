using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations
{
    /// <inheritdoc />
    public partial class manualPriceToDecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "SetInStockPrice",
                table: "YourTableName",  // Замініть "YourTableName" на реальне ім'я таблиці
                type: "decimal(10,4)",   // Задайте бажаний тип для вашої бази даних
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SetInStockPrice",
                table: "YourTableName",  // Замініть "YourTableName" на реальне ім'я таблиці
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)");
        }
    }
}
