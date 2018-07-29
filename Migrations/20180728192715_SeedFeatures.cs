using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class SeedFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Inserting data to the Makes table
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feture1')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feture2')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feture3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Features WHERE Name IN ('Feture1', 'Feture2', 'Feture3')");
        }
    }
}
