using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Yemeksepeti.Migrations
{
    public partial class DataSeed_first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Bonus", "Email", "Name", "PasswordHash", "PasswordSalt", "PhoneNumber", "Role", "Surname" },
                values: new object[] { 1, 0, null, "Sumeyra", null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "MinBasketAmount", "Name", "ServiceDuration", "ServiceVelocity", "Taste", "WorkingHours" },
                values: new object[] { 1, 0.0, "Dominos", 0, 0.0, 0.0, new TimeSpan(0, 0, 0, 0, 0) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
