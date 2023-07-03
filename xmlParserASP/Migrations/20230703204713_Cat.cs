using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace xmlParserASP.Migrations
{
    /// <inheritdoc />
    public partial class Cat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CategoriesRelation",
                columns: table => new
                {
                    MyCatId = table.Column<int>(type: "int", nullable: false),
                    SupplierCatId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesRelation", x => new { x.MyCatId, x.SupplierCatId, x.SupplierId, x.LanguageId });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MyAttributes",
                columns: table => new
                {
                    AttrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ParentAttrId = table.Column<int>(type: "int", nullable: false),
                    Attr_Name = table.Column<string>(type: "longtext", nullable: false),
                    SuppAttrIdEqualsOurAttr = table.Column<int>(type: "int", nullable: false),
                    SuppAttrNameEqualsOurAttr = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyAttributes", x => x.AttrId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MyCategories",
                columns: table => new
                {
                    CatId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    ParentCatId = table.Column<int>(type: "int", nullable: false),
                    Cat_Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyCategories", x => new { x.CatId, x.LanguageId });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SupplierCategories",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    CatId = table.Column<int>(type: "int", nullable: false),
                    ParentCatId = table.Column<int>(type: "int", nullable: false),
                    Cat_Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierCategories", x => new { x.CatId, x.SupplierId, x.LanguageId });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LanguageName = table.Column<string>(type: "longtext", nullable: false),
                    MyAttributeAttrId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                    table.ForeignKey(
                        name: "FK_Languages_MyAttributes_MyAttributeAttrId",
                        column: x => x.MyAttributeAttrId,
                        principalTable: "MyAttributes",
                        principalColumn: "AttrId");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SupplierName = table.Column<int>(type: "int", nullable: false),
                    MyAttributeAttrId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                    table.ForeignKey(
                        name: "FK_Suppliers_MyAttributes_MyAttributeAttrId",
                        column: x => x.MyAttributeAttrId,
                        principalTable: "MyAttributes",
                        principalColumn: "AttrId");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_MyAttributeAttrId",
                table: "Languages",
                column: "MyAttributeAttrId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_MyAttributeAttrId",
                table: "Suppliers",
                column: "MyAttributeAttrId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriesRelation");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "MyCategories");

            migrationBuilder.DropTable(
                name: "SupplierCategories");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "MyAttributes");
        }
    }
}
