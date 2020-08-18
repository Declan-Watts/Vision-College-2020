using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VisitorManagement.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StaffNames",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    department = table.Column<string>(nullable: true),
                    visitorCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffNames", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    business = table.Column<string>(nullable: true),
                    dateIn = table.Column<DateTime>(nullable: false),
                    dateOut = table.Column<DateTime>(nullable: false),
                    StaffNamesid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.id);
                    table.ForeignKey(
                        name: "FK_Visitors_StaffNames_StaffNamesid",
                        column: x => x.StaffNamesid,
                        principalTable: "StaffNames",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_StaffNamesid",
                table: "Visitors",
                column: "StaffNamesid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "StaffNames");
        }
    }
}
