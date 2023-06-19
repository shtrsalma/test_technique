using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_TestTechnique.Migrations
{
    public partial class InitialazData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HR");

            migrationBuilder.CreateTable(
                name: "Candidat",
                schema: "HR",
                columns: table => new
                {
                    CandidatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "varchar(20)", nullable: false),
                    Lastname = table.Column<string>(type: "varchar(20)", nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    ScooleLevel = table.Column<string>(type: "varchar(50)", nullable: false),
                    Experience = table.Column<string>(type: "varchar(50)", nullable: false),
                    LastJob = table.Column<string>(type: "varchar(50)", nullable: false),
                    CandidatCv = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidat", x => x.CandidatId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "HR",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(nullable: false),
                    UserPasswored = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidat",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "User",
                schema: "HR");
        }
    }
}
