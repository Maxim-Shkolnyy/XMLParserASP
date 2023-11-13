using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace xmlParserASP.Migrations.Gamma
{
    /// <inheritdoc />
    public partial class LargeChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "mm_supplier_supplier_id",
                table: "oc_product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "mm_supplier",
                columns: table => new
                {
                    supplier_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    supplier_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_mm_supplier", x => x.supplier_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "products_manual_set_prices",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sku = table.Column<string>(type: "longtext", nullable: false),
                    set_in_stock_price = table.Column<int>(type: "int", nullable: false),
                    date_start = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    date_end = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_products_manual_set_prices", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "mm_supplier_xml_settings",
                columns: table => new
                {
                    supplier_xml_setting_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    setting_name = table.Column<string>(type: "longtext", nullable: false),
                    supplier_id = table.Column<int>(type: "int", nullable: false),
                    path = table.Column<string>(type: "longtext", nullable: true),
                    start_gamma_id_from = table.Column<int>(type: "int", nullable: true),
                    main_product_node = table.Column<string>(type: "longtext", nullable: true),
                    product_node = table.Column<string>(type: "longtext", nullable: true),
                    param_attribute = table.Column<string>(type: "longtext", nullable: true),
                    model_node = table.Column<string>(type: "longtext", nullable: true),
                    model_xl_column = table.Column<string>(type: "longtext", nullable: true),
                    price_node = table.Column<string>(type: "longtext", nullable: true),
                    description_node = table.Column<string>(type: "longtext", nullable: true),
                    name_node = table.Column<string>(type: "longtext", nullable: true),
                    currency_node = table.Column<string>(type: "longtext", nullable: true),
                    picture_node = table.Column<string>(type: "longtext", nullable: true),
                    picture_price_quantity_xl_column = table.Column<string>(type: "longtext", nullable: true),
                    image_name_in_cat_img = table.Column<string>(type: "longtext", nullable: true),
                    photo_folder = table.Column<string>(type: "longtext", nullable: true),
                    quantity_node = table.Column<string>(type: "longtext", nullable: true),
                    quantity_db_stock1 = table.Column<string>(type: "longtext", nullable: true),
                    quantity_db_stock2 = table.Column<string>(type: "longtext", nullable: true),
                    quantity_db_stock3 = table.Column<string>(type: "longtext", nullable: true),
                    quantity_db_stock4 = table.Column<string>(type: "longtext", nullable: true),
                    quantity_db_stock5 = table.Column<string>(type: "longtext", nullable: true),
                    quantity_long_term_node = table.Column<string>(type: "longtext", nullable: true),
                    supplier_node = table.Column<string>(type: "longtext", nullable: true),
                    param_node = table.Column<string>(type: "longtext", nullable: true),
                    param_attr_node = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_mm_supplier_xml_settings", x => x.supplier_xml_setting_id);
                    table.ForeignKey(
                        name: "fk_mm_supplier_xml_settings_mm_supplier_supplier_id",
                        column: x => x.supplier_id,
                        principalTable: "mm_supplier",
                        principalColumn: "supplier_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "ix_oc_product_mm_supplier_supplier_id",
                table: "oc_product",
                column: "mm_supplier_supplier_id");

            migrationBuilder.CreateIndex(
                name: "ix_mm_supplier_xml_settings_supplier_id",
                table: "mm_supplier_xml_settings",
                column: "supplier_id");

            migrationBuilder.AddForeignKey(
                name: "fk_oc_product_mm_supplier_mm_supplier_supplier_id",
                table: "oc_product",
                column: "mm_supplier_supplier_id",
                principalTable: "mm_supplier",
                principalColumn: "supplier_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_oc_product_mm_supplier_mm_supplier_supplier_id",
                table: "oc_product");

            migrationBuilder.DropTable(
                name: "mm_supplier_xml_settings");

            migrationBuilder.DropTable(
                name: "products_manual_set_prices");

            migrationBuilder.DropTable(
                name: "mm_supplier");

            migrationBuilder.DropIndex(
                name: "ix_oc_product_mm_supplier_supplier_id",
                table: "oc_product");

            migrationBuilder.DropColumn(
                name: "mm_supplier_supplier_id",
                table: "oc_product");
        }
    }
}
