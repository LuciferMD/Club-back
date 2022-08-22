using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Club.Infastructure.Migrations
{
    public partial class v01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entertainments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Production_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Rating = table.Column<double>(type: "double precision", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entertainments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    User_id = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Number_books = table.Column<int>(type: "integer", nullable: false),
                    Number_films = table.Column<int>(type: "integer", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Completeds",
                columns: table => new
                {
                    User_id = table.Column<Guid>(type: "uuid", nullable: false),
                    Enter_id = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Completeds", x => new { x.User_id, x.Enter_id });
                    table.ForeignKey(
                        name: "FK_Completeds_Entertainments_Enter_id",
                        column: x => x.Enter_id,
                        principalTable: "Entertainments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Completeds_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    User_id = table.Column<Guid>(type: "uuid", nullable: false),
                    Enter_id = table.Column<Guid>(type: "uuid", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Entertainments_Enter_id",
                        column: x => x.Enter_id,
                        principalTable: "Entertainments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uncompleteds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    User_id = table.Column<Guid>(type: "uuid", nullable: false),
                    Enter_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uncompleteds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uncompleteds_Entertainments_Enter_id",
                        column: x => x.Enter_id,
                        principalTable: "Entertainments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Uncompleteds_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Completeds_Enter_id",
                table: "Completeds",
                column: "Enter_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_Enter_id",
                table: "Reviews",
                column: "Enter_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_User_id",
                table: "Reviews",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Uncompleteds_Enter_id",
                table: "Uncompleteds",
                column: "Enter_id");

            migrationBuilder.CreateIndex(
                name: "IX_Uncompleteds_User_id",
                table: "Uncompleteds",
                column: "User_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Completeds");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Uncompleteds");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.DropTable(
                name: "Entertainments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
