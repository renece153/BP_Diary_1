using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BP_Diary_1.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bp_diary",
                columns: table => new
                {
                    bp_diary_id = table.Column<int>(type: "integer", nullable: false),
                    date_record = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    systolic = table.Column<int>(type: "integer", nullable: false),
                    diastolic = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bp_diary");
        }
    }
}
