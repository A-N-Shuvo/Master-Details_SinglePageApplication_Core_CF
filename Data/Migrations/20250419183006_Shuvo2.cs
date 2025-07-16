using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Evidence_MDetails_SinglePage_Core_CF.Data.Migrations
{
    /// <inheritdoc />
    public partial class Shuvo2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DOB",
                table: "Applicant",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DOB",
                table: "Applicant");
        }
    }
}
