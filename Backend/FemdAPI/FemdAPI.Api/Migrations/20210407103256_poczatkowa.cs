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
                name: "PartsOfSpeechDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Translation = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: false),
                    WordsDictonaryId = table.Column<Guid>(nullable: false),
                    Parts = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartsOfSpeechDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartsOfSpeechDbSet_WordsDictionaryDbSet_WordsDictonaryId",
                        column: x => x.WordsDictonaryId,
                        principalTable: "WordsDictionaryDbSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PartsOfSpeechDbSet_WordsDictionaryDbSet_WordsDictonaryId1",
                        column: x => x.WordsDictonaryId,
                        principalTable: "WordsDictionaryDbSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PartsOfSpeechDbSet_WordsDictionaryDbSet_WordsDictonaryId2",
                        column: x => x.WordsDictonaryId,
                        principalTable: "WordsDictionaryDbSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PartsOfSpeechDbSet_WordsDictionaryDbSet_WordsDictonaryId3",
                        column: x => x.WordsDictonaryId,
                        principalTable: "WordsDictionaryDbSet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PersonalPronounDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Translation = table.Column<string>(nullable: false),
                    FirstPerson = table.Column<string>(nullable: false),
                    SecondPerson = table.Column<string>(nullable: false),
                    ThirdPerson = table.Column<string>(nullable: false),
                    FirstPersonPlural = table.Column<string>(nullable: false),
                    SecondPersonPlural = table.Column<string>(nullable: false),
                    ThirdPersonPlural = table.Column<string>(nullable: false),
                    Formal = table.Column<string>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: false),
                    WordsDictonaryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalPronounDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalPronounDbSet_WordsDictionaryDbSet_WordsDictonaryId",
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
                    Translation = table.Column<string>(nullable: false),
                    Infinitive = table.Column<string>(nullable: false),
                    ConjugationTense = table.Column<string>(nullable: true),
                    ConjugationIch = table.Column<string>(nullable: false),
                    ConjugationDu = table.Column<string>(nullable: false),
                    ConjugationEr = table.Column<string>(nullable: false),
                    ConjugationWir = table.Column<string>(nullable: false),
                    ConjugationIhr = table.Column<string>(nullable: false),
                    Conjugation_sie = table.Column<string>(nullable: false),
                    ConjugationSie = table.Column<string>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
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
                name: "IX_PartsOfSpeechDbSet_WordsDictonaryId",
                table: "PartsOfSpeechDbSet",
                column: "WordsDictonaryId");

            migrationBuilder.CreateIndex(
                name: "IX_PartsOfSpeechDbSet_WordsDictonaryId1",
                table: "PartsOfSpeechDbSet",
                column: "WordsDictonaryId");

            migrationBuilder.CreateIndex(
                name: "IX_PartsOfSpeechDbSet_WordsDictonaryId2",
                table: "PartsOfSpeechDbSet",
                column: "WordsDictonaryId");

            migrationBuilder.CreateIndex(
                name: "IX_PartsOfSpeechDbSet_WordsDictonaryId3",
                table: "PartsOfSpeechDbSet",
                column: "WordsDictonaryId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalPronounDbSet_WordsDictonaryId",
                table: "PersonalPronounDbSet",
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
                name: "PartsOfSpeechDbSet");

            migrationBuilder.DropTable(
                name: "PersonalPronounDbSet");

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
