using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoastersFactory.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coasters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Shape = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coasters", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coasters");
        }
    }
}
