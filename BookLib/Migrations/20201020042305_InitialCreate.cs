using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLib.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BooksTable",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumberOfPages = table.Column<int>(type: "INT", nullable: false),
                    YearOfPublication = table.Column<int>(type: "INT", nullable: false),
                    BookName = table.Column<string>(type: "VARCHAR", nullable: false),
                    BookAddedAt = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksTable", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "UsersTable",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Login = table.Column<string>(type: "VARCHAR", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "VARCHAR", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR", nullable: false),
                    AccountCreatedAt = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersTable", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "IntermediateUserBookTable",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntermediateUserBookTable", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_IntermediateUserBookTable_BooksTable_BookId",
                        column: x => x.BookId,
                        principalTable: "BooksTable",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IntermediateUserBookTable_UsersTable_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReminderTable",
                columns: table => new
                {
                    ReminderId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    ReminderStatus = table.Column<int>(nullable: false),
                    ReminderDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReminderTable", x => x.ReminderId);
                    table.ForeignKey(
                        name: "FK_ReminderTable_BooksTable_BookId",
                        column: x => x.BookId,
                        principalTable: "BooksTable",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReminderTable_UsersTable_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewsTable",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    Review = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewsTable", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_ReviewsTable_BooksTable_BookId",
                        column: x => x.BookId,
                        principalTable: "BooksTable",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewsTable_UsersTable_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IntermediateUserBookTable_BookId",
                table: "IntermediateUserBookTable",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_ReminderTable_BookId",
                table: "ReminderTable",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_ReminderTable_UserId",
                table: "ReminderTable",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewsTable_BookId",
                table: "ReviewsTable",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewsTable_UserId",
                table: "ReviewsTable",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IntermediateUserBookTable");

            migrationBuilder.DropTable(
                name: "ReminderTable");

            migrationBuilder.DropTable(
                name: "ReviewsTable");

            migrationBuilder.DropTable(
                name: "BooksTable");

            migrationBuilder.DropTable(
                name: "UsersTable");
        }
    }
}
