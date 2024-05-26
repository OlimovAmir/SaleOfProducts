using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaleOfProducts.Migrations
{
    /// <inheritdoc />
    public partial class version1 : Migration
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
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    State = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<int>(type: "integer", nullable: true),
                    INN = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
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
                name: "GroupProducts",
                columns: table => new
                {
                    GroupProductsId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupProducts", x => x.GroupProductsId);
                });

            migrationBuilder.CreateTable(
                name: "IncomeItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NameCharacteristicProducts",
                columns: table => new
                {
                    NameCharacteristicProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NameCharacteristicProducts", x => x.NameCharacteristicProductId);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    State = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<int>(type: "integer", nullable: true),
                    INN = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupProductId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_GroupProducts_GroupProductId",
                        column: x => x.GroupProductId,
                        principalTable: "GroupProducts",
                        principalColumn: "GroupProductsId",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Product_NameCharacteristicProduct",
                columns: table => new
                {
                    GroupProductsId = table.Column<Guid>(type: "uuid", nullable: false),
                    NameCharacteristicProductsNameCharacteristicProductId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_NameCharacteristicProduct", x => new { x.GroupProductsId, x.NameCharacteristicProductsNameCharacteristicProductId });
                    table.ForeignKey(
                        name: "FK_Product_NameCharacteristicProduct_GroupProducts_GroupProduc~",
                        column: x => x.GroupProductsId,
                        principalTable: "GroupProducts",
                        principalColumn: "GroupProductsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_NameCharacteristicProduct_NameCharacteristicProduct~",
                        column: x => x.NameCharacteristicProductsNameCharacteristicProductId,
                        principalTable: "NameCharacteristicProducts",
                        principalColumn: "NameCharacteristicProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PositionId = table.Column<Guid>(type: "uuid", nullable: false),
                    HireDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TerminationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsHired = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SurName = table.Column<string>(type: "text", nullable: false),
                    Birthday = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseProduct",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    UnitId = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseProduct_GroupProducts_GroupProductId",
                        column: x => x.GroupProductId,
                        principalTable: "GroupProducts",
                        principalColumn: "GroupProductsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseProduct_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseProduct_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ValueCharacteristicProducts",
                columns: table => new
                {
                    ValueCharacteristicProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PurchaseProductId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValueCharacteristicProducts", x => x.ValueCharacteristicProductId);
                    table.ForeignKey(
                        name: "FK_ValueCharacteristicProducts_PurchaseProduct_PurchaseProduct~",
                        column: x => x.PurchaseProductId,
                        principalTable: "PurchaseProduct",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NameValueCharacteristicProduct",
                columns: table => new
                {
                    NameCharacteristicProductsNameCharacteristicProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    ValueCharacteristicProductsValueCharacteristicProductId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NameValueCharacteristicProduct", x => new { x.NameCharacteristicProductsNameCharacteristicProductId, x.ValueCharacteristicProductsValueCharacteristicProductId });
                    table.ForeignKey(
                        name: "FK_NameValueCharacteristicProduct_NameCharacteristicProducts_N~",
                        column: x => x.NameCharacteristicProductsNameCharacteristicProductId,
                        principalTable: "NameCharacteristicProducts",
                        principalColumn: "NameCharacteristicProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NameValueCharacteristicProduct_ValueCharacteristicProducts_~",
                        column: x => x.ValueCharacteristicProductsValueCharacteristicProductId,
                        principalTable: "ValueCharacteristicProducts",
                        principalColumn: "ValueCharacteristicProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CashExpenseExpenseItem_ExpenseItemsId",
                table: "CashExpenseExpenseItem",
                column: "ExpenseItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_CashIncomeIncomeItem_IncomeItemsId",
                table: "CashIncomeIncomeItem",
                column: "IncomeItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId",
                table: "Employees",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_NameValueCharacteristicProduct_ValueCharacteristicProductsV~",
                table: "NameValueCharacteristicProduct",
                column: "ValueCharacteristicProductsValueCharacteristicProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_NameCharacteristicProduct_NameCharacteristicProduct~",
                table: "Product_NameCharacteristicProduct",
                column: "NameCharacteristicProductsNameCharacteristicProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GroupProductId",
                table: "Products",
                column: "GroupProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseProduct_GroupProductId",
                table: "PurchaseProduct",
                column: "GroupProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseProduct_SupplierId",
                table: "PurchaseProduct",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseProduct_UnitId",
                table: "PurchaseProduct",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ValueCharacteristicProducts_PurchaseProductId",
                table: "ValueCharacteristicProducts",
                column: "PurchaseProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashExpenseExpenseItem");

            migrationBuilder.DropTable(
                name: "CashIncomeIncomeItem");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "NameValueCharacteristicProduct");

            migrationBuilder.DropTable(
                name: "Product_NameCharacteristicProduct");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CashExpenses");

            migrationBuilder.DropTable(
                name: "ExpenseItems");

            migrationBuilder.DropTable(
                name: "CashIncomes");

            migrationBuilder.DropTable(
                name: "IncomeItems");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "ValueCharacteristicProducts");

            migrationBuilder.DropTable(
                name: "NameCharacteristicProducts");

            migrationBuilder.DropTable(
                name: "PurchaseProduct");

            migrationBuilder.DropTable(
                name: "GroupProducts");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Units");
        }
    }
}
