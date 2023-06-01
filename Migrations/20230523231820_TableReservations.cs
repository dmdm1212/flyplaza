using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace flyplaza.Migrations
{
    /// <inheritdoc />
    public partial class TableReservations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "TableReservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AllTableReservations",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "TableReservations");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AllTableReservations");
        }
    }
}
