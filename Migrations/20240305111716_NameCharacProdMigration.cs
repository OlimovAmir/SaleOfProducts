using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaleOfProducts.Migrations
{
    /// <inheritdoc />
    public partial class NameCharacProdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NameCharacteristicProduct",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NameCharacteristicProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ValueCharacteristicProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NameCharacteristicProductId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValueCharacteristicProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValueCharacteristicProducts_NameCharacteristicProduct_NameC~",
                        column: x => x.NameCharacteristicProductId,
                        principalTable: "NameCharacteristicProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ValueCharacteristicProducts_NameCharacteristicProductId",
                table: "ValueCharacteristicProducts",
                column: "NameCharacteristicProductId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ValueCharacteristicProducts");

            migrationBuilder.DropTable(
                name: "NameCharacteristicProduct");
        }
    }
}
