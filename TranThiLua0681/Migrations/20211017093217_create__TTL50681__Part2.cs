using Microsoft.EntityFrameworkCore.Migrations;

namespace TranThiLua0681.Migrations
{
    public partial class create__TTL50681__Part2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TTL50681",
                columns: table => new
                {
                    TTLId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TTLName = table.Column<string>(type: "TEXT", nullable: true),
                    TTLGender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TTL50681", x => x.TTLId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TTL50681");
        }
    }
}
