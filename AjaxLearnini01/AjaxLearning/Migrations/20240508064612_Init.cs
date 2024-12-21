using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AjaxLearning.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employes",
                columns: table => new
                {
                    EmployeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employes", x => x.EmployeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employes");
        }
    }
}
