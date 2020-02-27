using Microsoft.EntityFrameworkCore.Migrations;

namespace PartyThyme1.Migrations
{
    public partial class addedWateringFrequencyColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WateringFrequency",
                table: "Plants",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WateringFrequency",
                table: "Plants");
        }
    }
}
