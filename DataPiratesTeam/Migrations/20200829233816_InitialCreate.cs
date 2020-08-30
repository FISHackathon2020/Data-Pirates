using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPiratesTeam.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InfoS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Major = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    University = table.Column<string>(nullable: true),
                    Interest = table.Column<string>(nullable: true),
                    Work_Experience = table.Column<string>(nullable: true),
                    Gpa = table.Column<string>(nullable: true),
                    Graduation_Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoS", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InfoS");
        }
    }
}
