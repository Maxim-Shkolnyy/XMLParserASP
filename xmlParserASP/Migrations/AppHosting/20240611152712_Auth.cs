using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations.AppHosting
{
    /// <inheritdoc />
    public partial class Auth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MmSuppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MmSuppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "MmSupplierXmlSettings",
                columns: table => new
                {
                    SupplierXmlSettingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainProductNode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductNode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParamAttribute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelNode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelXlColumn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceNode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionNode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameNode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyNode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureNode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePictureXlColumn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantityXlColumn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoFolder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantityNode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantityDbStock1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    QuantityDbStock2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    QuantityDbStock3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    QuantityDbStock4 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    QuantityDbStock5 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    QuantityDbStock6 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    QuantityDbStock7 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    QuantityDbStock8 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    QuantityDbStock9 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    QuantityLongTermNode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierNode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParamNode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParamAttrNode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtyInBoxColumnNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MmSupplierXmlSettings", x => x.SupplierXmlSettingId);
                });

            migrationBuilder.CreateTable(
                name: "ProductsManualSetPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sku = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    SetInStockPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsManualSetPrices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsManualSetQuanitys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sku = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    SetInStockQty = table.Column<int>(type: "int", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsManualSetQuanitys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsSetQuantityWhenMin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sku = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    MinQuantity = table.Column<int>(type: "int", nullable: true),
                    SetQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsSetQuantityWhenMin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MmSuppliers");

            migrationBuilder.DropTable(
                name: "MmSupplierXmlSettings");

            migrationBuilder.DropTable(
                name: "ProductsManualSetPrices");

            migrationBuilder.DropTable(
                name: "ProductsManualSetQuanitys");

            migrationBuilder.DropTable(
                name: "ProductsSetQuantityWhenMin");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTokens");
        }
    }
}
