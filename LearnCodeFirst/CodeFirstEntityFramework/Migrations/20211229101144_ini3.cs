using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstEntityFramework.Migrations
{
    public partial class ini3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_school_SchoolId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "SchoolId",
                table: "Students",
                newName: "SId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_SchoolId",
                table: "Students",
                newName: "IX_Students_SId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_school_SId",
                table: "Students",
                column: "SId",
                principalTable: "school",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_school_SId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "SId",
                table: "Students",
                newName: "SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_SId",
                table: "Students",
                newName: "IX_Students_SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_school_SchoolId",
                table: "Students",
                column: "SchoolId",
                principalTable: "school",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
