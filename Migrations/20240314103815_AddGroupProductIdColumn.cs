using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaleOfProducts.Migrations
{
    /// <inheritdoc />
    public partial class AddGroupProductIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupProductNameCharacteristicProduct_NameCharacteristicPro~",
                table: "GroupProductNameCharacteristicProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ValueCharacteristicProducts_NameCharacteristicProduct_NameC~",
                table: "ValueCharacteristicProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupProductNameCharacteristicProduct",
                table: "GroupProductNameCharacteristicProduct");

            migrationBuilder.DropIndex(
                name: "IX_GroupProductNameCharacteristicProduct_GroupProductId",
                table: "GroupProductNameCharacteristicProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NameCharacteristicProduct",
                table: "NameCharacteristicProduct");

            migrationBuilder.DropColumn(
                name: "GroupProductId",
                table: "NameCharacteristicProduct");

            migrationBuilder.RenameTable(
                name: "NameCharacteristicProduct",
                newName: "NameCharacteristicProducts");

            migrationBuilder.RenameColumn(
                name: "CharacteristicsId",
                table: "GroupProductNameCharacteristicProduct",
                newName: "Id");

            migrationBuilder.AddColumn<Guid>(
                name: "GroupProductId",
                table: "ValueCharacteristicProducts",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "NameCharacteristicProductId1",
                table: "ValueCharacteristicProducts",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GroupProductId",
                table: "GroupProducts",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "NameCharacteristicProductId",
                table: "GroupProductNameCharacteristicProduct",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "NameCharacteristicProductId",
                table: "NameCharacteristicProducts",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupProductNameCharacteristicProduct",
                table: "GroupProductNameCharacteristicProduct",
                columns: new[] { "GroupProductId", "NameCharacteristicProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_NameCharacteristicProducts",
                table: "NameCharacteristicProducts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ValueCharacteristicProducts_NameCharacteristicProductId1",
                table: "ValueCharacteristicProducts",
                column: "NameCharacteristicProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_GroupProductNameCharacteristicProduct_NameCharacteristicPro~",
                table: "GroupProductNameCharacteristicProduct",
                column: "NameCharacteristicProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupProductNameCharacteristicProduct_NameCharacteristicPro~",
                table: "GroupProductNameCharacteristicProduct",
                column: "NameCharacteristicProductId",
                principalTable: "NameCharacteristicProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ValueCharacteristicProducts_NameCharacteristicProducts_Name~",
                table: "ValueCharacteristicProducts",
                column: "NameCharacteristicProductId",
                principalTable: "NameCharacteristicProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ValueCharacteristicProducts_NameCharacteristicProducts_Nam~1",
                table: "ValueCharacteristicProducts",
                column: "NameCharacteristicProductId1",
                principalTable: "NameCharacteristicProducts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupProductNameCharacteristicProduct_NameCharacteristicPro~",
                table: "GroupProductNameCharacteristicProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ValueCharacteristicProducts_NameCharacteristicProducts_Name~",
                table: "ValueCharacteristicProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_ValueCharacteristicProducts_NameCharacteristicProducts_Nam~1",
                table: "ValueCharacteristicProducts");

            migrationBuilder.DropIndex(
                name: "IX_ValueCharacteristicProducts_NameCharacteristicProductId1",
                table: "ValueCharacteristicProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupProductNameCharacteristicProduct",
                table: "GroupProductNameCharacteristicProduct");

            migrationBuilder.DropIndex(
                name: "IX_GroupProductNameCharacteristicProduct_NameCharacteristicPro~",
                table: "GroupProductNameCharacteristicProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NameCharacteristicProducts",
                table: "NameCharacteristicProducts");

            migrationBuilder.DropColumn(
                name: "GroupProductId",
                table: "ValueCharacteristicProducts");

            migrationBuilder.DropColumn(
                name: "NameCharacteristicProductId1",
                table: "ValueCharacteristicProducts");

            migrationBuilder.DropColumn(
                name: "GroupProductId",
                table: "GroupProducts");

            migrationBuilder.DropColumn(
                name: "NameCharacteristicProductId",
                table: "GroupProductNameCharacteristicProduct");

            migrationBuilder.DropColumn(
                name: "NameCharacteristicProductId",
                table: "NameCharacteristicProducts");

            migrationBuilder.RenameTable(
                name: "NameCharacteristicProducts",
                newName: "NameCharacteristicProduct");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "GroupProductNameCharacteristicProduct",
                newName: "CharacteristicsId");

            migrationBuilder.AddColumn<int>(
                name: "GroupProductId",
                table: "NameCharacteristicProduct",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupProductNameCharacteristicProduct",
                table: "GroupProductNameCharacteristicProduct",
                columns: new[] { "CharacteristicsId", "GroupProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_NameCharacteristicProduct",
                table: "NameCharacteristicProduct",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_GroupProductNameCharacteristicProduct_GroupProductId",
                table: "GroupProductNameCharacteristicProduct",
                column: "GroupProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupProductNameCharacteristicProduct_NameCharacteristicPro~",
                table: "GroupProductNameCharacteristicProduct",
                column: "CharacteristicsId",
                principalTable: "NameCharacteristicProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ValueCharacteristicProducts_NameCharacteristicProduct_NameC~",
                table: "ValueCharacteristicProducts",
                column: "NameCharacteristicProductId",
                principalTable: "NameCharacteristicProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
