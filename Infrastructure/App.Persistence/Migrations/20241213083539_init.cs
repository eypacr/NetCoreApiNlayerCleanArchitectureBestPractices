using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 13, 11, 35, 39, 511, DateTimeKind.Local).AddTicks(8172), "Elektronik", null },
                    { 2, new DateTime(2024, 12, 13, 11, 35, 39, 511, DateTimeKind.Local).AddTicks(8184), "Aksesuarlar", null },
                    { 3, new DateTime(2024, 12, 13, 11, 35, 39, 511, DateTimeKind.Local).AddTicks(8186), "Ses", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Name", "Price", "Stock", "Updated" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 13, 11, 35, 39, 511, DateTimeKind.Local).AddTicks(9656), "Dizüstü Bilgisayar", 10000.00m, 50, null },
                    { 2, 2, new DateTime(2024, 12, 13, 11, 35, 39, 511, DateTimeKind.Local).AddTicks(9659), "Akıllı Telefon", 7000.00m, 100, null },
                    { 3, 3, new DateTime(2024, 12, 13, 11, 35, 39, 511, DateTimeKind.Local).AddTicks(9660), "Kulaklık", 1500.00m, 200, null },
                    { 4, 2, new DateTime(2024, 12, 13, 11, 35, 39, 511, DateTimeKind.Local).AddTicks(9662), "Akıllı Saat", 3000.00m, 80, null },
                    { 5, 1, new DateTime(2024, 12, 13, 11, 35, 39, 511, DateTimeKind.Local).AddTicks(9664), "Tablet", 5000.00m, 120, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
