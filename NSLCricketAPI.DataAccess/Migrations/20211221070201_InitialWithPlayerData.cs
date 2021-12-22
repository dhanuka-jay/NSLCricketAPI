using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NSLCricketAPI.DataAccess.Migrations
{
    public partial class InitialWithPlayerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    joinedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "ID", "fName", "joinedOn", "lName", "role" },
                values: new object[,]
                {
                    { 1, "Sudeera", new DateTime(2021, 12, 1, 18, 2, 0, 345, DateTimeKind.Local).AddTicks(4438), "Ilandarage", 2 },
                    { 2, "Thilina", new DateTime(2021, 12, 11, 18, 2, 0, 355, DateTimeKind.Local).AddTicks(1062), "Kalu Malli", 3 },
                    { 3, "Punya", new DateTime(2021, 12, 11, 18, 2, 0, 355, DateTimeKind.Local).AddTicks(1252), "Abaya", 5 },
                    { 4, "Shehan", new DateTime(2021, 12, 6, 18, 2, 0, 355, DateTimeKind.Local).AddTicks(1271), "De Silva", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
