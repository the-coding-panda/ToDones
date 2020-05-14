using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDones.Data.Migrations
{
    public partial class UpdateTimeLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "TimeLogs");

            migrationBuilder.AddColumn<DateTime>(
                name: "End",
                table: "TimeLogs",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Start",
                table: "TimeLogs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "End",
                table: "TimeLogs");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "TimeLogs");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "TimeLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
