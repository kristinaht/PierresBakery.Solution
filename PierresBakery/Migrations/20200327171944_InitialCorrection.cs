using Microsoft.EntityFrameworkCore.Migrations;

namespace PierresBakery.Migrations
{
    public partial class InitialCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatFlavor_Flavor_FlavorId",
                table: "TreatFlavor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flavor",
                table: "Flavor");

            migrationBuilder.RenameTable(
                name: "Flavor",
                newName: "Flavors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flavors",
                table: "Flavors",
                column: "FlavorId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatFlavor_Flavors_FlavorId",
                table: "TreatFlavor",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatFlavor_Flavors_FlavorId",
                table: "TreatFlavor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flavors",
                table: "Flavors");

            migrationBuilder.RenameTable(
                name: "Flavors",
                newName: "Flavor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flavor",
                table: "Flavor",
                column: "FlavorId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatFlavor_Flavor_FlavorId",
                table: "TreatFlavor",
                column: "FlavorId",
                principalTable: "Flavor",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
