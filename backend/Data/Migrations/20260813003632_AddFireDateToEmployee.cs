using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employees.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFireDateToEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "FIreDate",
                table: "Employees",
                type: "date",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FIreDate",
                table: "Employees");
        }
    }
}
