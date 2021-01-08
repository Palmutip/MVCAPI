using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCAPI.Migrations
{
    public partial class incial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "__EFMigrationsHistory",
                columns: table => new
                {
                    MigrationId = table.Column<string>(type: "varchar(95)", nullable: false),
                    ProductVersion = table.Column<string>(type: "varchar(32)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK___EFMigrationsHistory", x => x.MigrationId);
                });

            migrationBuilder.CreateTable(
                name: "Chaves",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numchave = table.Column<byte>(nullable: false),
                    stringchave = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chaves", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    @class = table.Column<int>(name: "class", type: "int(11)", nullable: false),
                    grade = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "__EFMigrationsHistory");

            migrationBuilder.DropTable(
                name: "Chaves");

            migrationBuilder.DropTable(
                name: "student");
        }
    }
}
