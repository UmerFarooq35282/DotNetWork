using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MDCForms.Migrations
{
    /// <inheritdoc />
    public partial class ProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductType = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompaniesCompanyName = table.Column<string>(type: "nvarchar(40)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Companies_CompaniesCompanyName",
                        column: x => x.CompaniesCompanyName,
                        principalTable: "Companies",
                        principalColumn: "CompanyName");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompaniesCompanyName",
                table: "Products",
                column: "CompaniesCompanyName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
