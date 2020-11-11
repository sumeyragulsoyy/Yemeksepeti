using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Yemeksepeti.Migrations
{
    public partial class restaurant_hour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkingHours",
                table: "Restaurants");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "ClosingHour",
                table: "Restaurants",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartingHour",
                table: "Restaurants",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosingHour",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "StartingHour",
                table: "Restaurants");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "WorkingHours",
                table: "Restaurants",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
