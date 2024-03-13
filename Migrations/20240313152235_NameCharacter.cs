using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaleOfProducts.Migrations
{
    /// <inheritdoc />
    public partial class NameCharacter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupProductId",
                table: "NameCharacteristicProduct",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "GroupProductNameCharacteristicProduct",
                columns: table => new
                {
                    CharacteristicsId = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupProductId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupProductNameCharacteristicProduct", x => new { x.CharacteristicsId, x.GroupProductId });
                    table.ForeignKey(
                        name: "FK_GroupProductNameCharacteristicProduct_GroupProducts_GroupPr~",
                        column: x => x.GroupProductId,
                        principalTable: "GroupProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupProductNameCharacteristicProduct_NameCharacteristicPro~",
                        column: x => x.CharacteristicsId,
                        principalTable: "NameCharacteristicProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupProductNameCharacteristicProduct_GroupProductId",
                table: "GroupProductNameCharacteristicProduct",
                column: "GroupProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupProductNameCharacteristicProduct");

            migrationBuilder.DropColumn(
                name: "GroupProductId",
                table: "NameCharacteristicProduct");
        }
    }
}
