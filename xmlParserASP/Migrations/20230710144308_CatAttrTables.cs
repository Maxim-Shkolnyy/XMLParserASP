using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace xmlParserASP.Migrations
{
    /// <inheritdoc />
    public partial class CatAttrTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "myAttributes",
                columns: table => new
                {
                    myAttrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    myAttrNameRU = table.Column<string>(type: "longtext", nullable: false),
                    myAttrNameUA = table.Column<string>(type: "longtext", nullable: false),
                    myAttrGroup = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pK_myAttributes", x => x.myAttrId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "myCategories",
                columns: table => new
                {
                    myCatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    myParentCatId = table.Column<int>(type: "int", nullable: false),
                    myCatNameRU = table.Column<string>(type: "longtext", nullable: false),
                    myCatNameUA = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pK_myCategories", x => x.myCatId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    supplierId = table.Column<int>(type: "int", nullable: false),
                    productNameRU = table.Column<string>(type: "longtext", nullable: false),
                    productNameUA = table.Column<string>(type: "longtext", nullable: true),
                    myCatId = table.Column<int>(type: "int", nullable: false),
                    sku = table.Column<int>(type: "int", nullable: true),
                    model = table.Column<string>(type: "longtext", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<float>(type: "float", nullable: false),
                    imageName = table.Column<string>(type: "longtext", nullable: true),
                    descriptionRU = table.Column<string>(type: "longtext", nullable: true),
                    descriptionUA = table.Column<string>(type: "longtext", nullable: true),
                    manufacturer = table.Column<string>(type: "longtext", nullable: true),
                    dateAdded = table.Column<string>(type: "longtext", nullable: true),
                    dateModified = table.Column<string>(type: "longtext", nullable: true),
                    dateAvailable = table.Column<string>(type: "longtext", nullable: true),
                    seoKeyword = table.Column<string>(type: "longtext", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pK_products", x => x.productId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "supplierAttributes",
                columns: table => new
                {
                    supAttrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    supplierId = table.Column<int>(type: "int", nullable: false),
                    supAttrNameRU = table.Column<string>(type: "longtext", nullable: false),
                    supAttrNameUA = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pK_supplierAttributes", x => x.supAttrId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "supplierCategories",
                columns: table => new
                {
                    supplierCatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    supplierId = table.Column<int>(type: "int", nullable: false),
                    parentSupCatId = table.Column<int>(type: "int", nullable: false),
                    catNameRU = table.Column<string>(type: "longtext", nullable: false),
                    catNameUA = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pK_supplierCategories", x => x.supplierCatId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    supplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    supplierName = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pK_suppliers", x => x.supplierId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MyAttributesSupplierAttributes",
                columns: table => new
                {
                    myAttributesMyAttrId = table.Column<int>(type: "int", nullable: false),
                    supplierAttributesSupAttrId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pK_MyAttributesSupplierAttributes", x => new { x.myAttributesMyAttrId, x.supplierAttributesSupAttrId });
                    table.ForeignKey(
                        name: "fK_MyAttributesSupplierAttributes_myAttributes_myAttributesMyAt~",
                        column: x => x.myAttributesMyAttrId,
                        principalTable: "myAttributes",
                        principalColumn: "myAttrId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fK_MyAttributesSupplierAttributes_supplierAttributes_supplierAt~",
                        column: x => x.supplierAttributesSupAttrId,
                        principalTable: "supplierAttributes",
                        principalColumn: "supAttrId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MyCategoriesSupplierCategories",
                columns: table => new
                {
                    myCategoriesMyCatId = table.Column<int>(type: "int", nullable: false),
                    supplierCategoriesSupplierCatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pK_MyCategoriesSupplierCategories", x => new { x.myCategoriesMyCatId, x.supplierCategoriesSupplierCatId });
                    table.ForeignKey(
                        name: "fK_MyCategoriesSupplierCategories_myCategories_myCategoriesMyCa~",
                        column: x => x.myCategoriesMyCatId,
                        principalTable: "myCategories",
                        principalColumn: "myCatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fK_MyCategoriesSupplierCategories_supplierCategories_supplierCa~",
                        column: x => x.supplierCategoriesSupplierCatId,
                        principalTable: "supplierCategories",
                        principalColumn: "supplierCatId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "iX_MyAttributesSupplierAttributes_supplierAttributesSupAttrId",
                table: "MyAttributesSupplierAttributes",
                column: "supplierAttributesSupAttrId");

            migrationBuilder.CreateIndex(
                name: "iX_MyCategoriesSupplierCategories_supplierCategoriesSupplierCat~",
                table: "MyCategoriesSupplierCategories",
                column: "supplierCategoriesSupplierCatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyAttributesSupplierAttributes");

            migrationBuilder.DropTable(
                name: "MyCategoriesSupplierCategories");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.DropTable(
                name: "myAttributes");

            migrationBuilder.DropTable(
                name: "supplierAttributes");

            migrationBuilder.DropTable(
                name: "myCategories");

            migrationBuilder.DropTable(
                name: "supplierCategories");
        }
    }
}
