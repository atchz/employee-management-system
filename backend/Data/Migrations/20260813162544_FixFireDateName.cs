using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Empleados.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixFireDateName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FIreDate",
                table: "Employees",
                newName: "FireDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FireDate",
                table: "Employees",
                newName: "FIreDate");
        }
    }
}
