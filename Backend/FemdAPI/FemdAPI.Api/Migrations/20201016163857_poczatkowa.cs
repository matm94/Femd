using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FemdAPI.Api.Migrations
{
    public partial class poczatkowa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LectureDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true)
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
                    Password = table.Column<string>(maxLength: 15, nullable: false),
                    Role = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDbSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WordsDictionaryDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LectureId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordsDictionaryDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WordsDictionaryDbSet_LectureDbSet_LectureId",
                        column: x => x.LectureId,
                        principalTable: "LectureDbSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NounDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Feminine = table.Column<string>(nullable: true),
                    Masculine = table.Column<string>(nullable: true),
                    GenderNeutral = table.Column<string>(nullable: true),
                    PhotoPath = table.Column<string>(nullable: false),
                    WordsDictonaryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NounDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NounDbSet_WordsDictionaryDbSet_WordsDictonaryId",
                        column: x => x.WordsDictonaryId,
                        principalTable: "WordsDictionaryDbSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VerbDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Infinitive = table.Column<string>(nullable: false),
                    PastPrateritum = table.Column<string>(nullable: false),
                    PastPartizip = table.Column<string>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: false),
                    WordsDictonaryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerbDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VerbDbSet_WordsDictionaryDbSet_WordsDictonaryId",
                        column: x => x.WordsDictonaryId,
                        principalTable: "WordsDictionaryDbSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NounDbSet_WordsDictonaryId",
                table: "NounDbSet",
                column: "WordsDictonaryId");

            migrationBuilder.CreateIndex(
                name: "IX_VerbDbSet_WordsDictonaryId",
                table: "VerbDbSet",
                column: "WordsDictonaryId");

            migrationBuilder.CreateIndex(
                name: "IX_WordsDictionaryDbSet_LectureId",
                table: "WordsDictionaryDbSet",
                column: "LectureId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NounDbSet");

            migrationBuilder.DropTable(
                name: "UserDbSet");

            migrationBuilder.DropTable(
                name: "VerbDbSet");

            migrationBuilder.DropTable(
                name: "WordsDictionaryDbSet");

            migrationBuilder.DropTable(
                name: "LectureDbSet");
        }
    }
}
