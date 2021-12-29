using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstEntityFramework.Migrations.LearnDbContext1Migrations
{
    public partial class ini1213 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sname",
                table: "school",
                newName: "SName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "school",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SName",
                table: "school",
                newName: "sname");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "school",
                newName: "id");
        }
    }
}
