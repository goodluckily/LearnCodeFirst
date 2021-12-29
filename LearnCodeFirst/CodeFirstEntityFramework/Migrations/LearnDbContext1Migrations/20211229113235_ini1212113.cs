using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstEntityFramework.Migrations.LearnDbContext1Migrations
{
    public partial class ini1212113 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_school_SId",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_school",
                table: "school");

            migrationBuilder.RenameTable(
                name: "school",
                newName: "School");

            migrationBuilder.AddPrimaryKey(
                name: "PK_School",
                table: "School",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_School_SId",
                table: "Student",
                column: "SId",
                principalTable: "School",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_School_SId",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_School",
                table: "School");

            migrationBuilder.RenameTable(
                name: "School",
                newName: "school");

            migrationBuilder.AddPrimaryKey(
                name: "PK_school",
                table: "school",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_school_SId",
                table: "Student",
                column: "SId",
                principalTable: "school",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
