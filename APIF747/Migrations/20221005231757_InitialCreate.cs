using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIF747.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Director = table.Column<string>(type: "TEXT", nullable: true),
                    LeadActor = table.Column<string>(type: "TEXT", nullable: true),
                    SupportActor = table.Column<string>(type: "TEXT", nullable: true),
                    CriticScore = table.Column<float>(type: "REAL", nullable: false),
                    AudienceScore = table.Column<float>(type: "REAL", nullable: false),
                    Synopsis = table.Column<string>(type: "TEXT", nullable: true),
                    Budget = table.Column<double>(type: "REAL", nullable: false),
                    Revenue = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieItems");
        }
    }
}
