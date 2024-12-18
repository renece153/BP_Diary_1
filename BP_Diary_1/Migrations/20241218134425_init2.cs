using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BP_Diary_1.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bp_diary");

            migrationBuilder.CreateTable(
                name: "bp_diary_records",
                columns: table => new
                {
                    bp_diary_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date_record = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    systolic = table.Column<int>(type: "integer", nullable: false),
                    diastolic = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bp_diary_records", x => x.bp_diary_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bp_diary_records");

            migrationBuilder.CreateTable(
                name: "bp_diary",
                columns: table => new
                {
                    bp_diary_id = table.Column<int>(type: "integer", nullable: false),
                    date_record = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    diastolic = table.Column<int>(type: "integer", nullable: false),
                    systolic = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                });
        }
    }
}
