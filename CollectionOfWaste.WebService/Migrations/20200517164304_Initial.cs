using Microsoft.EntityFrameworkCore.Migrations;

namespace CollectionOfWaste.WebService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TRASHs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Space = table.Column<string>(nullable: true),
                    TypeArea = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRASHs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "Name", "Space", "TypeArea" },
                values: new object[] { 1L, "Контейнерная площадка № 1987645", "18", "Контейнерная площадка" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TRASHs");
        }
    }
}
