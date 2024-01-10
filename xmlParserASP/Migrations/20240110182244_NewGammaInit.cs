using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace xmlParserASP.Migrations
{
    /// <inheritdoc />
    public partial class NewGammaInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "__EFMigrationsHistory",
                columns: table => new
                {
                    migration_id = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    product_version = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.migration_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "attribute_description",
                columns: table => new
                {
                    attribute_id = table.Column<int>(type: "int(11)", nullable: true),
                    language_id = table.Column<int>(type: "int(11)", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "mm_supplier",
                columns: table => new
                {
                    supplier_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    supplier_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.supplier_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "mm_supplier_xml_settings",
                columns: table => new
                {
                    supplier_xml_setting_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    setting_name = table.Column<string>(type: "longtext", nullable: false),
                    supplier_id = table.Column<int>(type: "int(11)", nullable: false),
                    path = table.Column<string>(type: "longtext", nullable: true),
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
                    param_attr_node = table.Column<string>(type: "longtext", nullable: true),
                    qty_in_box_column_number = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.supplier_xml_setting_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_address",
                columns: table => new
                {
                    address_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    firstname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    lastname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    company = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    address_1 = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    address_2 = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    city = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    postcode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    country_id = table.Column<int>(type: "int(11)", nullable: false),
                    zone_id = table.Column<int>(type: "int(11)", nullable: false),
                    custom_field = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.address_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_address_simple_fields",
                columns: table => new
                {
                    address_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    metadata = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.address_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_api",
                columns: table => new
                {
                    api_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    key = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.api_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_api_ip",
                columns: table => new
                {
                    api_ip_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    api_id = table.Column<int>(type: "int(11)", nullable: false),
                    ip = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.api_ip_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_api_session",
                columns: table => new
                {
                    api_session_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    api_id = table.Column<int>(type: "int(11)", nullable: false),
                    session_id = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    ip = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.api_session_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_article",
                columns: table => new
                {
                    article_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    date_available = table.Column<DateTime>(type: "date", nullable: false),
                    sort_order = table.Column<int>(type: "int(11)", nullable: false),
                    article_review = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    noindex = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValueSql: "'1'"),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'"),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'"),
                    viewed = table.Column<int>(type: "int(5)", nullable: false),
                    gstatus = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.article_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_article_description",
                columns: table => new
                {
                    article_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    meta_description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_keyword = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_h1 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    tag = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.article_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_article_image",
                columns: table => new
                {
                    article_image_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    article_id = table.Column<int>(type: "int(11)", nullable: false),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.article_image_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_article_related",
                columns: table => new
                {
                    article_id = table.Column<int>(type: "int(11)", nullable: false),
                    related_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.article_id, x.related_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_article_related_mn",
                columns: table => new
                {
                    article_id = table.Column<int>(type: "int(11)", nullable: false),
                    manufacturer_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.article_id, x.manufacturer_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_article_related_product",
                columns: table => new
                {
                    article_id = table.Column<int>(type: "int(11)", nullable: false),
                    product_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.article_id, x.product_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_article_related_wb",
                columns: table => new
                {
                    article_id = table.Column<int>(type: "int(11)", nullable: false),
                    category_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.article_id, x.category_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_article_to_blog_category",
                columns: table => new
                {
                    article_id = table.Column<int>(type: "int(11)", nullable: false),
                    blog_category_id = table.Column<int>(type: "int(11)", nullable: false),
                    main_blog_category = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.article_id, x.blog_category_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_article_to_download",
                columns: table => new
                {
                    article_id = table.Column<int>(type: "int(11)", nullable: false),
                    download_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.article_id, x.download_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_article_to_layout",
                columns: table => new
                {
                    article_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    layout_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.article_id, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_article_to_store",
                columns: table => new
                {
                    article_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.article_id, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_attribute",
                columns: table => new
                {
                    attribute_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    attribute_group_id = table.Column<int>(type: "int(11)", nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.attribute_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_attribute_description",
                columns: table => new
                {
                    attribute_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.attribute_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_attribute_group",
                columns: table => new
                {
                    attribute_group_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.attribute_group_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_attribute_group_description",
                columns: table => new
                {
                    attribute_group_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.attribute_group_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_banner",
                columns: table => new
                {
                    banner_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.banner_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_banner_image",
                columns: table => new
                {
                    banner_image_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    banner_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    title = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    link = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.banner_image_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_blog_category",
                columns: table => new
                {
                    blog_category_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    parent_id = table.Column<int>(type: "int(11)", nullable: false),
                    top = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    column = table.Column<int>(type: "int(3)", nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    noindex = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValueSql: "'1'"),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'"),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.blog_category_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_blog_category_description",
                columns: table => new
                {
                    blog_category_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", nullable: false, defaultValueSql: "''"),
                    description = table.Column<string>(type: "text", nullable: false),
                    meta_description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_keyword = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_h1 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.blog_category_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_blog_category_path",
                columns: table => new
                {
                    blog_category_id = table.Column<int>(type: "int(11)", nullable: false),
                    path_id = table.Column<int>(type: "int(11)", nullable: false),
                    level = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.blog_category_id, x.path_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_blog_category_to_layout",
                columns: table => new
                {
                    blog_category_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    layout_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.blog_category_id, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_blog_category_to_store",
                columns: table => new
                {
                    blog_category_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.blog_category_id, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_cart",
                columns: table => new
                {
                    cart_id = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    api_id = table.Column<int>(type: "int(11)", nullable: false),
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    session_id = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    recurring_id = table.Column<int>(type: "int(11)", nullable: false),
                    option = table.Column<string>(type: "text", nullable: false),
                    quantity = table.Column<int>(type: "int(5)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.cart_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_category",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    parent_id = table.Column<int>(type: "int(11)", nullable: false),
                    top = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    column = table.Column<int>(type: "int(3)", nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false),
                    noindex = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.category_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_category_description",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    meta_title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_keyword = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_h1 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.category_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_category_filter",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int(11)", nullable: false),
                    filter_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.category_id, x.filter_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_category_path",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int(11)", nullable: false),
                    path_id = table.Column<int>(type: "int(11)", nullable: false),
                    level = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.category_id, x.path_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_category_to_layout",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    layout_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.category_id, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_category_to_prom_category",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int(11)", nullable: false),
                    prom_category_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.category_id, x.prom_category_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_category_to_store",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.category_id, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_country",
                columns: table => new
                {
                    country_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    iso_code_2 = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    iso_code_3 = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    address_format = table.Column<string>(type: "text", nullable: false),
                    postcode_required = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.country_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_coupon",
                columns: table => new
                {
                    coupon_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    code = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    type = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false),
                    discount = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    logged = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    shipping = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    total = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    date_start = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "'0000-00-00'"),
                    date_end = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "'0000-00-00'"),
                    uses_total = table.Column<int>(type: "int(11)", nullable: false),
                    uses_customer = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.coupon_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_coupon_category",
                columns: table => new
                {
                    coupon_id = table.Column<int>(type: "int(11)", nullable: false),
                    category_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.coupon_id, x.category_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_coupon_history",
                columns: table => new
                {
                    coupon_history_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    coupon_id = table.Column<int>(type: "int(11)", nullable: false),
                    order_id = table.Column<int>(type: "int(11)", nullable: false),
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.coupon_history_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_coupon_product",
                columns: table => new
                {
                    coupon_product_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    coupon_id = table.Column<int>(type: "int(11)", nullable: false),
                    product_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.coupon_product_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_currency",
                columns: table => new
                {
                    currency_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    code = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    symbol_left = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false),
                    symbol_right = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false),
                    decimal_place = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false),
                    value = table.Column<double>(type: "double(15,8)", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.currency_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_custom_field",
                columns: table => new
                {
                    custom_field_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    value = table.Column<string>(type: "text", nullable: false),
                    validation = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    location = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.custom_field_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_custom_field_customer_group",
                columns: table => new
                {
                    custom_field_id = table.Column<int>(type: "int(11)", nullable: false),
                    customer_group_id = table.Column<int>(type: "int(11)", nullable: false),
                    required = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.custom_field_id, x.customer_group_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_custom_field_description",
                columns: table => new
                {
                    custom_field_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.custom_field_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_custom_field_value",
                columns: table => new
                {
                    custom_field_value_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    custom_field_id = table.Column<int>(type: "int(11)", nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.custom_field_value_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_custom_field_value_description",
                columns: table => new
                {
                    custom_field_value_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    custom_field_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.custom_field_value_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_customer",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    customer_group_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    firstname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    lastname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    email = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: false),
                    telephone = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    telegram_id = table.Column<string>(type: "text", nullable: false),
                    fax = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    password = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    salt = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false),
                    cart = table.Column<string>(type: "text", nullable: true),
                    wishlist = table.Column<string>(type: "text", nullable: true),
                    newsletter = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    address_id = table.Column<int>(type: "int(11)", nullable: false),
                    custom_field = table.Column<string>(type: "text", nullable: false),
                    ip = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    safe = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    token = table.Column<string>(type: "text", nullable: false),
                    code = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.customer_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_customer_activity",
                columns: table => new
                {
                    customer_activity_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    key = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    data = table.Column<string>(type: "text", nullable: false),
                    ip = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.customer_activity_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_customer_affiliate",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    company = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    website = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    tracking = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    commission = table.Column<decimal>(type: "decimal(4,2)", precision: 4, nullable: false),
                    tax = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    payment = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false),
                    cheque = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    paypal = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    bank_name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    bank_branch_number = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    bank_swift_code = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    bank_account_name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    bank_account_number = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    custom_field = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.customer_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_customer_approval",
                columns: table => new
                {
                    customer_approval_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    type = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.customer_approval_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_customer_group",
                columns: table => new
                {
                    customer_group_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    approval = table.Column<int>(type: "int(1)", nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.customer_group_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_customer_group_description",
                columns: table => new
                {
                    customer_group_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.customer_group_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_customer_history",
                columns: table => new
                {
                    customer_history_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.customer_history_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_customer_ip",
                columns: table => new
                {
                    customer_ip_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    ip = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.customer_ip_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_customer_login",
                columns: table => new
                {
                    customer_login_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: false),
                    ip = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    total = table.Column<int>(type: "int(4)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.customer_login_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_customer_online",
                columns: table => new
                {
                    ip = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    url = table.Column<string>(type: "text", nullable: false),
                    referer = table.Column<string>(type: "text", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ip);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_customer_reward",
                columns: table => new
                {
                    customer_reward_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    order_id = table.Column<int>(type: "int(11)", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    points = table.Column<int>(type: "int(8)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.customer_reward_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_customer_search",
                columns: table => new
                {
                    customer_search_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    keyword = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    category_id = table.Column<int>(type: "int(11)", nullable: true),
                    sub_category = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    description = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    products = table.Column<int>(type: "int(11)", nullable: false),
                    ip = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.customer_search_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_customer_simple_fields",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    metadata = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.customer_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_customer_transaction",
                columns: table => new
                {
                    customer_transaction_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    order_id = table.Column<int>(type: "int(11)", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.customer_transaction_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_customer_wishlist",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.customer_id, x.product_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_download",
                columns: table => new
                {
                    download_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    filename = table.Column<string>(type: "varchar(160)", maxLength: 160, nullable: false),
                    mask = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.download_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_download_description",
                columns: table => new
                {
                    download_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.download_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_event",
                columns: table => new
                {
                    event_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    trigger = table.Column<string>(type: "text", nullable: false),
                    action = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.event_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_extension",
                columns: table => new
                {
                    extension_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.extension_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_extension_install",
                columns: table => new
                {
                    extension_install_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    extension_download_id = table.Column<int>(type: "int(11)", nullable: false),
                    filename = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.extension_install_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_extension_path",
                columns: table => new
                {
                    extension_path_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    extension_install_id = table.Column<int>(type: "int(11)", nullable: false),
                    path = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.extension_path_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_filter",
                columns: table => new
                {
                    filter_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    filter_group_id = table.Column<int>(type: "int(11)", nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.filter_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_filter_description",
                columns: table => new
                {
                    filter_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    filter_group_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.filter_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_filter_group",
                columns: table => new
                {
                    filter_group_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.filter_group_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_filter_group_description",
                columns: table => new
                {
                    filter_group_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.filter_group_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_geo_zone",
                columns: table => new
                {
                    geo_zone_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.geo_zone_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_googleshopping_category",
                columns: table => new
                {
                    google_product_category = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    category_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.google_product_category, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_googleshopping_product",
                columns: table => new
                {
                    product_advertise_google_id = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    product_id = table.Column<int>(type: "int(11)", nullable: true),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    has_issues = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    destination_status = table.Column<string>(type: "enum('pending','approved','disapproved')", nullable: false, defaultValueSql: "'pending'"),
                    impressions = table.Column<int>(type: "int(11)", nullable: false),
                    clicks = table.Column<int>(type: "int(11)", nullable: false),
                    conversions = table.Column<int>(type: "int(11)", nullable: false),
                    cost = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    conversion_value = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    google_product_category = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    condition = table.Column<string>(type: "enum('new','refurbished','used')", nullable: true),
                    adult = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    multipack = table.Column<int>(type: "int(11)", nullable: true),
                    is_bundle = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    age_group = table.Column<string>(type: "enum('newborn','infant','toddler','kids','adult')", nullable: true),
                    color = table.Column<int>(type: "int(11)", nullable: true),
                    gender = table.Column<string>(type: "enum('male','female','unisex')", nullable: true),
                    size_type = table.Column<string>(type: "enum('regular','petite','plus','big and tall','maternity')", nullable: true),
                    size_system = table.Column<string>(type: "enum('AU','BR','CN','DE','EU','FR','IT','JP','MEX','UK','US')", nullable: true),
                    size = table.Column<int>(type: "int(11)", nullable: true),
                    is_modified = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.product_advertise_google_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_googleshopping_product_status",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    product_variation_id = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''"),
                    destination_statuses = table.Column<string>(type: "text", nullable: false),
                    data_quality_issues = table.Column<string>(type: "text", nullable: false),
                    item_level_issues = table.Column<string>(type: "text", nullable: false),
                    google_expiration_date = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.product_id, x.store_id, x.product_variation_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_googleshopping_product_target",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    advertise_google_target_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.product_id, x.advertise_google_target_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_googleshopping_target",
                columns: table => new
                {
                    advertise_google_target_id = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    campaign_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    country = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false, defaultValueSql: "''"),
                    budget = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    feeds = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<string>(type: "enum('paused','active')", nullable: false, defaultValueSql: "'paused'"),
                    date_added = table.Column<DateTime>(type: "date", nullable: true),
                    roas = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.advertise_google_target_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_information",
                columns: table => new
                {
                    information_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    bottom = table.Column<int>(type: "int(1)", nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValueSql: "'1'"),
                    noindex = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.information_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_information_description",
                columns: table => new
                {
                    information_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    title = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    description = table.Column<string>(type: "mediumtext", nullable: false),
                    meta_title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_keyword = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_h1 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.information_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_information_to_layout",
                columns: table => new
                {
                    information_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    layout_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.information_id, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_information_to_store",
                columns: table => new
                {
                    information_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.information_id, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_language",
                columns: table => new
                {
                    language_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    code = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    locale = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    image = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    directory = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.language_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_layout",
                columns: table => new
                {
                    layout_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.layout_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_layout_module",
                columns: table => new
                {
                    layout_module_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    layout_id = table.Column<int>(type: "int(11)", nullable: false),
                    code = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    position = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.layout_module_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_layout_route",
                columns: table => new
                {
                    layout_route_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    layout_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    route = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.layout_route_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_length_class",
                columns: table => new
                {
                    length_class_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    value = table.Column<decimal>(type: "decimal(15,8)", precision: 15, scale: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.length_class_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_length_class_description",
                columns: table => new
                {
                    length_class_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    title = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    unit = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.length_class_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_licenses_km",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    p_code = table.Column<string>(type: "text", nullable: false),
                    value = table.Column<string>(type: "text", nullable: false),
                    key = table.Column<string>(type: "text", nullable: false),
                    license_key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_location",
                columns: table => new
                {
                    location_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    telephone = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    fax = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    geocode = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    open = table.Column<string>(type: "text", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.location_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_manufacturer",
                columns: table => new
                {
                    manufacturer_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false),
                    noindex = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.manufacturer_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_manufacturer_description",
                columns: table => new
                {
                    manufacturer_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    description3 = table.Column<string>(type: "text", nullable: false),
                    meta_description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_keyword = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_h1 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_manufacturer_to_layout",
                columns: table => new
                {
                    manufacturer_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    layout_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.manufacturer_id, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_manufacturer_to_store",
                columns: table => new
                {
                    manufacturer_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.manufacturer_id, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_marketing",
                columns: table => new
                {
                    marketing_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    code = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    clicks = table.Column<int>(type: "int(5)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.marketing_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_modification",
                columns: table => new
                {
                    modification_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    extension_install_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    code = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    author = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    version = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    link = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    xml = table.Column<string>(type: "mediumtext", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.modification_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_modification_backup",
                columns: table => new
                {
                    backup_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    modification_id = table.Column<int>(type: "int(11)", nullable: false),
                    code = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    xml = table.Column<string>(type: "mediumtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.backup_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_module",
                columns: table => new
                {
                    module_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    setting = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.module_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_multi_xml",
                columns: table => new
                {
                    xml_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    categories = table.Column<string>(type: "text", nullable: false),
                    products = table.Column<string>(type: "text", nullable: false),
                    suppliers = table.Column<string>(type: "text", nullable: false),
                    settings = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.xml_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_multiplicity_product",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    step = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.product_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_novaposhta_cities",
                columns: table => new
                {
                    @ref = table.Column<string>(name: "ref", type: "varchar(36)", maxLength: 36, nullable: false),
                    CityID = table.Column<int>(type: "int(11)", nullable: false),
                    description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    description_ru = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    area = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    area_description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    area_description_ru = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    settlement_type = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    settlement_type_description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    settlement_type_description_ru = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    delivery1 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    delivery2 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    delivery3 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    delivery4 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    delivery5 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    delivery6 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    delivery7 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    prevent_entry_new_streets_user = table.Column<string>(type: "text", nullable: false),
                    is_branch = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    special_cash_check = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.@ref);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_novaposhta_departments",
                columns: table => new
                {
                    @ref = table.Column<string>(name: "ref", type: "varchar(36)", maxLength: 36, nullable: false),
                    site_key = table.Column<int>(type: "int(11)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    description_ru = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    short_address = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    short_address_ru = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    type_of_warehouse = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    city_ref = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    city_description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    city_description_ru = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    settlement_ref = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    settlement_description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    settlement_area_description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    settlement_regions_description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    settlement_type_description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    number = table.Column<int>(type: "int(11)", nullable: false),
                    phone = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    longitude = table.Column<double>(type: "double", nullable: false),
                    latitude = table.Column<double>(type: "double", nullable: false),
                    post_finance = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    bicycle_parking = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    payment_access = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    POSTerminal = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    international_shipping = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    self_service_workplaces_count = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    total_max_weight_allowed = table.Column<int>(type: "int(11)", nullable: false),
                    place_max_weight_allowed = table.Column<int>(type: "int(11)", nullable: false),
                    SendingLimitationsOnDimensions_length = table.Column<int>(type: "int(11)", nullable: false),
                    SendingLimitationsOnDimensions_width = table.Column<int>(type: "int(11)", nullable: false),
                    SendingLimitationsOnDimensions_height = table.Column<int>(type: "int(11)", nullable: false),
                    ReceivingLimitationsOnDimensions_length = table.Column<int>(type: "int(11)", nullable: false),
                    ReceivingLimitationsOnDimensions_width = table.Column<int>(type: "int(11)", nullable: false),
                    ReceivingLimitationsOnDimensions_height = table.Column<int>(type: "int(11)", nullable: false),
                    Reception_monday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Reception_tuesday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Reception_wednesday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Reception_thursday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Reception_friday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Reception_saturday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Reception_sunday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Delivery_monday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Delivery_tuesday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Delivery_wednesday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Delivery_thursday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Delivery_friday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Delivery_saturday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Delivery_sunday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Schedule_monday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Schedule_tuesday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Schedule_wednesday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Schedule_thursday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Schedule_friday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Schedule_saturday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Schedule_sunday = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    district_code = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    warehouse_status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    warehouse_status_date = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    category_of_warehouse = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    direct = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    region_city = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.@ref);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_novaposhta_references",
                columns: table => new
                {
                    type = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    value = table.Column<string>(type: "mediumtext", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_novaposhta_regions",
                columns: table => new
                {
                    @ref = table.Column<string>(name: "ref", type: "varchar(36)", maxLength: 36, nullable: false),
                    areas_center = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    description_ru = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.@ref);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ocfilter_attribute_cache",
                columns: table => new
                {
                    attribute_cache_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    product_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    attribute_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    language_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    key = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.attribute_cache_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ocfilter_cache",
                columns: table => new
                {
                    key = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    value = table.Column<string>(type: "longtext", nullable: false),
                    path = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    expire = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.key);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ocfilter_filter",
                columns: table => new
                {
                    filter_id = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    source = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    type = table.Column<string>(type: "set('checkbox','radio','slide','slide_dual')", nullable: false, defaultValueSql: "'checkbox'"),
                    dropdown = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    color = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    image = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    sort_order = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.filter_id, x.source });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ocfilter_filter_description",
                columns: table => new
                {
                    filter_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    source = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    language_id = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false, defaultValueSql: "''"),
                    suffix = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, defaultValueSql: "''"),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.filter_id, x.language_id, x.source });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ocfilter_filter_range_to_product",
                columns: table => new
                {
                    filter_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    source = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    product_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    min = table.Column<decimal>(type: "decimal(15,3)", precision: 15, scale: 3, nullable: true),
                    max = table.Column<decimal>(type: "decimal(15,3)", precision: 15, scale: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.filter_id, x.source, x.product_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ocfilter_filter_to_category",
                columns: table => new
                {
                    filter_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    source = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    category_id = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.category_id, x.filter_id, x.source });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ocfilter_filter_to_store",
                columns: table => new
                {
                    filter_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    source = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.store_id, x.filter_id, x.source });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ocfilter_filter_value",
                columns: table => new
                {
                    value_id = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    source = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    filter_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    key = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    color = table.Column<string>(type: "char(6)", fixedLength: true, maxLength: 6, nullable: false, defaultValueSql: "''"),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    sort_order = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.value_id, x.source });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ocfilter_filter_value_description",
                columns: table => new
                {
                    value_id = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    source = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    language_id = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    filter_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", nullable: false, defaultValueSql: "''"),
                    attribute_text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.value_id, x.language_id, x.source });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ocfilter_filter_value_to_product",
                columns: table => new
                {
                    filter_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    value_id = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    source = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    product_id = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.filter_id, x.value_id, x.source, x.product_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ocfilter_page",
                columns: table => new
                {
                    page_id = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    category_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    dynamic_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    params_key = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    params_count = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    @params = table.Column<string>(name: "params", type: "text", nullable: false),
                    dynamic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    module = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    sitemap = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    category = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    product = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.page_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ocfilter_page_description",
                columns: table => new
                {
                    page_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    language_id = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    heading_title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_keyword = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description_top = table.Column<string>(type: "text", nullable: false),
                    description_bottom = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.page_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ocfilter_page_to_layout",
                columns: table => new
                {
                    page_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    store_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    layout_id = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.page_id, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ocfilter_page_to_store",
                columns: table => new
                {
                    page_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    store_id = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.store_id, x.page_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ocfilter_setting",
                columns: table => new
                {
                    key = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    serialized = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    value = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.key);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_admin_setting",
                columns: table => new
                {
                    log_sql = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    groupdefault = table.Column<int>(type: "int(11)", nullable: false),
                    target_mail_template = table.Column<string>(type: "longtext", nullable: false),
                    target_sms_template = table.Column<string>(type: "longtext", nullable: false),
                    target_tlgrm_template = table.Column<string>(type: "longtext", nullable: false),
                    tlgrm_bot_token = table.Column<string>(type: "text", nullable: false),
                    tlgrm_admin_ides = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_fields_added",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    table = table.Column<string>(type: "text", nullable: false),
                    field = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_fields_setting",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(1)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    order_fields = table.Column<string>(type: "longtext", nullable: false),
                    order_as_fields = table.Column<string>(type: "longtext", nullable: false),
                    order_simple_fields = table.Column<string>(type: "longtext", nullable: false),
                    product_fields = table.Column<string>(type: "longtext", nullable: false),
                    product_as_fields = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_group_setting",
                columns: table => new
                {
                    user_group_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    group_target = table.Column<string>(type: "tinytext", nullable: false),
                    pages = table.Column<string>(type: "text", nullable: false),
                    access_actions = table.Column<string>(type: "longtext", nullable: false),
                    payments_list = table.Column<string>(type: "text", nullable: false),
                    shippings_list = table.Column<string>(type: "text", nullable: false),
                    select_orders = table.Column<string>(type: "longtext", nullable: false),
                    filters_default = table.Column<string>(type: "mediumtext", nullable: false),
                    order_formats = table.Column<string>(type: "mediumtext", nullable: false),
                    product_formats = table.Column<string>(type: "mediumtext", nullable: false),
                    order_statuses = table.Column<string>(type: "mediumtext", nullable: false),
                    order_payments = table.Column<string>(type: "mediumtext", nullable: false),
                    order_shippings = table.Column<string>(type: "mediumtext", nullable: false),
                    days_to_ship = table.Column<string>(type: "mediumtext", nullable: false),
                    comment_templates = table.Column<string>(type: "mediumtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.user_group_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_block",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    target = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_comment",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_excel_orders",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_excel_orders_products",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_filter",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    filter_id = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_filter_product",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    filter_id = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_history",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_mail",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_option",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_orders",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_page_block",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    target = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_pages",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    icon = table.Column<string>(type: "tinytext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_print_orders",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_print_orders_table",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_print_products_table",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_product",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_sms",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_ompro_tpl_tlgrm",
                columns: table => new
                {
                    template_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    template = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.template_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_option",
                columns: table => new
                {
                    option_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.option_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_option_description",
                columns: table => new
                {
                    option_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.option_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_option_value",
                columns: table => new
                {
                    option_value_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    option_id = table.Column<int>(type: "int(11)", nullable: false),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.option_value_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_option_value_description",
                columns: table => new
                {
                    option_value_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    option_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.option_value_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_order",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    manager_user_id = table.Column<int>(type: "int(11)", nullable: false),
                    courier_user_id = table.Column<int>(type: "int(11)", nullable: false),
                    track_no = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    invoice_no = table.Column<int>(type: "int(11)", nullable: false),
                    invoice_prefix = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false),
                    novaposhta_cn_number = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    novaposhta_cn_ref = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    store_url = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    customer_group_id = table.Column<int>(type: "int(11)", nullable: false),
                    firstname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    lastname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    email = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: false),
                    telephone = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    fax = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    custom_field = table.Column<string>(type: "text", nullable: false),
                    payment_firstname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    payment_lastname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    payment_company = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    payment_address_1 = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    payment_address_2 = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    payment_city = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    payment_postcode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    payment_country = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    payment_country_id = table.Column<int>(type: "int(11)", nullable: false),
                    payment_zone = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    payment_zone_id = table.Column<int>(type: "int(11)", nullable: false),
                    payment_address_format = table.Column<string>(type: "text", nullable: false),
                    payment_custom_field = table.Column<string>(type: "text", nullable: false),
                    payment_method = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    payment_code = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    payment_status_id = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    shipping_firstname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    shipping_lastname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    shipping_company = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    shipping_address_1 = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    shipping_address_2 = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    shipping_city = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    shipping_postcode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    shipping_country = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    shipping_country_id = table.Column<int>(type: "int(11)", nullable: false),
                    shipping_zone = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    shipping_zone_id = table.Column<int>(type: "int(11)", nullable: false),
                    shipping_address_format = table.Column<string>(type: "text", nullable: false),
                    shipping_custom_field = table.Column<string>(type: "text", nullable: false),
                    shipping_method = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    shipping_datetime_start = table.Column<DateTime>(type: "datetime", nullable: false),
                    shipping_datetime_end = table.Column<DateTime>(type: "datetime", nullable: false),
                    shipping_code = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    shipping_cost_fact = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    shipping_status_id = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    shipping_date = table.Column<DateTime>(type: "date", nullable: false),
                    shipping_time_start = table.Column<TimeSpan>(type: "time", nullable: false),
                    shipping_time_end = table.Column<TimeSpan>(type: "time", nullable: false),
                    shipping_latitude = table.Column<float>(type: "float(9,6)", nullable: false),
                    shipping_longitude = table.Column<float>(type: "float(9,6)", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: false),
                    total = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    order_discount = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    order_present_cost = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    order_present = table.Column<string>(type: "text", nullable: false),
                    order_custom_file = table.Column<string>(type: "text", nullable: false),
                    order_custom_image = table.Column<string>(type: "text", nullable: false),
                    order_status_id = table.Column<int>(type: "int(11)", nullable: false),
                    affiliate_id = table.Column<int>(type: "int(11)", nullable: false),
                    commission = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    marketing_id = table.Column<int>(type: "int(11)", nullable: false),
                    tracking = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    currency_id = table.Column<int>(type: "int(11)", nullable: false),
                    currency_code = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    currency_value = table.Column<decimal>(type: "decimal(15,8)", precision: 15, scale: 8, nullable: false, defaultValueSql: "'1.00000000'"),
                    ip = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    forwarded_ip = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    user_agent = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    accept_language = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.order_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_order_history",
                columns: table => new
                {
                    order_history_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    order_id = table.Column<int>(type: "int(11)", nullable: false),
                    user_id = table.Column<int>(type: "int(11)", nullable: false),
                    order_status_id = table.Column<int>(type: "int(11)", nullable: false),
                    payment_status_id = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    shipping_status_id = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    notify = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    notify_sms = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    notify_tlgrm = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: false),
                    log = table.Column<string>(type: "text", nullable: false),
                    file_name = table.Column<string>(type: "varchar(124)", maxLength: 124, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.order_history_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_order_option",
                columns: table => new
                {
                    order_option_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    order_id = table.Column<int>(type: "int(11)", nullable: false),
                    order_product_id = table.Column<int>(type: "int(11)", nullable: false),
                    product_option_id = table.Column<int>(type: "int(11)", nullable: false),
                    product_option_value_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    value = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.order_option_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_order_product",
                columns: table => new
                {
                    order_product_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    order_id = table.Column<int>(type: "int(11)", nullable: false),
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    model = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    quantity = table.Column<int>(type: "int(4)", nullable: false),
                    purchase = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    price = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    total = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    tax = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    reward = table.Column<int>(type: "int(8)", nullable: false),
                    notes = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.order_product_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_order_recurring",
                columns: table => new
                {
                    order_recurring_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    order_id = table.Column<int>(type: "int(11)", nullable: false),
                    reference = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    product_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    product_quantity = table.Column<int>(type: "int(11)", nullable: false),
                    recurring_id = table.Column<int>(type: "int(11)", nullable: false),
                    recurring_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    recurring_description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    recurring_frequency = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    recurring_cycle = table.Column<short>(type: "smallint(6)", nullable: false),
                    recurring_duration = table.Column<short>(type: "smallint(6)", nullable: false),
                    recurring_price = table.Column<decimal>(type: "decimal(10,4)", precision: 10, scale: 4, nullable: false),
                    trial = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    trial_frequency = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    trial_cycle = table.Column<short>(type: "smallint(6)", nullable: false),
                    trial_duration = table.Column<short>(type: "smallint(6)", nullable: false),
                    trial_price = table.Column<decimal>(type: "decimal(10,4)", precision: 10, scale: 4, nullable: false),
                    status = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.order_recurring_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_order_recurring_transaction",
                columns: table => new
                {
                    order_recurring_transaction_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    order_recurring_id = table.Column<int>(type: "int(11)", nullable: false),
                    reference = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    type = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    amount = table.Column<decimal>(type: "decimal(10,4)", precision: 10, scale: 4, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.order_recurring_transaction_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_order_shipment",
                columns: table => new
                {
                    order_shipment_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    order_id = table.Column<int>(type: "int(11)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    shipping_courier_id = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    tracking_number = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.order_shipment_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_order_simple_fields",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    metadata = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.order_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_order_status",
                columns: table => new
                {
                    order_status_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.order_status_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_order_total",
                columns: table => new
                {
                    order_total_id = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    order_id = table.Column<int>(type: "int(11)", nullable: false),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    value = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.order_total_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_order_voucher",
                columns: table => new
                {
                    order_voucher_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    order_id = table.Column<int>(type: "int(11)", nullable: false),
                    voucher_id = table.Column<int>(type: "int(11)", nullable: false),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    code = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    from_name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    from_email = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: false),
                    to_name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    to_email = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: false),
                    voucher_theme_id = table.Column<int>(type: "int(11)", nullable: false),
                    message = table.Column<string>(type: "text", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.order_voucher_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    model = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    sku = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    upc = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    ean = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    jan = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    isbn = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    mpn = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    location = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    quantity = table.Column<int>(type: "int(4)", nullable: false),
                    stock_status_id = table.Column<int>(type: "int(11)", nullable: false),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    manufacturer_id = table.Column<int>(type: "int(11)", nullable: false),
                    shipping = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValueSql: "'1'"),
                    price = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    points = table.Column<int>(type: "int(8)", nullable: false),
                    tax_class_id = table.Column<int>(type: "int(11)", nullable: false),
                    date_available = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "'0000-00-00'"),
                    weight = table.Column<decimal>(type: "decimal(15,8)", precision: 15, scale: 8, nullable: false),
                    weight_class_id = table.Column<int>(type: "int(11)", nullable: false),
                    length = table.Column<decimal>(type: "decimal(15,8)", precision: 15, scale: 8, nullable: false),
                    width = table.Column<decimal>(type: "decimal(15,8)", precision: 15, scale: 8, nullable: false),
                    height = table.Column<decimal>(type: "decimal(15,8)", precision: 15, scale: 8, nullable: false),
                    length_class_id = table.Column<int>(type: "int(11)", nullable: false),
                    subtract = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValueSql: "'1'"),
                    minimum = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "'1'"),
                    sort_order = table.Column<int>(type: "int(11)", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    viewed = table.Column<int>(type: "int(5)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false),
                    noindex = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValueSql: "'1'"),
                    cost = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.product_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_attribute",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    attribute_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.product_id, x.attribute_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_description",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    tag = table.Column<string>(type: "text", nullable: false),
                    meta_title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_keyword = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_h1 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.product_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_discount",
                columns: table => new
                {
                    product_discount_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    customer_group_id = table.Column<int>(type: "int(11)", nullable: false),
                    quantity = table.Column<int>(type: "int(4)", nullable: false),
                    priority = table.Column<int>(type: "int(5)", nullable: false, defaultValueSql: "'1'"),
                    price = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    date_start = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "'0000-00-00'"),
                    date_end = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "'0000-00-00'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.product_discount_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_filter",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    filter_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.product_id, x.filter_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_image",
                columns: table => new
                {
                    product_image_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.product_image_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_option",
                columns: table => new
                {
                    product_option_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    option_id = table.Column<int>(type: "int(11)", nullable: false),
                    value = table.Column<string>(type: "text", nullable: false),
                    required = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.product_option_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_option_value",
                columns: table => new
                {
                    product_option_value_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    product_option_id = table.Column<int>(type: "int(11)", nullable: false),
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    option_id = table.Column<int>(type: "int(11)", nullable: false),
                    option_value_id = table.Column<int>(type: "int(11)", nullable: false),
                    quantity = table.Column<int>(type: "int(3)", nullable: false),
                    subtract = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    price_prefix = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
                    points = table.Column<int>(type: "int(8)", nullable: false),
                    points_prefix = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
                    weight = table.Column<decimal>(type: "decimal(15,8)", precision: 15, scale: 8, nullable: false),
                    weight_prefix = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.product_option_value_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_recurring",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    recurring_id = table.Column<int>(type: "int(11)", nullable: false),
                    customer_group_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.product_id, x.recurring_id, x.customer_group_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_related",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    related_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.product_id, x.related_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_related_article",
                columns: table => new
                {
                    article_id = table.Column<int>(type: "int(11)", nullable: false),
                    product_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.article_id, x.product_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_related_mn",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    manufacturer_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_related_wb",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    category_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_reward",
                columns: table => new
                {
                    product_reward_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    customer_group_id = table.Column<int>(type: "int(11)", nullable: false),
                    points = table.Column<int>(type: "int(8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.product_reward_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_special",
                columns: table => new
                {
                    product_special_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    customer_group_id = table.Column<int>(type: "int(11)", nullable: false),
                    priority = table.Column<int>(type: "int(5)", nullable: false, defaultValueSql: "'1'"),
                    price = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    date_start = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "'0000-00-00'"),
                    date_end = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "'0000-00-00'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.product_special_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_to_category",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    category_id = table.Column<int>(type: "int(11)", nullable: false),
                    main_category = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.product_id, x.category_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_to_download",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    download_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.product_id, x.download_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_to_layout",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    layout_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.product_id, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_to_prom_product",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    prom_product_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.product_id, x.prom_product_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_to_store",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.product_id, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_product_to_supplier",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    supplier_id = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.product_id, x.supplier_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_prom_category",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    parent_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.category_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_prom_id",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    prom_id = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.product_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_recurring",
                columns: table => new
                {
                    recurring_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    price = table.Column<decimal>(type: "decimal(10,4)", precision: 10, scale: 4, nullable: false),
                    frequency = table.Column<string>(type: "enum('day','week','semi_month','month','year')", nullable: false),
                    duration = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    cycle = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    trial_status = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    trial_price = table.Column<decimal>(type: "decimal(10,4)", precision: 10, scale: 4, nullable: false),
                    trial_frequency = table.Column<string>(type: "enum('day','week','semi_month','month','year')", nullable: false),
                    trial_duration = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    trial_cycle = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    status = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    sort_order = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.recurring_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_recurring_description",
                columns: table => new
                {
                    recurring_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.recurring_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_remarketing_orders",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ecommerce = table.Column<DateTime>(type: "datetime", nullable: false),
                    ecommerce_ga4 = table.Column<DateTime>(type: "datetime", nullable: false),
                    facebook = table.Column<DateTime>(type: "datetime", nullable: false),
                    esputnik = table.Column<DateTime>(type: "datetime", nullable: false),
                    telegram = table.Column<DateTime>(type: "datetime", nullable: false),
                    tiktok = table.Column<DateTime>(type: "datetime", nullable: false),
                    facebook_lead = table.Column<DateTime>(type: "datetime", nullable: false),
                    success_page = table.Column<DateTime>(type: "datetime", nullable: false),
                    order_data = table.Column<string>(type: "longtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    tt_event_id = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    fb_lead_event_id = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    fb_event_id = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    ttclid = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    utm_content = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    utm_term = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    utm_medium = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    utm_campaign = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    utm_source = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    dclid = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    gclid = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    fbp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    fbc = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    fbclid = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    ga4_uuid = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    uuid = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.order_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_return",
                columns: table => new
                {
                    return_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    order_id = table.Column<int>(type: "int(11)", nullable: false),
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    firstname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    lastname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    email = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: false),
                    telephone = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    product = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    model = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    quantity = table.Column<int>(type: "int(4)", nullable: false),
                    opened = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    return_reason_id = table.Column<int>(type: "int(11)", nullable: false),
                    return_action_id = table.Column<int>(type: "int(11)", nullable: false),
                    return_status_id = table.Column<int>(type: "int(11)", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: true),
                    date_ordered = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "'0000-00-00'"),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.return_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_return_action",
                columns: table => new
                {
                    return_action_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.return_action_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_return_history",
                columns: table => new
                {
                    return_history_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    return_id = table.Column<int>(type: "int(11)", nullable: false),
                    return_status_id = table.Column<int>(type: "int(11)", nullable: false),
                    notify = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.return_history_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_return_reason",
                columns: table => new
                {
                    return_reason_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.return_reason_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_return_status",
                columns: table => new
                {
                    return_status_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.return_status_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_review",
                columns: table => new
                {
                    review_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    author = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    text = table.Column<string>(type: "text", nullable: false),
                    plus = table.Column<string>(type: "text", nullable: false),
                    minus = table.Column<string>(type: "text", nullable: false),
                    votes_plus = table.Column<int>(type: "int(11)", nullable: false),
                    votes_minus = table.Column<int>(type: "int(11)", nullable: false),
                    admin_reply = table.Column<string>(type: "text", nullable: false),
                    images = table.Column<string>(type: "tinytext", nullable: false),
                    real_buyer = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    rating = table.Column<int>(type: "int(1)", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.review_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_review_article",
                columns: table => new
                {
                    review_article_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    article_id = table.Column<int>(type: "int(11)", nullable: false),
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    author = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''"),
                    text = table.Column<string>(type: "text", nullable: false),
                    rating = table.Column<int>(type: "int(1)", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'"),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.review_article_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_seo_tags_generator",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(2)", nullable: false),
                    key = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_seo_tags_generator_category_copy",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int(11)", nullable: false),
                    copy_category_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.category_id, x.copy_category_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_seo_tags_generator_category_declension",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(3)", nullable: false),
                    category_name_singular_nominative = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    category_name_singular_genitive = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    category_name_plural_nominative = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    category_name_plural_genitive = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.category_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_seo_tags_generator_category_setting",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int(11)", nullable: false),
                    setting = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_seo_tags_generator_not_use",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false),
                    essence_id = table.Column<int>(type: "int(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.id, x.essence_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_seo_url",
                columns: table => new
                {
                    seo_url_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    query = table.Column<string>(type: "varchar(255)", nullable: false),
                    keyword = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.seo_url_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_session",
                columns: table => new
                {
                    session_id = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    data = table.Column<string>(type: "mediumtext", nullable: false),
                    expire = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.session_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_setting",
                columns: table => new
                {
                    setting_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    code = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    key = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    value = table.Column<string>(type: "mediumtext", nullable: false),
                    serialized = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.setting_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_setting_seolang",
                columns: table => new
                {
                    setting_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    codekey = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    value = table.Column<string>(type: "longtext", nullable: false),
                    serialized = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_shipping_courier",
                columns: table => new
                {
                    shipping_courier_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    shipping_courier_code = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    shipping_courier_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.shipping_courier_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_simple_cart",
                columns: table => new
                {
                    simple_cart_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<int>(type: "int(11)", nullable: true),
                    customer_id = table.Column<int>(type: "int(11)", nullable: true),
                    email = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: true),
                    firstname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: true),
                    lastname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: true),
                    telephone = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: true),
                    products = table.Column<string>(type: "text", nullable: true),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.simple_cart_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_statistics",
                columns: table => new
                {
                    statistics_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    value = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.statistics_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_stock_status",
                columns: table => new
                {
                    stock_status_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.stock_status_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_store",
                columns: table => new
                {
                    store_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    url = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    ssl = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.store_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_tax_class",
                columns: table => new
                {
                    tax_class_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.tax_class_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_tax_rate",
                columns: table => new
                {
                    tax_rate_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    geo_zone_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    rate = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    type = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.tax_rate_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_tax_rate_to_customer_group",
                columns: table => new
                {
                    tax_rate_id = table.Column<int>(type: "int(11)", nullable: false),
                    customer_group_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.tax_rate_id, x.customer_group_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_tax_rule",
                columns: table => new
                {
                    tax_rule_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    tax_class_id = table.Column<int>(type: "int(11)", nullable: false),
                    tax_rate_id = table.Column<int>(type: "int(11)", nullable: false),
                    based = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    priority = table.Column<int>(type: "int(5)", nullable: false, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.tax_rule_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_theme",
                columns: table => new
                {
                    theme_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    theme = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    route = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    code = table.Column<string>(type: "mediumtext", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.theme_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_translation",
                columns: table => new
                {
                    translation_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    route = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    key = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    value = table.Column<string>(type: "text", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.translation_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_uni_gallery",
                columns: table => new
                {
                    gallery_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.gallery_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_uni_gallery_description",
                columns: table => new
                {
                    gallery_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    meta_description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_keyword = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.gallery_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_uni_gallery_image",
                columns: table => new
                {
                    image_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    gallery_id = table.Column<int>(type: "int(11)", nullable: false),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.image_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_uni_gallery_image_description",
                columns: table => new
                {
                    image_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    link = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.image_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_uni_gallery_to_store",
                columns: table => new
                {
                    gallery_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.gallery_id, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_uni_news_category",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    parent_id = table.Column<int>(type: "int(11)", nullable: false),
                    sort_order = table.Column<int>(type: "int(3)", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.category_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_uni_news_category_description",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    meta_description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_keyword = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_h1 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.category_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_uni_news_category_path",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int(11)", nullable: false),
                    path_id = table.Column<int>(type: "int(11)", nullable: false),
                    level = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.category_id, x.path_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_uni_news_category_to_store",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.category_id, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_uni_news_product_related",
                columns: table => new
                {
                    news_id = table.Column<int>(type: "int(11)", nullable: false),
                    product_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.news_id, x.product_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_uni_news_story",
                columns: table => new
                {
                    news_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: true),
                    viewed = table.Column<int>(type: "int(11)", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.news_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_uni_news_story_description",
                columns: table => new
                {
                    news_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    meta_description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_keyword = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    meta_h1 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.news_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_uni_news_story_to_category",
                columns: table => new
                {
                    news_id = table.Column<int>(type: "int(11)", nullable: false),
                    category_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.news_id, x.category_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_uni_news_story_to_store",
                columns: table => new
                {
                    news_id = table.Column<int>(type: "int(11)", nullable: false),
                    store_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.news_id, x.store_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_uni_request",
                columns: table => new
                {
                    request_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    phone = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    mail = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    product_id = table.Column<int>(type: "int(11)", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: false),
                    admin_comment = table.Column<string>(type: "text", nullable: false),
                    date_added = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "'0000-00-00'"),
                    date_modified = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "'0000-00-00'"),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValueSql: "'1'"),
                    request_list = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.request_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_uni_setting",
                columns: table => new
                {
                    store_id = table.Column<int>(type: "int(11)", nullable: false),
                    data = table.Column<string>(type: "mediumtext", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_upload",
                columns: table => new
                {
                    upload_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    filename = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    code = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.upload_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_user",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    user_group_id = table.Column<int>(type: "int(11)", nullable: false),
                    username = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    password = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    salt = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false),
                    firstname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    lastname = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    email = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: false),
                    telephone = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    telegram_id = table.Column<string>(type: "text", nullable: false),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    code = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    ip = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.user_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_user_group",
                columns: table => new
                {
                    user_group_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    permission = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.user_group_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_voucher",
                columns: table => new
                {
                    voucher_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    order_id = table.Column<int>(type: "int(11)", nullable: false),
                    code = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    from_name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    from_email = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: false),
                    to_name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    to_email = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: false),
                    voucher_theme_id = table.Column<int>(type: "int(11)", nullable: false),
                    message = table.Column<string>(type: "text", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.voucher_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_voucher_history",
                columns: table => new
                {
                    voucher_history_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    voucher_id = table.Column<int>(type: "int(11)", nullable: false),
                    order_id = table.Column<int>(type: "int(11)", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.voucher_history_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_voucher_theme",
                columns: table => new
                {
                    voucher_theme_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.voucher_theme_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_voucher_theme_description",
                columns: table => new
                {
                    voucher_theme_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.voucher_theme_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_weight_class",
                columns: table => new
                {
                    weight_class_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    value = table.Column<decimal>(type: "decimal(15,8)", precision: 15, scale: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.weight_class_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_weight_class_description",
                columns: table => new
                {
                    weight_class_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_id = table.Column<int>(type: "int(11)", nullable: false),
                    title = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    unit = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.weight_class_id, x.language_id });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_zone",
                columns: table => new
                {
                    zone_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    country_id = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    code = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.zone_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ng_zone_to_geo_zone",
                columns: table => new
                {
                    zone_to_geo_zone_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    country_id = table.Column<int>(type: "int(11)", nullable: false),
                    zone_id = table.Column<int>(type: "int(11)", nullable: false),
                    geo_zone_id = table.Column<int>(type: "int(11)", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.zone_to_geo_zone_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "products_manual_set_prices",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sku = table.Column<string>(type: "longtext", nullable: false),
                    set_in_stock_price = table.Column<int>(type: "int(11)", nullable: false),
                    date_start = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: true),
                    date_end = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "products_manual_set_quanitys",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sku = table.Column<string>(type: "varchar(255)", nullable: false),
                    set_in_stock_qty = table.Column<int>(type: "int(11)", nullable: false),
                    date_start = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: true),
                    date_end = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "ix_mm_supplier_xml_settings_supplier_id",
                table: "mm_supplier_xml_settings",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_address_customer_id",
                table: "ng_address",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_article_description_name",
                table: "ng_article_description",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "ix_ng_blog_category_description_name",
                table: "ng_blog_category_description",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "ix_ng_cart_api_id_customer_id_session_id_product_id_recurring_id",
                table: "ng_cart",
                columns: new[] { "api_id", "customer_id", "session_id", "product_id", "recurring_id" });

            migrationBuilder.CreateIndex(
                name: "ix_ng_category_parent_id",
                table: "ng_category",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_category_description_name",
                table: "ng_category_description",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "ix_ng_category_to_prom_category_prom_category_id",
                table: "ng_category_to_prom_category",
                column: "prom_category_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_customer_group_customer_group_id",
                table: "ng_customer_group",
                column: "customer_group_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_customer_group_description_customer_group_id",
                table: "ng_customer_group_description",
                column: "customer_group_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_customer_ip_ip",
                table: "ng_customer_ip",
                column: "ip");

            migrationBuilder.CreateIndex(
                name: "ix_ng_customer_login_email",
                table: "ng_customer_login",
                column: "email");

            migrationBuilder.CreateIndex(
                name: "ix_ng_customer_login_ip",
                table: "ng_customer_login",
                column: "ip");

            migrationBuilder.CreateIndex(
                name: "ix_ng_customer_reward_customer_id",
                table: "ng_customer_reward",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_customer_reward_order_id",
                table: "ng_customer_reward",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_googleshopping_category_category_id_store_id",
                table: "ng_googleshopping_category",
                columns: new[] { "category_id", "store_id" });

            migrationBuilder.CreateIndex(
                name: "ix_ng_googleshopping_product_product_id_store_id",
                table: "ng_googleshopping_product",
                columns: new[] { "product_id", "store_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_ng_googleshopping_target_store_id",
                table: "ng_googleshopping_target",
                column: "store_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_language_name",
                table: "ng_language",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "ix_ng_location_name",
                table: "ng_location",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "ix_ng_novaposhta_cities_area",
                table: "ng_novaposhta_cities",
                column: "area");

            migrationBuilder.CreateIndex(
                name: "ix_ng_novaposhta_departments_city_ref",
                table: "ng_novaposhta_departments",
                column: "city_ref");

            migrationBuilder.CreateIndex(
                name: "ix_ng_novaposhta_departments_type_of_warehouse",
                table: "ng_novaposhta_departments",
                column: "type_of_warehouse");

            migrationBuilder.CreateIndex(
                name: "ix_ng_novaposhta_references_type",
                table: "ng_novaposhta_references",
                column: "type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_attribute_cache_attribute_id",
                table: "ng_ocfilter_attribute_cache",
                column: "attribute_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_attribute_cache_key",
                table: "ng_ocfilter_attribute_cache",
                column: "key");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_attribute_cache_language_id",
                table: "ng_ocfilter_attribute_cache",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_attribute_cache_product_id",
                table: "ng_ocfilter_attribute_cache",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_cache_expire",
                table: "ng_ocfilter_cache",
                column: "expire");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_cache_path",
                table: "ng_ocfilter_cache",
                column: "path");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_filter_sort_order",
                table: "ng_ocfilter_filter",
                column: "sort_order");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_filter_status",
                table: "ng_ocfilter_filter",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_filter_description_language_id",
                table: "ng_ocfilter_filter_description",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_filter_description_name",
                table: "ng_ocfilter_filter_description",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_filter_range_to_product_min_max",
                table: "ng_ocfilter_filter_range_to_product",
                columns: new[] { "min", "max" });

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_filter_range_to_product_product_id",
                table: "ng_ocfilter_filter_range_to_product",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_filter_to_category_category_id",
                table: "ng_ocfilter_filter_to_category",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_filter_to_store_store_id",
                table: "ng_ocfilter_filter_to_store",
                column: "store_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_filter_value_filter_id",
                table: "ng_ocfilter_filter_value",
                column: "filter_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_filter_value_key",
                table: "ng_ocfilter_filter_value",
                column: "key");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_filter_value_sort_order",
                table: "ng_ocfilter_filter_value",
                column: "sort_order");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_filter_value_description_filter_id",
                table: "ng_ocfilter_filter_value_description",
                column: "filter_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_filter_value_description_language_id",
                table: "ng_ocfilter_filter_value_description",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_filter_value_description_name",
                table: "ng_ocfilter_filter_value_description",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_filter_value_to_product_product_id",
                table: "ng_ocfilter_filter_value_to_product",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_page_category_id",
                table: "ng_ocfilter_page",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_page_dynamic_id",
                table: "ng_ocfilter_page",
                column: "dynamic_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_page_params_count",
                table: "ng_ocfilter_page",
                column: "params_count");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_page_params_key",
                table: "ng_ocfilter_page",
                column: "params_key");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_page_description_language_id",
                table: "ng_ocfilter_page_description",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_page_to_layout_store_id",
                table: "ng_ocfilter_page_to_layout",
                column: "store_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_ocfilter_page_to_store_store_id",
                table: "ng_ocfilter_page_to_store",
                column: "store_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_courier_user_id",
                table: "ng_order",
                column: "courier_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_customer_group_id",
                table: "ng_order",
                column: "customer_group_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_customer_id",
                table: "ng_order",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_date_added",
                table: "ng_order",
                column: "date_added");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_date_modified",
                table: "ng_order",
                column: "date_modified");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_manager_user_id",
                table: "ng_order",
                column: "manager_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_order_id",
                table: "ng_order",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_order_status_id",
                table: "ng_order",
                column: "order_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_payment_code",
                table: "ng_order",
                column: "payment_code");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_shipping_code",
                table: "ng_order",
                column: "shipping_code");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_total",
                table: "ng_order",
                column: "total");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_history_order_id",
                table: "ng_order_history",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_history_order_status_id",
                table: "ng_order_history",
                column: "order_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_option_order_id",
                table: "ng_order_option",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_option_order_option_id",
                table: "ng_order_option",
                column: "order_option_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_option_order_product_id",
                table: "ng_order_option",
                column: "order_product_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_option_product_option_value_id",
                table: "ng_order_option",
                column: "product_option_value_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_product_order_id",
                table: "ng_order_product",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_product_order_product_id",
                table: "ng_order_product",
                column: "order_product_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_status_order_status_id",
                table: "ng_order_status",
                column: "order_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_total_code",
                table: "ng_order_total",
                column: "code");

            migrationBuilder.CreateIndex(
                name: "ix_ng_order_total_order_id",
                table: "ng_order_total",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_product_product_id",
                table: "ng_product",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_product_description_name",
                table: "ng_product_description",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "ix_ng_product_discount_product_id",
                table: "ng_product_discount",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_product_image_product_id",
                table: "ng_product_image",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_product_option_value_product_id",
                table: "ng_product_option_value",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_product_option_value_product_option_id",
                table: "ng_product_option_value",
                column: "product_option_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_product_option_value_product_option_value_id",
                table: "ng_product_option_value",
                column: "product_option_value_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_product_special_product_id",
                table: "ng_product_special",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_product_to_category_category_id",
                table: "ng_product_to_category",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_product_to_prom_product_prom_product_id",
                table: "ng_product_to_prom_product",
                column: "prom_product_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_product_to_supplier_supplier_id",
                table: "ng_product_to_supplier",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_prom_category_parent_id",
                table: "ng_prom_category",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_review_product_id",
                table: "ng_review",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_review_article_article_id",
                table: "ng_review_article",
                column: "article_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_seo_tags_generator_category_id",
                table: "ng_seo_tags_generator",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_seo_tags_generator_key",
                table: "ng_seo_tags_generator",
                column: "key");

            migrationBuilder.CreateIndex(
                name: "ix_ng_seo_tags_generator_language_id",
                table: "ng_seo_tags_generator",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_seo_tags_generator_category_copy_copy_category_id",
                table: "ng_seo_tags_generator_category_copy",
                column: "copy_category_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_seo_tags_generator_category_setting_category_id",
                table: "ng_seo_tags_generator_category_setting",
                column: "category_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_ng_seo_url_keyword",
                table: "ng_seo_url",
                column: "keyword");

            migrationBuilder.CreateIndex(
                name: "ix_ng_seo_url_query",
                table: "ng_seo_url",
                column: "query");

            migrationBuilder.CreateIndex(
                name: "ix_ng_setting_seolang_codekey",
                table: "ng_setting_seolang",
                column: "codekey");

            migrationBuilder.CreateIndex(
                name: "ix_ng_setting_seolang_setting_id",
                table: "ng_setting_seolang",
                column: "setting_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_ng_setting_seolang_store_id",
                table: "ng_setting_seolang",
                column: "store_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_uni_news_category_parent_id",
                table: "ng_uni_news_category",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "ix_ng_uni_news_category_description_name",
                table: "ng_uni_news_category_description",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "ix_ng_uni_news_story_to_category_category_id",
                table: "ng_uni_news_story_to_category",
                column: "category_id");

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
                name: "__EFMigrationsHistory");

            migrationBuilder.DropTable(
                name: "attribute_description");

            migrationBuilder.DropTable(
                name: "mm_supplier");

            migrationBuilder.DropTable(
                name: "mm_supplier_xml_settings");

            migrationBuilder.DropTable(
                name: "ng_address");

            migrationBuilder.DropTable(
                name: "ng_address_simple_fields");

            migrationBuilder.DropTable(
                name: "ng_api");

            migrationBuilder.DropTable(
                name: "ng_api_ip");

            migrationBuilder.DropTable(
                name: "ng_api_session");

            migrationBuilder.DropTable(
                name: "ng_article");

            migrationBuilder.DropTable(
                name: "ng_article_description");

            migrationBuilder.DropTable(
                name: "ng_article_image");

            migrationBuilder.DropTable(
                name: "ng_article_related");

            migrationBuilder.DropTable(
                name: "ng_article_related_mn");

            migrationBuilder.DropTable(
                name: "ng_article_related_product");

            migrationBuilder.DropTable(
                name: "ng_article_related_wb");

            migrationBuilder.DropTable(
                name: "ng_article_to_blog_category");

            migrationBuilder.DropTable(
                name: "ng_article_to_download");

            migrationBuilder.DropTable(
                name: "ng_article_to_layout");

            migrationBuilder.DropTable(
                name: "ng_article_to_store");

            migrationBuilder.DropTable(
                name: "ng_attribute");

            migrationBuilder.DropTable(
                name: "ng_attribute_description");

            migrationBuilder.DropTable(
                name: "ng_attribute_group");

            migrationBuilder.DropTable(
                name: "ng_attribute_group_description");

            migrationBuilder.DropTable(
                name: "ng_banner");

            migrationBuilder.DropTable(
                name: "ng_banner_image");

            migrationBuilder.DropTable(
                name: "ng_blog_category");

            migrationBuilder.DropTable(
                name: "ng_blog_category_description");

            migrationBuilder.DropTable(
                name: "ng_blog_category_path");

            migrationBuilder.DropTable(
                name: "ng_blog_category_to_layout");

            migrationBuilder.DropTable(
                name: "ng_blog_category_to_store");

            migrationBuilder.DropTable(
                name: "ng_cart");

            migrationBuilder.DropTable(
                name: "ng_category");

            migrationBuilder.DropTable(
                name: "ng_category_description");

            migrationBuilder.DropTable(
                name: "ng_category_filter");

            migrationBuilder.DropTable(
                name: "ng_category_path");

            migrationBuilder.DropTable(
                name: "ng_category_to_layout");

            migrationBuilder.DropTable(
                name: "ng_category_to_prom_category");

            migrationBuilder.DropTable(
                name: "ng_category_to_store");

            migrationBuilder.DropTable(
                name: "ng_country");

            migrationBuilder.DropTable(
                name: "ng_coupon");

            migrationBuilder.DropTable(
                name: "ng_coupon_category");

            migrationBuilder.DropTable(
                name: "ng_coupon_history");

            migrationBuilder.DropTable(
                name: "ng_coupon_product");

            migrationBuilder.DropTable(
                name: "ng_currency");

            migrationBuilder.DropTable(
                name: "ng_custom_field");

            migrationBuilder.DropTable(
                name: "ng_custom_field_customer_group");

            migrationBuilder.DropTable(
                name: "ng_custom_field_description");

            migrationBuilder.DropTable(
                name: "ng_custom_field_value");

            migrationBuilder.DropTable(
                name: "ng_custom_field_value_description");

            migrationBuilder.DropTable(
                name: "ng_customer");

            migrationBuilder.DropTable(
                name: "ng_customer_activity");

            migrationBuilder.DropTable(
                name: "ng_customer_affiliate");

            migrationBuilder.DropTable(
                name: "ng_customer_approval");

            migrationBuilder.DropTable(
                name: "ng_customer_group");

            migrationBuilder.DropTable(
                name: "ng_customer_group_description");

            migrationBuilder.DropTable(
                name: "ng_customer_history");

            migrationBuilder.DropTable(
                name: "ng_customer_ip");

            migrationBuilder.DropTable(
                name: "ng_customer_login");

            migrationBuilder.DropTable(
                name: "ng_customer_online");

            migrationBuilder.DropTable(
                name: "ng_customer_reward");

            migrationBuilder.DropTable(
                name: "ng_customer_search");

            migrationBuilder.DropTable(
                name: "ng_customer_simple_fields");

            migrationBuilder.DropTable(
                name: "ng_customer_transaction");

            migrationBuilder.DropTable(
                name: "ng_customer_wishlist");

            migrationBuilder.DropTable(
                name: "ng_download");

            migrationBuilder.DropTable(
                name: "ng_download_description");

            migrationBuilder.DropTable(
                name: "ng_event");

            migrationBuilder.DropTable(
                name: "ng_extension");

            migrationBuilder.DropTable(
                name: "ng_extension_install");

            migrationBuilder.DropTable(
                name: "ng_extension_path");

            migrationBuilder.DropTable(
                name: "ng_filter");

            migrationBuilder.DropTable(
                name: "ng_filter_description");

            migrationBuilder.DropTable(
                name: "ng_filter_group");

            migrationBuilder.DropTable(
                name: "ng_filter_group_description");

            migrationBuilder.DropTable(
                name: "ng_geo_zone");

            migrationBuilder.DropTable(
                name: "ng_googleshopping_category");

            migrationBuilder.DropTable(
                name: "ng_googleshopping_product");

            migrationBuilder.DropTable(
                name: "ng_googleshopping_product_status");

            migrationBuilder.DropTable(
                name: "ng_googleshopping_product_target");

            migrationBuilder.DropTable(
                name: "ng_googleshopping_target");

            migrationBuilder.DropTable(
                name: "ng_information");

            migrationBuilder.DropTable(
                name: "ng_information_description");

            migrationBuilder.DropTable(
                name: "ng_information_to_layout");

            migrationBuilder.DropTable(
                name: "ng_information_to_store");

            migrationBuilder.DropTable(
                name: "ng_language");

            migrationBuilder.DropTable(
                name: "ng_layout");

            migrationBuilder.DropTable(
                name: "ng_layout_module");

            migrationBuilder.DropTable(
                name: "ng_layout_route");

            migrationBuilder.DropTable(
                name: "ng_length_class");

            migrationBuilder.DropTable(
                name: "ng_length_class_description");

            migrationBuilder.DropTable(
                name: "ng_licenses_km");

            migrationBuilder.DropTable(
                name: "ng_location");

            migrationBuilder.DropTable(
                name: "ng_manufacturer");

            migrationBuilder.DropTable(
                name: "ng_manufacturer_description");

            migrationBuilder.DropTable(
                name: "ng_manufacturer_to_layout");

            migrationBuilder.DropTable(
                name: "ng_manufacturer_to_store");

            migrationBuilder.DropTable(
                name: "ng_marketing");

            migrationBuilder.DropTable(
                name: "ng_modification");

            migrationBuilder.DropTable(
                name: "ng_modification_backup");

            migrationBuilder.DropTable(
                name: "ng_module");

            migrationBuilder.DropTable(
                name: "ng_multi_xml");

            migrationBuilder.DropTable(
                name: "ng_multiplicity_product");

            migrationBuilder.DropTable(
                name: "ng_novaposhta_cities");

            migrationBuilder.DropTable(
                name: "ng_novaposhta_departments");

            migrationBuilder.DropTable(
                name: "ng_novaposhta_references");

            migrationBuilder.DropTable(
                name: "ng_novaposhta_regions");

            migrationBuilder.DropTable(
                name: "ng_ocfilter_attribute_cache");

            migrationBuilder.DropTable(
                name: "ng_ocfilter_cache");

            migrationBuilder.DropTable(
                name: "ng_ocfilter_filter");

            migrationBuilder.DropTable(
                name: "ng_ocfilter_filter_description");

            migrationBuilder.DropTable(
                name: "ng_ocfilter_filter_range_to_product");

            migrationBuilder.DropTable(
                name: "ng_ocfilter_filter_to_category");

            migrationBuilder.DropTable(
                name: "ng_ocfilter_filter_to_store");

            migrationBuilder.DropTable(
                name: "ng_ocfilter_filter_value");

            migrationBuilder.DropTable(
                name: "ng_ocfilter_filter_value_description");

            migrationBuilder.DropTable(
                name: "ng_ocfilter_filter_value_to_product");

            migrationBuilder.DropTable(
                name: "ng_ocfilter_page");

            migrationBuilder.DropTable(
                name: "ng_ocfilter_page_description");

            migrationBuilder.DropTable(
                name: "ng_ocfilter_page_to_layout");

            migrationBuilder.DropTable(
                name: "ng_ocfilter_page_to_store");

            migrationBuilder.DropTable(
                name: "ng_ocfilter_setting");

            migrationBuilder.DropTable(
                name: "ng_ompro_admin_setting");

            migrationBuilder.DropTable(
                name: "ng_ompro_fields_added");

            migrationBuilder.DropTable(
                name: "ng_ompro_fields_setting");

            migrationBuilder.DropTable(
                name: "ng_ompro_group_setting");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_block");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_comment");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_excel_orders");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_excel_orders_products");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_filter");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_filter_product");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_history");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_mail");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_option");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_orders");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_page_block");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_pages");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_print_orders");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_print_orders_table");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_print_products_table");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_product");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_sms");

            migrationBuilder.DropTable(
                name: "ng_ompro_tpl_tlgrm");

            migrationBuilder.DropTable(
                name: "ng_option");

            migrationBuilder.DropTable(
                name: "ng_option_description");

            migrationBuilder.DropTable(
                name: "ng_option_value");

            migrationBuilder.DropTable(
                name: "ng_option_value_description");

            migrationBuilder.DropTable(
                name: "ng_order");

            migrationBuilder.DropTable(
                name: "ng_order_history");

            migrationBuilder.DropTable(
                name: "ng_order_option");

            migrationBuilder.DropTable(
                name: "ng_order_product");

            migrationBuilder.DropTable(
                name: "ng_order_recurring");

            migrationBuilder.DropTable(
                name: "ng_order_recurring_transaction");

            migrationBuilder.DropTable(
                name: "ng_order_shipment");

            migrationBuilder.DropTable(
                name: "ng_order_simple_fields");

            migrationBuilder.DropTable(
                name: "ng_order_status");

            migrationBuilder.DropTable(
                name: "ng_order_total");

            migrationBuilder.DropTable(
                name: "ng_order_voucher");

            migrationBuilder.DropTable(
                name: "ng_product");

            migrationBuilder.DropTable(
                name: "ng_product_attribute");

            migrationBuilder.DropTable(
                name: "ng_product_description");

            migrationBuilder.DropTable(
                name: "ng_product_discount");

            migrationBuilder.DropTable(
                name: "ng_product_filter");

            migrationBuilder.DropTable(
                name: "ng_product_image");

            migrationBuilder.DropTable(
                name: "ng_product_option");

            migrationBuilder.DropTable(
                name: "ng_product_option_value");

            migrationBuilder.DropTable(
                name: "ng_product_recurring");

            migrationBuilder.DropTable(
                name: "ng_product_related");

            migrationBuilder.DropTable(
                name: "ng_product_related_article");

            migrationBuilder.DropTable(
                name: "ng_product_related_mn");

            migrationBuilder.DropTable(
                name: "ng_product_related_wb");

            migrationBuilder.DropTable(
                name: "ng_product_reward");

            migrationBuilder.DropTable(
                name: "ng_product_special");

            migrationBuilder.DropTable(
                name: "ng_product_to_category");

            migrationBuilder.DropTable(
                name: "ng_product_to_download");

            migrationBuilder.DropTable(
                name: "ng_product_to_layout");

            migrationBuilder.DropTable(
                name: "ng_product_to_prom_product");

            migrationBuilder.DropTable(
                name: "ng_product_to_store");

            migrationBuilder.DropTable(
                name: "ng_product_to_supplier");

            migrationBuilder.DropTable(
                name: "ng_prom_category");

            migrationBuilder.DropTable(
                name: "ng_prom_id");

            migrationBuilder.DropTable(
                name: "ng_recurring");

            migrationBuilder.DropTable(
                name: "ng_recurring_description");

            migrationBuilder.DropTable(
                name: "ng_remarketing_orders");

            migrationBuilder.DropTable(
                name: "ng_return");

            migrationBuilder.DropTable(
                name: "ng_return_action");

            migrationBuilder.DropTable(
                name: "ng_return_history");

            migrationBuilder.DropTable(
                name: "ng_return_reason");

            migrationBuilder.DropTable(
                name: "ng_return_status");

            migrationBuilder.DropTable(
                name: "ng_review");

            migrationBuilder.DropTable(
                name: "ng_review_article");

            migrationBuilder.DropTable(
                name: "ng_seo_tags_generator");

            migrationBuilder.DropTable(
                name: "ng_seo_tags_generator_category_copy");

            migrationBuilder.DropTable(
                name: "ng_seo_tags_generator_category_declension");

            migrationBuilder.DropTable(
                name: "ng_seo_tags_generator_category_setting");

            migrationBuilder.DropTable(
                name: "ng_seo_tags_generator_not_use");

            migrationBuilder.DropTable(
                name: "ng_seo_url");

            migrationBuilder.DropTable(
                name: "ng_session");

            migrationBuilder.DropTable(
                name: "ng_setting");

            migrationBuilder.DropTable(
                name: "ng_setting_seolang");

            migrationBuilder.DropTable(
                name: "ng_shipping_courier");

            migrationBuilder.DropTable(
                name: "ng_simple_cart");

            migrationBuilder.DropTable(
                name: "ng_statistics");

            migrationBuilder.DropTable(
                name: "ng_stock_status");

            migrationBuilder.DropTable(
                name: "ng_store");

            migrationBuilder.DropTable(
                name: "ng_tax_class");

            migrationBuilder.DropTable(
                name: "ng_tax_rate");

            migrationBuilder.DropTable(
                name: "ng_tax_rate_to_customer_group");

            migrationBuilder.DropTable(
                name: "ng_tax_rule");

            migrationBuilder.DropTable(
                name: "ng_theme");

            migrationBuilder.DropTable(
                name: "ng_translation");

            migrationBuilder.DropTable(
                name: "ng_uni_gallery");

            migrationBuilder.DropTable(
                name: "ng_uni_gallery_description");

            migrationBuilder.DropTable(
                name: "ng_uni_gallery_image");

            migrationBuilder.DropTable(
                name: "ng_uni_gallery_image_description");

            migrationBuilder.DropTable(
                name: "ng_uni_gallery_to_store");

            migrationBuilder.DropTable(
                name: "ng_uni_news_category");

            migrationBuilder.DropTable(
                name: "ng_uni_news_category_description");

            migrationBuilder.DropTable(
                name: "ng_uni_news_category_path");

            migrationBuilder.DropTable(
                name: "ng_uni_news_category_to_store");

            migrationBuilder.DropTable(
                name: "ng_uni_news_product_related");

            migrationBuilder.DropTable(
                name: "ng_uni_news_story");

            migrationBuilder.DropTable(
                name: "ng_uni_news_story_description");

            migrationBuilder.DropTable(
                name: "ng_uni_news_story_to_category");

            migrationBuilder.DropTable(
                name: "ng_uni_news_story_to_store");

            migrationBuilder.DropTable(
                name: "ng_uni_request");

            migrationBuilder.DropTable(
                name: "ng_uni_setting");

            migrationBuilder.DropTable(
                name: "ng_upload");

            migrationBuilder.DropTable(
                name: "ng_user");

            migrationBuilder.DropTable(
                name: "ng_user_group");

            migrationBuilder.DropTable(
                name: "ng_voucher");

            migrationBuilder.DropTable(
                name: "ng_voucher_history");

            migrationBuilder.DropTable(
                name: "ng_voucher_theme");

            migrationBuilder.DropTable(
                name: "ng_voucher_theme_description");

            migrationBuilder.DropTable(
                name: "ng_weight_class");

            migrationBuilder.DropTable(
                name: "ng_weight_class_description");

            migrationBuilder.DropTable(
                name: "ng_zone");

            migrationBuilder.DropTable(
                name: "ng_zone_to_geo_zone");

            migrationBuilder.DropTable(
                name: "products_manual_set_prices");

            migrationBuilder.DropTable(
                name: "products_manual_set_quanitys");
        }
    }
}
