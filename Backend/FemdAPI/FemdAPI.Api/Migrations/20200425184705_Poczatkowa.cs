using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FemdAPI.Api.Migrations
{
    public partial class Poczatkowa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LectureDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LectureDbSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Login = table.Column<string>(maxLength: 30, nullable: false),
                    Password = table.Column<string>(maxLength: 30, nullable: false),
                    Token = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDbSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VerbDbSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Infinitive = table.Column<string>(nullable: false),
                    PastPrateritum = table.Column<string>(nullable: false),
                    PastPartizip = table.Column<string>(nullable: false),
                    LectureId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerbDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VerbDbSet_LectureDbSet_LectureId",
                        column: x => x.LectureId,
                        principalTable: "LectureDbSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentDbSet_UserDbSet_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDbSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentDbSet_UserId",
                table: "StudentDbSet",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VerbDbSet_LectureId",
                table: "VerbDbSet",
                column: "LectureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentDbSet");

            migrationBuilder.DropTable(
                name: "VerbDbSet");

            migrationBuilder.DropTable(
                name: "UserDbSet");

            migrationBuilder.DropTable(
                name: "LectureDbSet");
        }
    }
}
