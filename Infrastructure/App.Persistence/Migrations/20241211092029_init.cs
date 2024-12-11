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
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    { 1, new DateTime(2024, 12, 11, 12, 20, 29, 454, DateTimeKind.Local).AddTicks(9938), "Elektronik", new DateTime(2024, 12, 11, 12, 20, 29, 454, DateTimeKind.Local).AddTicks(9951) },
                    { 2, new DateTime(2024, 12, 11, 12, 20, 29, 454, DateTimeKind.Local).AddTicks(9957), "Aksesuarlar", new DateTime(2024, 12, 11, 12, 20, 29, 454, DateTimeKind.Local).AddTicks(9958) },
                    { 3, new DateTime(2024, 12, 11, 12, 20, 29, 454, DateTimeKind.Local).AddTicks(9960), "Ses", new DateTime(2024, 12, 11, 12, 20, 29, 454, DateTimeKind.Local).AddTicks(9961) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Name", "Price", "Stock", "Updated" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 11, 12, 20, 29, 455, DateTimeKind.Local).AddTicks(3325), "Dizüstü Bilgisayar", 10000.00m, 50, new DateTime(2024, 12, 11, 12, 20, 29, 455, DateTimeKind.Local).AddTicks(3327) },
                    { 2, 2, new DateTime(2024, 12, 11, 12, 20, 29, 455, DateTimeKind.Local).AddTicks(3333), "Akıllı Telefon", 7000.00m, 100, new DateTime(2024, 12, 11, 12, 20, 29, 455, DateTimeKind.Local).AddTicks(3334) },
                    { 3, 3, new DateTime(2024, 12, 11, 12, 20, 29, 455, DateTimeKind.Local).AddTicks(3337), "Kulaklık", 1500.00m, 200, new DateTime(2024, 12, 11, 12, 20, 29, 455, DateTimeKind.Local).AddTicks(3338) },
                    { 4, 2, new DateTime(2024, 12, 11, 12, 20, 29, 455, DateTimeKind.Local).AddTicks(3342), "Akıllı Saat", 3000.00m, 80, new DateTime(2024, 12, 11, 12, 20, 29, 455, DateTimeKind.Local).AddTicks(3343) },
                    { 5, 1, new DateTime(2024, 12, 11, 12, 20, 29, 455, DateTimeKind.Local).AddTicks(3346), "Tablet", 5000.00m, 120, new DateTime(2024, 12, 11, 12, 20, 29, 455, DateTimeKind.Local).AddTicks(3347) }
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
