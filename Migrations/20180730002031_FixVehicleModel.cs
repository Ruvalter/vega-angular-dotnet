using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class FixVehicleModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsRegistred",
                table: "Vehicles",
                newName: "IsRegistered");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsRegistered",
                table: "Vehicles",
                newName: "IsRegistred");
        }
    }
}
