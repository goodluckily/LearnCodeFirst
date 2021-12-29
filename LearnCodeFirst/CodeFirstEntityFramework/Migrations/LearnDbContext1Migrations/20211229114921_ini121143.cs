using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstEntityFramework.Migrations.LearnDbContext1Migrations
{
    public partial class ini121143 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    State = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => new { x.State, x.LicensePlate });
                });

            migrationBuilder.CreateTable(
                name: "RecordOfSales",
                columns: table => new
                {
                    RecordOfSaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateSold = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CarState = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CarLicensePlate = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordOfSales", x => x.RecordOfSaleId);
                    table.ForeignKey(
                        name: "FK_RecordOfSales_Car_CarState_CarLicensePlate",
                        columns: x => new { x.CarState, x.CarLicensePlate },
                        principalTable: "Car",
                        principalColumns: new[] { "State", "LicensePlate" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecordOfSales_CarState_CarLicensePlate",
                table: "RecordOfSales",
                columns: new[] { "CarState", "CarLicensePlate" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecordOfSales");

            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}
