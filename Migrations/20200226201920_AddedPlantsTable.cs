using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PartyThyme1.Migrations
{
  public partial class AddedPlantsTable : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "Plants",
          columns: table => new
          {
            Id = table.Column<int>(nullable: false)
                  .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            Species = table.Column<string>(nullable: true),
            LocatedPlant = table.Column<string>(nullable: true),
            PlantedDate = table.Column<DateTime>(nullable: false),
            LastWateredDate = table.Column<DateTime>(nullable: false),
            WaterNeeded = table.Column<double>(nullable: false),
            LightNeeded = table.Column<double>(nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Plants", x => x.Id);
          });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "Plants");
    }
  }
}
