using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPersist.Migrations
{
    public partial class CorrectActivityProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Catgory",
                table: "Activities",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "ActivityDate",
                table: "Activities",
                newName: "Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Activities",
                newName: "ActivityDate");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Activities",
                newName: "Catgory");
        }
    }
}
