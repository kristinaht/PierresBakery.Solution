using Microsoft.EntityFrameworkCore.Migrations;

namespace PierresBakery.Migrations
{
    public partial class TreatUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Treats",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Treats",
                newName: "Type");
        }
    }
}
