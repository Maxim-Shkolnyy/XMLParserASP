using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace xmlParserASP.Migrations
{
    /// <inheritdoc />
    public partial class CatAttrTables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "my_attributes",
                columns: table => new
                {
                    my_attr_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    my_attr_name_ru = table.Column<string>(type: "longtext", nullable: false),
                    my_attr_name_ua = table.Column<string>(type: "longtext", nullable: false),
                    my_attr_group = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_my_attributes", x => x.my_attr_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "my_categories",
                columns: table => new
                {
                    my_cat_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    my_parent_cat_id = table.Column<int>(type: "int", nullable: false),
                    my_cat_name_ru = table.Column<string>(type: "longtext", nullable: false),
                    my_cat_name_ua = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_my_categories", x => x.my_cat_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    supplier_id = table.Column<int>(type: "int", nullable: false),
                    product_name_ru = table.Column<string>(type: "longtext", nullable: false),
                    product_name_ua = table.Column<string>(type: "longtext", nullable: true),
                    my_cat_id = table.Column<int>(type: "int", nullable: false),
                    sku = table.Column<int>(type: "int", nullable: true),
                    model = table.Column<string>(type: "longtext", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<float>(type: "float", nullable: false),
                    image_name = table.Column<string>(type: "longtext", nullable: true),
                    description_ru = table.Column<string>(type: "longtext", nullable: true),
                    description_ua = table.Column<string>(type: "longtext", nullable: true),
                    manufacturer = table.Column<string>(type: "longtext", nullable: true),
                    date_added = table.Column<string>(type: "longtext", nullable: true),
                    date_modified = table.Column<string>(type: "longtext", nullable: true),
                    date_available = table.Column<string>(type: "longtext", nullable: true),
                    seo_keyword = table.Column<string>(type: "longtext", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_products", x => x.product_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "supplier_attributes",
                columns: table => new
                {
                    sup_attr_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    supplier_id = table.Column<int>(type: "int", nullable: false),
                    sup_attr_name_ru = table.Column<string>(type: "longtext", nullable: false),
                    sup_attr_name_ua = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_supplier_attributes", x => x.sup_attr_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "supplier_categories",
                columns: table => new
                {
                    supplier_cat_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    supplier_id = table.Column<int>(type: "int", nullable: false),
                    parent_sup_cat_id = table.Column<int>(type: "int", nullable: false),
                    cat_name_ru = table.Column<string>(type: "longtext", nullable: false),
                    cat_name_ua = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_supplier_categories", x => x.supplier_cat_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    supplier_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    supplier_name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_suppliers", x => x.supplier_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "my_attributes_supplier_attributes",
                columns: table => new
                {
                    my_attributes_my_attr_id = table.Column<int>(type: "int", nullable: false),
                    supplier_attributes_sup_attr_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_my_attributes_supplier_attributes", x => new { x.my_attributes_my_attr_id, x.supplier_attributes_sup_attr_id });
                    table.ForeignKey(
                        name: "fk_my_attributes_supplier_attributes_my_attributes_my_attribute",
                        column: x => x.my_attributes_my_attr_id,
                        principalTable: "my_attributes",
                        principalColumn: "my_attr_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_my_attributes_supplier_attributes_supplier_attributes_suppli",
                        column: x => x.supplier_attributes_sup_attr_id,
                        principalTable: "supplier_attributes",
                        principalColumn: "sup_attr_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "my_categories_supplier_categories",
                columns: table => new
                {
                    my_categories_my_cat_id = table.Column<int>(type: "int", nullable: false),
                    supplier_categories_supplier_cat_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_my_categories_supplier_categories", x => new { x.my_categories_my_cat_id, x.supplier_categories_supplier_cat_id });
                    table.ForeignKey(
                        name: "fk_my_categories_supplier_categories_my_categories_my_categorie",
                        column: x => x.my_categories_my_cat_id,
                        principalTable: "my_categories",
                        principalColumn: "my_cat_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_my_categories_supplier_categories_supplier_categories_suppli",
                        column: x => x.supplier_categories_supplier_cat_id,
                        principalTable: "supplier_categories",
                        principalColumn: "supplier_cat_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "ix_my_attributes_supplier_attributes_supplier_attributes_sup_at",
                table: "my_attributes_supplier_attributes",
                column: "supplier_attributes_sup_attr_id");

            migrationBuilder.CreateIndex(
                name: "ix_my_categories_supplier_categories_supplier_categories_suppli",
                table: "my_categories_supplier_categories",
                column: "supplier_categories_supplier_cat_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "my_attributes_supplier_attributes");

            migrationBuilder.DropTable(
                name: "my_categories_supplier_categories");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.DropTable(
                name: "my_attributes");

            migrationBuilder.DropTable(
                name: "supplier_attributes");

            migrationBuilder.DropTable(
                name: "my_categories");

            migrationBuilder.DropTable(
                name: "supplier_categories");
        }
    }
}
