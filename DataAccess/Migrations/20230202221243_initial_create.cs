using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UnitsInStock = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Status" },
                values: new object[,]
                {
                    { 1, "Bilgisayar", true },
                    { 2, "Telefon", true },
                    { 3, "Tablet", true },
                    { 4, "Televizyon", true }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ProductName", "Status", "UnitPrice", "UnitsInStock" },
                values: new object[,]
                {
                    { 1, 1, "HP Laptop", true, 17000m, 50 },
                    { 2, 1, "Msi Laptop", true, 25000m, 45 },
                    { 3, 2, "Samsung S22", true, 15500m, 30 },
                    { 4, 2, "IPhone 14 Pro", true, 32000m, 18 },
                    { 5, 2, "Oppo Reno", true, 4000m, 9 },
                    { 6, 3, "Huawei Tablet", true, 3800m, 11 },
                    { 7, 3, "IPad Pro", true, 24000m, 9 },
                    { 8, 4, "LG Ultra TV", true, 43800m, 11 },
                    { 9, 4, "Philips 4K TV", true, 34000m, 9 },
                    { 10, 4, "Samsung OLed TV", true, 32340m, 5 },
                    { 11, 4, "Samsung Led TV", true, 35000m, 11 },
                    { 12, 4, "Arçelik HD TV", true, 23800m, 11 },
                    { 13, 4, "Beko HD TV", true, 32200m, 9 },
                    { 14, 4, "Asus Oled TV", true, 30300m, 11 },
                    { 15, 4, "Sony HD TV", true, 29200m, 9 }
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
