using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Yemeksepeti.Migrations
{
    public partial class restaurant_hour_type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartingHour",
                table: "Restaurants",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClosingHour",
                table: "Restaurants",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "StartingHour",
                table: "Restaurants",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "ClosingHour",
                table: "Restaurants",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
