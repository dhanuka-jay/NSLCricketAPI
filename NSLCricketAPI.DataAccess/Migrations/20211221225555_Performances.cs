using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NSLCricketAPI.DataAccess.Migrations
{
    public partial class Performances : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Performances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Runs = table.Column<int>(type: "int", nullable: false),
                    Overs = table.Column<float>(type: "real", nullable: false),
                    Wickets = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Performances_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Performances",
                columns: new[] { "Id", "GameDay", "Overs", "PlayerId", "Runs", "Wickets" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 18, 9, 55, 54, 512, DateTimeKind.Local).AddTicks(974), 0f, 1, 28, 0 },
                    { 2, new DateTime(2021, 12, 18, 9, 55, 54, 512, DateTimeKind.Local).AddTicks(4112), 6f, 4, 56, 2 },
                    { 3, new DateTime(2021, 12, 18, 9, 55, 54, 512, DateTimeKind.Local).AddTicks(4147), 3f, 3, 9, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "ID",
                keyValue: 1,
                column: "joinedOn",
                value: new DateTime(2021, 12, 2, 9, 55, 54, 501, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "ID",
                keyValue: 2,
                column: "joinedOn",
                value: new DateTime(2021, 12, 12, 9, 55, 54, 509, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "ID",
                keyValue: 3,
                column: "joinedOn",
                value: new DateTime(2021, 12, 12, 9, 55, 54, 509, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "ID",
                keyValue: 4,
                column: "joinedOn",
                value: new DateTime(2021, 12, 7, 9, 55, 54, 509, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.CreateIndex(
                name: "IX_Performances_PlayerId",
                table: "Performances",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Performances");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "ID",
                keyValue: 1,
                column: "joinedOn",
                value: new DateTime(2021, 12, 2, 9, 54, 53, 11, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "ID",
                keyValue: 2,
                column: "joinedOn",
                value: new DateTime(2021, 12, 12, 9, 54, 53, 19, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "ID",
                keyValue: 3,
                column: "joinedOn",
                value: new DateTime(2021, 12, 12, 9, 54, 53, 19, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "ID",
                keyValue: 4,
                column: "joinedOn",
                value: new DateTime(2021, 12, 7, 9, 54, 53, 19, DateTimeKind.Local).AddTicks(7805));
        }
    }
}
