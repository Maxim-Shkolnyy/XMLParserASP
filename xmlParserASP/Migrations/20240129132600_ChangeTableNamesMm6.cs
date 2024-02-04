using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableNamesMm6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "pk_products_set_quantity_when_min",
            //    table: "products_set_quantity_when_min");

            //migrationBuilder.RenameTable(
            //    name: "products_set_quantity_when_min",
            //    newName: "mm_products_set_quantity_when_min");

            //migrationBuilder.RenameTable(
            //    name: "products_manual_set_quanitys",
            //    newName: "mm_products_manual_set_quanitys");

            //migrationBuilder.RenameTable(
            //    name: "products_manual_set_prices",
            //    newName: "mm_products_manual_set_prices");



            //migrationBuilder.RenameIndex(
            //    name: "ix_products_set_quantity_when_min_sku",
            //    table: "mm_products_set_quantity_when_min",
            //    newName: "ix_mm_products_set_quantity_when_min_sku");



            //migrationBuilder.RenameIndex(
            //    name: "ix_products_manual_set_quanitys_sku",
            //    table: "mm_products_manual_set_quanitys",
            //    newName: "ix_mm_products_manual_set_quanitys_sku");

            //migrationBuilder.RenameIndex(
            //    name: "ix_products_manual_set_prices_sku",
            //    table: "mm_products_manual_set_prices",
            //    newName: "ix_mm_products_manual_set_prices_sku");

            //migrationBuilder.AlterColumn<int>(
            //    name: "id",
            //    table: "mm_products_set_quantity_when_min",
            //    type: "int(11)",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int");
            //    //.Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
            //    //.OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            //migrationBuilder.AddPrimaryKey(
            //    name: "PRIMARY",
            //    table: "mm_products_set_quantity_when_min",
            //    column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PRIMARY",
            //    table: "mm_products_set_quantity_when_min");

            //migrationBuilder.RenameTable(
            //    name: "mm_products_set_quantity_when_min",
            //    newName: "products_set_quantity_when_min");

            //migrationBuilder.RenameTable(
            //    name: "mm_products_manual_set_quanitys",
            //    newName: "products_manual_set_quanitys");

            //migrationBuilder.RenameTable(
            //    name: "mm_products_manual_set_prices",
            //    newName: "products_manual_set_prices");

            //migrationBuilder.RenameIndex(
            //    name: "ix_mm_products_set_quantity_when_min_sku",
            //    table: "products_set_quantity_when_min",
            //    newName: "ix_products_set_quantity_when_min_sku");

            //migrationBuilder.RenameIndex(
            //    name: "ix_mm_products_manual_set_quanitys_sku",
            //    table: "products_manual_set_quanitys",
            //    newName: "ix_products_manual_set_quanitys_sku");

            //migrationBuilder.RenameIndex(
            //    name: "ix_mm_products_manual_set_prices_sku",
            //    table: "products_manual_set_prices",
            //    newName: "ix_products_manual_set_prices_sku");

            //migrationBuilder.AlterColumn<int>(
            //    name: "id",
            //    table: "products_set_quantity_when_min",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int(11)");
            //    //.Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
            //    //.OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            //migrationBuilder.AddPrimaryKey(
            //    name: "pk_products_set_quantity_when_min",
            //    table: "products_set_quantity_when_min",
            //    column: "id");
        }
    }
}
