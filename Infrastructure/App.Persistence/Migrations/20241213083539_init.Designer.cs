﻿// <auto-generated />
using System;
using App.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241213083539_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("App.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 12, 13, 11, 35, 39, 511, DateTimeKind.Local).AddTicks(8172),
                            Name = "Elektronik"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 12, 13, 11, 35, 39, 511, DateTimeKind.Local).AddTicks(8184),
                            Name = "Aksesuarlar"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 12, 13, 11, 35, 39, 511, DateTimeKind.Local).AddTicks(8186),
                            Name = "Ses"
                        });
                });

            modelBuilder.Entity("App.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Created = new DateTime(2024, 12, 13, 11, 35, 39, 511, DateTimeKind.Local).AddTicks(9656),
                            Name = "Dizüstü Bilgisayar",
                            Price = 10000.00m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Created = new DateTime(2024, 12, 13, 11, 35, 39, 511, DateTimeKind.Local).AddTicks(9659),
                            Name = "Akıllı Telefon",
                            Price = 7000.00m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Created = new DateTime(2024, 12, 13, 11, 35, 39, 511, DateTimeKind.Local).AddTicks(9660),
                            Name = "Kulaklık",
                            Price = 1500.00m,
                            Stock = 200
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Created = new DateTime(2024, 12, 13, 11, 35, 39, 511, DateTimeKind.Local).AddTicks(9662),
                            Name = "Akıllı Saat",
                            Price = 3000.00m,
                            Stock = 80
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Created = new DateTime(2024, 12, 13, 11, 35, 39, 511, DateTimeKind.Local).AddTicks(9664),
                            Name = "Tablet",
                            Price = 5000.00m,
                            Stock = 120
                        });
                });

            modelBuilder.Entity("App.Domain.Entities.Product", b =>
                {
                    b.HasOne("App.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("App.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}