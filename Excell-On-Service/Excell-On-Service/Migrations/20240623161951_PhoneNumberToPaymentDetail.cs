using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Excell_On_Service.Migrations
{
    /// <inheritdoc />
    public partial class PhoneNumberToPaymentDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "PymentDetail",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "PymentDetail");
        }
    }
}
