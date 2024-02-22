using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaleOfProducts.Migrations
{
    /// <inheritdoc />
    public partial class CashIncomeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CashIncomes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ExpenseItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashIncomes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CashIncomeIncomeItem",
                columns: table => new
                {
                    CashIncomeId = table.Column<Guid>(type: "uuid", nullable: false),
                    IncomeItemsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashIncomeIncomeItem", x => new { x.CashIncomeId, x.IncomeItemsId });
                    table.ForeignKey(
                        name: "FK_CashIncomeIncomeItem_CashIncomes_CashIncomeId",
                        column: x => x.CashIncomeId,
                        principalTable: "CashIncomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CashIncomeIncomeItem_IncomeItems_IncomeItemsId",
                        column: x => x.IncomeItemsId,
                        principalTable: "IncomeItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CashIncomeIncomeItem_IncomeItemsId",
                table: "CashIncomeIncomeItem",
                column: "IncomeItemsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashIncomeIncomeItem");

            migrationBuilder.DropTable(
                name: "CashIncomes");
        }
    }
}
