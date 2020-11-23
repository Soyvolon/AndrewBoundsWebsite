using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebsiteMain.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardGames",
                columns: table => new
                {
                    GameNumber = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Winner = table.Column<ulong>(type: "INTEGER", nullable: true),
                    FirstGuess = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastCard = table.Column<bool>(type: "INTEGER", nullable: false),
                    WinsInARow = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardGames", x => x.GameNumber);
                });

            migrationBuilder.CreateTable(
                name: "CardGuess",
                columns: table => new
                {
                    GuessId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Team = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<ulong>(type: "INTEGER", nullable: false),
                    Card = table.Column<int>(type: "INTEGER", nullable: false),
                    GuessedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CardGameGameNumber = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardGuess", x => x.GuessId);
                    table.ForeignKey(
                        name: "FK_CardGuess_CardGames_CardGameGameNumber",
                        column: x => x.CardGameGameNumber,
                        principalTable: "CardGames",
                        principalColumn: "GameNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardGuess_CardGameGameNumber",
                table: "CardGuess",
                column: "CardGameGameNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardGuess");

            migrationBuilder.DropTable(
                name: "CardGames");
        }
    }
}
