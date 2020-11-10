using Microsoft.EntityFrameworkCore.Migrations;

namespace Yemeksepeti.Migrations
{
    public partial class dbset_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRegion_Customers_CustomerId",
                table: "CustomerRegion");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRegion_Region_RegionId",
                table: "CustomerRegion");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantRegion_Region_RegionId",
                table: "RestaurantRegion");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantRegion_Restaurants_RestaurantId",
                table: "RestaurantRegion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestaurantRegion",
                table: "RestaurantRegion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Region",
                table: "Region");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerRegion",
                table: "CustomerRegion");

            migrationBuilder.RenameTable(
                name: "RestaurantRegion",
                newName: "RestaurantRegions");

            migrationBuilder.RenameTable(
                name: "Region",
                newName: "Regions");

            migrationBuilder.RenameTable(
                name: "CustomerRegion",
                newName: "CustomerRegions");

            migrationBuilder.RenameIndex(
                name: "IX_RestaurantRegion_RegionId",
                table: "RestaurantRegions",
                newName: "IX_RestaurantRegions_RegionId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerRegion_RegionId",
                table: "CustomerRegions",
                newName: "IX_CustomerRegions_RegionId");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                nullable: true,
                defaultValue: "Customer",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestaurantRegions",
                table: "RestaurantRegions",
                columns: new[] { "RestaurantId", "RegionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regions",
                table: "Regions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerRegions",
                table: "CustomerRegions",
                columns: new[] { "CustomerId", "RegionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRegions_Customers_CustomerId",
                table: "CustomerRegions",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRegions_Regions_RegionId",
                table: "CustomerRegions",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantRegions_Regions_RegionId",
                table: "RestaurantRegions",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantRegions_Restaurants_RestaurantId",
                table: "RestaurantRegions",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRegions_Customers_CustomerId",
                table: "CustomerRegions");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRegions_Regions_RegionId",
                table: "CustomerRegions");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantRegions_Regions_RegionId",
                table: "RestaurantRegions");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantRegions_Restaurants_RestaurantId",
                table: "RestaurantRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestaurantRegions",
                table: "RestaurantRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regions",
                table: "Regions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerRegions",
                table: "CustomerRegions");

            migrationBuilder.RenameTable(
                name: "RestaurantRegions",
                newName: "RestaurantRegion");

            migrationBuilder.RenameTable(
                name: "Regions",
                newName: "Region");

            migrationBuilder.RenameTable(
                name: "CustomerRegions",
                newName: "CustomerRegion");

            migrationBuilder.RenameIndex(
                name: "IX_RestaurantRegions_RegionId",
                table: "RestaurantRegion",
                newName: "IX_RestaurantRegion_RegionId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerRegions_RegionId",
                table: "CustomerRegion",
                newName: "IX_CustomerRegion_RegionId");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldDefaultValue: "Customer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestaurantRegion",
                table: "RestaurantRegion",
                columns: new[] { "RestaurantId", "RegionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Region",
                table: "Region",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerRegion",
                table: "CustomerRegion",
                columns: new[] { "CustomerId", "RegionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRegion_Customers_CustomerId",
                table: "CustomerRegion",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRegion_Region_RegionId",
                table: "CustomerRegion",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantRegion_Region_RegionId",
                table: "RestaurantRegion",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantRegion_Restaurants_RestaurantId",
                table: "RestaurantRegion",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
