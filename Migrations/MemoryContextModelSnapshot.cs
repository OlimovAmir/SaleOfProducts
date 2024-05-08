﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SaleOfProducts.Infrastructure;

#nullable disable

namespace SaleOfProducts.Migrations
{
    [DbContext(typeof(MemoryContext))]
    partial class MemoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CashExpenseExpenseItem", b =>
                {
                    b.Property<Guid>("CashExpenseId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ExpenseItemsId")
                        .HasColumnType("uuid");

                    b.HasKey("CashExpenseId", "ExpenseItemsId");

                    b.HasIndex("ExpenseItemsId");

                    b.ToTable("CashExpenseExpenseItem");
                });

            modelBuilder.Entity("CashIncomeIncomeItem", b =>
                {
                    b.Property<Guid>("CashIncomeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IncomeItemsId")
                        .HasColumnType("uuid");

                    b.HasKey("CashIncomeId", "IncomeItemsId");

                    b.HasIndex("IncomeItemsId");

                    b.ToTable("CashIncomeIncomeItem");
                });

            modelBuilder.Entity("SaleOfProducts.Models.CashExpense", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ExpenseItemId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("CashExpenses");
                });

            modelBuilder.Entity("SaleOfProducts.Models.CashIncome", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ExpenseItemId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("CashIncomes");
                });

            modelBuilder.Entity("SaleOfProducts.Models.CharacteristicProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<Dictionary<string, string>>("Specifications")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.HasKey("Id");

                    b.ToTable("CharacteristicProducts");
                });

            modelBuilder.Entity("SaleOfProducts.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("INN")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Phone")
                        .HasColumnType("integer");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SaleOfProducts.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsHired")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("PositionId")
                        .HasColumnType("uuid");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("TerminationDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SaleOfProducts.Models.ExpenseItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ExpenseItems");
                });

            modelBuilder.Entity("SaleOfProducts.Models.GroupProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("GroupProducts");
                });

            modelBuilder.Entity("SaleOfProducts.Models.GroupProductNameCharacteristicProduct", b =>
                {
                    b.Property<Guid>("GroupProductId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("NameCharacteristicProductId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.HasKey("GroupProductId", "NameCharacteristicProductId");

                    b.HasIndex("NameCharacteristicProductId");

                    b.ToTable("GroupProductNameCharacteristicProduct");
                });

            modelBuilder.Entity("SaleOfProducts.Models.IncomeItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("IncomeItems");
                });

            modelBuilder.Entity("SaleOfProducts.Models.NameCharacteristicProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("NameCharacteristicProducts");
                });

            modelBuilder.Entity("SaleOfProducts.Models.Position", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("SaleOfProducts.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("GroupProductId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GroupProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SaleOfProducts.Models.Supplier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("INN")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Phone")
                        .HasColumnType("integer");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("SaleOfProducts.Models.Unit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("SaleOfProducts.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SaleOfProducts.Models.ValueCharacteristicProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("GroupProductId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("NameCharacteristicProductId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("NameCharacteristicProductId")
                        .IsUnique();

                    b.ToTable("ValueCharacteristicProducts");
                });

            modelBuilder.Entity("CashExpenseExpenseItem", b =>
                {
                    b.HasOne("SaleOfProducts.Models.CashExpense", null)
                        .WithMany()
                        .HasForeignKey("CashExpenseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaleOfProducts.Models.ExpenseItem", null)
                        .WithMany()
                        .HasForeignKey("ExpenseItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CashIncomeIncomeItem", b =>
                {
                    b.HasOne("SaleOfProducts.Models.CashIncome", null)
                        .WithMany()
                        .HasForeignKey("CashIncomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaleOfProducts.Models.IncomeItem", null)
                        .WithMany()
                        .HasForeignKey("IncomeItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SaleOfProducts.Models.Employee", b =>
                {
                    b.HasOne("SaleOfProducts.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");
                });

            modelBuilder.Entity("SaleOfProducts.Models.GroupProductNameCharacteristicProduct", b =>
                {
                    b.HasOne("SaleOfProducts.Models.GroupProduct", "GroupProduct")
                        .WithMany()
                        .HasForeignKey("GroupProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaleOfProducts.Models.NameCharacteristicProduct", "NameCharacteristicProduct")
                        .WithMany("GroupProductCharacteristics")
                        .HasForeignKey("NameCharacteristicProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupProduct");

                    b.Navigation("NameCharacteristicProduct");
                });

            modelBuilder.Entity("SaleOfProducts.Models.Product", b =>
                {
                    b.HasOne("SaleOfProducts.Models.GroupProduct", "GroupProduct")
                        .WithMany("Products")
                        .HasForeignKey("GroupProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupProduct");
                });

            modelBuilder.Entity("SaleOfProducts.Models.ValueCharacteristicProduct", b =>
                {
                    b.HasOne("SaleOfProducts.Models.NameCharacteristicProduct", "NameCharacteristicProduct")
                        .WithOne()
                        .HasForeignKey("SaleOfProducts.Models.ValueCharacteristicProduct", "NameCharacteristicProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NameCharacteristicProduct");
                });

            modelBuilder.Entity("SaleOfProducts.Models.GroupProduct", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SaleOfProducts.Models.NameCharacteristicProduct", b =>
                {
                    b.Navigation("GroupProductCharacteristics");
                });
#pragma warning restore 612, 618
        }
    }
}
