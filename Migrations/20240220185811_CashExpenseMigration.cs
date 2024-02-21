using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaleOfProducts.Migrations
{
    /// <inheritdoc />
    public partial class CashExpenseMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CashExpenses",
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
                    table.PrimaryKey("PK_CashExpenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CashExpenseExpenseItem",
                columns: table => new
                {
                    CashExpenseId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExpenseItemsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashExpenseExpenseItem", x => new { x.CashExpenseId, x.ExpenseItemsId });
                    table.ForeignKey(
                        name: "FK_CashExpenseExpenseItem_CashExpenses_CashExpenseId",
                        column: x => x.CashExpenseId,
                        principalTable: "CashExpenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CashExpenseExpenseItem_ExpenseItems_ExpenseItemsId",
                        column: x => x.ExpenseItemsId,
                        principalTable: "ExpenseItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CashExpenseExpenseItem_ExpenseItemsId",
                table: "CashExpenseExpenseItem",
                column: "ExpenseItemsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashExpenseExpenseItem");

            migrationBuilder.DropTable(
                name: "CashExpenses");

            migrationBuilder.DropTable(
                name: "ExpenseItems");
        }
    }
}
