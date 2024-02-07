using System;
using DocumentFormat.OpenXml.CustomXmlSchemaReferences;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.MySqlClient.X.XDevAPI.Common;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace xmlParserASP.Migrations
{
    /// <inheritdoc />
    public partial class QuantityXlColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "quantity_xl_column",
                table: "mm_supplier_xml_settings",
                type: "varchar(255)",
                nullable: true);

           
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quantity_xl_column",
                table: "mm_supplier_xml_settings");
        }
    }
}
